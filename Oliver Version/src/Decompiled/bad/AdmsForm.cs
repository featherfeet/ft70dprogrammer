// Decompiled with JetBrains decompiler
// Type: ADMS10.AdmsForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace ADMS10
{
  public class AdmsForm : Form
  {
    private ResourceManager resources = new ResourceManager("ADMS10.Strings", typeof (DataForm).Assembly);
    public string ComName = "COM1";
    private object[] copy = new object[52];
    public string FinedStr = "";
    private string filePath = Application.StartupPath + "\\";
    private FObject fobj;
    private bool isPaste;
    public int FinedCol;
    private IContainer components;
    private ToolStripButton toolStrip_FileNew;
    private ToolStrip toolStrip1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem menu_File;
    private ToolStripMenuItem menu_FileOpen;
    private ToolStripMenuItem menu_FileClose;
    private ToolStripMenuItem menu_Window;
    private ToolStripMenuItem menu_WindowUD;
    private ToolStripMenuItem menu_WindowRL;
    private ToolStripMenuItem menu_WindowNormal;
    private ToolStripMenuItem menu_FileNew;
    private ToolStripMenuItem menu_FileSave;
    private ToolStripMenuItem menu_FileNameSave;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem menu_FileInport;
    private ToolStripMenuItem menu_FileExport;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripMenuItem menu_FilePrint;
    private ToolStripSeparator toolStripSeparator11;
    private ToolStripMenuItem menu_FileEnd;
    private ToolStripMenuItem menu_Edit;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem menu_EditCut;
    private ToolStripMenuItem menu_EditCopy;
    private ToolStripMenuItem menu_EditPaste;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripMenuItem menu_EditFined;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripMenuItem menu_EditChMove;
    private ToolStripMenuItem menu_EditChInsert;
    private ToolStripMenuItem menu_EditChDelete;
    private ToolStripMenuItem menu_EditChClear;
    private ToolStripMenuItem menu_EditChUp;
    private ToolStripMenuItem menu_EditChDown;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripMenuItem menu_EditAddFreq;
    private ToolStripMenuItem menu_EditSort;
    private ToolStripMenuItem menu_Com;
    private ToolStripMenuItem menu_ComRead;
    private ToolStripMenuItem menu_ComWrite;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem menu_ComPortSet;
    private ToolStripMenuItem menu_Set;
    private ToolStripMenuItem menu_SetMode;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem menu_SetToolbar;
    private ToolStripMenuItem menu_SetStatusbar;
    private ToolStripSeparator toolStripSeparator9;
    private ToolStripMenuItem menu_Help;
    private ToolStripMenuItem menu_HelpVersion;
    public SerialPort serialPort1;
    private ToolStripButton toolStrip_FileOpen;
    private ToolStripButton toolStrip_FileSave;
    private ToolStripButton toolStrip_EditCopy;
    private ToolStripButton toolStrip_EditCut;
    private ToolStripButton toolStrip_EditPaste;
    private ToolStripButton toolStrip_FilePrint;
    private ToolStripButton toolStrip_EditChUp;
    private ToolStripButton toolStrip_EditChDown;
    private ToolStripButton toolStrip_EditFined;
    private ToolStripButton toolStrip_EditSort;
    private ToolStripButton toolStrip_ComWrite;
    private ToolStripButton toolStrip_ComRead;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel StatusLabel;
    public ToolStripMenuItem menu_EditUndo;
    public ToolStripMenuItem menu_EditFinedNext;
    private ToolStripSeparator toolStripSeparator12;
    private ToolStripSeparator toolStripSeparator13;
    private ToolStripSeparator toolStripSeparator14;
    private ToolStripSeparator toolStripSeparator15;
    private ToolStripSeparator toolStripSeparator16;
    private ToolStripSeparator toolStripSeparator17;
    private ToolStripMenuItem untitle1ToolStripMenuItem;

    public AdmsForm()
    {
      this.fobj = new FObject();
      if (Settings.Instance.Language != 0)
      {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        this.Controls.Clear();
        for (int index = 0; index < DataForm.tbl_Default_Jpn.GetLength(0); ++index)
        {
          DataForm.tbl_Default_Jpn[index, 13] = (object) "RX Normal TX Normal";
          DataForm.tbl_Default_Eng[index, 13] = (object) "RX Normal TX Normal";
        }
      }
      else
      {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("ja-JP");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");
        this.Controls.Clear();
        for (int index = 0; index < DataForm.tbl_Default_Jpn.GetLength(0); ++index)
        {
          DataForm.tbl_Default_Jpn[index, 13] = (object) "RX同相 TX同相";
          DataForm.tbl_Default_Eng[index, 13] = (object) "RX同相 TX同相";
        }
      }
      this.InitializeComponent();
      this.serialPort1.PortName = Array.IndexOf<string>(SerialPort.GetPortNames(), Settings.Instance.ComPortName) != -1 ? Settings.Instance.ComPortName : "COM1";
      foreach (Control control in (ArrangedElementCollection) this.Controls)
      {
        if (control is MdiClient)
        {
          MdiClient mdiClient = (MdiClient) control;
          mdiClient.ControlAdded += new ControlEventHandler(this.MDIClient_ControlAdded);
          mdiClient.ControlRemoved += new ControlEventHandler(this.MDIClient_ControlRemoved);
        }
      }
    }

    private void MDIClient_ControlAdded(object sender, ControlEventArgs e)
    {
    }

    private void MDIClient_ControlRemoved(object sender, ControlEventArgs e)
    {
      if ((DataForm) this.ActiveMdiChild != null)
        return;
      this.visibleMenuToolStrip(false);
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
      this.CreateDataForm("FT-70D Untitled" + (this.MdiChildren.Length + 1).ToString());
      this.StatusLabel.Text = "Ready";
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.SaveToXmlFile();
    }

    private void menu_FileNew_Click(object sender, EventArgs e)
    {
      this.StatusLabel.Text = "Loading...";
      this.CreateDataForm("FT-70D Untitled" + (this.MdiChildren.Length + 1).ToString());
      this.StatusLabel.Text = "Ready";
    }

    private void CreateDataForm(string text)
    {
      Database database = new Database();
      DefaultFile defaultFile = new DefaultFile();
      defaultFile.LoadFromDefaultFile();
      database.Buffer = defaultFile.DefaultBuffer;
      database.Decode();
      DataForm dataForm = new DataForm(this, database);
      dataForm.MdiParent = (Form) this;
      dataForm.Text = text;
      dataForm.FileName = dataForm.Text + ".ft70d";
      dataForm.Show();
      this.menuToolStripSetting(0, dataForm.IsSend);
    }

    private void menu_FileOpen_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      activeMdiChild?.EditEnd();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "FT-70D File(*.ft70d)|*.ft70d";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        bool flag = activeMdiChild == null;
        string fileName = Path.GetFileName(openFileDialog.FileName);
        if (flag)
        {
          this.CreateDataForm(Path.GetFileNameWithoutExtension(fileName));
          activeMdiChild = (DataForm) this.ActiveMdiChild;
        }
        activeMdiChild.Text = Path.GetFileNameWithoutExtension(fileName);
        FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
        if (fileStream != null)
        {
          try
          {
            this.fobj = (FObject) new BinaryFormatter().Deserialize((Stream) fileStream);
            activeMdiChild.FilePath = Path.GetDirectoryName(openFileDialog.FileName.ToString()) + "\\";
            activeMdiChild.FileName = Path.GetFileName(openFileDialog.FileName.ToString());
            FObjectConvert.ToDatabase(activeMdiChild.GetDB(), this.fobj);
            activeMdiChild.GetDB().Decode();
            activeMdiChild.Reset();
            activeMdiChild.FormSet();
            activeMdiChild.Activate();
          }
          catch
          {
            activeMdiChild.IsSave = true;
            activeMdiChild.Close();
            activeMdiChild.Dispose();
            int num = (int) MessageBox.Show(this.resources.GetString("FILEOPENERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        fileStream.Close();
        fileStream.Dispose();
      }
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FileClose_Click(object sender, EventArgs e)
    {
      this.ActiveMdiChild?.Close();
    }

    private void menu_FileSave_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Save";
      activeMdiChild.EditEnd();
      if (activeMdiChild.FilePath == null || activeMdiChild.FilePath == "")
      {
        int num = (int) this.FileSaveAs(activeMdiChild);
      }
      else
        this.FileSave(activeMdiChild);
      this.StatusLabel.Text = "Ready";
    }

    public void FileSave(DataForm dform)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      Database db = dform.GetDB();
      dform.MemSet();
      db.Encode();
      saveFileDialog.InitialDirectory = dform.FilePath;
      saveFileDialog.FileName = dform.FileName;
      saveFileDialog.Filter = "FT-70D File(*.ft70d)|*.ft70d";
      FObjectConvert.ToFObject(db, this.fobj);
      FileStream fileStream = new FileStream(dform.FilePath + dform.FileName, FileMode.Create, FileAccess.Write);
      if (fileStream != null)
      {
        new BinaryFormatter().Serialize((Stream) fileStream, (object) this.fobj);
        dform.IsSave = true;
      }
      fileStream.Close();
      fileStream.Dispose();
    }

    public DialogResult FileSaveAs(DataForm dform)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      Database db = dform.GetDB();
      dform.MemSet();
      db.Encode();
      saveFileDialog.InitialDirectory = dform.FilePath;
      saveFileDialog.FileName = dform.FileName;
      saveFileDialog.Filter = "FT-70D File(*.ft70d)|*.ft70d";
      FObjectConvert.ToFObject(db, this.fobj);
      DialogResult dialogResult = saveFileDialog.ShowDialog();
      if (dialogResult == DialogResult.OK)
      {
        FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
        if (fileStream != null)
        {
          new BinaryFormatter().Serialize((Stream) fileStream, (object) this.fobj);
          dform.FilePath = Path.GetDirectoryName(saveFileDialog.FileName.ToString()) + "\\";
          dform.FileName = Path.GetFileName(saveFileDialog.FileName.ToString());
          dform.Text = Path.GetFileNameWithoutExtension(saveFileDialog.FileName.ToString());
          dform.IsSave = true;
        }
        fileStream.Close();
        fileStream.Dispose();
      }
      return dialogResult;
    }

    private void menu_FileNameSave_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Save";
      activeMdiChild.EditEnd();
      int num = (int) this.FileSaveAs(activeMdiChild);
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FileInport_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Open";
      activeMdiChild.EditEnd();
      activeMdiChild.SelectedDgv();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "CSVファイル(*.csv)|*.csv";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        CSVFile csvFile = new CSVFile();
        csvFile.FileName = openFileDialog.FileName;
        csvFile.Encode = Encoding.GetEncoding("SHIFT-JIS");
        bool flag = csvFile.Read();
        if (flag)
          flag = activeMdiChild.Inport(csvFile.Data);
        if (!flag)
        {
          int num = (int) MessageBox.Show(this.resources.GetString("INPORTERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      activeMdiChild.EditEnd();
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FileExport_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "Save";
      activeMdiChild.EditEnd();
      activeMdiChild.SelectedDgv();
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.FileName = activeMdiChild.Text + ".csv";
      saveFileDialog.Filter = "CSVファイル(*.csv)|*.csv";
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        if (!new CSVFile()
        {
          FileName = saveFileDialog.FileName,
          Encode = Encoding.GetEncoding("SHIFT-JIS"),
          Data = activeMdiChild.Export()
        }.Write())
        {
          int num = (int) MessageBox.Show(this.resources.GetString("EXPORTERROR"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      this.StatusLabel.Text = "Ready";
    }

    private void menu_FilePrint_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      PrintForm printForm = new PrintForm(activeMdiChild);
      int num = (int) printForm.ShowDialog();
      printForm.Dispose();
    }

    private void menu_FileEnd_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void menu_EditUndo_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Undo();
      this.menu_EditUndo.Enabled = false;
    }

    private void menu_EditCut_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      if (activeMdiChild.IsCannel1())
      {
        activeMdiChild.ShowEntryCH0ErrMsg();
      }
      else
      {
        activeMdiChild.EditEnd();
        this.copy = activeMdiChild.Copy();
        activeMdiChild.Clear();
        this.isPaste = true;
        this.menu_EditPaste.Enabled = true;
        this.toolStrip_EditPaste.Enabled = true;
      }
    }

    private void menu_EditCopy_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      this.copy = activeMdiChild.Copy();
      this.isPaste = true;
      this.menu_EditPaste.Enabled = true;
      this.toolStrip_EditPaste.Enabled = true;
    }

    private void menu_EditPaste_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Past(this.copy);
    }

    private void menu_EditFined_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      SearchForm searchForm = new SearchForm(this, activeMdiChild);
      int num = (int) searchForm.ShowDialog();
      searchForm.Dispose();
    }

    private void menu_EditFinedNext_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.FinedNext();
    }

    private void menu_EditChMove_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      MoveForm moveForm = new MoveForm(activeMdiChild);
      int num = (int) moveForm.ShowDialog();
      moveForm.Dispose();
    }

    private void menu_EditChInsert_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Insert();
    }

    private void menu_EditChDelete_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Delete();
    }

    private void menu_EditChClear_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Clear();
    }

    private void menu_EditChUp_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Up();
    }

    private void menu_Edit_ChDown_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.Down();
    }

    private void menu_EditAddFreq_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      FreqForm freqForm = new FreqForm(activeMdiChild);
      int num = (int) freqForm.ShowDialog();
      freqForm.Dispose();
    }

    private void menu_EditSort_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      SortForm sortForm = new SortForm(activeMdiChild);
      int num = (int) sortForm.ShowDialog();
      sortForm.Dispose();
    }

    private void menu_ComRead_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "ADMS";
      activeMdiChild.EditEnd();
      activeMdiChild.MemSet();
      activeMdiChild.GetDB().Encode();
      SerialRecvForm serialRecvForm = new SerialRecvForm(this.serialPort1, this, activeMdiChild, new ComForm(this.serialPort1));
      serialRecvForm.StartPosition = FormStartPosition.CenterParent;
      int num = (int) serialRecvForm.ShowDialog();
      serialRecvForm.Dispose();
      activeMdiChild.GetDB().Decode();
      activeMdiChild.Reset();
      activeMdiChild.FormSet();
      activeMdiChild.EditEnd();
      this.StatusLabel.Text = "Ready";
    }

    private void menu_ComWrite_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      this.StatusLabel.Text = "ADMS";
      activeMdiChild.EditEnd();
      activeMdiChild.MemSet();
      activeMdiChild.GetDB().Encode();
      SerialSendForm serialSendForm = new SerialSendForm(this.serialPort1, this, activeMdiChild);
      serialSendForm.StartPosition = FormStartPosition.CenterParent;
      int num = (int) serialSendForm.ShowDialog();
      serialSendForm.Dispose();
      activeMdiChild.EditEnd();
      this.StatusLabel.Text = "Ready";
    }

    private void menu_ComPortSet_Click(object sender, EventArgs e)
    {
      ComForm comForm = new ComForm(this.serialPort1);
      int num = (int) comForm.ShowDialog();
      comForm.Dispose();
    }

    private void menu_SetMode_Click(object sender, EventArgs e)
    {
      DataForm activeMdiChild = (DataForm) this.ActiveMdiChild;
      if (activeMdiChild == null)
        return;
      activeMdiChild.EditEnd();
      activeMdiChild.MemSet();
      activeMdiChild.GetDB().Encode();
      SetForm setForm = new SetForm(activeMdiChild);
      int num = (int) setForm.ShowDialog();
      setForm.Dispose();
      activeMdiChild.FormSet();
      activeMdiChild.IsSave = false;
    }

    private void menu_Window_DropDownOpening(object sender, EventArgs e)
    {
      Form[] mdiChildren = this.MdiChildren;
      for (int index = 3; index < this.menu_Window.DropDownItems.Count; ++index)
        this.menu_Window.DropDownItems.RemoveAt(index);
      for (int index = 3; index < this.menu_Window.DropDownItems.Count; ++index)
        this.menu_Window.DropDownItems.RemoveAt(index);
      int num = 1;
      foreach (DataForm dataForm in mdiChildren)
      {
        ToolStripMenuItem menu = dataForm.GetMenu();
        menu.Text = "&" + (object) num + " " + dataForm.Text;
        menu.Checked = false;
        this.menu_Window.DropDownItems.Add((ToolStripItem) menu);
        menu.Click += new EventHandler(this.untitle1ToolStripMenuItem_Click);
        ++num;
      }
      this.menu_Window.DropDownItems.Insert(3, (ToolStripItem) new ToolStripSeparator());
      ((DataForm) this.ActiveMdiChild).GetMenu().Checked = true;
    }

    private void untitle1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem) sender;
      foreach (DataForm mdiChild in this.MdiChildren)
      {
        if (mdiChild.GetMenu().Equals((object) toolStripMenuItem))
        {
          toolStripMenuItem.Checked = true;
          mdiChild.Activate();
        }
      }
    }

    private void menu_WindowUD_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void menu_WindowRD_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileVertical);
    }

    private void menu_WindowNormal_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.Cascade);
    }

    private void menu_HelpVersion_Click(object sender, EventArgs e)
    {
      VerForm verForm = new VerForm();
      int num = (int) verForm.ShowDialog();
      verForm.Dispose();
    }

    private void menu_SetToolbar_Click(object sender, EventArgs e)
    {
      if (this.menu_SetToolbar.Checked)
      {
        this.toolStrip1.Visible = false;
        this.menu_SetToolbar.Checked = false;
      }
      else
      {
        this.toolStrip1.Visible = true;
        this.menu_SetToolbar.Checked = true;
      }
    }

    private void menu_SetStatusbar_Click(object sender, EventArgs e)
    {
      if (this.menu_SetStatusbar.Checked)
      {
        this.statusStrip1.Visible = false;
        this.menu_SetStatusbar.Checked = false;
      }
      else
      {
        this.statusStrip1.Visible = true;
        this.menu_SetStatusbar.Checked = true;
      }
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      this.menu_FileNew_Click(sender, e);
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
      this.menu_FileOpen_Click(sender, e);
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      this.menu_FileSave_Click(sender, e);
    }

    private void toolStripButton4_Click(object sender, EventArgs e)
    {
      this.menu_EditCopy_Click(sender, e);
    }

    private void toolStripButton5_Click(object sender, EventArgs e)
    {
      this.menu_EditCut_Click(sender, e);
    }

    private void toolStripButton6_Click(object sender, EventArgs e)
    {
      this.menu_EditPaste_Click(sender, e);
    }

    private void toolStripButton7_Click(object sender, EventArgs e)
    {
      this.menu_FilePrint_Click(sender, e);
    }

    private void toolStripButton8_Click(object sender, EventArgs e)
    {
      this.menu_EditChUp_Click(sender, e);
    }

    private void toolStripButton9_Click(object sender, EventArgs e)
    {
      this.menu_Edit_ChDown_Click(sender, e);
    }

    private void toolStripButton10_Click(object sender, EventArgs e)
    {
      this.menu_EditFined_Click(sender, e);
    }

    private void toolStripButton11_Click(object sender, EventArgs e)
    {
      this.menu_EditSort_Click(sender, e);
    }

    private void toolStripButton12_Click(object sender, EventArgs e)
    {
      this.menu_ComWrite_Click(sender, e);
    }

    private void toolStripButton13_Click(object sender, EventArgs e)
    {
      this.menu_ComRead_Click(sender, e);
    }

    public void MenuToolStripSetting(int idx, bool isSend)
    {
      this.menuToolStripSetting(idx, isSend);
    }

    public void EnableFineNext()
    {
      this.menu_EditFinedNext.Enabled = true;
    }

    public void EnableUndo()
    {
      this.menu_EditUndo.Enabled = true;
    }

    public void EnableComWrite()
    {
      this.menu_ComWrite.Enabled = true;
      this.toolStrip_ComWrite.Enabled = true;
    }

    private void visibleMenuToolStrip(bool enable)
    {
      this.menu_Edit.Visible = enable;
      this.menu_Com.Visible = enable;
      this.menu_Set.Visible = enable;
      this.menu_Window.Visible = enable;
      this.menu_FileClose.Enabled = enable;
      this.menu_FileSave.Enabled = enable;
      this.menu_FileNameSave.Enabled = enable;
      this.menu_FileInport.Enabled = enable;
      this.menu_FileExport.Enabled = enable;
      this.menu_FilePrint.Enabled = enable;
      this.toolStrip_FileSave.Enabled = enable;
      this.toolStrip_FilePrint.Enabled = enable;
      this.toolStrip_EditCopy.Enabled = enable;
      this.toolStrip_EditCut.Enabled = enable;
      this.toolStrip_EditPaste.Enabled = enable;
      this.toolStrip_EditChUp.Enabled = enable;
      this.toolStrip_EditChDown.Enabled = enable;
      this.toolStrip_EditFined.Enabled = enable;
      this.toolStrip_EditSort.Enabled = enable;
      this.toolStrip_ComWrite.Enabled = enable;
      this.toolStrip_ComRead.Enabled = enable;
    }

    private void menuToolStripSetting(int idx, bool isSend)
    {
      bool flag1;
      bool flag2;
      if (idx < 3)
      {
        flag1 = true;
        flag2 = this.isPaste;
      }
      else
      {
        flag1 = false;
        flag2 = false;
      }
      this.menu_File.Visible = true;
      this.menu_Edit.Visible = true;
      this.menu_Com.Visible = true;
      this.menu_Set.Visible = true;
      this.menu_Window.Visible = true;
      this.menu_Help.Visible = true;
      this.menu_FileNew.Enabled = true;
      this.menu_FileOpen.Enabled = true;
      this.menu_FileClose.Enabled = true;
      this.menu_FileSave.Enabled = true;
      this.menu_FileNameSave.Enabled = true;
      this.menu_FileInport.Enabled = true;
      this.menu_FileExport.Enabled = true;
      this.menu_FilePrint.Enabled = true;
      this.menu_FileEnd.Enabled = true;
      this.menu_EditUndo.Enabled = false;
      this.menu_EditCut.Enabled = flag1;
      this.menu_EditCopy.Enabled = flag1;
      this.menu_EditPaste.Enabled = flag2;
      this.menu_EditFined.Enabled = true;
      this.menu_EditFinedNext.Enabled = false;
      this.menu_EditChMove.Enabled = flag1;
      this.menu_EditChInsert.Enabled = flag1;
      this.menu_EditChDelete.Enabled = flag1;
      this.menu_EditChClear.Enabled = flag1;
      this.menu_EditChUp.Enabled = flag1;
      this.menu_EditChDown.Enabled = flag1;
      this.menu_EditAddFreq.Enabled = flag1;
      this.menu_EditSort.Enabled = flag1;
      this.menu_ComRead.Enabled = true;
      this.menu_ComWrite.Enabled = isSend;
      this.menu_SetMode.Enabled = true;
      this.menu_SetToolbar.Enabled = true;
      this.menu_SetStatusbar.Enabled = true;
      this.menu_WindowUD.Enabled = true;
      this.menu_WindowRL.Enabled = true;
      this.menu_WindowNormal.Enabled = true;
      this.menu_HelpVersion.Enabled = true;
      this.toolStrip_FileNew.Enabled = true;
      this.toolStrip_FileOpen.Enabled = true;
      this.toolStrip_FileSave.Enabled = true;
      this.toolStrip_FilePrint.Enabled = true;
      this.toolStrip_EditCopy.Enabled = flag1;
      this.toolStrip_EditCut.Enabled = flag1;
      this.toolStrip_EditPaste.Enabled = flag2;
      this.toolStrip_EditChUp.Enabled = flag1;
      this.toolStrip_EditChDown.Enabled = flag1;
      this.toolStrip_EditFined.Enabled = true;
      this.toolStrip_EditSort.Enabled = flag1;
      this.toolStrip_ComWrite.Enabled = isSend;
      this.toolStrip_ComRead.Enabled = true;
    }

    public void logger(string msg)
    {
      if (!Debugger.Instance.Datalogger)
        return;
      try
      {
        DateTime now = DateTime.Now;
        string path1 = AppDomain.CurrentDomain.BaseDirectory + "Log";
        Directory.CreateDirectory(path1);
        string path2 = path1 + "\\TraceLog" + now.ToString("dd") + ".log";
        File.Delete(path1 + "\\TraceLog" + now.AddDays(1.0).ToString("dd") + ".log");
        string str = now.ToString("yyyy/MM/dd HH:mm:ss") + "\t" + msg;
        StreamWriter streamWriter = (StreamWriter) null;
        try
        {
          streamWriter = new StreamWriter(path2, true, Encoding.GetEncoding("Shift-JIS"));
          streamWriter.WriteLine(str);
        }
        catch
        {
        }
        finally
        {
          streamWriter?.Close();
        }
      }
      catch
      {
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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AdmsForm));
      this.statusStrip1 = new StatusStrip();
      this.StatusLabel = new ToolStripStatusLabel();
      this.menuStrip1 = new MenuStrip();
      this.menu_File = new ToolStripMenuItem();
      this.menu_FileNew = new ToolStripMenuItem();
      this.menu_FileOpen = new ToolStripMenuItem();
      this.menu_FileClose = new ToolStripMenuItem();
      this.menu_FileSave = new ToolStripMenuItem();
      this.menu_FileNameSave = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.menu_FileInport = new ToolStripMenuItem();
      this.menu_FileExport = new ToolStripMenuItem();
      this.toolStripSeparator10 = new ToolStripSeparator();
      this.menu_FilePrint = new ToolStripMenuItem();
      this.toolStripSeparator11 = new ToolStripSeparator();
      this.menu_FileEnd = new ToolStripMenuItem();
      this.menu_Edit = new ToolStripMenuItem();
      this.menu_EditUndo = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.menu_EditCut = new ToolStripMenuItem();
      this.menu_EditCopy = new ToolStripMenuItem();
      this.menu_EditPaste = new ToolStripMenuItem();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.menu_EditFined = new ToolStripMenuItem();
      this.menu_EditFinedNext = new ToolStripMenuItem();
      this.toolStripSeparator7 = new ToolStripSeparator();
      this.menu_EditChMove = new ToolStripMenuItem();
      this.menu_EditChInsert = new ToolStripMenuItem();
      this.menu_EditChDelete = new ToolStripMenuItem();
      this.menu_EditChClear = new ToolStripMenuItem();
      this.menu_EditChUp = new ToolStripMenuItem();
      this.menu_EditChDown = new ToolStripMenuItem();
      this.toolStripSeparator8 = new ToolStripSeparator();
      this.menu_EditAddFreq = new ToolStripMenuItem();
      this.menu_EditSort = new ToolStripMenuItem();
      this.menu_Com = new ToolStripMenuItem();
      this.menu_ComRead = new ToolStripMenuItem();
      this.menu_ComWrite = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.menu_ComPortSet = new ToolStripMenuItem();
      this.menu_Set = new ToolStripMenuItem();
      this.menu_SetMode = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.menu_SetToolbar = new ToolStripMenuItem();
      this.menu_SetStatusbar = new ToolStripMenuItem();
      this.menu_Window = new ToolStripMenuItem();
      this.menu_WindowUD = new ToolStripMenuItem();
      this.menu_WindowRL = new ToolStripMenuItem();
      this.menu_WindowNormal = new ToolStripMenuItem();
      this.toolStripSeparator9 = new ToolStripSeparator();
      this.untitle1ToolStripMenuItem = new ToolStripMenuItem();
      this.menu_Help = new ToolStripMenuItem();
      this.menu_HelpVersion = new ToolStripMenuItem();
      this.toolStrip1 = new ToolStrip();
      this.toolStrip_FileNew = new ToolStripButton();
      this.toolStrip_FileOpen = new ToolStripButton();
      this.toolStrip_FileSave = new ToolStripButton();
      this.toolStripSeparator12 = new ToolStripSeparator();
      this.toolStrip_EditCopy = new ToolStripButton();
      this.toolStrip_EditCut = new ToolStripButton();
      this.toolStrip_EditPaste = new ToolStripButton();
      this.toolStripSeparator13 = new ToolStripSeparator();
      this.toolStrip_FilePrint = new ToolStripButton();
      this.toolStripSeparator14 = new ToolStripSeparator();
      this.toolStrip_EditChUp = new ToolStripButton();
      this.toolStrip_EditChDown = new ToolStripButton();
      this.toolStripSeparator15 = new ToolStripSeparator();
      this.toolStrip_EditFined = new ToolStripButton();
      this.toolStrip_EditSort = new ToolStripButton();
      this.toolStripSeparator16 = new ToolStripSeparator();
      this.toolStrip_ComWrite = new ToolStripButton();
      this.toolStrip_ComRead = new ToolStripButton();
      this.toolStripSeparator17 = new ToolStripSeparator();
      this.serialPort1 = new SerialPort(this.components);
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      this.statusStrip1.GripStyle = ToolStripGripStyle.Visible;
      this.statusStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.StatusLabel
      });
      componentResourceManager.ApplyResources((object) this.statusStrip1, "statusStrip1");
      this.statusStrip1.Name = "statusStrip1";
      this.StatusLabel.Name = "StatusLabel";
      componentResourceManager.ApplyResources((object) this.StatusLabel, "StatusLabel");
      this.menuStrip1.Items.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.menu_File,
        (ToolStripItem) this.menu_Edit,
        (ToolStripItem) this.menu_Com,
        (ToolStripItem) this.menu_Set,
        (ToolStripItem) this.menu_Window,
        (ToolStripItem) this.menu_Help
      });
      componentResourceManager.ApplyResources((object) this.menuStrip1, "menuStrip1");
      this.menuStrip1.Name = "menuStrip1";
      this.menu_File.DropDownItems.AddRange(new ToolStripItem[12]
      {
        (ToolStripItem) this.menu_FileNew,
        (ToolStripItem) this.menu_FileOpen,
        (ToolStripItem) this.menu_FileClose,
        (ToolStripItem) this.menu_FileSave,
        (ToolStripItem) this.menu_FileNameSave,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.menu_FileInport,
        (ToolStripItem) this.menu_FileExport,
        (ToolStripItem) this.toolStripSeparator10,
        (ToolStripItem) this.menu_FilePrint,
        (ToolStripItem) this.toolStripSeparator11,
        (ToolStripItem) this.menu_FileEnd
      });
      this.menu_File.Name = "menu_File";
      componentResourceManager.ApplyResources((object) this.menu_File, "menu_File");
      this.menu_FileNew.Name = "menu_FileNew";
      componentResourceManager.ApplyResources((object) this.menu_FileNew, "menu_FileNew");
      this.menu_FileNew.Click += new EventHandler(this.menu_FileNew_Click);
      this.menu_FileOpen.Name = "menu_FileOpen";
      componentResourceManager.ApplyResources((object) this.menu_FileOpen, "menu_FileOpen");
      this.menu_FileOpen.Click += new EventHandler(this.menu_FileOpen_Click);
      this.menu_FileClose.Name = "menu_FileClose";
      componentResourceManager.ApplyResources((object) this.menu_FileClose, "menu_FileClose");
      this.menu_FileClose.Click += new EventHandler(this.menu_FileClose_Click);
      this.menu_FileSave.Name = "menu_FileSave";
      componentResourceManager.ApplyResources((object) this.menu_FileSave, "menu_FileSave");
      this.menu_FileSave.Click += new EventHandler(this.menu_FileSave_Click);
      this.menu_FileNameSave.Name = "menu_FileNameSave";
      componentResourceManager.ApplyResources((object) this.menu_FileNameSave, "menu_FileNameSave");
      this.menu_FileNameSave.Click += new EventHandler(this.menu_FileNameSave_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator1, "toolStripSeparator1");
      this.menu_FileInport.Name = "menu_FileInport";
      componentResourceManager.ApplyResources((object) this.menu_FileInport, "menu_FileInport");
      this.menu_FileInport.Click += new EventHandler(this.menu_FileInport_Click);
      this.menu_FileExport.Name = "menu_FileExport";
      componentResourceManager.ApplyResources((object) this.menu_FileExport, "menu_FileExport");
      this.menu_FileExport.Click += new EventHandler(this.menu_FileExport_Click);
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator10, "toolStripSeparator10");
      this.menu_FilePrint.Name = "menu_FilePrint";
      componentResourceManager.ApplyResources((object) this.menu_FilePrint, "menu_FilePrint");
      this.menu_FilePrint.Click += new EventHandler(this.menu_FilePrint_Click);
      this.toolStripSeparator11.Name = "toolStripSeparator11";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator11, "toolStripSeparator11");
      this.menu_FileEnd.Name = "menu_FileEnd";
      componentResourceManager.ApplyResources((object) this.menu_FileEnd, "menu_FileEnd");
      this.menu_FileEnd.Click += new EventHandler(this.menu_FileEnd_Click);
      this.menu_Edit.DropDownItems.AddRange(new ToolStripItem[18]
      {
        (ToolStripItem) this.menu_EditUndo,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.menu_EditCut,
        (ToolStripItem) this.menu_EditCopy,
        (ToolStripItem) this.menu_EditPaste,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.menu_EditFined,
        (ToolStripItem) this.menu_EditFinedNext,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.menu_EditChMove,
        (ToolStripItem) this.menu_EditChInsert,
        (ToolStripItem) this.menu_EditChDelete,
        (ToolStripItem) this.menu_EditChClear,
        (ToolStripItem) this.menu_EditChUp,
        (ToolStripItem) this.menu_EditChDown,
        (ToolStripItem) this.toolStripSeparator8,
        (ToolStripItem) this.menu_EditAddFreq,
        (ToolStripItem) this.menu_EditSort
      });
      this.menu_Edit.Name = "menu_Edit";
      componentResourceManager.ApplyResources((object) this.menu_Edit, "menu_Edit");
      componentResourceManager.ApplyResources((object) this.menu_EditUndo, "menu_EditUndo");
      this.menu_EditUndo.Name = "menu_EditUndo";
      this.menu_EditUndo.Click += new EventHandler(this.menu_EditUndo_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator5, "toolStripSeparator5");
      this.menu_EditCut.Name = "menu_EditCut";
      componentResourceManager.ApplyResources((object) this.menu_EditCut, "menu_EditCut");
      this.menu_EditCut.Click += new EventHandler(this.menu_EditCut_Click);
      this.menu_EditCopy.Name = "menu_EditCopy";
      componentResourceManager.ApplyResources((object) this.menu_EditCopy, "menu_EditCopy");
      this.menu_EditCopy.Click += new EventHandler(this.menu_EditCopy_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditPaste, "menu_EditPaste");
      this.menu_EditPaste.Name = "menu_EditPaste";
      this.menu_EditPaste.Click += new EventHandler(this.menu_EditPaste_Click);
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator6, "toolStripSeparator6");
      this.menu_EditFined.Name = "menu_EditFined";
      componentResourceManager.ApplyResources((object) this.menu_EditFined, "menu_EditFined");
      this.menu_EditFined.Click += new EventHandler(this.menu_EditFined_Click);
      componentResourceManager.ApplyResources((object) this.menu_EditFinedNext, "menu_EditFinedNext");
      this.menu_EditFinedNext.Name = "menu_EditFinedNext";
      this.menu_EditFinedNext.Click += new EventHandler(this.menu_EditFinedNext_Click);
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator7, "toolStripSeparator7");
      this.menu_EditChMove.Name = "menu_EditChMove";
      componentResourceManager.ApplyResources((object) this.menu_EditChMove, "menu_EditChMove");
      this.menu_EditChMove.Click += new EventHandler(this.menu_EditChMove_Click);
      this.menu_EditChInsert.Name = "menu_EditChInsert";
      componentResourceManager.ApplyResources((object) this.menu_EditChInsert, "menu_EditChInsert");
      this.menu_EditChInsert.Click += new EventHandler(this.menu_EditChInsert_Click);
      this.menu_EditChDelete.Name = "menu_EditChDelete";
      componentResourceManager.ApplyResources((object) this.menu_EditChDelete, "menu_EditChDelete");
      this.menu_EditChDelete.Click += new EventHandler(this.menu_EditChDelete_Click);
      this.menu_EditChClear.Name = "menu_EditChClear";
      componentResourceManager.ApplyResources((object) this.menu_EditChClear, "menu_EditChClear");
      this.menu_EditChClear.Click += new EventHandler(this.menu_EditChClear_Click);
      this.menu_EditChUp.Name = "menu_EditChUp";
      componentResourceManager.ApplyResources((object) this.menu_EditChUp, "menu_EditChUp");
      this.menu_EditChUp.Click += new EventHandler(this.menu_EditChUp_Click);
      this.menu_EditChDown.Name = "menu_EditChDown";
      componentResourceManager.ApplyResources((object) this.menu_EditChDown, "menu_EditChDown");
      this.menu_EditChDown.Click += new EventHandler(this.menu_Edit_ChDown_Click);
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator8, "toolStripSeparator8");
      this.menu_EditAddFreq.Name = "menu_EditAddFreq";
      componentResourceManager.ApplyResources((object) this.menu_EditAddFreq, "menu_EditAddFreq");
      this.menu_EditAddFreq.Click += new EventHandler(this.menu_EditAddFreq_Click);
      this.menu_EditSort.Name = "menu_EditSort";
      componentResourceManager.ApplyResources((object) this.menu_EditSort, "menu_EditSort");
      this.menu_EditSort.Click += new EventHandler(this.menu_EditSort_Click);
      this.menu_Com.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.menu_ComRead,
        (ToolStripItem) this.menu_ComWrite,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.menu_ComPortSet
      });
      this.menu_Com.Name = "menu_Com";
      componentResourceManager.ApplyResources((object) this.menu_Com, "menu_Com");
      this.menu_ComRead.Name = "menu_ComRead";
      componentResourceManager.ApplyResources((object) this.menu_ComRead, "menu_ComRead");
      this.menu_ComRead.Click += new EventHandler(this.menu_ComRead_Click);
      this.menu_ComWrite.Name = "menu_ComWrite";
      componentResourceManager.ApplyResources((object) this.menu_ComWrite, "menu_ComWrite");
      this.menu_ComWrite.Click += new EventHandler(this.menu_ComWrite_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator3, "toolStripSeparator3");
      this.menu_ComPortSet.Name = "menu_ComPortSet";
      componentResourceManager.ApplyResources((object) this.menu_ComPortSet, "menu_ComPortSet");
      this.menu_ComPortSet.Click += new EventHandler(this.menu_ComPortSet_Click);
      this.menu_Set.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.menu_SetMode,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.menu_SetToolbar,
        (ToolStripItem) this.menu_SetStatusbar
      });
      this.menu_Set.Name = "menu_Set";
      componentResourceManager.ApplyResources((object) this.menu_Set, "menu_Set");
      this.menu_SetMode.Name = "menu_SetMode";
      componentResourceManager.ApplyResources((object) this.menu_SetMode, "menu_SetMode");
      this.menu_SetMode.Click += new EventHandler(this.menu_SetMode_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator2, "toolStripSeparator2");
      this.menu_SetToolbar.Checked = true;
      this.menu_SetToolbar.CheckState = CheckState.Checked;
      this.menu_SetToolbar.Name = "menu_SetToolbar";
      componentResourceManager.ApplyResources((object) this.menu_SetToolbar, "menu_SetToolbar");
      this.menu_SetToolbar.Click += new EventHandler(this.menu_SetToolbar_Click);
      this.menu_SetStatusbar.Checked = true;
      this.menu_SetStatusbar.CheckState = CheckState.Checked;
      this.menu_SetStatusbar.Name = "menu_SetStatusbar";
      componentResourceManager.ApplyResources((object) this.menu_SetStatusbar, "menu_SetStatusbar");
      this.menu_SetStatusbar.Click += new EventHandler(this.menu_SetStatusbar_Click);
      this.menu_Window.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.menu_WindowUD,
        (ToolStripItem) this.menu_WindowRL,
        (ToolStripItem) this.menu_WindowNormal,
        (ToolStripItem) this.toolStripSeparator9,
        (ToolStripItem) this.untitle1ToolStripMenuItem
      });
      this.menu_Window.Name = "menu_Window";
      componentResourceManager.ApplyResources((object) this.menu_Window, "menu_Window");
      this.menu_Window.DropDownOpening += new EventHandler(this.menu_Window_DropDownOpening);
      this.menu_WindowUD.Name = "menu_WindowUD";
      componentResourceManager.ApplyResources((object) this.menu_WindowUD, "menu_WindowUD");
      this.menu_WindowUD.Click += new EventHandler(this.menu_WindowUD_Click);
      this.menu_WindowRL.Name = "menu_WindowRL";
      componentResourceManager.ApplyResources((object) this.menu_WindowRL, "menu_WindowRL");
      this.menu_WindowRL.Click += new EventHandler(this.menu_WindowRD_Click);
      this.menu_WindowNormal.Name = "menu_WindowNormal";
      componentResourceManager.ApplyResources((object) this.menu_WindowNormal, "menu_WindowNormal");
      this.menu_WindowNormal.Click += new EventHandler(this.menu_WindowNormal_Click);
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator9, "toolStripSeparator9");
      this.untitle1ToolStripMenuItem.Name = "untitle1ToolStripMenuItem";
      componentResourceManager.ApplyResources((object) this.untitle1ToolStripMenuItem, "untitle1ToolStripMenuItem");
      this.menu_Help.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.menu_HelpVersion
      });
      this.menu_Help.Name = "menu_Help";
      componentResourceManager.ApplyResources((object) this.menu_Help, "menu_Help");
      this.menu_HelpVersion.Name = "menu_HelpVersion";
      componentResourceManager.ApplyResources((object) this.menu_HelpVersion, "menu_HelpVersion");
      this.menu_HelpVersion.Click += new EventHandler(this.menu_HelpVersion_Click);
      this.toolStrip1.Items.AddRange(new ToolStripItem[19]
      {
        (ToolStripItem) this.toolStrip_FileNew,
        (ToolStripItem) this.toolStrip_FileOpen,
        (ToolStripItem) this.toolStrip_FileSave,
        (ToolStripItem) this.toolStripSeparator12,
        (ToolStripItem) this.toolStrip_EditCopy,
        (ToolStripItem) this.toolStrip_EditCut,
        (ToolStripItem) this.toolStrip_EditPaste,
        (ToolStripItem) this.toolStripSeparator13,
        (ToolStripItem) this.toolStrip_FilePrint,
        (ToolStripItem) this.toolStripSeparator14,
        (ToolStripItem) this.toolStrip_EditChUp,
        (ToolStripItem) this.toolStrip_EditChDown,
        (ToolStripItem) this.toolStripSeparator15,
        (ToolStripItem) this.toolStrip_EditFined,
        (ToolStripItem) this.toolStrip_EditSort,
        (ToolStripItem) this.toolStripSeparator16,
        (ToolStripItem) this.toolStrip_ComWrite,
        (ToolStripItem) this.toolStrip_ComRead,
        (ToolStripItem) this.toolStripSeparator17
      });
      componentResourceManager.ApplyResources((object) this.toolStrip1, "toolStrip1");
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip_FileNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_FileNew, "toolStrip_FileNew");
      this.toolStrip_FileNew.Name = "toolStrip_FileNew";
      this.toolStrip_FileNew.Click += new EventHandler(this.toolStripButton1_Click);
      this.toolStrip_FileOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_FileOpen, "toolStrip_FileOpen");
      this.toolStrip_FileOpen.Name = "toolStrip_FileOpen";
      this.toolStrip_FileOpen.Click += new EventHandler(this.toolStripButton2_Click);
      this.toolStrip_FileSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_FileSave, "toolStrip_FileSave");
      this.toolStrip_FileSave.Name = "toolStrip_FileSave";
      this.toolStrip_FileSave.Click += new EventHandler(this.toolStripButton3_Click);
      this.toolStripSeparator12.Name = "toolStripSeparator12";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator12, "toolStripSeparator12");
      this.toolStrip_EditCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_EditCopy, "toolStrip_EditCopy");
      this.toolStrip_EditCopy.Name = "toolStrip_EditCopy";
      this.toolStrip_EditCopy.Click += new EventHandler(this.toolStripButton4_Click);
      this.toolStrip_EditCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_EditCut, "toolStrip_EditCut");
      this.toolStrip_EditCut.Name = "toolStrip_EditCut";
      this.toolStrip_EditCut.Click += new EventHandler(this.toolStripButton5_Click);
      this.toolStrip_EditPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_EditPaste, "toolStrip_EditPaste");
      this.toolStrip_EditPaste.Name = "toolStrip_EditPaste";
      this.toolStrip_EditPaste.Click += new EventHandler(this.toolStripButton6_Click);
      this.toolStripSeparator13.Name = "toolStripSeparator13";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator13, "toolStripSeparator13");
      this.toolStrip_FilePrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_FilePrint, "toolStrip_FilePrint");
      this.toolStrip_FilePrint.Name = "toolStrip_FilePrint";
      this.toolStrip_FilePrint.Click += new EventHandler(this.toolStripButton7_Click);
      this.toolStripSeparator14.Name = "toolStripSeparator14";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator14, "toolStripSeparator14");
      this.toolStrip_EditChUp.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_EditChUp, "toolStrip_EditChUp");
      this.toolStrip_EditChUp.Name = "toolStrip_EditChUp";
      this.toolStrip_EditChUp.Click += new EventHandler(this.toolStripButton8_Click);
      this.toolStrip_EditChDown.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_EditChDown, "toolStrip_EditChDown");
      this.toolStrip_EditChDown.Name = "toolStrip_EditChDown";
      this.toolStrip_EditChDown.Click += new EventHandler(this.toolStripButton9_Click);
      this.toolStripSeparator15.Name = "toolStripSeparator15";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator15, "toolStripSeparator15");
      this.toolStrip_EditFined.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_EditFined, "toolStrip_EditFined");
      this.toolStrip_EditFined.Name = "toolStrip_EditFined";
      this.toolStrip_EditFined.Click += new EventHandler(this.toolStripButton10_Click);
      this.toolStrip_EditSort.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_EditSort, "toolStrip_EditSort");
      this.toolStrip_EditSort.Name = "toolStrip_EditSort";
      this.toolStrip_EditSort.Click += new EventHandler(this.toolStripButton11_Click);
      this.toolStripSeparator16.Name = "toolStripSeparator16";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator16, "toolStripSeparator16");
      this.toolStrip_ComWrite.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_ComWrite, "toolStrip_ComWrite");
      this.toolStrip_ComWrite.Name = "toolStrip_ComWrite";
      this.toolStrip_ComWrite.Click += new EventHandler(this.toolStripButton12_Click);
      this.toolStrip_ComRead.DisplayStyle = ToolStripItemDisplayStyle.Image;
      componentResourceManager.ApplyResources((object) this.toolStrip_ComRead, "toolStrip_ComRead");
      this.toolStrip_ComRead.Name = "toolStrip_ComRead";
      this.toolStrip_ComRead.Click += new EventHandler(this.toolStripButton13_Click);
      this.toolStripSeparator17.Name = "toolStripSeparator17";
      componentResourceManager.ApplyResources((object) this.toolStripSeparator17, "toolStripSeparator17");
      this.serialPort1.BaudRate = 38400;
      this.serialPort1.ReadBufferSize = 8192;
      this.serialPort1.WriteBufferSize = 100;
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.toolStrip1);
      this.Controls.Add((Control) this.statusStrip1);
      this.Controls.Add((Control) this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = nameof (AdmsForm);
      this.FormClosing += new FormClosingEventHandler(this.MainForm_FormClosing);
      this.Shown += new EventHandler(this.MainForm_Shown);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
