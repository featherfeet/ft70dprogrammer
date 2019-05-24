// Decompiled with JetBrains decompiler
// Type: ADMS10.SerialProtocol
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Resources;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace ADMS10
{
  public class SerialProtocol : Form
  {
    private byte[] DataArray = new byte[65216];
    private ResourceManager resources = new ResourceManager("ADMS10.Strings", typeof (DataForm).Assembly);
    private const int TO01SEC = 1000;
    private const int TO02SEC = 2000;
    private const int TO05SEC = 5000;
    private const int TO07SEC = 7000;
    private const int BUFDATASIZE = 65216;
    private const int CMDDATASIZE = 64;
    private const int ERRORTHROW = 1000;
    private readonly string TIMEOUTERRMESSAGE;
    private readonly string CHECKSUMERRMESSAGE;
    private readonly string FORMATERRMESSAGE;
    private readonly string COMPLETEDMESSAGE;
    private readonly string SENDMESSAGE;
    private readonly string RECVMESSAGE;
    private readonly string CPUTYPERRMESSAGE;
    private bool IsSend;
    private bool IsTimeout;
    private string errorMessage;
    private int tmpCpuType;
    private int tmpCountryType;
    private int tmpExpType;
    private int tmpExpSW;
    private bool IsComp;
    private AdmsForm aform;
    private SerialPort mySerial;
    private DataForm cActiveForm;
    private Database db;
    private System.Timers.Timer myTimer;
    private IContainer components;
    private Button btn_BerCancel;
    private ProgressBar progressBar1;
    private BackgroundWorker backgroundWorker1;
    private Label lbl_percentage;

    public SerialProtocol()
    {
    }

    public SerialProtocol(SerialPort serialport, AdmsForm admsform, DataForm df, bool isSend)
    {
      this.aform = admsform;
      this.mySerial = serialport;
      this.IsSend = isSend;
      this.cActiveForm = df;
      this.db = this.cActiveForm.GetDB();
      this.db.Buffer.CopyTo((Array) this.DataArray, 0);
      this.IsComp = false;
      this.tmpCpuType = Settings.Instance.CpuType;
      this.tmpCountryType = Settings.Instance.CountryType;
      this.tmpExpType = Settings.Instance.ExpType;
      this.TIMEOUTERRMESSAGE = this.resources.GetString("TIMEOUTERROR");
      this.CHECKSUMERRMESSAGE = this.resources.GetString("CHECKSUMERROR");
      this.FORMATERRMESSAGE = this.resources.GetString("FORMATERROR");
      this.COMPLETEDMESSAGE = this.resources.GetString("COMPLETED");
      this.SENDMESSAGE = this.resources.GetString("SENDING");
      this.RECVMESSAGE = this.resources.GetString("RECEIVING");
      this.CPUTYPERRMESSAGE = this.resources.GetString("CPUTYPEERROR");
      this.InitializeComponent();
      if (isSend)
      {
        this.Text = this.SENDMESSAGE;
      }
      else
      {
        this.Text = this.RECVMESSAGE;
        this.lbl_percentage.Text = this.resources.GetString("RECVSTARTMESSAGE");
      }
      this.myTimer = new System.Timers.Timer();
      this.myTimer.Elapsed += new ElapsedEventHandler(this.OnTimerEvent);
      this.backgroundWorker1.WorkerSupportsCancellation = true;
    }

    public void PortOpen()
    {
      this.mySerial.BaudRate = 38400;
      this.mySerial.DataBits = 8;
      this.mySerial.Parity = Parity.None;
      this.mySerial.StopBits = StopBits.One;
      this.mySerial.Handshake = Handshake.None;
      try
      {
        this.mySerial.Open();
      }
      catch
      {
        throw new IOException(this.resources.GetString("COMPORTOPENERROR"));
      }
    }

    public void PortClose()
    {
      try
      {
        this.mySerial.Close();
      }
      catch
      {
      }
    }

    public void Run()
    {
      this.backgroundWorker1.RunWorkerAsync();
    }

    private byte calcCheckSum(byte[] buf, int len)
    {
      byte num = 0;
      for (int index = 0; index < len; ++index)
        num += buf[index];
      return num;
    }

    private void OnTimerEvent(object source, ElapsedEventArgs e)
    {
      this.IsTimeout = true;
    }

    private void startToTimer(double time)
    {
      this.myTimer.Enabled = true;
      this.myTimer.AutoReset = true;
      this.myTimer.Interval = time;
      this.IsTimeout = false;
    }

    private void stopToTimer()
    {
      this.myTimer.Enabled = false;
      this.myTimer.AutoReset = false;
      this.IsTimeout = false;
    }

    private bool IsChk10Byte(byte[] buf)
    {
      bool flag = true;
      if ((byte) 65 != buf[0] || (byte) 72 != buf[1] || ((byte) 53 != buf[2] || (byte) 49 != buf[3]) || (byte) 71 != buf[4])
      {
        this.errorMessage = this.FORMATERRMESSAGE;
        throw new Exception();
      }
      if (buf[5] > (byte) 2)
        flag = false;
      else if (buf[5] == (byte) 0)
      {
        if (buf[7] != (byte) 1)
          flag = false;
      }
      else if (buf[5] == (byte) 1)
      {
        if (buf[7] != (byte) 0)
          flag = false;
      }
      else if (buf[7] > (byte) 7)
        flag = false;
      if (flag && (buf[8] > (byte) 1 || buf[9] > (byte) 1))
        flag = false;
      if (flag && Settings.Instance.Language == 0 && ((int) buf[5] != Settings.Instance.CpuType && (int) buf[7] != Settings.Instance.CountryType))
        flag = false;
      return flag;
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      BackgroundWorker backgroundWorker = (BackgroundWorker) sender;
      try
      {
        if (this.IsSend)
        {
          byte[] numArray = new byte[10]
          {
            (byte) 65,
            (byte) 72,
            (byte) 53,
            (byte) 49,
            (byte) 71,
            (byte) Settings.Instance.CpuType,
            (byte) 0,
            (byte) Settings.Instance.CountryType,
            (byte) 0,
            (byte) 0
          };
          if (Settings.Instance.ExpType == 0)
          {
            numArray[8] = (byte) 0;
            numArray[9] = (byte) Settings.Instance.ExpSW;
          }
          else
          {
            numArray[8] = (byte) 1;
            numArray[9] = Settings.Instance.ExpType != 1 ? (byte) 1 : (byte) 0;
          }
          this.mySerial.Write(numArray, 0, numArray.Length);
          this.startToTimer(5000.0);
          byte[] buffer1 = new byte[1];
          while (!this.IsTimeout)
          {
            if (backgroundWorker.CancellationPending)
            {
              e.Cancel = true;
              return;
            }
            if (this.mySerial.BytesToRead >= buffer1.Length)
            {
              this.mySerial.Read(buffer1, 0, buffer1.Length);
              if (buffer1[0] != (byte) 6)
              {
                this.errorMessage = this.FORMATERRMESSAGE;
                throw new Exception();
              }
              break;
            }
          }
          if (this.IsTimeout)
          {
            this.errorMessage = this.TIMEOUTERRMESSAGE;
            throw new Exception();
          }
          this.stopToTimer();
          Thread.Sleep(2000);
          for (int offset = 0; offset < 65216; offset += 64)
          {
            Thread.Sleep(15);
            this.mySerial.Write(this.db.Buffer, offset, 64);
            int percentProgress = offset * 100 / 65216;
            backgroundWorker.ReportProgress(percentProgress);
          }
          byte[] buffer2 = new byte[1]
          {
            this.calcCheckSum(this.db.Buffer, 65216)
          };
          buffer2[0] = (byte) ((int) buffer2[0] + (int) this.calcCheckSum(numArray, 10) & (int) byte.MaxValue);
          this.mySerial.Write(buffer2, 0, buffer2.Length);
          int percentProgress1 = 100;
          backgroundWorker.ReportProgress(percentProgress1);
        }
        else
        {
          this.startToTimer(7000.0);
          byte[] numArray = new byte[10];
          while (!this.IsTimeout)
          {
            if (backgroundWorker.CancellationPending)
            {
              e.Cancel = true;
              return;
            }
            if (this.mySerial.BytesToRead >= numArray.Length)
            {
              this.mySerial.Read(numArray, 0, numArray.Length);
              if (!this.IsChk10Byte(numArray))
              {
                this.errorMessage = this.CPUTYPERRMESSAGE;
                throw new Exception();
              }
              this.tmpCpuType = Settings.Instance.CpuType;
              this.tmpCountryType = Settings.Instance.CountryType;
              this.tmpExpType = Settings.Instance.ExpType;
              if (Settings.Instance.Language != 0)
              {
                this.tmpCpuType = (int) numArray[5];
                this.tmpCountryType = (int) numArray[7];
                if (numArray[8] == (byte) 0)
                {
                  this.tmpExpType = 0;
                  this.tmpExpSW = (int) numArray[9];
                  break;
                }
                this.tmpExpType = numArray[9] != (byte) 0 ? 2 : 1;
                break;
              }
              break;
            }
          }
          if (this.IsTimeout)
          {
            this.errorMessage = this.TIMEOUTERRMESSAGE;
            throw new Exception();
          }
          this.stopToTimer();
          byte[] buffer1 = new byte[1]{ (byte) 6 };
          this.mySerial.Write(buffer1, 0, buffer1.Length);
          backgroundWorker.ReportProgress(0);
          byte[] buffer2 = new byte[64];
          this.startToTimer(5000.0);
          int index = 0;
          while (!this.IsTimeout && index < 65216)
          {
            if (this.mySerial.BytesToRead >= buffer2.Length)
            {
              this.stopToTimer();
              this.mySerial.Read(buffer2, 0, buffer2.Length);
              buffer2.CopyTo((Array) this.DataArray, index);
              index += buffer2.Length;
              int percentProgress = index * 100 / 65216;
              backgroundWorker.ReportProgress(percentProgress);
              this.startToTimer(1000.0);
            }
          }
          if (this.IsTimeout)
          {
            this.errorMessage = this.TIMEOUTERRMESSAGE;
            throw new Exception();
          }
          this.stopToTimer();
          this.startToTimer(5000.0);
          byte[] buffer3 = new byte[1];
          while (!this.IsTimeout)
          {
            if (this.mySerial.BytesToRead >= buffer3.Length)
            {
              this.mySerial.Read(buffer3, 0, buffer3.Length);
              break;
            }
          }
          if (this.IsTimeout)
          {
            this.errorMessage = this.TIMEOUTERRMESSAGE;
            throw new Exception();
          }
          this.stopToTimer();
          byte num = (byte) ((int) this.calcCheckSum(this.DataArray, 65216) + (int) this.calcCheckSum(numArray, 10) & (int) byte.MaxValue);
          if ((int) buffer3[0] != (int) num)
          {
            this.errorMessage = this.CHECKSUMERRMESSAGE;
            throw new Exception();
          }
          this.DataArray.CopyTo((Array) this.db.Buffer, 0);
        }
      }
      catch
      {
        backgroundWorker.ReportProgress(1000);
      }
      this.stopToTimer();
    }

    private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.btn_BerCancel.Enabled = false;
      if (e.ProgressPercentage < 100)
      {
        int num = e.ProgressPercentage - 5;
        if (num < 0)
          this.lbl_percentage.Text = "0%";
        else
          this.lbl_percentage.Text = num.ToString() + "%";
        this.progressBar1.Value = e.ProgressPercentage;
      }
      else if (e.ProgressPercentage == 100)
      {
        this.IsComp = true;
        this.progressBar1.Value = e.ProgressPercentage;
      }
      else
        this.lbl_percentage.Text = this.errorMessage;
    }

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (this.IsComp)
      {
        for (int index = 0; index <= 200000; ++index)
        {
          this.lbl_percentage.Text = (95 + index * 5 / 200000).ToString() + "%";
          Application.DoEvents();
        }
        this.lbl_percentage.Text = this.COMPLETEDMESSAGE;
        if (!this.IsSend)
        {
          if (Settings.Instance.Language != 0)
          {
            Settings.Instance.CpuType = this.tmpCpuType;
            Settings.Instance.CountryType = this.tmpCountryType;
            Settings.Instance.ExpType = this.tmpExpType;
            Settings.Instance.ExpSW = this.tmpExpSW;
            if (Settings.Instance.CountryType == 1)
              this.cActiveForm.WxVisible();
          }
          Settings.Instance.Recv_flg = true;
          this.aform.EnableComWrite();
          this.cActiveForm.IsSend = true;
          this.cActiveForm.IsSave = false;
        }
        if (Debugger.Instance.DefaultUpdate)
          new DefaultFile()
          {
            DefaultBuffer = this.DataArray
          }.SaveFromDefaultFile();
        if (Debugger.Instance.Datalogger)
        {
          if (this.IsSend)
            new Logger(this.db, "TXLOG").Save();
          else
            new Logger(this.db, "RXLOG").Save();
        }
      }
      this.btn_BerCancel.Enabled = true;
      this.btn_BerCancel.Text = "Close";
    }

    private void btn_BerCancel_Click(object sender, EventArgs e)
    {
      this.backgroundWorker1.CancelAsync();
      this.PortClose();
      this.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SerialProtocol));
      this.btn_BerCancel = new Button();
      this.progressBar1 = new ProgressBar();
      this.backgroundWorker1 = new BackgroundWorker();
      this.lbl_percentage = new Label();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.btn_BerCancel, "btn_BerCancel");
      this.btn_BerCancel.Name = "btn_BerCancel";
      this.btn_BerCancel.UseVisualStyleBackColor = true;
      this.btn_BerCancel.Click += new EventHandler(this.btn_BerCancel_Click);
      componentResourceManager.ApplyResources((object) this.progressBar1, "progressBar1");
      this.progressBar1.Name = "progressBar1";
      this.backgroundWorker1.WorkerReportsProgress = true;
      this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
      this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      componentResourceManager.ApplyResources((object) this.lbl_percentage, "lbl_percentage");
      this.lbl_percentage.Name = "lbl_percentage";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ControlBox = false;
      this.Controls.Add((Control) this.lbl_percentage);
      this.Controls.Add((Control) this.progressBar1);
      this.Controls.Add((Control) this.btn_BerCancel);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = nameof (SerialProtocol);
      this.ResumeLayout(false);
    }
  }
}
