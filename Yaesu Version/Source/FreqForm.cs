// Decompiled with JetBrains decompiler
// Type: ADMS10.FreqForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.ComponentModel;
using System.Resources;
using System.Windows.Forms;

namespace ADMS10
{
  public class FreqForm : Form
  {
    private ResourceManager resources = new ResourceManager("ADMS10.Strings", typeof (DataForm).Assembly);
    private DataForm cDataForm;
    private DataGridView dgv;
    private IContainer components;
    private Button btn_FreqOk;
    private Button btn_FreqCancel;
    private TextBox txt_FreqStart;
    private NumericUpDown nud_FreqAddCh;
    private ComboBox cmb_FreqStep;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;

    public FreqForm()
    {
    }

    public FreqForm(DataForm dForm)
    {
      this.InitializeComponent();
      this.cDataForm = dForm;
      this.txt_FreqStart.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_Freq_KeyPress);
      this.dgv = dForm.SelectedDgv();
      this.nud_FreqAddCh.Maximum = (Decimal) (this.dgv.RowCount - this.dgv.SelectedCells[0].RowIndex);
      this.cmb_FreqStep.Items.Clear();
      this.cmb_FreqStep.Items.AddRange((object[]) DataForm.tbl_Step_air);
      this.cmb_FreqStep.SelectedIndex = 0;
    }

    private void btn_FreqOk_Click(object sender, EventArgs e)
    {
      if (this.txt_FreqStart.Text != null)
      {
        if (!(this.txt_FreqStart.Text == ""))
        {
          Decimal startFreq;
          try
          {
            startFreq = Decimal.Parse(this.txt_FreqStart.Text);
          }
          catch
          {
            this.cDataForm.ShowEntryFreqErrMsg();
            this.Close();
            return;
          }
          int addChannel = int.Parse(this.nud_FreqAddCh.Text);
          if (!this.cDataForm.AddFreq(startFreq, addChannel, this.cmb_FreqStep.Text))
          {
            this.cDataForm.ShowEntryFreqErrMsg();
            this.Close();
            return;
          }
          this.Close();
          return;
        }
      }
      this.cDataForm.ShowEntryFreqErrMsg();
      this.Close();
    }

    private void btn_FreqCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void txt_FreqStart_TextChanged(object sender, EventArgs e)
    {
      if (this.txt_FreqStart.Text == null || this.txt_FreqStart.Text == "")
        return;
      Decimal frq = Decimal.Parse(this.txt_FreqStart.Text);
      string text = this.cmb_FreqStep.Text;
      if (DataForm.GetBandIdx(frq) == -1)
        return;
      this.cmb_FreqStep.Items.Clear();
      this.cmb_FreqStep.Items.AddRange((object[]) this.cDataForm.GetSTEPList(frq));
      if (Array.IndexOf<string>(this.cDataForm.GetSTEPList(frq), text) >= 0)
        this.cmb_FreqStep.Text = text;
      else
        this.cmb_FreqStep.SelectedIndex = 0;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FreqForm));
      this.btn_FreqOk = new Button();
      this.btn_FreqCancel = new Button();
      this.txt_FreqStart = new TextBox();
      this.nud_FreqAddCh = new NumericUpDown();
      this.cmb_FreqStep = new ComboBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.nud_FreqAddCh.BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.btn_FreqOk, "btn_FreqOk");
      this.btn_FreqOk.Name = "btn_FreqOk";
      this.btn_FreqOk.UseVisualStyleBackColor = true;
      this.btn_FreqOk.Click += new EventHandler(this.btn_FreqOk_Click);
      componentResourceManager.ApplyResources((object) this.btn_FreqCancel, "btn_FreqCancel");
      this.btn_FreqCancel.DialogResult = DialogResult.Cancel;
      this.btn_FreqCancel.Name = "btn_FreqCancel";
      this.btn_FreqCancel.UseVisualStyleBackColor = true;
      this.btn_FreqCancel.Click += new EventHandler(this.btn_FreqCancel_Click);
      componentResourceManager.ApplyResources((object) this.txt_FreqStart, "txt_FreqStart");
      this.txt_FreqStart.Name = "txt_FreqStart";
      this.txt_FreqStart.Leave += new EventHandler(this.txt_FreqStart_TextChanged);
      componentResourceManager.ApplyResources((object) this.nud_FreqAddCh, "nud_FreqAddCh");
      this.nud_FreqAddCh.Maximum = new Decimal(new int[4]
      {
        900,
        0,
        0,
        0
      });
      this.nud_FreqAddCh.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.nud_FreqAddCh.Name = "nud_FreqAddCh";
      this.nud_FreqAddCh.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.cmb_FreqStep, "cmb_FreqStep");
      this.cmb_FreqStep.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmb_FreqStep.FormattingEnabled = true;
      this.cmb_FreqStep.Name = "cmb_FreqStep";
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.Name = "label3";
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.Name = "label4";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btn_FreqCancel;
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.cmb_FreqStep);
      this.Controls.Add((Control) this.nud_FreqAddCh);
      this.Controls.Add((Control) this.txt_FreqStart);
      this.Controls.Add((Control) this.btn_FreqCancel);
      this.Controls.Add((Control) this.btn_FreqOk);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (FreqForm);
      this.ShowIcon = false;
      this.nud_FreqAddCh.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
