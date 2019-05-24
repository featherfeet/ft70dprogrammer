// Decompiled with JetBrains decompiler
// Type: ADMS10.SetForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace ADMS10
{
  public class SetForm : Form
  {
    private mojiConvert mojiConv = new mojiConvert();
    private Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
    private ResourceManager resources = new ResourceManager("ADMS10.Strings", typeof (DataForm).Assembly);
    private Database db;
    private DataForm cDataForm;
    private bool lock_flg;
    private IContainer components;
    private GroupBox grb_Memory;
    private ComboBox cmb_Memory_WriteMode;
    private Label lbl_Memory_WriteMode;
    private GroupBox grb_Scan;
    private ComboBox cmb_Scan_ReStart;
    private Label lbl_Scan_ReStart;
    private ComboBox cmb_Scan_Lamp;
    private Label lbl_Scan_Lamp;
    private ComboBox cmb_Scan_DwTime;
    private Label lbl_Scan_DwTime;
    private GroupBox grb_Signaling;
    private ComboBox cmb_Signaling_PagerRxCode2;
    private ComboBox cmb_Signaling_PagerTxCode2;
    private ComboBox cmb_Signaling_PagerTxCode1;
    private Label lbl_Signaling_PagerRxCode2;
    private Label lbl_Signaling_PagerTxCode1;
    private ComboBox cmb_Signaling_PagerRxCode1;
    private Label lbl_Signaling_PagerRxCode1;
    private ComboBox cmb_Signaling_PagerAnserBack;
    private Label lbl_Signaling_PagerTxCode2;
    private Label lbl_Signaling_PagerAnserBack;
    private Label lbl_Signaling_Pager;
    private ComboBox cmb_Signaling_DtmfTxSpeed;
    private Label lbl_Signaling_DtmfTxMode;
    private ComboBox cmb_Signaling_DtmfTxMode;
    private Label lbl_Signaling_DtmfTxDelay;
    private ComboBox cmb_Signaling_DtmfTxDelay;
    private Label lbl_Signaling_DtmfTxSpeed;
    private Label lbl_Signaling_Dtmf;
    private ComboBox cmb_Signaling_WxAlart;
    private ComboBox cmb_Signaling_Bell;
    private ComboBox cmb_Signaling_ToneSarchSpeed;
    private ComboBox cmb_Signaling_ToneSarchMute;
    private ComboBox cmb_Signaling_SqlExpansion;
    private ComboBox cmb_Signaling_SqlLevel;
    private Label lbl_Signaling_SqlLevel;
    private GroupBox grb_DtmfMemory;
    private DataGridView dgv_DtmfSelect;
    private GroupBox grp_Scan_ScanWidth;
    private ComboBox cmb_ScanWidth_Vfo;
    private Label lbl_ScanWidth_Vfo;
    private ComboBox cmb_ScanWidth_Memory;
    private Label lbl_ScanWidth_Memory;
    private GroupBox grp_Scan_ScanResume;
    private ComboBox cmb_ScanResume_Scan;
    private Label lbl_ScanResume_Scan;
    private ComboBox cmb_ScanResume_Dw;
    private Label lbl_ScanResume_Dw;
    private GroupBox grb_Digital;
    private Label lbl_Digital_GmMode;
    private ComboBox cmb_Digital_GmMode;
    private Label lbl_Digital_StandbyBeep;
    private ComboBox cmb_Digital_StandbyBeep;
    private ComboBox cmb_Digital_SqlCode;
    private Label lbl_Digital_SqlCode;
    private ComboBox cmb_Digital_Popup;
    private Label lbl_Digital_Popup;
    private ComboBox cmb_Digital_SqlType;
    private Label lbl_Digital_SqlType;
    private ComboBox cmb_Digital_AmsTxMode;
    private Label lbl_Digital_AmsTxMode;
    private GroupBox grb_MemoryBank;
    private DataGridView dgv_MemoryBank;
    private GroupBox grb_Gm;
    private Label lbl_Gm_Interval;
    private ComboBox cmb_Gm_Interval;
    private Label lbl_Gm_Ringer;
    private TextBox txt_Digital_MyCallSign;
    private ComboBox cmb_Gm_Ringer;
    private Label lbl_Digital_MyCallSign;
    private GroupBox grb_Config;
    private ComboBox cmb_Config_HomeRev;
    private Label lbl_Config_HomeRev;
    private ComboBox cmb_Config_DwRvt;
    private Label lbl_Config_DwRvt;
    private ComboBox cmb_Config_Tot;
    private Label lbl_Config_VfoMode;
    private ComboBox cmb_Config_VfoMode;
    private Label lbl_Config_Tot;
    private ComboBox cmb_Config_SaveRx;
    private Label lbl_Config_SaveRx;
    private ComboBox cmb_Config_RptArs;
    private Label lbl_Config_RptArs;
    private ComboBox cmb_Config_PttDelay;
    private Label lbl_Config_PttDelay;
    private ComboBox cmb_Config_MonTcall;
    private Label lbl_Config_MonTcall;
    private ComboBox cmb_Config_Lock;
    private Label lbl_Config_Lock;
    private ComboBox cmb_Config_HomeVfo;
    private Label lbl_Config_HomeVfo;
    private TextBox txt_Config_PasswordTxt;
    private ComboBox cmb_Config_BeepEdge;
    private Label lbl_Config_BeepEdge;
    private ComboBox cmb_Config_PasswordSel;
    private Label lbl_Config_PasswordSel;
    private ComboBox cmb_Config_BusyLed;
    private Label lbl_Config_BusyLedA;
    private ComboBox cmb_Config_BeepSelect;
    private Label lbl_Config_BeepSelect;
    private ComboBox cmb_Config_Bclo;
    private Label lbl_Config_Bclo;
    private ComboBox cmb_Config_Apo;
    private Label lbl_Config_Apo;
    private GroupBox grb_TxRx;
    private ComboBox cmb_TxRx_MicGain;
    private Label lbl_TxRx_MicGain;
    private GroupBox grb_Display;
    private TextBox txt_Display_OpeningMessageTxt;
    private ComboBox cmb_Display_OpeningMessageSel;
    private ComboBox cmb_Display_LcdDimmer;
    private ComboBox cmb_Display_Lamp;
    private Label lbl_Signaling_WxAlart;
    private Label lbl_Signaling_Bell;
    private Label lbl_Signaling_ToneSarchSpeed;
    private Label lbl_Signaling_ToneSarchMute;
    private Label lbl_Signaling_SqlExpansion;
    private Label lbl_Display_OpeningMessage;
    private Label lbl_Display_LcdDimmer;
    private Label lbl_Display_Lamp;
    private Label lbl_Config_P2;
    private Label lbl_Config_P1;
    private ComboBox cmb_Config_P2;
    private ComboBox cmb_Config_P1;
    private Label lbl_Digital_SplitDgIdTxCode;
    private Label lbl_Digital_SplitDgIdRxCode;
    private Label lbl_Digital_DgIdMode;
    private Label lbl_Digital_NormalDgIdCode;
    private ComboBox cmb_Digital_SplitDgIdTxCode;
    private ComboBox cmb_Digital_DgIdMode;
    private ComboBox cmb_Digital_NormalDgIdCode;
    private ComboBox cmb_Digital_SplitDgIdRxCode;
    private Label lbl_Display_TempUnit;
    private ComboBox cmb_Display_TempUnit;
    private DataGridViewTextBoxColumn BankName;
    private DataGridViewTextBoxColumn CODE;
    private Label lbl_Config_BeepLevel;
    private ComboBox cmb_Config_BeepLevel;
    private Label lbl_Digital_VwMode;
    private ComboBox cmb_Digital_VwMode;
    private Label label1;
    private ComboBox cmb_Gm_StatusLed;
    private Label lbl_Gm_StatusLed;

    public SetForm()
    {
    }

    public SetForm(DataForm dataform)
    {
      this.InitializeComponent();
      this.cDataForm = dataform;
      this.db = this.cDataForm.GetDB();
    }

    private void SetForm_Load(object sender, EventArgs e)
    {
      this.dgv_DtmfSelect.TopLeftHeaderCell.Value = (object) this.resources.GetString("DTMFNUM");
      this.dgv_DtmfSelect.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_DtmfSelect.Rows.Add(10);
      for (int index = 0; index < this.dgv_DtmfSelect.RowCount - 1; ++index)
        this.dgv_DtmfSelect.Rows[index].HeaderCell.Value = (object) (index + 1).ToString();
      this.dgv_DtmfSelect.Rows[this.dgv_DtmfSelect.RowCount - 1].HeaderCell.Value = (object) string.Concat((object) 0);
      this.dgv_DtmfSelect.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgv_MemoryBank.TopLeftHeaderCell.Value = (object) this.resources.GetString("MEMORYBANKNUM");
      this.dgv_MemoryBank.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_MemoryBank.Rows.Add(24);
      for (int index = 0; index < this.dgv_MemoryBank.RowCount; ++index)
        this.dgv_MemoryBank.Rows[index].HeaderCell.Value = (object) (index + 1).ToString();
      this.dgv_MemoryBank.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      if (!Settings.Instance.Recv_flg)
      {
        if (Settings.Instance.Language == 0)
        {
          this.cmb_Config_P1.Items.Remove((object) "WX ALERT");
          this.cmb_Config_P2.Items.Remove((object) "WX ALERT");
          this.lbl_Signaling_WxAlart.Visible = false;
          this.cmb_Signaling_WxAlart.Visible = false;
        }
      }
      else if (Settings.Instance.CpuType == 1 || Settings.Instance.CpuType == 2 && Settings.Instance.CountryType != 1)
      {
        this.cmb_Config_P1.Items.Remove((object) "WX ALERT");
        this.cmb_Config_P2.Items.Remove((object) "WX ALERT");
        this.lbl_Signaling_WxAlart.Visible = false;
        this.cmb_Signaling_WxAlart.Visible = false;
      }
      this.txt_Config_PasswordTxt.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_PassWord_KeyPress);
      this.txt_Display_OpeningMessageTxt.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_MemoryName_KeyPress);
      this.txt_Digital_MyCallSign.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_GmCallSign_KeyPress);
      this.cmb_Config_Apo.DataBindings.Add("SelectedIndex", (object) this.db, "Config_Apo");
      this.cmb_Config_Bclo.DataBindings.Add("SelectedIndex", (object) this.db, "Config_Bclo");
      this.cmb_Config_BeepSelect.DataBindings.Add("SelectedIndex", (object) this.db, "Config_BeepSelect");
      this.cmb_Config_BeepLevel.DataBindings.Add("SelectedIndex", (object) this.db, "Config_BeepLevel");
      this.cmb_Config_BeepEdge.DataBindings.Add("SelectedIndex", (object) this.db, "Config_BeepEdge");
      this.cmb_Config_BusyLed.DataBindings.Add("SelectedIndex", (object) this.db, "Config_BusyLed");
      this.cmb_Config_PasswordSel.DataBindings.Add("SelectedIndex", (object) this.db, "Config_PasswordSel");
      this.txt_Config_PasswordTxt.DataBindings.Add("Text", (object) this.db, "Config_PasswordTxt");
      this.cmb_Config_HomeRev.DataBindings.Add("SelectedIndex", (object) this.db, "Config_HomeRev");
      this.cmb_Config_HomeVfo.DataBindings.Add("SelectedIndex", (object) this.db, "Config_HomeVfo");
      this.cmb_Config_Lock.DataBindings.Add("SelectedIndex", (object) this.db, "Config_Lock");
      this.cmb_Config_MonTcall.DataBindings.Add("SelectedIndex", (object) this.db, "Config_MonTcall");
      this.cmb_Config_PttDelay.DataBindings.Add("SelectedIndex", (object) this.db, "Config_PttDelay");
      this.cmb_Config_RptArs.DataBindings.Add("SelectedIndex", (object) this.db, "Config_RptArs");
      this.cmb_Config_SaveRx.DataBindings.Add("SelectedIndex", (object) this.db, "Config_SaveRx");
      this.cmb_Config_VfoMode.DataBindings.Add("SelectedIndex", (object) this.db, "Config_VfoMode");
      this.cmb_Config_Tot.DataBindings.Add("SelectedIndex", (object) this.db, "Config_Tot");
      this.cmb_Config_DwRvt.DataBindings.Add("SelectedIndex", (object) this.db, "Config_DwRvt");
      this.cmb_Config_P1.DataBindings.Add("SelectedIndex", (object) this.db, "Config_P1");
      this.cmb_Config_P2.DataBindings.Add("SelectedIndex", (object) this.db, "Config_P2");
      this.cmb_TxRx_MicGain.DataBindings.Add("SelectedIndex", (object) this.db, "TxRx_MicGain");
      this.cmb_Display_Lamp.DataBindings.Add("SelectedIndex", (object) this.db, "Display_Lamp");
      this.cmb_Display_LcdDimmer.DataBindings.Add("SelectedIndex", (object) this.db, "Display_LcdDimmer");
      this.cmb_Display_OpeningMessageSel.DataBindings.Add("SelectedIndex", (object) this.db, "Display_OpeningMessageSel");
      this.txt_Display_OpeningMessageTxt.DataBindings.Add("Text", (object) this.db, "Display_OpeningMessageTxt");
      this.cmb_Display_TempUnit.DataBindings.Add("SelectedIndex", (object) this.db, "Display_TempUnit");
      this.cmb_Scan_DwTime.DataBindings.Add("SelectedIndex", (object) this.db, "Scan_DwTime");
      this.cmb_Scan_Lamp.DataBindings.Add("SelectedIndex", (object) this.db, "Scan_Lamp");
      this.cmb_Scan_ReStart.DataBindings.Add("SelectedIndex", (object) this.db, "Scan_ReStart");
      this.cmb_ScanResume_Scan.DataBindings.Add("SelectedIndex", (object) this.db, "ScanResume_Scan");
      this.cmb_ScanResume_Dw.DataBindings.Add("SelectedIndex", (object) this.db, "ScanResume_Dw");
      this.cmb_ScanWidth_Vfo.DataBindings.Add("SelectedIndex", (object) this.db, "ScanWidth_Vfo");
      this.cmb_ScanWidth_Memory.DataBindings.Add("SelectedIndex", (object) this.db, "ScanWidth_Memory");
      this.txt_Digital_MyCallSign.DataBindings.Add("Text", (object) this.db, "Digital_MyCallSign");
      this.cmb_Digital_AmsTxMode.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_AmsTxMode");
      this.cmb_Digital_VwMode.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_VwMode");
      this.cmb_Digital_GmMode.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_GmMode");
      this.cmb_Digital_SqlType.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_SqlType");
      this.cmb_Digital_DgIdMode.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_DgIdMode");
      this.cmb_Digital_NormalDgIdCode.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_NormalDgIdCode");
      this.cmb_Digital_SplitDgIdRxCode.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_SplitDgIdRxCode");
      this.cmb_Digital_SplitDgIdTxCode.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_SplitDgIdTxCode");
      this.cmb_Digital_SqlCode.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_SqlCode");
      this.cmb_Digital_Popup.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_Popup");
      this.cmb_Digital_StandbyBeep.DataBindings.Add("SelectedIndex", (object) this.db, "Digital_StandbyBeep");
      this.cmb_Gm_Ringer.DataBindings.Add("SelectedIndex", (object) this.db, "Gm_Ringer");
      this.cmb_Gm_Interval.DataBindings.Add("SelectedIndex", (object) this.db, "Gm_Interval");
      this.cmb_Gm_StatusLed.DataBindings.Add("SelectedIndex", (object) this.db, "Gm_StatusLed");
      this.cmb_Signaling_DtmfTxMode.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_DtmfTxMode");
      this.cmb_Signaling_DtmfTxDelay.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_DtmfTxDelay");
      this.cmb_Signaling_DtmfTxSpeed.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_DtmfTxSpeed");
      this.cmb_Signaling_PagerAnserBack.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_PagerAnserBack");
      this.cmb_Signaling_PagerRxCode1.SelectedIndex = this.db.Signaling_PagerRxCode1;
      this.cmb_Signaling_PagerRxCode2.SelectedIndex = this.db.Signaling_PagerRxCode2;
      this.cmb_Signaling_PagerTxCode1.SelectedIndex = this.db.Signaling_PagerTxCode1;
      this.cmb_Signaling_PagerTxCode2.SelectedIndex = this.db.Signaling_PagerTxCode2;
      this.cmb_Signaling_SqlLevel.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_SqlLevel");
      this.cmb_Signaling_SqlExpansion.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_SqlExpansion");
      this.cmb_Signaling_ToneSarchMute.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_ToneSarchMute");
      this.cmb_Signaling_ToneSarchSpeed.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_ToneSarchSpeed");
      this.cmb_Signaling_Bell.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_Bell");
      this.cmb_Signaling_WxAlart.DataBindings.Add("SelectedIndex", (object) this.db, "Signaling_WxAlart");
      this.cmb_Memory_WriteMode.DataBindings.Add("SelectedIndex", (object) this.db, "Memory_WriteMode");
      for (int index = 0; index < 10; ++index)
        this.dgv_DtmfSelect.Rows[index].Cells[0].Value = (object) this.db.DtmfMemory[index].Code;
      for (int index = 0; index < 24; ++index)
        this.dgv_MemoryBank.Rows[index].Cells[0].Value = (object) this.db.MemoryBank[index].BankName;
    }

    private void SetForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.dgv_DtmfSelect.Focus();
      this.dgv_DtmfSelect.EndEdit();
      this.dgv_MemoryBank.EndEdit();
      for (int index = 0; index < 10; ++index)
      {
        if (this.dgv_DtmfSelect.Rows[index].Cells[0].Value != null)
          this.db.DtmfMemory[index].Code = this.dgv_DtmfSelect.Rows[index].Cells[0].Value.ToString();
      }
      for (int index = 0; index < 24; ++index)
      {
        if (this.dgv_MemoryBank.Rows[index].Cells[0].Value != null)
          this.db.MemoryBank[index].BankName = this.dgv_MemoryBank.Rows[index].Cells[0].Value.ToString();
      }
    }

    private void dgv_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      if (dataGridView == this.dgv_DtmfSelect)
      {
        if (!(e.Control is DataGridViewTextBoxEditingControl))
          return;
        DataGridViewTextBoxEditingControl control = (DataGridViewTextBoxEditingControl) e.Control;
        control.KeyPress -= new KeyPressEventHandler(KeyPressCancel.txt_Dtmf_KeyPress);
        if (dataGridView.CurrentCell.ColumnIndex != 0)
          return;
        control.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_Dtmf_KeyPress);
      }
      else
      {
        if (!(e.Control is DataGridViewTextBoxEditingControl))
          return;
        DataGridViewTextBoxEditingControl control = (DataGridViewTextBoxEditingControl) e.Control;
        control.KeyPress -= new KeyPressEventHandler(KeyPressCancel.txt_MemoryName_KeyPress);
        if (dataGridView.CurrentCell.ColumnIndex != 0)
          return;
        control.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_MemoryName_KeyPress);
      }
    }

    private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      if (dataGridView == this.dgv_DtmfSelect)
      {
        if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
          dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (object) "";
        foreach (char c in dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToCharArray())
        {
          if (!mojiConvert.IsDtmf(c))
          {
            dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (object) this.db.DtmfMemory[e.ColumnIndex].Code;
            break;
          }
        }
      }
      else
      {
        if (dataGridView != this.dgv_MemoryBank)
          return;
        if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
          dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (object) "";
        foreach (char c in dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToCharArray())
        {
          if (!mojiConvert.IsMemoryNameChar(c))
          {
            dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (object) this.db.MemoryBank[e.ColumnIndex].BankName;
            break;
          }
        }
      }
    }

    private void txt_TextChanged(object sender, EventArgs e)
    {
      TextBox textBox = (TextBox) sender;
      if (textBox == this.txt_Config_PasswordTxt)
      {
        foreach (char c in textBox.Text.ToCharArray())
        {
          if (!mojiConvert.IsPW(c))
          {
            this.txt_Config_PasswordTxt.Text = this.db.Config_PasswordTxt;
            break;
          }
        }
      }
      else if (textBox == this.txt_Display_OpeningMessageTxt)
      {
        foreach (char c in textBox.Text.ToCharArray())
        {
          if (!mojiConvert.IsMemoryNameChar(c))
          {
            this.txt_Display_OpeningMessageTxt.Text = this.db.Display_OpeningMessageTxt;
            break;
          }
        }
      }
      else
      {
        if (textBox != this.txt_Digital_MyCallSign)
          return;
        char[] charArray = textBox.Text.ToCharArray();
        for (int index = 0; index < charArray.Length; ++index)
        {
          if (index == 0)
          {
            if (charArray[index] != '/' && charArray[index] != '-')
            {
              if (!mojiConvert.IsCallSign(charArray[index]))
              {
                this.txt_Digital_MyCallSign.Text = this.db.Digital_MyCallSign;
                break;
              }
            }
            else
              this.txt_Digital_MyCallSign.Text = "";
          }
          else if (!mojiConvert.IsCallSign(charArray[index]))
          {
            this.txt_Digital_MyCallSign.Text = this.db.Digital_MyCallSign;
            break;
          }
        }
      }
    }

    private void cmb_Signaling_PagerRxTxCode_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.lock_flg)
        return;
      this.lock_flg = true;
      ComboBox comboBox = (ComboBox) sender;
      int selectedIndex1 = this.cmb_Signaling_PagerRxCode1.SelectedIndex;
      int selectedIndex2 = this.cmb_Signaling_PagerRxCode2.SelectedIndex;
      int selectedIndex3 = this.cmb_Signaling_PagerTxCode1.SelectedIndex;
      int selectedIndex4 = this.cmb_Signaling_PagerTxCode2.SelectedIndex;
      bool flag = false;
      if (comboBox.Equals((object) this.cmb_Signaling_PagerRxCode1))
      {
        if (selectedIndex1 == selectedIndex2)
        {
          this.cmb_Signaling_PagerRxCode1.SelectedIndex = this.db.Signaling_PagerRxCode1;
          flag = true;
        }
        else
          this.db.Signaling_PagerRxCode1 = this.cmb_Signaling_PagerRxCode1.SelectedIndex;
      }
      else if (comboBox.Equals((object) this.cmb_Signaling_PagerRxCode2))
      {
        if (selectedIndex1 == selectedIndex2)
        {
          this.cmb_Signaling_PagerRxCode2.SelectedIndex = this.db.Signaling_PagerRxCode2;
          flag = true;
        }
        else
          this.db.Signaling_PagerRxCode2 = this.cmb_Signaling_PagerRxCode2.SelectedIndex;
      }
      else if (comboBox.Equals((object) this.cmb_Signaling_PagerTxCode1))
      {
        if (selectedIndex3 == selectedIndex4)
        {
          this.cmb_Signaling_PagerTxCode1.SelectedIndex = this.db.Signaling_PagerTxCode1;
          flag = true;
        }
        else
          this.db.Signaling_PagerTxCode1 = this.cmb_Signaling_PagerTxCode1.SelectedIndex;
      }
      else if (comboBox.Equals((object) this.cmb_Signaling_PagerTxCode2))
      {
        if (selectedIndex3 == selectedIndex4)
        {
          this.cmb_Signaling_PagerTxCode2.SelectedIndex = this.db.Signaling_PagerTxCode2;
          flag = true;
        }
        else
          this.db.Signaling_PagerTxCode2 = this.cmb_Signaling_PagerTxCode2.SelectedIndex;
      }
      if (flag)
      {
        int num = (int) MessageBox.Show(this.resources.GetString("RXTXCODEERRORMSG"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.lock_flg = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SetForm));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.grb_Memory = new GroupBox();
      this.cmb_Memory_WriteMode = new ComboBox();
      this.lbl_Memory_WriteMode = new Label();
      this.grb_Scan = new GroupBox();
      this.cmb_Scan_ReStart = new ComboBox();
      this.lbl_Scan_ReStart = new Label();
      this.cmb_Scan_Lamp = new ComboBox();
      this.lbl_Scan_Lamp = new Label();
      this.cmb_Scan_DwTime = new ComboBox();
      this.lbl_Scan_DwTime = new Label();
      this.grb_Signaling = new GroupBox();
      this.lbl_Signaling_WxAlart = new Label();
      this.lbl_Signaling_Bell = new Label();
      this.lbl_Signaling_ToneSarchSpeed = new Label();
      this.lbl_Signaling_ToneSarchMute = new Label();
      this.lbl_Signaling_SqlExpansion = new Label();
      this.cmb_Signaling_PagerRxCode2 = new ComboBox();
      this.cmb_Signaling_PagerTxCode2 = new ComboBox();
      this.cmb_Signaling_PagerTxCode1 = new ComboBox();
      this.lbl_Signaling_PagerRxCode2 = new Label();
      this.lbl_Signaling_PagerTxCode1 = new Label();
      this.cmb_Signaling_PagerRxCode1 = new ComboBox();
      this.lbl_Signaling_PagerRxCode1 = new Label();
      this.cmb_Signaling_PagerAnserBack = new ComboBox();
      this.lbl_Signaling_PagerTxCode2 = new Label();
      this.lbl_Signaling_PagerAnserBack = new Label();
      this.lbl_Signaling_Pager = new Label();
      this.cmb_Signaling_DtmfTxSpeed = new ComboBox();
      this.lbl_Signaling_DtmfTxMode = new Label();
      this.cmb_Signaling_DtmfTxMode = new ComboBox();
      this.lbl_Signaling_DtmfTxDelay = new Label();
      this.cmb_Signaling_DtmfTxDelay = new ComboBox();
      this.lbl_Signaling_DtmfTxSpeed = new Label();
      this.lbl_Signaling_Dtmf = new Label();
      this.cmb_Signaling_WxAlart = new ComboBox();
      this.cmb_Signaling_Bell = new ComboBox();
      this.cmb_Signaling_ToneSarchSpeed = new ComboBox();
      this.cmb_Signaling_ToneSarchMute = new ComboBox();
      this.cmb_Signaling_SqlExpansion = new ComboBox();
      this.cmb_Signaling_SqlLevel = new ComboBox();
      this.lbl_Signaling_SqlLevel = new Label();
      this.grb_DtmfMemory = new GroupBox();
      this.dgv_DtmfSelect = new DataGridView();
      this.CODE = new DataGridViewTextBoxColumn();
      this.grp_Scan_ScanWidth = new GroupBox();
      this.cmb_ScanWidth_Vfo = new ComboBox();
      this.lbl_ScanWidth_Vfo = new Label();
      this.cmb_ScanWidth_Memory = new ComboBox();
      this.lbl_ScanWidth_Memory = new Label();
      this.grp_Scan_ScanResume = new GroupBox();
      this.cmb_ScanResume_Scan = new ComboBox();
      this.lbl_ScanResume_Scan = new Label();
      this.cmb_ScanResume_Dw = new ComboBox();
      this.lbl_ScanResume_Dw = new Label();
      this.grb_Digital = new GroupBox();
      this.cmb_Digital_DgIdMode = new ComboBox();
      this.lbl_Digital_VwMode = new Label();
      this.lbl_Digital_SqlType = new Label();
      this.cmb_Digital_VwMode = new ComboBox();
      this.cmb_Digital_NormalDgIdCode = new ComboBox();
      this.cmb_Digital_SplitDgIdRxCode = new ComboBox();
      this.cmb_Digital_SqlType = new ComboBox();
      this.cmb_Digital_SplitDgIdTxCode = new ComboBox();
      this.cmb_Digital_GmMode = new ComboBox();
      this.lbl_Digital_SplitDgIdTxCode = new Label();
      this.lbl_Digital_GmMode = new Label();
      this.lbl_Digital_SplitDgIdRxCode = new Label();
      this.lbl_Digital_NormalDgIdCode = new Label();
      this.lbl_Digital_StandbyBeep = new Label();
      this.lbl_Digital_DgIdMode = new Label();
      this.txt_Digital_MyCallSign = new TextBox();
      this.cmb_Digital_StandbyBeep = new ComboBox();
      this.lbl_Digital_MyCallSign = new Label();
      this.cmb_Digital_SqlCode = new ComboBox();
      this.lbl_Digital_SqlCode = new Label();
      this.cmb_Digital_Popup = new ComboBox();
      this.lbl_Digital_Popup = new Label();
      this.cmb_Digital_AmsTxMode = new ComboBox();
      this.lbl_Digital_AmsTxMode = new Label();
      this.grb_MemoryBank = new GroupBox();
      this.dgv_MemoryBank = new DataGridView();
      this.BankName = new DataGridViewTextBoxColumn();
      this.grb_Gm = new GroupBox();
      this.cmb_Gm_StatusLed = new ComboBox();
      this.lbl_Gm_StatusLed = new Label();
      this.lbl_Gm_Interval = new Label();
      this.cmb_Gm_Interval = new ComboBox();
      this.lbl_Gm_Ringer = new Label();
      this.cmb_Gm_Ringer = new ComboBox();
      this.grb_Config = new GroupBox();
      this.lbl_Config_BeepLevel = new Label();
      this.cmb_Config_BeepLevel = new ComboBox();
      this.lbl_Config_P2 = new Label();
      this.lbl_Config_P1 = new Label();
      this.cmb_Config_P2 = new ComboBox();
      this.cmb_Config_P1 = new ComboBox();
      this.cmb_Config_HomeRev = new ComboBox();
      this.lbl_Config_HomeRev = new Label();
      this.cmb_Config_DwRvt = new ComboBox();
      this.lbl_Config_DwRvt = new Label();
      this.cmb_Config_Tot = new ComboBox();
      this.lbl_Config_VfoMode = new Label();
      this.cmb_Config_VfoMode = new ComboBox();
      this.lbl_Config_Tot = new Label();
      this.cmb_Config_SaveRx = new ComboBox();
      this.lbl_Config_SaveRx = new Label();
      this.cmb_Config_RptArs = new ComboBox();
      this.lbl_Config_RptArs = new Label();
      this.cmb_Config_PttDelay = new ComboBox();
      this.lbl_Config_PttDelay = new Label();
      this.cmb_Config_MonTcall = new ComboBox();
      this.lbl_Config_MonTcall = new Label();
      this.cmb_Config_Lock = new ComboBox();
      this.lbl_Config_Lock = new Label();
      this.cmb_Config_HomeVfo = new ComboBox();
      this.lbl_Config_HomeVfo = new Label();
      this.txt_Config_PasswordTxt = new TextBox();
      this.cmb_Config_BeepEdge = new ComboBox();
      this.lbl_Config_BeepEdge = new Label();
      this.cmb_Config_PasswordSel = new ComboBox();
      this.lbl_Config_PasswordSel = new Label();
      this.cmb_Config_BusyLed = new ComboBox();
      this.lbl_Config_BusyLedA = new Label();
      this.cmb_Config_BeepSelect = new ComboBox();
      this.lbl_Config_BeepSelect = new Label();
      this.cmb_Config_Bclo = new ComboBox();
      this.lbl_Config_Bclo = new Label();
      this.cmb_Config_Apo = new ComboBox();
      this.lbl_Config_Apo = new Label();
      this.grb_TxRx = new GroupBox();
      this.cmb_TxRx_MicGain = new ComboBox();
      this.lbl_TxRx_MicGain = new Label();
      this.grb_Display = new GroupBox();
      this.label1 = new Label();
      this.lbl_Display_TempUnit = new Label();
      this.cmb_Display_TempUnit = new ComboBox();
      this.lbl_Display_OpeningMessage = new Label();
      this.lbl_Display_LcdDimmer = new Label();
      this.lbl_Display_Lamp = new Label();
      this.txt_Display_OpeningMessageTxt = new TextBox();
      this.cmb_Display_OpeningMessageSel = new ComboBox();
      this.cmb_Display_LcdDimmer = new ComboBox();
      this.cmb_Display_Lamp = new ComboBox();
      this.grb_Memory.SuspendLayout();
      this.grb_Scan.SuspendLayout();
      this.grb_Signaling.SuspendLayout();
      this.grb_DtmfMemory.SuspendLayout();
      ((ISupportInitialize) this.dgv_DtmfSelect).BeginInit();
      this.grp_Scan_ScanWidth.SuspendLayout();
      this.grp_Scan_ScanResume.SuspendLayout();
      this.grb_Digital.SuspendLayout();
      this.grb_MemoryBank.SuspendLayout();
      ((ISupportInitialize) this.dgv_MemoryBank).BeginInit();
      this.grb_Gm.SuspendLayout();
      this.grb_Config.SuspendLayout();
      this.grb_TxRx.SuspendLayout();
      this.grb_Display.SuspendLayout();
      this.SuspendLayout();
      this.grb_Memory.Controls.Add((Control) this.cmb_Memory_WriteMode);
      this.grb_Memory.Controls.Add((Control) this.lbl_Memory_WriteMode);
      componentResourceManager.ApplyResources((object) this.grb_Memory, "grb_Memory");
      this.grb_Memory.Name = "grb_Memory";
      this.grb_Memory.TabStop = false;
      this.cmb_Memory_WriteMode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Memory_WriteMode, "cmb_Memory_WriteMode");
      this.cmb_Memory_WriteMode.FormattingEnabled = true;
      this.cmb_Memory_WriteMode.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Memory_WriteMode.Items"),
        (object) componentResourceManager.GetString("cmb_Memory_WriteMode.Items1")
      });
      this.cmb_Memory_WriteMode.Name = "cmb_Memory_WriteMode";
      componentResourceManager.ApplyResources((object) this.lbl_Memory_WriteMode, "lbl_Memory_WriteMode");
      this.lbl_Memory_WriteMode.Name = "lbl_Memory_WriteMode";
      this.grb_Scan.Controls.Add((Control) this.cmb_Scan_ReStart);
      this.grb_Scan.Controls.Add((Control) this.lbl_Scan_ReStart);
      this.grb_Scan.Controls.Add((Control) this.cmb_Scan_Lamp);
      this.grb_Scan.Controls.Add((Control) this.lbl_Scan_Lamp);
      this.grb_Scan.Controls.Add((Control) this.cmb_Scan_DwTime);
      this.grb_Scan.Controls.Add((Control) this.lbl_Scan_DwTime);
      componentResourceManager.ApplyResources((object) this.grb_Scan, "grb_Scan");
      this.grb_Scan.Name = "grb_Scan";
      this.grb_Scan.TabStop = false;
      this.cmb_Scan_ReStart.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Scan_ReStart, "cmb_Scan_ReStart");
      this.cmb_Scan_ReStart.FormattingEnabled = true;
      this.cmb_Scan_ReStart.Items.AddRange(new object[28]
      {
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items1"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items2"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items3"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items4"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items5"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items6"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items7"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items8"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items9"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items10"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items11"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items12"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items13"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items14"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items15"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items16"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items17"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items18"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items19"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items20"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items21"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items22"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items23"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items24"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items25"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items26"),
        (object) componentResourceManager.GetString("cmb_Scan_ReStart.Items27")
      });
      this.cmb_Scan_ReStart.Name = "cmb_Scan_ReStart";
      componentResourceManager.ApplyResources((object) this.lbl_Scan_ReStart, "lbl_Scan_ReStart");
      this.lbl_Scan_ReStart.Name = "lbl_Scan_ReStart";
      this.cmb_Scan_Lamp.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Scan_Lamp, "cmb_Scan_Lamp");
      this.cmb_Scan_Lamp.FormattingEnabled = true;
      this.cmb_Scan_Lamp.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Scan_Lamp.Items"),
        (object) componentResourceManager.GetString("cmb_Scan_Lamp.Items1")
      });
      this.cmb_Scan_Lamp.Name = "cmb_Scan_Lamp";
      componentResourceManager.ApplyResources((object) this.lbl_Scan_Lamp, "lbl_Scan_Lamp");
      this.lbl_Scan_Lamp.Name = "lbl_Scan_Lamp";
      this.cmb_Scan_DwTime.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Scan_DwTime, "cmb_Scan_DwTime");
      this.cmb_Scan_DwTime.FormattingEnabled = true;
      this.cmb_Scan_DwTime.Items.AddRange(new object[28]
      {
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items1"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items2"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items3"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items4"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items5"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items6"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items7"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items8"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items9"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items10"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items11"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items12"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items13"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items14"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items15"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items16"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items17"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items18"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items19"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items20"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items21"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items22"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items23"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items24"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items25"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items26"),
        (object) componentResourceManager.GetString("cmb_Scan_DwTime.Items27")
      });
      this.cmb_Scan_DwTime.Name = "cmb_Scan_DwTime";
      componentResourceManager.ApplyResources((object) this.lbl_Scan_DwTime, "lbl_Scan_DwTime");
      this.lbl_Scan_DwTime.Name = "lbl_Scan_DwTime";
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_WxAlart);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_Bell);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_ToneSarchSpeed);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_ToneSarchMute);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_SqlExpansion);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_PagerRxCode2);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_PagerTxCode2);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_PagerTxCode1);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_PagerRxCode2);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_PagerTxCode1);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_PagerRxCode1);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_PagerRxCode1);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_PagerAnserBack);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_PagerTxCode2);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_PagerAnserBack);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_Pager);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_DtmfTxSpeed);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_DtmfTxMode);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_DtmfTxMode);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_DtmfTxDelay);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_DtmfTxDelay);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_DtmfTxSpeed);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_Dtmf);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_WxAlart);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_Bell);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_ToneSarchSpeed);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_ToneSarchMute);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_SqlExpansion);
      this.grb_Signaling.Controls.Add((Control) this.cmb_Signaling_SqlLevel);
      this.grb_Signaling.Controls.Add((Control) this.lbl_Signaling_SqlLevel);
      componentResourceManager.ApplyResources((object) this.grb_Signaling, "grb_Signaling");
      this.grb_Signaling.Name = "grb_Signaling";
      this.grb_Signaling.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_WxAlart, "lbl_Signaling_WxAlart");
      this.lbl_Signaling_WxAlart.Name = "lbl_Signaling_WxAlart";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_Bell, "lbl_Signaling_Bell");
      this.lbl_Signaling_Bell.Name = "lbl_Signaling_Bell";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_ToneSarchSpeed, "lbl_Signaling_ToneSarchSpeed");
      this.lbl_Signaling_ToneSarchSpeed.Name = "lbl_Signaling_ToneSarchSpeed";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_ToneSarchMute, "lbl_Signaling_ToneSarchMute");
      this.lbl_Signaling_ToneSarchMute.Name = "lbl_Signaling_ToneSarchMute";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_SqlExpansion, "lbl_Signaling_SqlExpansion");
      this.lbl_Signaling_SqlExpansion.Name = "lbl_Signaling_SqlExpansion";
      this.cmb_Signaling_PagerRxCode2.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_PagerRxCode2, "cmb_Signaling_PagerRxCode2");
      this.cmb_Signaling_PagerRxCode2.FormattingEnabled = true;
      this.cmb_Signaling_PagerRxCode2.Items.AddRange(new object[50]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items5"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items6"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items7"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items8"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items9"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items10"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items11"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items12"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items13"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items14"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items15"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items16"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items17"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items18"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items19"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items20"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items21"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items22"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items23"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items24"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items25"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items26"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items27"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items28"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items29"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items30"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items31"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items32"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items33"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items34"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items35"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items36"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items37"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items38"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items39"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items40"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items41"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items42"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items43"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items44"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items45"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items46"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items47"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items48"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode2.Items49")
      });
      this.cmb_Signaling_PagerRxCode2.Name = "cmb_Signaling_PagerRxCode2";
      this.cmb_Signaling_PagerRxCode2.SelectedIndexChanged += new EventHandler(this.cmb_Signaling_PagerRxTxCode_SelectedIndexChanged);
      this.cmb_Signaling_PagerTxCode2.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_PagerTxCode2, "cmb_Signaling_PagerTxCode2");
      this.cmb_Signaling_PagerTxCode2.FormattingEnabled = true;
      this.cmb_Signaling_PagerTxCode2.Items.AddRange(new object[50]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items5"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items6"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items7"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items8"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items9"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items10"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items11"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items12"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items13"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items14"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items15"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items16"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items17"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items18"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items19"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items20"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items21"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items22"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items23"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items24"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items25"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items26"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items27"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items28"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items29"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items30"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items31"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items32"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items33"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items34"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items35"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items36"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items37"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items38"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items39"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items40"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items41"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items42"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items43"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items44"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items45"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items46"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items47"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items48"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode2.Items49")
      });
      this.cmb_Signaling_PagerTxCode2.Name = "cmb_Signaling_PagerTxCode2";
      this.cmb_Signaling_PagerTxCode2.SelectedIndexChanged += new EventHandler(this.cmb_Signaling_PagerRxTxCode_SelectedIndexChanged);
      this.cmb_Signaling_PagerTxCode1.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_PagerTxCode1, "cmb_Signaling_PagerTxCode1");
      this.cmb_Signaling_PagerTxCode1.FormattingEnabled = true;
      this.cmb_Signaling_PagerTxCode1.Items.AddRange(new object[50]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items5"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items6"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items7"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items8"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items9"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items10"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items11"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items12"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items13"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items14"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items15"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items16"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items17"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items18"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items19"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items20"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items21"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items22"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items23"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items24"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items25"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items26"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items27"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items28"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items29"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items30"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items31"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items32"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items33"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items34"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items35"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items36"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items37"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items38"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items39"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items40"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items41"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items42"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items43"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items44"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items45"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items46"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items47"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items48"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerTxCode1.Items49")
      });
      this.cmb_Signaling_PagerTxCode1.Name = "cmb_Signaling_PagerTxCode1";
      this.cmb_Signaling_PagerTxCode1.SelectedIndexChanged += new EventHandler(this.cmb_Signaling_PagerRxTxCode_SelectedIndexChanged);
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_PagerRxCode2, "lbl_Signaling_PagerRxCode2");
      this.lbl_Signaling_PagerRxCode2.Name = "lbl_Signaling_PagerRxCode2";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_PagerTxCode1, "lbl_Signaling_PagerTxCode1");
      this.lbl_Signaling_PagerTxCode1.Name = "lbl_Signaling_PagerTxCode1";
      this.cmb_Signaling_PagerRxCode1.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_PagerRxCode1, "cmb_Signaling_PagerRxCode1");
      this.cmb_Signaling_PagerRxCode1.FormattingEnabled = true;
      this.cmb_Signaling_PagerRxCode1.Items.AddRange(new object[50]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items5"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items6"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items7"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items8"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items9"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items10"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items11"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items12"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items13"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items14"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items15"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items16"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items17"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items18"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items19"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items20"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items21"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items22"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items23"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items24"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items25"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items26"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items27"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items28"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items29"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items30"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items31"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items32"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items33"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items34"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items35"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items36"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items37"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items38"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items39"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items40"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items41"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items42"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items43"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items44"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items45"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items46"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items47"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items48"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerRxCode1.Items49")
      });
      this.cmb_Signaling_PagerRxCode1.Name = "cmb_Signaling_PagerRxCode1";
      this.cmb_Signaling_PagerRxCode1.SelectedIndexChanged += new EventHandler(this.cmb_Signaling_PagerRxTxCode_SelectedIndexChanged);
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_PagerRxCode1, "lbl_Signaling_PagerRxCode1");
      this.lbl_Signaling_PagerRxCode1.Name = "lbl_Signaling_PagerRxCode1";
      this.cmb_Signaling_PagerAnserBack.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_PagerAnserBack, "cmb_Signaling_PagerAnserBack");
      this.cmb_Signaling_PagerAnserBack.FormattingEnabled = true;
      this.cmb_Signaling_PagerAnserBack.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_PagerAnserBack.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_PagerAnserBack.Items1")
      });
      this.cmb_Signaling_PagerAnserBack.Name = "cmb_Signaling_PagerAnserBack";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_PagerTxCode2, "lbl_Signaling_PagerTxCode2");
      this.lbl_Signaling_PagerTxCode2.Name = "lbl_Signaling_PagerTxCode2";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_PagerAnserBack, "lbl_Signaling_PagerAnserBack");
      this.lbl_Signaling_PagerAnserBack.Name = "lbl_Signaling_PagerAnserBack";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_Pager, "lbl_Signaling_Pager");
      this.lbl_Signaling_Pager.Name = "lbl_Signaling_Pager";
      this.cmb_Signaling_DtmfTxSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_DtmfTxSpeed, "cmb_Signaling_DtmfTxSpeed");
      this.cmb_Signaling_DtmfTxSpeed.FormattingEnabled = true;
      this.cmb_Signaling_DtmfTxSpeed.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_DtmfTxSpeed.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_DtmfTxSpeed.Items1")
      });
      this.cmb_Signaling_DtmfTxSpeed.Name = "cmb_Signaling_DtmfTxSpeed";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_DtmfTxMode, "lbl_Signaling_DtmfTxMode");
      this.lbl_Signaling_DtmfTxMode.Name = "lbl_Signaling_DtmfTxMode";
      this.cmb_Signaling_DtmfTxMode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_DtmfTxMode, "cmb_Signaling_DtmfTxMode");
      this.cmb_Signaling_DtmfTxMode.FormattingEnabled = true;
      this.cmb_Signaling_DtmfTxMode.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_DtmfTxMode.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_DtmfTxMode.Items1")
      });
      this.cmb_Signaling_DtmfTxMode.Name = "cmb_Signaling_DtmfTxMode";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_DtmfTxDelay, "lbl_Signaling_DtmfTxDelay");
      this.lbl_Signaling_DtmfTxDelay.Name = "lbl_Signaling_DtmfTxDelay";
      this.cmb_Signaling_DtmfTxDelay.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_DtmfTxDelay, "cmb_Signaling_DtmfTxDelay");
      this.cmb_Signaling_DtmfTxDelay.FormattingEnabled = true;
      this.cmb_Signaling_DtmfTxDelay.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_DtmfTxDelay.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_DtmfTxDelay.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_DtmfTxDelay.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_DtmfTxDelay.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_DtmfTxDelay.Items4")
      });
      this.cmb_Signaling_DtmfTxDelay.Name = "cmb_Signaling_DtmfTxDelay";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_DtmfTxSpeed, "lbl_Signaling_DtmfTxSpeed");
      this.lbl_Signaling_DtmfTxSpeed.Name = "lbl_Signaling_DtmfTxSpeed";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_Dtmf, "lbl_Signaling_Dtmf");
      this.lbl_Signaling_Dtmf.Name = "lbl_Signaling_Dtmf";
      this.cmb_Signaling_WxAlart.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_WxAlart, "cmb_Signaling_WxAlart");
      this.cmb_Signaling_WxAlart.FormattingEnabled = true;
      this.cmb_Signaling_WxAlart.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_WxAlart.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_WxAlart.Items1")
      });
      this.cmb_Signaling_WxAlart.Name = "cmb_Signaling_WxAlart";
      this.cmb_Signaling_Bell.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_Bell, "cmb_Signaling_Bell");
      this.cmb_Signaling_Bell.FormattingEnabled = true;
      this.cmb_Signaling_Bell.Items.AddRange(new object[21]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items5"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items6"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items7"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items8"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items9"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items10"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items11"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items12"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items13"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items14"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items15"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items16"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items17"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items18"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items19"),
        (object) componentResourceManager.GetString("cmb_Signaling_Bell.Items20")
      });
      this.cmb_Signaling_Bell.Name = "cmb_Signaling_Bell";
      this.cmb_Signaling_ToneSarchSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_ToneSarchSpeed, "cmb_Signaling_ToneSarchSpeed");
      this.cmb_Signaling_ToneSarchSpeed.FormattingEnabled = true;
      this.cmb_Signaling_ToneSarchSpeed.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_ToneSarchSpeed.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_ToneSarchSpeed.Items1")
      });
      this.cmb_Signaling_ToneSarchSpeed.Name = "cmb_Signaling_ToneSarchSpeed";
      this.cmb_Signaling_ToneSarchMute.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_ToneSarchMute, "cmb_Signaling_ToneSarchMute");
      this.cmb_Signaling_ToneSarchMute.FormattingEnabled = true;
      this.cmb_Signaling_ToneSarchMute.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_ToneSarchMute.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_ToneSarchMute.Items1")
      });
      this.cmb_Signaling_ToneSarchMute.Name = "cmb_Signaling_ToneSarchMute";
      this.cmb_Signaling_SqlExpansion.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_SqlExpansion, "cmb_Signaling_SqlExpansion");
      this.cmb_Signaling_SqlExpansion.FormattingEnabled = true;
      this.cmb_Signaling_SqlExpansion.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_SqlExpansion.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlExpansion.Items1")
      });
      this.cmb_Signaling_SqlExpansion.Name = "cmb_Signaling_SqlExpansion";
      this.cmb_Signaling_SqlLevel.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Signaling_SqlLevel, "cmb_Signaling_SqlLevel");
      this.cmb_Signaling_SqlLevel.FormattingEnabled = true;
      this.cmb_Signaling_SqlLevel.Items.AddRange(new object[16]
      {
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items1"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items2"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items3"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items4"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items5"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items6"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items7"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items8"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items9"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items10"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items11"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items12"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items13"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items14"),
        (object) componentResourceManager.GetString("cmb_Signaling_SqlLevel.Items15")
      });
      this.cmb_Signaling_SqlLevel.Name = "cmb_Signaling_SqlLevel";
      componentResourceManager.ApplyResources((object) this.lbl_Signaling_SqlLevel, "lbl_Signaling_SqlLevel");
      this.lbl_Signaling_SqlLevel.Name = "lbl_Signaling_SqlLevel";
      this.grb_DtmfMemory.Controls.Add((Control) this.dgv_DtmfSelect);
      componentResourceManager.ApplyResources((object) this.grb_DtmfMemory, "grb_DtmfMemory");
      this.grb_DtmfMemory.Name = "grb_DtmfMemory";
      this.grb_DtmfMemory.TabStop = false;
      this.dgv_DtmfSelect.AllowUserToAddRows = false;
      this.dgv_DtmfSelect.AllowUserToDeleteRows = false;
      this.dgv_DtmfSelect.AllowUserToResizeColumns = false;
      this.dgv_DtmfSelect.AllowUserToResizeRows = false;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("MS UI Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 128);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dgv_DtmfSelect.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      componentResourceManager.ApplyResources((object) this.dgv_DtmfSelect, "dgv_DtmfSelect");
      this.dgv_DtmfSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_DtmfSelect.Columns.AddRange((DataGridViewColumn) this.CODE);
      this.dgv_DtmfSelect.EnableHeadersVisualStyles = false;
      this.dgv_DtmfSelect.MultiSelect = false;
      this.dgv_DtmfSelect.Name = "dgv_DtmfSelect";
      this.dgv_DtmfSelect.RowTemplate.Height = 21;
      this.dgv_DtmfSelect.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
      this.dgv_DtmfSelect.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      this.CODE.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      componentResourceManager.ApplyResources((object) this.CODE, "CODE");
      this.CODE.MaxInputLength = 16;
      this.CODE.Name = "CODE";
      this.CODE.Resizable = DataGridViewTriState.False;
      this.CODE.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.grp_Scan_ScanWidth.Controls.Add((Control) this.cmb_ScanWidth_Vfo);
      this.grp_Scan_ScanWidth.Controls.Add((Control) this.lbl_ScanWidth_Vfo);
      this.grp_Scan_ScanWidth.Controls.Add((Control) this.cmb_ScanWidth_Memory);
      this.grp_Scan_ScanWidth.Controls.Add((Control) this.lbl_ScanWidth_Memory);
      componentResourceManager.ApplyResources((object) this.grp_Scan_ScanWidth, "grp_Scan_ScanWidth");
      this.grp_Scan_ScanWidth.Name = "grp_Scan_ScanWidth";
      this.grp_Scan_ScanWidth.TabStop = false;
      this.cmb_ScanWidth_Vfo.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_ScanWidth_Vfo, "cmb_ScanWidth_Vfo");
      this.cmb_ScanWidth_Vfo.FormattingEnabled = true;
      this.cmb_ScanWidth_Vfo.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_ScanWidth_Vfo.Items"),
        (object) componentResourceManager.GetString("cmb_ScanWidth_Vfo.Items1")
      });
      this.cmb_ScanWidth_Vfo.Name = "cmb_ScanWidth_Vfo";
      componentResourceManager.ApplyResources((object) this.lbl_ScanWidth_Vfo, "lbl_ScanWidth_Vfo");
      this.lbl_ScanWidth_Vfo.Name = "lbl_ScanWidth_Vfo";
      this.cmb_ScanWidth_Memory.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_ScanWidth_Memory, "cmb_ScanWidth_Memory");
      this.cmb_ScanWidth_Memory.FormattingEnabled = true;
      this.cmb_ScanWidth_Memory.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_ScanWidth_Memory.Items"),
        (object) componentResourceManager.GetString("cmb_ScanWidth_Memory.Items1")
      });
      this.cmb_ScanWidth_Memory.Name = "cmb_ScanWidth_Memory";
      componentResourceManager.ApplyResources((object) this.lbl_ScanWidth_Memory, "lbl_ScanWidth_Memory");
      this.lbl_ScanWidth_Memory.Name = "lbl_ScanWidth_Memory";
      this.grp_Scan_ScanResume.Controls.Add((Control) this.cmb_ScanResume_Scan);
      this.grp_Scan_ScanResume.Controls.Add((Control) this.lbl_ScanResume_Scan);
      this.grp_Scan_ScanResume.Controls.Add((Control) this.cmb_ScanResume_Dw);
      this.grp_Scan_ScanResume.Controls.Add((Control) this.lbl_ScanResume_Dw);
      componentResourceManager.ApplyResources((object) this.grp_Scan_ScanResume, "grp_Scan_ScanResume");
      this.grp_Scan_ScanResume.Name = "grp_Scan_ScanResume";
      this.grp_Scan_ScanResume.TabStop = false;
      this.cmb_ScanResume_Scan.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_ScanResume_Scan, "cmb_ScanResume_Scan");
      this.cmb_ScanResume_Scan.FormattingEnabled = true;
      this.cmb_ScanResume_Scan.Items.AddRange(new object[19]
      {
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items1"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items2"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items3"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items4"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items5"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items6"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items7"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items8"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items9"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items10"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items11"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items12"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items13"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items14"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items15"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items16"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items17"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Scan.Items18")
      });
      this.cmb_ScanResume_Scan.Name = "cmb_ScanResume_Scan";
      componentResourceManager.ApplyResources((object) this.lbl_ScanResume_Scan, "lbl_ScanResume_Scan");
      this.lbl_ScanResume_Scan.Name = "lbl_ScanResume_Scan";
      this.cmb_ScanResume_Dw.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_ScanResume_Dw, "cmb_ScanResume_Dw");
      this.cmb_ScanResume_Dw.FormattingEnabled = true;
      this.cmb_ScanResume_Dw.Items.AddRange(new object[19]
      {
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items1"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items2"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items3"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items4"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items5"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items6"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items7"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items8"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items9"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items10"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items11"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items12"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items13"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items14"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items15"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items16"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items17"),
        (object) componentResourceManager.GetString("cmb_ScanResume_Dw.Items18")
      });
      this.cmb_ScanResume_Dw.Name = "cmb_ScanResume_Dw";
      componentResourceManager.ApplyResources((object) this.lbl_ScanResume_Dw, "lbl_ScanResume_Dw");
      this.lbl_ScanResume_Dw.Name = "lbl_ScanResume_Dw";
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_DgIdMode);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_VwMode);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_SqlType);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_VwMode);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_NormalDgIdCode);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_SplitDgIdRxCode);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_SqlType);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_SplitDgIdTxCode);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_GmMode);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_SplitDgIdTxCode);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_GmMode);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_SplitDgIdRxCode);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_NormalDgIdCode);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_StandbyBeep);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_DgIdMode);
      this.grb_Digital.Controls.Add((Control) this.txt_Digital_MyCallSign);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_StandbyBeep);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_MyCallSign);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_SqlCode);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_SqlCode);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_Popup);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_Popup);
      this.grb_Digital.Controls.Add((Control) this.cmb_Digital_AmsTxMode);
      this.grb_Digital.Controls.Add((Control) this.lbl_Digital_AmsTxMode);
      componentResourceManager.ApplyResources((object) this.grb_Digital, "grb_Digital");
      this.grb_Digital.Name = "grb_Digital";
      this.grb_Digital.TabStop = false;
      this.cmb_Digital_DgIdMode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_DgIdMode, "cmb_Digital_DgIdMode");
      this.cmb_Digital_DgIdMode.FormattingEnabled = true;
      this.cmb_Digital_DgIdMode.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Digital_DgIdMode.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_DgIdMode.Items1")
      });
      this.cmb_Digital_DgIdMode.Name = "cmb_Digital_DgIdMode";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_VwMode, "lbl_Digital_VwMode");
      this.lbl_Digital_VwMode.Name = "lbl_Digital_VwMode";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_SqlType, "lbl_Digital_SqlType");
      this.lbl_Digital_SqlType.Name = "lbl_Digital_SqlType";
      this.cmb_Digital_VwMode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_VwMode, "cmb_Digital_VwMode");
      this.cmb_Digital_VwMode.FormattingEnabled = true;
      this.cmb_Digital_VwMode.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Digital_VwMode.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_VwMode.Items1")
      });
      this.cmb_Digital_VwMode.Name = "cmb_Digital_VwMode";
      this.cmb_Digital_NormalDgIdCode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_NormalDgIdCode, "cmb_Digital_NormalDgIdCode");
      this.cmb_Digital_NormalDgIdCode.FormattingEnabled = true;
      this.cmb_Digital_NormalDgIdCode.Items.AddRange(new object[100]
      {
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items2"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items3"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items4"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items5"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items6"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items7"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items8"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items9"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items10"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items11"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items12"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items13"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items14"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items15"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items16"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items17"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items18"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items19"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items20"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items21"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items22"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items23"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items24"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items25"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items26"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items27"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items28"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items29"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items30"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items31"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items32"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items33"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items34"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items35"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items36"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items37"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items38"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items39"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items40"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items41"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items42"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items43"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items44"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items45"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items46"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items47"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items48"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items49"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items50"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items51"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items52"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items53"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items54"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items55"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items56"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items57"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items58"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items59"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items60"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items61"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items62"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items63"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items64"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items65"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items66"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items67"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items68"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items69"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items70"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items71"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items72"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items73"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items74"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items75"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items76"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items77"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items78"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items79"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items80"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items81"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items82"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items83"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items84"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items85"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items86"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items87"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items88"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items89"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items90"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items91"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items92"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items93"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items94"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items95"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items96"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items97"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items98"),
        (object) componentResourceManager.GetString("cmb_Digital_NormalDgIdCode.Items99")
      });
      this.cmb_Digital_NormalDgIdCode.Name = "cmb_Digital_NormalDgIdCode";
      this.cmb_Digital_SplitDgIdRxCode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_SplitDgIdRxCode, "cmb_Digital_SplitDgIdRxCode");
      this.cmb_Digital_SplitDgIdRxCode.FormattingEnabled = true;
      this.cmb_Digital_SplitDgIdRxCode.Items.AddRange(new object[100]
      {
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items2"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items3"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items4"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items5"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items6"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items7"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items8"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items9"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items10"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items11"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items12"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items13"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items14"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items15"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items16"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items17"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items18"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items19"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items20"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items21"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items22"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items23"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items24"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items25"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items26"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items27"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items28"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items29"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items30"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items31"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items32"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items33"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items34"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items35"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items36"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items37"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items38"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items39"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items40"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items41"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items42"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items43"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items44"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items45"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items46"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items47"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items48"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items49"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items50"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items51"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items52"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items53"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items54"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items55"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items56"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items57"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items58"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items59"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items60"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items61"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items62"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items63"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items64"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items65"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items66"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items67"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items68"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items69"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items70"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items71"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items72"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items73"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items74"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items75"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items76"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items77"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items78"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items79"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items80"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items81"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items82"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items83"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items84"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items85"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items86"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items87"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items88"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items89"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items90"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items91"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items92"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items93"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items94"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items95"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items96"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items97"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items98"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdRxCode.Items99")
      });
      this.cmb_Digital_SplitDgIdRxCode.Name = "cmb_Digital_SplitDgIdRxCode";
      this.cmb_Digital_SqlType.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_SqlType, "cmb_Digital_SqlType");
      this.cmb_Digital_SqlType.FormattingEnabled = true;
      this.cmb_Digital_SqlType.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Digital_SqlType.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlType.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlType.Items2")
      });
      this.cmb_Digital_SqlType.Name = "cmb_Digital_SqlType";
      this.cmb_Digital_SplitDgIdTxCode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_SplitDgIdTxCode, "cmb_Digital_SplitDgIdTxCode");
      this.cmb_Digital_SplitDgIdTxCode.FormattingEnabled = true;
      this.cmb_Digital_SplitDgIdTxCode.Items.AddRange(new object[100]
      {
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items2"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items3"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items4"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items5"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items6"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items7"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items8"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items9"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items10"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items11"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items12"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items13"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items14"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items15"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items16"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items17"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items18"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items19"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items20"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items21"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items22"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items23"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items24"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items25"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items26"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items27"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items28"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items29"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items30"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items31"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items32"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items33"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items34"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items35"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items36"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items37"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items38"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items39"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items40"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items41"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items42"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items43"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items44"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items45"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items46"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items47"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items48"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items49"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items50"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items51"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items52"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items53"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items54"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items55"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items56"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items57"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items58"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items59"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items60"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items61"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items62"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items63"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items64"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items65"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items66"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items67"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items68"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items69"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items70"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items71"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items72"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items73"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items74"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items75"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items76"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items77"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items78"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items79"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items80"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items81"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items82"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items83"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items84"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items85"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items86"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items87"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items88"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items89"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items90"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items91"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items92"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items93"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items94"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items95"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items96"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items97"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items98"),
        (object) componentResourceManager.GetString("cmb_Digital_SplitDgIdTxCode.Items99")
      });
      this.cmb_Digital_SplitDgIdTxCode.Name = "cmb_Digital_SplitDgIdTxCode";
      this.cmb_Digital_GmMode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_GmMode, "cmb_Digital_GmMode");
      this.cmb_Digital_GmMode.FormattingEnabled = true;
      this.cmb_Digital_GmMode.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Digital_GmMode.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_GmMode.Items1")
      });
      this.cmb_Digital_GmMode.Name = "cmb_Digital_GmMode";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_SplitDgIdTxCode, "lbl_Digital_SplitDgIdTxCode");
      this.lbl_Digital_SplitDgIdTxCode.Name = "lbl_Digital_SplitDgIdTxCode";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_GmMode, "lbl_Digital_GmMode");
      this.lbl_Digital_GmMode.Name = "lbl_Digital_GmMode";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_SplitDgIdRxCode, "lbl_Digital_SplitDgIdRxCode");
      this.lbl_Digital_SplitDgIdRxCode.Name = "lbl_Digital_SplitDgIdRxCode";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_NormalDgIdCode, "lbl_Digital_NormalDgIdCode");
      this.lbl_Digital_NormalDgIdCode.Name = "lbl_Digital_NormalDgIdCode";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_StandbyBeep, "lbl_Digital_StandbyBeep");
      this.lbl_Digital_StandbyBeep.Name = "lbl_Digital_StandbyBeep";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_DgIdMode, "lbl_Digital_DgIdMode");
      this.lbl_Digital_DgIdMode.Name = "lbl_Digital_DgIdMode";
      this.txt_Digital_MyCallSign.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_Digital_MyCallSign, "txt_Digital_MyCallSign");
      this.txt_Digital_MyCallSign.Name = "txt_Digital_MyCallSign";
      this.txt_Digital_MyCallSign.TextChanged += new EventHandler(this.txt_TextChanged);
      this.cmb_Digital_StandbyBeep.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_StandbyBeep, "cmb_Digital_StandbyBeep");
      this.cmb_Digital_StandbyBeep.FormattingEnabled = true;
      this.cmb_Digital_StandbyBeep.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Digital_StandbyBeep.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_StandbyBeep.Items1")
      });
      this.cmb_Digital_StandbyBeep.Name = "cmb_Digital_StandbyBeep";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_MyCallSign, "lbl_Digital_MyCallSign");
      this.lbl_Digital_MyCallSign.Name = "lbl_Digital_MyCallSign";
      this.cmb_Digital_SqlCode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_SqlCode, "cmb_Digital_SqlCode");
      this.cmb_Digital_SqlCode.FormattingEnabled = true;
      this.cmb_Digital_SqlCode.Items.AddRange(new object[126]
      {
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items2"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items3"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items4"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items5"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items6"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items7"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items8"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items9"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items10"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items11"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items12"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items13"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items14"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items15"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items16"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items17"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items18"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items19"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items20"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items21"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items22"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items23"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items24"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items25"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items26"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items27"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items28"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items29"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items30"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items31"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items32"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items33"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items34"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items35"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items36"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items37"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items38"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items39"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items40"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items41"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items42"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items43"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items44"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items45"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items46"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items47"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items48"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items49"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items50"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items51"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items52"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items53"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items54"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items55"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items56"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items57"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items58"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items59"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items60"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items61"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items62"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items63"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items64"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items65"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items66"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items67"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items68"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items69"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items70"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items71"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items72"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items73"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items74"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items75"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items76"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items77"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items78"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items79"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items80"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items81"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items82"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items83"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items84"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items85"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items86"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items87"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items88"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items89"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items90"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items91"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items92"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items93"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items94"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items95"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items96"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items97"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items98"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items99"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items100"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items101"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items102"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items103"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items104"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items105"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items106"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items107"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items108"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items109"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items110"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items111"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items112"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items113"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items114"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items115"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items116"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items117"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items118"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items119"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items120"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items121"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items122"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items123"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items124"),
        (object) componentResourceManager.GetString("cmb_Digital_SqlCode.Items125")
      });
      this.cmb_Digital_SqlCode.Name = "cmb_Digital_SqlCode";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_SqlCode, "lbl_Digital_SqlCode");
      this.lbl_Digital_SqlCode.Name = "lbl_Digital_SqlCode";
      this.cmb_Digital_Popup.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_Popup, "cmb_Digital_Popup");
      this.cmb_Digital_Popup.FormattingEnabled = true;
      this.cmb_Digital_Popup.Items.AddRange(new object[10]
      {
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items2"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items3"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items4"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items5"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items6"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items7"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items8"),
        (object) componentResourceManager.GetString("cmb_Digital_Popup.Items9")
      });
      this.cmb_Digital_Popup.Name = "cmb_Digital_Popup";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_Popup, "lbl_Digital_Popup");
      this.lbl_Digital_Popup.Name = "lbl_Digital_Popup";
      this.cmb_Digital_AmsTxMode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Digital_AmsTxMode, "cmb_Digital_AmsTxMode");
      this.cmb_Digital_AmsTxMode.FormattingEnabled = true;
      this.cmb_Digital_AmsTxMode.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Digital_AmsTxMode.Items"),
        (object) componentResourceManager.GetString("cmb_Digital_AmsTxMode.Items1"),
        (object) componentResourceManager.GetString("cmb_Digital_AmsTxMode.Items2")
      });
      this.cmb_Digital_AmsTxMode.Name = "cmb_Digital_AmsTxMode";
      componentResourceManager.ApplyResources((object) this.lbl_Digital_AmsTxMode, "lbl_Digital_AmsTxMode");
      this.lbl_Digital_AmsTxMode.Name = "lbl_Digital_AmsTxMode";
      this.grb_MemoryBank.Controls.Add((Control) this.dgv_MemoryBank);
      componentResourceManager.ApplyResources((object) this.grb_MemoryBank, "grb_MemoryBank");
      this.grb_MemoryBank.Name = "grb_MemoryBank";
      this.grb_MemoryBank.TabStop = false;
      this.dgv_MemoryBank.AllowUserToAddRows = false;
      this.dgv_MemoryBank.AllowUserToDeleteRows = false;
      this.dgv_MemoryBank.AllowUserToResizeColumns = false;
      this.dgv_MemoryBank.AllowUserToResizeRows = false;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = SystemColors.Control;
      gridViewCellStyle2.Font = new Font("MS UI Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 128);
      gridViewCellStyle2.ForeColor = SystemColors.WindowText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.dgv_MemoryBank.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
      componentResourceManager.ApplyResources((object) this.dgv_MemoryBank, "dgv_MemoryBank");
      this.dgv_MemoryBank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_MemoryBank.Columns.AddRange((DataGridViewColumn) this.BankName);
      this.dgv_MemoryBank.EnableHeadersVisualStyles = false;
      this.dgv_MemoryBank.MultiSelect = false;
      this.dgv_MemoryBank.Name = "dgv_MemoryBank";
      this.dgv_MemoryBank.RowTemplate.Height = 21;
      this.dgv_MemoryBank.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
      this.dgv_MemoryBank.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      this.BankName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      componentResourceManager.ApplyResources((object) this.BankName, "BankName");
      this.BankName.MaxInputLength = 6;
      this.BankName.Name = "BankName";
      this.BankName.Resizable = DataGridViewTriState.False;
      this.BankName.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.grb_Gm.Controls.Add((Control) this.cmb_Gm_StatusLed);
      this.grb_Gm.Controls.Add((Control) this.lbl_Gm_StatusLed);
      this.grb_Gm.Controls.Add((Control) this.lbl_Gm_Interval);
      this.grb_Gm.Controls.Add((Control) this.cmb_Gm_Interval);
      this.grb_Gm.Controls.Add((Control) this.lbl_Gm_Ringer);
      this.grb_Gm.Controls.Add((Control) this.cmb_Gm_Ringer);
      componentResourceManager.ApplyResources((object) this.grb_Gm, "grb_Gm");
      this.grb_Gm.Name = "grb_Gm";
      this.grb_Gm.TabStop = false;
      this.cmb_Gm_StatusLed.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Gm_StatusLed, "cmb_Gm_StatusLed");
      this.cmb_Gm_StatusLed.FormattingEnabled = true;
      this.cmb_Gm_StatusLed.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Gm_StatusLed.Items"),
        (object) componentResourceManager.GetString("cmb_Gm_StatusLed.Items1")
      });
      this.cmb_Gm_StatusLed.Name = "cmb_Gm_StatusLed";
      componentResourceManager.ApplyResources((object) this.lbl_Gm_StatusLed, "lbl_Gm_StatusLed");
      this.lbl_Gm_StatusLed.Name = "lbl_Gm_StatusLed";
      componentResourceManager.ApplyResources((object) this.lbl_Gm_Interval, "lbl_Gm_Interval");
      this.lbl_Gm_Interval.Name = "lbl_Gm_Interval";
      this.cmb_Gm_Interval.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Gm_Interval, "cmb_Gm_Interval");
      this.cmb_Gm_Interval.FormattingEnabled = true;
      this.cmb_Gm_Interval.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Gm_Interval.Items"),
        (object) componentResourceManager.GetString("cmb_Gm_Interval.Items1"),
        (object) componentResourceManager.GetString("cmb_Gm_Interval.Items2")
      });
      this.cmb_Gm_Interval.Name = "cmb_Gm_Interval";
      componentResourceManager.ApplyResources((object) this.lbl_Gm_Ringer, "lbl_Gm_Ringer");
      this.lbl_Gm_Ringer.Name = "lbl_Gm_Ringer";
      this.cmb_Gm_Ringer.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Gm_Ringer, "cmb_Gm_Ringer");
      this.cmb_Gm_Ringer.FormattingEnabled = true;
      this.cmb_Gm_Ringer.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Gm_Ringer.Items"),
        (object) componentResourceManager.GetString("cmb_Gm_Ringer.Items1"),
        (object) componentResourceManager.GetString("cmb_Gm_Ringer.Items2")
      });
      this.cmb_Gm_Ringer.Name = "cmb_Gm_Ringer";
      this.grb_Config.Controls.Add((Control) this.lbl_Config_BeepLevel);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_BeepLevel);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_P2);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_P1);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_P2);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_P1);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_HomeRev);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_HomeRev);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_DwRvt);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_DwRvt);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_Tot);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_VfoMode);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_VfoMode);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_Tot);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_SaveRx);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_SaveRx);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_RptArs);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_RptArs);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_PttDelay);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_PttDelay);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_MonTcall);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_MonTcall);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_Lock);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_Lock);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_HomeVfo);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_HomeVfo);
      this.grb_Config.Controls.Add((Control) this.txt_Config_PasswordTxt);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_BeepEdge);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_BeepEdge);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_PasswordSel);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_PasswordSel);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_BusyLed);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_BusyLedA);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_BeepSelect);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_BeepSelect);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_Bclo);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_Bclo);
      this.grb_Config.Controls.Add((Control) this.cmb_Config_Apo);
      this.grb_Config.Controls.Add((Control) this.lbl_Config_Apo);
      componentResourceManager.ApplyResources((object) this.grb_Config, "grb_Config");
      this.grb_Config.Name = "grb_Config";
      this.grb_Config.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lbl_Config_BeepLevel, "lbl_Config_BeepLevel");
      this.lbl_Config_BeepLevel.Name = "lbl_Config_BeepLevel";
      this.cmb_Config_BeepLevel.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_BeepLevel, "cmb_Config_BeepLevel");
      this.cmb_Config_BeepLevel.FormattingEnabled = true;
      this.cmb_Config_BeepLevel.Items.AddRange(new object[7]
      {
        (object) componentResourceManager.GetString("cmb_Config_BeepLevel.Items"),
        (object) componentResourceManager.GetString("cmb_Config_BeepLevel.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_BeepLevel.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_BeepLevel.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_BeepLevel.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_BeepLevel.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_BeepLevel.Items6")
      });
      this.cmb_Config_BeepLevel.Name = "cmb_Config_BeepLevel";
      componentResourceManager.ApplyResources((object) this.lbl_Config_P2, "lbl_Config_P2");
      this.lbl_Config_P2.Name = "lbl_Config_P2";
      componentResourceManager.ApplyResources((object) this.lbl_Config_P1, "lbl_Config_P1");
      this.lbl_Config_P1.Name = "lbl_Config_P1";
      this.cmb_Config_P2.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_P2, "cmb_Config_P2");
      this.cmb_Config_P2.FormattingEnabled = true;
      this.cmb_Config_P2.Items.AddRange(new object[63]
      {
        (object) componentResourceManager.GetString("cmb_Config_P2.Items"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items14"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items15"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items16"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items17"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items18"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items19"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items20"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items21"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items22"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items23"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items24"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items25"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items26"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items27"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items28"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items29"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items30"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items31"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items32"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items33"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items34"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items35"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items36"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items37"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items38"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items39"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items40"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items41"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items42"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items43"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items44"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items45"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items46"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items47"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items48"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items49"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items50"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items51"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items52"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items53"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items54"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items55"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items56"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items57"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items58"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items59"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items60"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items61"),
        (object) componentResourceManager.GetString("cmb_Config_P2.Items62")
      });
      this.cmb_Config_P2.Name = "cmb_Config_P2";
      this.cmb_Config_P1.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_P1, "cmb_Config_P1");
      this.cmb_Config_P1.FormattingEnabled = true;
      this.cmb_Config_P1.Items.AddRange(new object[63]
      {
        (object) componentResourceManager.GetString("cmb_Config_P1.Items"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items14"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items15"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items16"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items17"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items18"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items19"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items20"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items21"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items22"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items23"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items24"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items25"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items26"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items27"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items28"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items29"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items30"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items31"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items32"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items33"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items34"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items35"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items36"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items37"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items38"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items39"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items40"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items41"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items42"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items43"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items44"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items45"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items46"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items47"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items48"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items49"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items50"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items51"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items52"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items53"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items54"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items55"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items56"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items57"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items58"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items59"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items60"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items61"),
        (object) componentResourceManager.GetString("cmb_Config_P1.Items62")
      });
      this.cmb_Config_P1.Name = "cmb_Config_P1";
      this.cmb_Config_HomeRev.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_HomeRev, "cmb_Config_HomeRev");
      this.cmb_Config_HomeRev.FormattingEnabled = true;
      this.cmb_Config_HomeRev.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_HomeRev.Items"),
        (object) componentResourceManager.GetString("cmb_Config_HomeRev.Items1")
      });
      this.cmb_Config_HomeRev.Name = "cmb_Config_HomeRev";
      componentResourceManager.ApplyResources((object) this.lbl_Config_HomeRev, "lbl_Config_HomeRev");
      this.lbl_Config_HomeRev.Name = "lbl_Config_HomeRev";
      this.cmb_Config_DwRvt.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_DwRvt, "cmb_Config_DwRvt");
      this.cmb_Config_DwRvt.FormattingEnabled = true;
      this.cmb_Config_DwRvt.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_DwRvt.Items"),
        (object) componentResourceManager.GetString("cmb_Config_DwRvt.Items1")
      });
      this.cmb_Config_DwRvt.Name = "cmb_Config_DwRvt";
      componentResourceManager.ApplyResources((object) this.lbl_Config_DwRvt, "lbl_Config_DwRvt");
      this.lbl_Config_DwRvt.Name = "lbl_Config_DwRvt";
      this.cmb_Config_Tot.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_Tot, "cmb_Config_Tot");
      this.cmb_Config_Tot.FormattingEnabled = true;
      this.cmb_Config_Tot.Items.AddRange(new object[21]
      {
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items14"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items15"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items16"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items17"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items18"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items19"),
        (object) componentResourceManager.GetString("cmb_Config_Tot.Items20")
      });
      this.cmb_Config_Tot.Name = "cmb_Config_Tot";
      componentResourceManager.ApplyResources((object) this.lbl_Config_VfoMode, "lbl_Config_VfoMode");
      this.lbl_Config_VfoMode.Name = "lbl_Config_VfoMode";
      this.cmb_Config_VfoMode.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_VfoMode, "cmb_Config_VfoMode");
      this.cmb_Config_VfoMode.FormattingEnabled = true;
      this.cmb_Config_VfoMode.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_VfoMode.Items"),
        (object) componentResourceManager.GetString("cmb_Config_VfoMode.Items1")
      });
      this.cmb_Config_VfoMode.Name = "cmb_Config_VfoMode";
      componentResourceManager.ApplyResources((object) this.lbl_Config_Tot, "lbl_Config_Tot");
      this.lbl_Config_Tot.Name = "lbl_Config_Tot";
      this.cmb_Config_SaveRx.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_SaveRx, "cmb_Config_SaveRx");
      this.cmb_Config_SaveRx.FormattingEnabled = true;
      this.cmb_Config_SaveRx.Items.AddRange(new object[38]
      {
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items14"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items15"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items16"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items17"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items18"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items19"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items20"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items21"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items22"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items23"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items24"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items25"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items26"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items27"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items28"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items29"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items30"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items31"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items32"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items33"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items34"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items35"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items36"),
        (object) componentResourceManager.GetString("cmb_Config_SaveRx.Items37")
      });
      this.cmb_Config_SaveRx.Name = "cmb_Config_SaveRx";
      componentResourceManager.ApplyResources((object) this.lbl_Config_SaveRx, "lbl_Config_SaveRx");
      this.lbl_Config_SaveRx.Name = "lbl_Config_SaveRx";
      this.cmb_Config_RptArs.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_RptArs, "cmb_Config_RptArs");
      this.cmb_Config_RptArs.FormattingEnabled = true;
      this.cmb_Config_RptArs.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_RptArs.Items"),
        (object) componentResourceManager.GetString("cmb_Config_RptArs.Items1")
      });
      this.cmb_Config_RptArs.Name = "cmb_Config_RptArs";
      componentResourceManager.ApplyResources((object) this.lbl_Config_RptArs, "lbl_Config_RptArs");
      this.lbl_Config_RptArs.Name = "lbl_Config_RptArs";
      this.cmb_Config_PttDelay.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_PttDelay, "cmb_Config_PttDelay");
      this.cmb_Config_PttDelay.FormattingEnabled = true;
      this.cmb_Config_PttDelay.Items.AddRange(new object[5]
      {
        (object) componentResourceManager.GetString("cmb_Config_PttDelay.Items"),
        (object) componentResourceManager.GetString("cmb_Config_PttDelay.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_PttDelay.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_PttDelay.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_PttDelay.Items4")
      });
      this.cmb_Config_PttDelay.Name = "cmb_Config_PttDelay";
      componentResourceManager.ApplyResources((object) this.lbl_Config_PttDelay, "lbl_Config_PttDelay");
      this.lbl_Config_PttDelay.Name = "lbl_Config_PttDelay";
      this.cmb_Config_MonTcall.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_MonTcall, "cmb_Config_MonTcall");
      this.cmb_Config_MonTcall.FormattingEnabled = true;
      this.cmb_Config_MonTcall.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_MonTcall.Items"),
        (object) componentResourceManager.GetString("cmb_Config_MonTcall.Items1")
      });
      this.cmb_Config_MonTcall.Name = "cmb_Config_MonTcall";
      componentResourceManager.ApplyResources((object) this.lbl_Config_MonTcall, "lbl_Config_MonTcall");
      this.lbl_Config_MonTcall.Name = "lbl_Config_MonTcall";
      this.cmb_Config_Lock.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_Lock, "cmb_Config_Lock");
      this.cmb_Config_Lock.FormattingEnabled = true;
      this.cmb_Config_Lock.Items.AddRange(new object[7]
      {
        (object) componentResourceManager.GetString("cmb_Config_Lock.Items"),
        (object) componentResourceManager.GetString("cmb_Config_Lock.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_Lock.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_Lock.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_Lock.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_Lock.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_Lock.Items6")
      });
      this.cmb_Config_Lock.Name = "cmb_Config_Lock";
      componentResourceManager.ApplyResources((object) this.lbl_Config_Lock, "lbl_Config_Lock");
      this.lbl_Config_Lock.Name = "lbl_Config_Lock";
      this.cmb_Config_HomeVfo.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_HomeVfo, "cmb_Config_HomeVfo");
      this.cmb_Config_HomeVfo.FormattingEnabled = true;
      this.cmb_Config_HomeVfo.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_HomeVfo.Items"),
        (object) componentResourceManager.GetString("cmb_Config_HomeVfo.Items1")
      });
      this.cmb_Config_HomeVfo.Name = "cmb_Config_HomeVfo";
      componentResourceManager.ApplyResources((object) this.lbl_Config_HomeVfo, "lbl_Config_HomeVfo");
      this.lbl_Config_HomeVfo.Name = "lbl_Config_HomeVfo";
      this.txt_Config_PasswordTxt.CharacterCasing = CharacterCasing.Upper;
      componentResourceManager.ApplyResources((object) this.txt_Config_PasswordTxt, "txt_Config_PasswordTxt");
      this.txt_Config_PasswordTxt.Name = "txt_Config_PasswordTxt";
      this.txt_Config_PasswordTxt.TextChanged += new EventHandler(this.txt_TextChanged);
      this.cmb_Config_BeepEdge.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_BeepEdge, "cmb_Config_BeepEdge");
      this.cmb_Config_BeepEdge.FormattingEnabled = true;
      this.cmb_Config_BeepEdge.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_BeepEdge.Items"),
        (object) componentResourceManager.GetString("cmb_Config_BeepEdge.Items1")
      });
      this.cmb_Config_BeepEdge.Name = "cmb_Config_BeepEdge";
      componentResourceManager.ApplyResources((object) this.lbl_Config_BeepEdge, "lbl_Config_BeepEdge");
      this.lbl_Config_BeepEdge.Name = "lbl_Config_BeepEdge";
      this.cmb_Config_PasswordSel.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_PasswordSel, "cmb_Config_PasswordSel");
      this.cmb_Config_PasswordSel.FormattingEnabled = true;
      this.cmb_Config_PasswordSel.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_PasswordSel.Items"),
        (object) componentResourceManager.GetString("cmb_Config_PasswordSel.Items1")
      });
      this.cmb_Config_PasswordSel.Name = "cmb_Config_PasswordSel";
      componentResourceManager.ApplyResources((object) this.lbl_Config_PasswordSel, "lbl_Config_PasswordSel");
      this.lbl_Config_PasswordSel.Name = "lbl_Config_PasswordSel";
      this.cmb_Config_BusyLed.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_BusyLed, "cmb_Config_BusyLed");
      this.cmb_Config_BusyLed.FormattingEnabled = true;
      this.cmb_Config_BusyLed.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_BusyLed.Items"),
        (object) componentResourceManager.GetString("cmb_Config_BusyLed.Items1")
      });
      this.cmb_Config_BusyLed.Name = "cmb_Config_BusyLed";
      componentResourceManager.ApplyResources((object) this.lbl_Config_BusyLedA, "lbl_Config_BusyLedA");
      this.lbl_Config_BusyLedA.Name = "lbl_Config_BusyLedA";
      this.cmb_Config_BeepSelect.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_BeepSelect, "cmb_Config_BeepSelect");
      this.cmb_Config_BeepSelect.FormattingEnabled = true;
      this.cmb_Config_BeepSelect.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Config_BeepSelect.Items"),
        (object) componentResourceManager.GetString("cmb_Config_BeepSelect.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_BeepSelect.Items2")
      });
      this.cmb_Config_BeepSelect.Name = "cmb_Config_BeepSelect";
      componentResourceManager.ApplyResources((object) this.lbl_Config_BeepSelect, "lbl_Config_BeepSelect");
      this.lbl_Config_BeepSelect.Name = "lbl_Config_BeepSelect";
      this.cmb_Config_Bclo.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_Bclo, "cmb_Config_Bclo");
      this.cmb_Config_Bclo.FormattingEnabled = true;
      this.cmb_Config_Bclo.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Config_Bclo.Items"),
        (object) componentResourceManager.GetString("cmb_Config_Bclo.Items1")
      });
      this.cmb_Config_Bclo.Name = "cmb_Config_Bclo";
      componentResourceManager.ApplyResources((object) this.lbl_Config_Bclo, "lbl_Config_Bclo");
      this.lbl_Config_Bclo.Name = "lbl_Config_Bclo";
      this.cmb_Config_Apo.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Config_Apo, "cmb_Config_Apo");
      this.cmb_Config_Apo.FormattingEnabled = true;
      this.cmb_Config_Apo.Items.AddRange(new object[25]
      {
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items1"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items2"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items3"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items4"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items5"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items6"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items7"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items8"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items9"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items10"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items11"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items12"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items13"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items14"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items15"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items16"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items17"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items18"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items19"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items20"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items21"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items22"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items23"),
        (object) componentResourceManager.GetString("cmb_Config_Apo.Items24")
      });
      this.cmb_Config_Apo.Name = "cmb_Config_Apo";
      componentResourceManager.ApplyResources((object) this.lbl_Config_Apo, "lbl_Config_Apo");
      this.lbl_Config_Apo.Name = "lbl_Config_Apo";
      this.grb_TxRx.Controls.Add((Control) this.cmb_TxRx_MicGain);
      this.grb_TxRx.Controls.Add((Control) this.lbl_TxRx_MicGain);
      componentResourceManager.ApplyResources((object) this.grb_TxRx, "grb_TxRx");
      this.grb_TxRx.Name = "grb_TxRx";
      this.grb_TxRx.TabStop = false;
      this.cmb_TxRx_MicGain.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_TxRx_MicGain, "cmb_TxRx_MicGain");
      this.cmb_TxRx_MicGain.FormattingEnabled = true;
      this.cmb_TxRx_MicGain.Items.AddRange(new object[9]
      {
        (object) componentResourceManager.GetString("cmb_TxRx_MicGain.Items"),
        (object) componentResourceManager.GetString("cmb_TxRx_MicGain.Items1"),
        (object) componentResourceManager.GetString("cmb_TxRx_MicGain.Items2"),
        (object) componentResourceManager.GetString("cmb_TxRx_MicGain.Items3"),
        (object) componentResourceManager.GetString("cmb_TxRx_MicGain.Items4"),
        (object) componentResourceManager.GetString("cmb_TxRx_MicGain.Items5"),
        (object) componentResourceManager.GetString("cmb_TxRx_MicGain.Items6"),
        (object) componentResourceManager.GetString("cmb_TxRx_MicGain.Items7"),
        (object) componentResourceManager.GetString("cmb_TxRx_MicGain.Items8")
      });
      this.cmb_TxRx_MicGain.Name = "cmb_TxRx_MicGain";
      componentResourceManager.ApplyResources((object) this.lbl_TxRx_MicGain, "lbl_TxRx_MicGain");
      this.lbl_TxRx_MicGain.Name = "lbl_TxRx_MicGain";
      this.grb_Display.Controls.Add((Control) this.label1);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_TempUnit);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_TempUnit);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_OpeningMessage);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_LcdDimmer);
      this.grb_Display.Controls.Add((Control) this.lbl_Display_Lamp);
      this.grb_Display.Controls.Add((Control) this.txt_Display_OpeningMessageTxt);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_OpeningMessageSel);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_LcdDimmer);
      this.grb_Display.Controls.Add((Control) this.cmb_Display_Lamp);
      componentResourceManager.ApplyResources((object) this.grb_Display, "grb_Display");
      this.grb_Display.Name = "grb_Display";
      this.grb_Display.TabStop = false;
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.lbl_Display_TempUnit, "lbl_Display_TempUnit");
      this.lbl_Display_TempUnit.Name = "lbl_Display_TempUnit";
      this.cmb_Display_TempUnit.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_TempUnit, "cmb_Display_TempUnit");
      this.cmb_Display_TempUnit.FormattingEnabled = true;
      this.cmb_Display_TempUnit.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmb_Display_TempUnit.Items"),
        (object) componentResourceManager.GetString("cmb_Display_TempUnit.Items1")
      });
      this.cmb_Display_TempUnit.Name = "cmb_Display_TempUnit";
      componentResourceManager.ApplyResources((object) this.lbl_Display_OpeningMessage, "lbl_Display_OpeningMessage");
      this.lbl_Display_OpeningMessage.Name = "lbl_Display_OpeningMessage";
      componentResourceManager.ApplyResources((object) this.lbl_Display_LcdDimmer, "lbl_Display_LcdDimmer");
      this.lbl_Display_LcdDimmer.Name = "lbl_Display_LcdDimmer";
      componentResourceManager.ApplyResources((object) this.lbl_Display_Lamp, "lbl_Display_Lamp");
      this.lbl_Display_Lamp.Name = "lbl_Display_Lamp";
      componentResourceManager.ApplyResources((object) this.txt_Display_OpeningMessageTxt, "txt_Display_OpeningMessageTxt");
      this.txt_Display_OpeningMessageTxt.Name = "txt_Display_OpeningMessageTxt";
      this.txt_Display_OpeningMessageTxt.TextChanged += new EventHandler(this.txt_TextChanged);
      this.cmb_Display_OpeningMessageSel.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_OpeningMessageSel, "cmb_Display_OpeningMessageSel");
      this.cmb_Display_OpeningMessageSel.FormattingEnabled = true;
      this.cmb_Display_OpeningMessageSel.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmb_Display_OpeningMessageSel.Items"),
        (object) componentResourceManager.GetString("cmb_Display_OpeningMessageSel.Items1"),
        (object) componentResourceManager.GetString("cmb_Display_OpeningMessageSel.Items2")
      });
      this.cmb_Display_OpeningMessageSel.Name = "cmb_Display_OpeningMessageSel";
      this.cmb_Display_LcdDimmer.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_LcdDimmer, "cmb_Display_LcdDimmer");
      this.cmb_Display_LcdDimmer.FormattingEnabled = true;
      this.cmb_Display_LcdDimmer.Items.AddRange(new object[6]
      {
        (object) componentResourceManager.GetString("cmb_Display_LcdDimmer.Items"),
        (object) componentResourceManager.GetString("cmb_Display_LcdDimmer.Items1"),
        (object) componentResourceManager.GetString("cmb_Display_LcdDimmer.Items2"),
        (object) componentResourceManager.GetString("cmb_Display_LcdDimmer.Items3"),
        (object) componentResourceManager.GetString("cmb_Display_LcdDimmer.Items4"),
        (object) componentResourceManager.GetString("cmb_Display_LcdDimmer.Items5")
      });
      this.cmb_Display_LcdDimmer.Name = "cmb_Display_LcdDimmer";
      this.cmb_Display_Lamp.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmb_Display_Lamp, "cmb_Display_Lamp");
      this.cmb_Display_Lamp.FormattingEnabled = true;
      this.cmb_Display_Lamp.Items.AddRange(new object[11]
      {
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items"),
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items1"),
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items2"),
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items3"),
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items4"),
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items5"),
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items6"),
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items7"),
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items8"),
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items9"),
        (object) componentResourceManager.GetString("cmb_Display_Lamp.Items10")
      });
      this.cmb_Display_Lamp.Name = "cmb_Display_Lamp";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.grb_Memory);
      this.Controls.Add((Control) this.grb_Scan);
      this.Controls.Add((Control) this.grb_Signaling);
      this.Controls.Add((Control) this.grb_DtmfMemory);
      this.Controls.Add((Control) this.grp_Scan_ScanWidth);
      this.Controls.Add((Control) this.grp_Scan_ScanResume);
      this.Controls.Add((Control) this.grb_Digital);
      this.Controls.Add((Control) this.grb_MemoryBank);
      this.Controls.Add((Control) this.grb_Gm);
      this.Controls.Add((Control) this.grb_Config);
      this.Controls.Add((Control) this.grb_TxRx);
      this.Controls.Add((Control) this.grb_Display);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (SetForm);
      this.ShowIcon = false;
      this.FormClosed += new FormClosedEventHandler(this.SetForm_FormClosed);
      this.Load += new EventHandler(this.SetForm_Load);
      this.grb_Memory.ResumeLayout(false);
      this.grb_Memory.PerformLayout();
      this.grb_Scan.ResumeLayout(false);
      this.grb_Scan.PerformLayout();
      this.grb_Signaling.ResumeLayout(false);
      this.grb_Signaling.PerformLayout();
      this.grb_DtmfMemory.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_DtmfSelect).EndInit();
      this.grp_Scan_ScanWidth.ResumeLayout(false);
      this.grp_Scan_ScanWidth.PerformLayout();
      this.grp_Scan_ScanResume.ResumeLayout(false);
      this.grp_Scan_ScanResume.PerformLayout();
      this.grb_Digital.ResumeLayout(false);
      this.grb_Digital.PerformLayout();
      this.grb_MemoryBank.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_MemoryBank).EndInit();
      this.grb_Gm.ResumeLayout(false);
      this.grb_Gm.PerformLayout();
      this.grb_Config.ResumeLayout(false);
      this.grb_Config.PerformLayout();
      this.grb_TxRx.ResumeLayout(false);
      this.grb_TxRx.PerformLayout();
      this.grb_Display.ResumeLayout(false);
      this.grb_Display.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
