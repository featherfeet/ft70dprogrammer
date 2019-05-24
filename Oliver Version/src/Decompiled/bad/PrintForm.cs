// Decompiled with JetBrains decompiler
// Type: ADMS10.PrintForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using Musashi.RprtNET;
using System;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Resources;
using System.Windows.Forms;

namespace ADMS10
{
  public class PrintForm : Form
  {
    private ResourceManager resources = new ResourceManager("ADMS10.Strings", typeof (DataForm).Assembly);
    private PrintControl prt = new PrintControl();
    private PageSettings PageSetting = new PageSettings();
    private string[][] RPR_FILENAME = new string[6][];
    private int[] colbuf = new int[100];
    private const int RPR_ROW = 36;
    private const int RPR_COL = 14;
    private const string RPR_DIR = "PrintForms\\";
    private DataForm dataform;
    private DataGridView dgv;
    private int total_page;
    private int set_pr;
    private int page;
    private int tIndex;
    private int visible_col;
    private int visible_row;
    private int visible_row_end;
    private IContainer components;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private Label label1;
    private Label label2;
    private Button btn_PrintStart;
    private Button btn_Cancel;
    private Button btn_SetPrint;
    private PrintDialog printDialog1;
    private PrintControl printControl1;
    private PrintDocument printDocument1;

    public PrintForm(DataForm dForm)
    {
      this.RPR_FILENAME[0] = new string[4]
      {
        "common.rpr",
        "common.rpr",
        "common.rpr",
        "norm.rpr"
      };
      this.RPR_FILENAME[1] = new string[2]
      {
        "common.rpr",
        "skip.rpr"
      };
      this.RPR_FILENAME[2] = new string[2]
      {
        "common.rpr",
        "pms.rpr"
      };
      this.RPR_FILENAME[3] = new string[2]
      {
        "common.rpr",
        "vfo.rpr"
      };
      this.RPR_FILENAME[4] = new string[2]
      {
        "common.rpr",
        "home.rpr"
      };
      this.RPR_FILENAME[5] = new string[3]
      {
        "common.rpr",
        "common.rpr",
        "wx.rpr"
      };
      this.InitializeComponent();
      this.dataform = dForm;
      this.dgv = this.dataform.SelectedDgv();
      this.tIndex = this.dataform.SelectedIndexTab();
      this.total_page = this.RPR_FILENAME[this.tIndex].Length;
      for (int index = 0; index < this.colbuf.Length; ++index)
        this.colbuf[index] = -1;
      int index1 = 0;
      for (int index2 = 0; index2 < this.dgv.ColumnCount; ++index2)
      {
        if (this.dgv.Columns[index2].Visible)
        {
          ++this.visible_col;
          this.colbuf[index1] = index2;
          ++index1;
        }
      }
      for (int index2 = 0; index2 < this.dgv.RowCount; ++index2)
      {
        if (this.dgv.Rows[index2].Visible)
          ++this.visible_row;
      }
      this.numericUpDown1.Minimum = new Decimal(1);
      this.numericUpDown1.Maximum = (Decimal) this.visible_row;
      this.numericUpDown1.Value = new Decimal(1);
      this.numericUpDown2.Minimum = new Decimal(1);
      this.numericUpDown2.Maximum = (Decimal) this.visible_row;
      this.numericUpDown2.Value = (Decimal) this.visible_row;
      this.printDocument1.DefaultPageSettings.Landscape = true;
    }

