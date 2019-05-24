// Decompiled with JetBrains decompiler
// Type: ADMS10.SearchForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ADMS10
{
  public class SearchForm : Form
  {
    private AdmsForm mfd;
    private DataForm cDataForm;
    private DataGridView cDgv;
    private int selCol;
    private IContainer components;
    private ComboBox cmb_Select;
    private Button btn_OK;
    private Button Btn_Cancel;
    private TextBox txt_Data;
    private Label label1;
    private Label label2;
    private CheckBox chb_Data;
    private ComboBox cmb_Data;

    public SearchForm(AdmsForm aForm, DataForm dForm)
    {
      this.cDataForm = dForm;
      this.mfd = aForm;
      this.InitializeComponent();
      this.cDgv = dForm.SelectedDgv();
      this.cmb_Select.Items.Clear();
      for (int index = 0; index < this.cDgv.ColumnCount; ++index)
      {
        if (this.cDgv.Columns[index].Visible)
          this.cmb_Select.Items.Add((object) this.cDgv.Columns[index].HeaderText);
      }
      int stringExact = this.cmb_Select.FindStringExact(this.cDataForm.finedHeader_Bak);
      if (stringExact != -1)
        this.cmb_Select.SelectedIndex = stringExact;
      else
        this.cmb_Select.SelectedIndex = 0;
      switch (this.selCol)
      {
        case 1:
        case 2:
        case 3:
        case 9:
        case 51:
          this.txt_Data.Text = this.cDataForm.finedVal_Bak[this.selCol];
          break;
        case 4:
        case 6:
        case 7:
        case 8:
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
        case 16:
        case 18:
        case 22:
        case 23:
        case 24:
          this.cmb_Data.Text = this.cDataForm.finedVal_Bak[this.selCol];
          break;
        default:
          if (this.cDataForm.finedVal_Bak[this.selCol] == "1")
          {
            this.chb_Data.Checked = true;
            break;
          }
          this.chb_Data.Checked = false;
          break;
      }
    }

    private void btn_OK_Click(object sender, EventArgs e)
    {
      switch (this.selCol)
      {
        case 1:
        case 2:
        case 3:
        case 9:
        case 51:
          this.mfd.FinedStr = this.txt_Data.Text;
          break;
        case 4:
        case 6:
        case 7:
        case 8:
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
        case 16:
        case 18:
        case 22:
        case 23:
        case 24:
          this.mfd.FinedStr = this.cmb_Data.Items[this.cmb_Data.SelectedIndex].ToString();
          break;
        default:
          this.mfd.FinedStr = !this.chb_Data.Checked ? "0" : "1";
          break;
      }
      this.mfd.FinedCol = this.selCol;
      this.cDataForm.Fined(this.mfd.FinedCol, this.mfd.FinedStr);
      this.cDataForm.finedHeader_Bak = this.cmb_Select.Text;
      this.cDataForm.finedVal_Bak[this.selCol] = this.mfd.FinedStr;
      this.Close();
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cmb_Select_SelectedIndexChanged(object sender, EventArgs e)
    {
      for (int index = 0; index < this.cDgv.ColumnCount; ++index)
      {
        if (this.cDgv.Columns[index].HeaderText == this.cmb_Select.Text)
          this.selCol = index;
      }
      switch (this.selCol)
      {
        case 1:
        case 2:
        case 3:
        case 9:
        case 51:
          this.chb_Data.Visible = false;
          this.cmb_Data.Visible = false;
          this.txt_Data.Visible = true;
          break;
        case 4:
        case 6:
        case 7:
        case 8:
        case 10:
        case 11:
        case 12:
        case 13:
        case 14:
        case 15:
        case 16:
        case 18:
        case 22:
        case 23:
        case 24:
          this.cmb_Data.Items.Clear();
          DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn) this.cDgv.Columns[this.selCol];
          for (int index = 0; index < column.Items.Count; ++index)
            this.cmb_Data.Items.Add(column.Items[index]);
          this.cmb_Data.SelectedIndex = 0;
          this.chb_Data.Visible = false;
          this.cmb_Data.Visible = true;
          this.txt_Data.Visible = false;
          break;
        default:
          this.chb_Data.Visible = true;
          this.cmb_Data.Visible = false;
          this.txt_Data.Visible = false;
          break;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SearchForm));
      this.cmb_Select = new ComboBox();
      this.btn_OK = new Button();
      this.Btn_Cancel = new Button();
      this.txt_Data = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.chb_Data = new CheckBox();
      this.cmb_Data = new ComboBox();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.cmb_Select, "cmb_Select");
      this.cmb_Select.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmb_Select.FormattingEnabled = true;
      this.cmb_Select.Name = "cmb_Select";
      this.cmb_Select.SelectedIndexChanged += new EventHandler(this.cmb_Select_SelectedIndexChanged);
      componentResourceManager.ApplyResources((object) this.btn_OK, "btn_OK");
      this.btn_OK.Name = "btn_OK";
      this.btn_OK.UseVisualStyleBackColor = true;
      this.btn_OK.Click += new EventHandler(this.btn_OK_Click);
      componentResourceManager.ApplyResources((object) this.Btn_Cancel, "Btn_Cancel");
      this.Btn_Cancel.DialogResult = DialogResult.Cancel;
      this.Btn_Cancel.Name = "Btn_Cancel";
      this.Btn_Cancel.UseVisualStyleBackColor = true;
      this.Btn_Cancel.Click += new EventHandler(this.btn_Cancel_Click);
      componentResourceManager.ApplyResources((object) this.txt_Data, "txt_Data");
      this.txt_Data.Name = "txt_Data";
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.chb_Data, "chb_Data");
      this.chb_Data.Checked = true;
      this.chb_Data.CheckState = CheckState.Checked;
      this.chb_Data.Name = "chb_Data";
      this.chb_Data.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.cmb_Data, "cmb_Data");
      this.cmb_Data.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmb_Data.FormattingEnabled = true;
      this.cmb_Data.Name = "cmb_Data";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.Btn_Cancel;
      this.Controls.Add((Control) this.cmb_Data);
      this.Controls.Add((Control) this.chb_Data);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.txt_Data);
      this.Controls.Add((Control) this.Btn_Cancel);
      this.Controls.Add((Control) this.btn_OK);
      this.Controls.Add((Control) this.cmb_Select);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (SearchForm);
      this.ShowIcon = false;
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
