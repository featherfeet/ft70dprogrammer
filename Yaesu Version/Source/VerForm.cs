// Decompiled with JetBrains decompiler
// Type: ADMS10.VerForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace ADMS10
{
  public class VerForm : Form
  {
    private IContainer components;
    private LinkLabel lnk_Url;
    private Button button1;
    private Label label1;
    private Label lbl_Version;
    private Label lbl_Copyright;
    private Label label4;
    private Label label5;

    public VerForm()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void VerForm_Load(object sender, EventArgs e)
    {
      this.lbl_Version.Text = "Ver " + (object) Assembly.GetExecutingAssembly().GetName().Version;
      this.lbl_Copyright.Text = ((AssemblyCopyrightAttribute) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof (AssemblyCopyrightAttribute))).Copyright;
      if (Settings.Instance.Language == 0)
      {
        this.lnk_Url.Text = "http://www.yaesu.com/jp/";
        this.lnk_Url.Links.Add(0, 60, (object) "http://www.yaesu.com/jp/");
      }
      else
      {
        this.lnk_Url.Text = "http://www.yaesu.com/";
        this.lnk_Url.Links.Add(0, 60, (object) "http://www.yaesu.com/");
      }
      this.ActiveControl = (Control) this.button1;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(this.lnk_Url.Links[0].LinkData.ToString());
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (VerForm));
      this.lnk_Url = new LinkLabel();
      this.button1 = new Button();
      this.label1 = new Label();
      this.lbl_Version = new Label();
      this.lbl_Copyright = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.SuspendLayout();
      this.lnk_Url.LinkVisited = true;
      componentResourceManager.ApplyResources((object) this.lnk_Url, "lnk_Url");
      this.lnk_Url.Name = "lnk_Url";
      this.lnk_Url.TabStop = true;
      this.lnk_Url.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.button1.DialogResult = DialogResult.Cancel;
      componentResourceManager.ApplyResources((object) this.button1, "button1");
      this.button1.Name = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.lbl_Version, "lbl_Version");
      this.lbl_Version.Name = "lbl_Version";
      componentResourceManager.ApplyResources((object) this.lbl_Copyright, "lbl_Copyright");
      this.lbl_Copyright.Name = "lbl_Copyright";
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.Name = "label4";
      componentResourceManager.ApplyResources((object) this.label5, "label5");
      this.label5.Name = "label5";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.lbl_Copyright);
      this.Controls.Add((Control) this.lbl_Version);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.lnk_Url);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (VerForm);
      this.ShowIcon = false;
      this.Load += new EventHandler(this.VerForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