    private void btn_PrintStart_Click(object sender, EventArgs e)
    {
      try
      {
        this.printDialog1.Document = this.printDocument1;
        this.set_pr = (int) this.numericUpDown1.Value - 1;
        this.page = 0;
        int num = 0;
        for (int index = 0; index < this.dgv.RowCount; ++index)
        {
          if (this.dgv.Rows[index].Visible)
          {
            ++num;
            if ((Decimal) num == this.numericUpDown2.Value)
              this.visible_row_end = index;
          }
        }
        this.printDocument1.Print();
      }
      catch
      {
        int num = (int) MessageBox.Show(this.resources.GetString("PRINTERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.Close();
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btn_SetPrint_Click(object sender, EventArgs e)
    {
      int num = (int) this.printDialog1.ShowDialog();
    }

    private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
    {
      try
      {
        this.prt.OpenFile("PrintForms\\" + this.RPR_FILENAME[this.tIndex][this.page]);
        this.prt.SetTableCellText("Table1", 0, 0, this.dgv.TopLeftHeaderCell.Value.ToString());
        int num = 1;
        for (int index = 1; index < 36; ++index)
        {
          int dr = this.set_pr + index - 1;
          if (this.dgv.Rows[dr].Visible)
          {
            this.prt.SetTableCellText("Table1", num, 0, this.dgv.Rows[dr].HeaderCell.Value.ToString());
            for (int pc = 1; pc < 14; ++pc)
            {
              int dc = this.colbuf[this.page * 13 + pc - 1];
              if (dc != -1)
                this.write(pc, num, dc, dr);
            }
            ++num;
          }
          if (dr >= this.visible_row_end)
            break;
        }
        ++this.page;
        if (this.page >= this.total_page)
        {
          this.page = 0;
          this.set_pr += 35;
        }
        this.prt.PrintPage(e.Graphics);
        if ((Decimal) this.set_pr < this.numericUpDown2.Value)
          e.HasMorePages = true;
        else
          e.HasMorePages = false;
      }
      catch
      {
        int num = (int) MessageBox.Show(this.resources.GetString("PRINTERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void write(int pc, int pr, int dc, int dr)
    {
      this.prt.SetTableCellText("Table1", 0, pc, this.dgv.Columns[dc].HeaderCell.Value.ToString());
      object obj = this.dgv.Rows[dr].Cells[dc].Value;
      if (this.dgv.Rows[dr].Cells[dc].Value == null)
        return;
      string text = obj.ToString();
      if (text != "")
      {
        switch (dc)
        {
          case 1:
          case 2:
          case 3:
            text = Convert.ToDecimal(obj).ToString("N5");
            break;
          case 4:
          case 6:
          case 7:
          case 8:
          case 9:
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
          case 51:
            break;
          default:
            text = this.dgv.Rows[dr].Cells[1].Value == null || this.dgv.Rows[dr].Cells[1].Value.ToString() == "" ? "" : (!this.dgv.Rows[dr].Cells[dc].EditedFormattedValue.Equals((object) true) ? "OFF" : "ON");
            break;
        }
      }
      this.prt.SetTableCellText("Table1", pr, pc, text);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PrintForm));
      this.numericUpDown1 = new NumericUpDown();
      this.numericUpDown2 = new NumericUpDown();
      this.label1 = new Label();
      this.label2 = new Label();
      this.btn_PrintStart = new Button();
      this.btn_Cancel = new Button();
      this.btn_SetPrint = new Button();
      this.printDialog1 = new PrintDialog();
      this.printDocument1 = new PrintDocument();
      this.printControl1 = new PrintControl();
      this.numericUpDown1.BeginInit();
      this.numericUpDown2.BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.numericUpDown1, "numericUpDown1");
      this.numericUpDown1.Name = "numericUpDown1";
      componentResourceManager.ApplyResources((object) this.numericUpDown2, "numericUpDown2");
      this.numericUpDown2.Name = "numericUpDown2";
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.btn_PrintStart, "btn_PrintStart");
      this.btn_PrintStart.Name = "btn_PrintStart";
      this.btn_PrintStart.UseVisualStyleBackColor = true;
      this.btn_PrintStart.Click += new EventHandler(this.btn_PrintStart_Click);
      componentResourceManager.ApplyResources((object) this.btn_Cancel, "btn_Cancel");
      this.btn_Cancel.DialogResult = DialogResult.Cancel;
      this.btn_Cancel.Name = "btn_Cancel";
      this.btn_Cancel.UseVisualStyleBackColor = true;
      this.btn_Cancel.Click += new EventHandler(this.btn_Cancel_Click);
      componentResourceManager.ApplyResources((object) this.btn_SetPrint, "btn_SetPrint");
      this.btn_SetPrint.Name = "btn_SetPrint";
      this.btn_SetPrint.UseVisualStyleBackColor = true;
      this.btn_SetPrint.Click += new EventHandler(this.btn_SetPrint_Click);
      this.printDialog1.Document = this.printDocument1;
      this.printDialog1.UseEXDialog = true;
      this.printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btn_Cancel;
      this.Controls.Add((Control) this.btn_SetPrint);
      this.Controls.Add((Control) this.btn_Cancel);
      this.Controls.Add((Control) this.btn_PrintStart);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.numericUpDown2);
      this.Controls.Add((Control) this.numericUpDown1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (PrintForm);
      this.ShowIcon = false;
      this.numericUpDown1.EndInit();
      this.numericUpDown2.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
