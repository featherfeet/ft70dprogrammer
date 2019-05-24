// Decompiled with JetBrains decompiler
// Type: ADMS10.ComForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Resources;
using System.Windows.Forms;

namespace ADMS10
{
  public class ComForm : Form
  {
    private ResourceManager resources = new ResourceManager("ADMS10.Strings", typeof (ComForm).Assembly);
    private SerialPort serial;
    private IContainer components;
    private Button btn_ComDevMgr;
    private Button btn_ComDecide;
    private Button btn_ComClose;
    internal ComboBox cmb_ComPort;

    public ComForm()
    {
    }

    public ComForm(SerialPort serialport)
    {
      this.serial = serialport;
      this.InitializeComponent();
    }

    private void cmb_ComPort_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void btn_DevMgr_Click(object sender, EventArgs e)
    {
      Process.Start("devmgmt.msc");
    }

    private void btn_ComDecide_Click(object sender, EventArgs e)
    {
      try
      {
        this.serial.PortName = this.cmb_ComPort.Text;
        Settings.Instance.ComPortName = this.serial.PortName;
      }
      catch
      {
        int num = (int) MessageBox.Show(this.resources.GetString("COMERRORMSG"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.Close();
    }

    private void btn_ComClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ComForm_Load(object sender, EventArgs e)
    {
      string[] portNames = SerialPort.GetPortNames();
      this.cmb_ComPort.Items.Clear();
      foreach (object obj in portNames)
        this.cmb_ComPort.Items.Add(obj);
      if (this.cmb_ComPort.Items.Count <= 0)
        return;
      this.cmb_ComPort.SelectedIndex = Array.IndexOf<string>(portNames, Settings.Instance.ComPortName);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ComForm));
      this.cmb_ComPort = new ComboBox();
      this.btn_ComDevMgr = new Button();
      this.btn_ComDecide = new Button();
      this.btn_ComClose = new Button();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.cmb_ComPort, "cmb_ComPort");
      this.cmb_ComPort.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmb_ComPort.FormattingEnabled = true;
      this.cmb_ComPort.Name = "cmb_ComPort";
      this.cmb_ComPort.SelectedIndexChanged += new EventHandler(this.cmb_ComPort_SelectedIndexChanged);
      componentResourceManager.ApplyResources((object) this.btn_ComDevMgr, "btn_ComDevMgr");
      this.btn_ComDevMgr.Name = "btn_ComDevMgr";
      this.btn_ComDevMgr.UseVisualStyleBackColor = true;
      this.btn_ComDevMgr.Click += new EventHandler(this.btn_DevMgr_Click);
      componentResourceManager.ApplyResources((object) this.btn_ComDecide, "btn_ComDecide");
      this.btn_ComDecide.Name = "btn_ComDecide";
      this.btn_ComDecide.UseVisualStyleBackColor = true;
      this.btn_ComDecide.Click += new EventHandler(this.btn_ComDecide_Click);
      componentResourceManager.ApplyResources((object) this.btn_ComClose, "btn_ComClose");
      this.btn_ComClose.DialogResult = DialogResult.Cancel;
      this.btn_ComClose.Name = "btn_ComClose";
      this.btn_ComClose.UseVisualStyleBackColor = true;
      this.btn_ComClose.Click += new EventHandler(this.btn_ComClose_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btn_ComClose;
      this.Controls.Add((Control) this.btn_ComClose);
      this.Controls.Add((Control) this.btn_ComDecide);
      this.Controls.Add((Control) this.btn_ComDevMgr);
      this.Controls.Add((Control) this.cmb_ComPort);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ComForm);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Load += new EventHandler(this.ComForm_Load);
      this.ResumeLayout(false);
    }
  }
}
