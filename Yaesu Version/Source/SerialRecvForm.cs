﻿// Decompiled with JetBrains decompiler
// Type: ADMS10.SerialRecvForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Resources;
using System.Windows.Forms;

namespace ADMS10
{
  public class SerialRecvForm : Form
  {
    private ResourceManager resources = new ResourceManager("ADMS10.Strings", typeof (SerialRecvForm).Assembly);
    private SerialPort serial;
    private AdmsForm aform;
    private DataForm cActiveForm;
    private ComForm cform;
    private IContainer components;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button btn_RxMsgOK;
    private Button btn_RxMsgCancel;
    private Label label5;
    private Label label6;
    private Label label7;

    public SerialRecvForm()
    {
    }

    public SerialRecvForm(SerialPort serialport, AdmsForm admsform, DataForm df, ComForm cf)
    {
      this.InitializeComponent();
      this.aform = admsform;
      this.serial = serialport;
      this.cActiveForm = df;
      this.cform = cf;
    }

    private void btn_RxMsgOK_Click(object sender, EventArgs e)
    {
      if (-1 == Array.IndexOf<string>(SerialPort.GetPortNames(), Settings.Instance.ComPortName))
      {
        int num1 = (int) MessageBox.Show(this.resources.GetString("COMERRORMSG"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        this.serial.PortName = Settings.Instance.ComPortName;
        SerialProtocol serialProtocol = new SerialProtocol(this.serial, this.aform, this.cActiveForm, false);
        serialProtocol.StartPosition = FormStartPosition.CenterParent;
        try
        {
          serialProtocol.PortOpen();
          serialProtocol.Run();
          int num2 = (int) serialProtocol.ShowDialog();
        }
        catch (Exception ex)
        {
          int num2 = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        serialProtocol.PortClose();
        serialProtocol.Dispose();
      }
      this.Close();
    }

    private void btn_RxMsgCancel_Click(object sender, EventArgs e)
    {
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SerialRecvForm));
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.btn_RxMsgOK = new Button();
      this.btn_RxMsgCancel = new Button();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.Name = "label3";
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.Name = "label4";
      componentResourceManager.ApplyResources((object) this.btn_RxMsgOK, "btn_RxMsgOK");
      this.btn_RxMsgOK.Name = "btn_RxMsgOK";
      this.btn_RxMsgOK.UseVisualStyleBackColor = true;
      this.btn_RxMsgOK.Click += new EventHandler(this.btn_RxMsgOK_Click);
      componentResourceManager.ApplyResources((object) this.btn_RxMsgCancel, "btn_RxMsgCancel");
      this.btn_RxMsgCancel.DialogResult = DialogResult.Cancel;
      this.btn_RxMsgCancel.Name = "btn_RxMsgCancel";
      this.btn_RxMsgCancel.UseVisualStyleBackColor = true;
      this.btn_RxMsgCancel.Click += new EventHandler(this.btn_RxMsgCancel_Click);
      componentResourceManager.ApplyResources((object) this.label5, "label5");
      this.label5.Name = "label5";
      componentResourceManager.ApplyResources((object) this.label6, "label6");
      this.label6.Name = "label6";
      componentResourceManager.ApplyResources((object) this.label7, "label7");
      this.label7.Name = "label7";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btn_RxMsgCancel;
      this.ControlBox = false;
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.btn_RxMsgCancel);
      this.Controls.Add((Control) this.btn_RxMsgOK);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = nameof (SerialRecvForm);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
