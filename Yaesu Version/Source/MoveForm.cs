// Decompiled with JetBrains decompiler
// Type: ADMS10.MoveForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ADMS10
{
  public class MoveForm : Form
  {
    private DataForm cDataForm;
    private DataGridView dgv;
    private IContainer components;
    private NumericUpDown nud_MoveCh;
    private Button btn_MoveOk;
    private Button btn_MoveCancel;
    private Label label1;
    private Label label2;

    public MoveForm()
    {
    }

    public MoveForm(DataForm dForm)
    {
      this.InitializeComponent();
      this.cDataForm = dForm;
      this.dgv = dForm.SelectedDgv();
      this.nud_MoveCh.Maximum = (Decimal) this.dgv.RowCount;
      this.nud_MoveCh.Value = (Decimal) (this.dgv.SelectedCells[0].RowIndex + 1);
    }

    private void btn_MoveOk_Click(object sender, EventArgs e)
    {
      this.cDataForm.MoveChannel((int) this.nud_MoveCh.Value);
      this.Close();
    }

    private void btn_MoveCancel_Click(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MoveForm));
      this.nud_MoveCh = new NumericUpDown();
      this.btn_MoveOk = new Button();
      this.btn_MoveCancel = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.nud_MoveCh.BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.nud_MoveCh, "nud_MoveCh");
      this.nud_MoveCh.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.nud_MoveCh.Name = "nud_MoveCh";
      this.nud_MoveCh.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.btn_MoveOk, "btn_MoveOk");
      this.btn_MoveOk.Name = "btn_MoveOk";
      this.btn_MoveOk.UseVisualStyleBackColor = true;
      this.btn_MoveOk.Click += new EventHandler(this.btn_MoveOk_Click);
      componentResourceManager.ApplyResources((object) this.btn_MoveCancel, "btn_MoveCancel");
      this.btn_MoveCancel.DialogResult = DialogResult.Cancel;
      this.btn_MoveCancel.Name = "btn_MoveCancel";
      this.btn_MoveCancel.UseVisualStyleBackColor = true;
      this.btn_MoveCancel.Click += new EventHandler(this.btn_MoveCancel_Click);
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btn_MoveCancel;
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.btn_MoveCancel);
      this.Controls.Add((Control) this.btn_MoveOk);
      this.Controls.Add((Control) this.nud_MoveCh);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (MoveForm);
      this.ShowIcon = false;
      this.nud_MoveCh.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
