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

public class SerialProtocol
{
  private byte[] DataArray = new byte[65216];
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
  private SerialPort mySerial;
  private Database db;
  private System.Timers.Timer myTimer;
  private IContainer components;

  public SerialProtocol()
  {
  }

  public SerialProtocol(SerialPort serialport, Database database, bool isSend)
  {
    this.mySerial = serialport;
    this.IsSend = isSend;
    this.db = database;
    this.db.Buffer.CopyTo((Array) this.DataArray, 0);
    this.IsComp = false;
    this.tmpCpuType = Settings.Instance.CpuType;
    this.tmpCountryType = Settings.Instance.CountryType;
    this.tmpExpType = Settings.Instance.ExpType;
    this.TIMEOUTERRMESSAGE = "Timeout error.";
    this.CHECKSUMERRMESSAGE = "Checksum error.";
    this.FORMATERRMESSAGE = "Format error.";
    this.COMPLETEDMESSAGE = "Completed.";
    this.SENDMESSAGE = "Sending.";
    this.RECVMESSAGE = "Receiving.";
    this.CPUTYPERRMESSAGE = "CPU Type Error.";
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
      throw new IOException("COM Port open error.");
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

  private byte calcCheckSum(byte[] buf, int len)
  {
    byte num = 0;
    for (int index = 0; index < len; ++index)
      num += buf[index];
    return num;
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

  public void Run()
  {
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
        byte[] buffer1 = new byte[1];
        while (true)
        {
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
        Thread.Sleep(2000);
        for (int offset = 0; offset < 65216; offset += 64)
        {
          Thread.Sleep(15);
          this.mySerial.Write(this.db.Buffer, offset, 64);
          int percentProgress = offset * 100 / 65216;
          Console.WriteLine(percentProgress);
        }
        byte[] buffer2 = new byte[1]
        {
          this.calcCheckSum(this.db.Buffer, 65216)
        };
        buffer2[0] = (byte) ((int) buffer2[0] + (int) this.calcCheckSum(numArray, 10) & (int) byte.MaxValue);
        this.mySerial.Write(buffer2, 0, buffer2.Length);
        int percentProgress1 = 100;
        Console.WriteLine(percentProgress1);
      }
      else
      {
        // Read 10 bytes from the radio that describe some settings.
        byte[] numArray = new byte[10];
        int i = 0;
        Int32 byte_read = -1;
        while (i < 10) {
            try {
                byte_read = mySerial.ReadByte();
            }
            catch (System.IO.IOException e) {
                Console.WriteLine("IOE");
            }
            if (byte_read != -1) {
                numArray[i] = (byte) byte_read;
                i++;
            }
        }
        // Print out the 10 bytes.
        for (int j = 0; j < 10; j++) {
            Console.WriteLine(numArray[j]);
        }
        // Parse the 10 bytes from the radio into settings.
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
          }
          else {
            this.tmpExpType = numArray[9] != (byte) 0 ? 2 : 1;
          }
        }
        // Read the actual radio memory data.
        byte[] buffer1 = new byte[1]{ (byte) 6 };
        this.mySerial.Write(buffer1, 0, buffer1.Length);
        Console.WriteLine(0);
        byte[] buffer2 = new byte[64];
        int index = 0;
        while (index < 65216)
        {
          if (this.mySerial.BytesToRead >= buffer2.Length)
          {
            this.mySerial.Read(buffer2, 0, buffer2.Length);
            buffer2.CopyTo((Array) this.DataArray, index);
            index += buffer2.Length;
            int percentProgress = index * 100 / 65216;
            Console.WriteLine(percentProgress);
          }
        }
        byte[] buffer3 = new byte[1];
        while (true)
        {
          if (this.mySerial.BytesToRead >= buffer3.Length)
          {
            this.mySerial.Read(buffer3, 0, buffer3.Length);
            break;
          }
        }
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
      Console.WriteLine(this.errorMessage);
    }
  }
}
