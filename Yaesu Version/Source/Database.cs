// Decompiled with JetBrains decompiler
// Type: ADMS10.Database
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ADMS10
{
  public class Database
  {
    private static byte[] ADMStoFT70D_KeyList = new byte[63]
    {
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 4,
      (byte) 5,
      (byte) 6,
      (byte) 7,
      (byte) 8,
      (byte) 9,
      (byte) 10,
      (byte) 11,
      (byte) 12,
      (byte) 14,
      (byte) 15,
      (byte) 16,
      (byte) 17,
      (byte) 24,
      (byte) 26,
      (byte) 27,
      (byte) 28,
      (byte) 29,
      (byte) 30,
      (byte) 31,
      (byte) 33,
      (byte) 34,
      (byte) 35,
      (byte) 36,
      (byte) 37,
      (byte) 38,
      (byte) 39,
      (byte) 40,
      (byte) 41,
      (byte) 42,
      (byte) 43,
      (byte) 44,
      (byte) 45,
      (byte) 46,
      (byte) 47,
      (byte) 48,
      (byte) 49,
      (byte) 50,
      (byte) 52,
      (byte) 53,
      (byte) 54,
      (byte) 55,
      (byte) 56,
      (byte) 58,
      (byte) 59,
      (byte) 60,
      (byte) 61,
      (byte) 62,
      (byte) 63,
      (byte) 64,
      (byte) 66,
      (byte) 69,
      (byte) 71,
      (byte) 72,
      (byte) 73,
      (byte) 74,
      (byte) 75,
      (byte) 76,
      (byte) 77,
      (byte) 78
    };
    private static byte[] FT70DtoADMS_KeyList = new byte[79]
    {
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 4,
      (byte) 5,
      (byte) 6,
      (byte) 7,
      (byte) 8,
      (byte) 9,
      (byte) 10,
      (byte) 11,
      (byte) 0,
      (byte) 12,
      (byte) 13,
      (byte) 14,
      (byte) 15,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 16,
      (byte) 0,
      (byte) 17,
      (byte) 18,
      (byte) 19,
      (byte) 20,
      (byte) 21,
      (byte) 22,
      (byte) 0,
      (byte) 23,
      (byte) 24,
      (byte) 25,
      (byte) 26,
      (byte) 27,
      (byte) 28,
      (byte) 29,
      (byte) 30,
      (byte) 31,
      (byte) 32,
      (byte) 33,
      (byte) 34,
      (byte) 35,
      (byte) 36,
      (byte) 37,
      (byte) 38,
      (byte) 39,
      (byte) 40,
      (byte) 0,
      (byte) 41,
      (byte) 42,
      (byte) 43,
      (byte) 44,
      (byte) 45,
      (byte) 0,
      (byte) 46,
      (byte) 47,
      (byte) 48,
      (byte) 49,
      (byte) 50,
      (byte) 51,
      (byte) 52,
      (byte) 0,
      (byte) 53,
      (byte) 0,
      (byte) 0,
      (byte) 54,
      (byte) 0,
      (byte) 55,
      (byte) 56,
      (byte) 57,
      (byte) 58,
      (byte) 59,
      (byte) 60,
      (byte) 61,
      (byte) 62
    };
    private byte[] dat = new byte[65216];
    public BindingList<BandMemory> NormalMemory = new BindingList<BandMemory>();
    public BindingList<BandMemory> SkipMemory = new BindingList<BandMemory>();
    public BindingList<BandMemory> PmsMemory = new BindingList<BandMemory>();
    public BindingList<BandMemory> VfoMemory = new BindingList<BandMemory>();
    public BindingList<BandMemory> HomeMemory = new BindingList<BandMemory>();
    public BindingList<BandMemory> WxMemory = new BindingList<BandMemory>();
    public List<ADMS10.DtmfMemory> DtmfMemory = new List<ADMS10.DtmfMemory>();
    public List<ADMS10.MemoryBank> MemoryBank = new List<ADMS10.MemoryBank>();
    private byte[] Dpidinfo_data = new byte[384];
    private List<Database.Converter> converts = new List<Database.Converter>();
    public const int BAND_SINGLE_RSV_BAK_OFFSET = 64;
    public const int SET_MODE_OFFSET = 1088;
    public const int BAND_COMMON_OFFSET = 1472;
    public const int BAND_COMMON_BAK_OFFSET = 1536;
    public const int BAND_SINGLE_OFFSET = 1600;
    public const int BAND_SINGLE_BAK_OFFSET = 1728;
    public const int DTMF_MEM_OFFSET = 2368;
    public const int WX_MEM_AN_OFFSET = 3648;
    public const int BANK_NAME_OFFSET = 3828;
    public const int HOME_CH_OFFSET = 4288;
    public const int VFO_OFFSET = 4672;
    public const int MEM_BANK_CH_NUM_OFFSET = 5440;
    public const int MEM_CH_DIR_OFFSET = 10240;
    public const int MEM_CH_NORM_OFFSET = 11584;
    public const int MEM_CH_SKIP_OFFSET = 40384;
    public const int MEM_CH_PMS_OFFSET = 43584;
    public const int DIGITAL_OFFSET = 52928;
    public const int DP_ID_INFO_OFFSET = 56000;
    public const int BAND_SINGLE_RSV_BAK_SIZE = 512;
    public const int SET_MODE_SIZE = 384;
    public const int BAND_COMMON_SIZE = 64;
    public const int BAND_COMMON_BAK_SIZE = 64;
    public const int BAND_SINGLE_SIZE = 128;
    public const int BAND_SINGLE_BAK_SIZE = 128;
    public const int DTMF_MEM_SIZE = 256;
    public const int WX_MEM_AN_SIZE = 180;
    public const int BANK_NAME_SIZE = 460;
    public const int HOME_CH_SIZE = 384;
    public const int VFO_SIZE = 384;
    public const int MEM_BANK_CH_NUM_SIZE = 4800;
    public const int MEM_CH_DIR_SIZE = 1344;
    public const int MEM_CH_NORM_SIZE = 28800;
    public const int MEM_CH_SKIP_SIZE = 3200;
    public const int MEM_CH_PMS_SIZE = 3200;
    public const int DIGITAL_SIZE = 384;
    public const int DP_ID_INFO_SIZE = 384;
    public const int BUFFSIZE = 65216;
    public const int NORMMEMCHNUM = 900;
    public const int SKIPMEMCHNUM = 99;
    public const int PMSMEMCHNUM = 100;
    public const int VFOCHNUM = 12;
    public const int HOMECHNUM = 12;
    public const int WXNUM = 10;
    public const int DTMFCHNUM = 10;
    public const int MEMORYBANKCHNUM = 24;

    public byte[] Buffer
    {
      get
      {
        return this.dat;
      }
      set
      {
        this.dat = value;
      }
    }

    public int Config_Apo { get; set; }

    public int Config_Bclo { get; set; }

    public int Config_BeepSelect { get; set; }

    public int Config_BeepLevel { get; set; }

    public int Config_BeepEdge { get; set; }

    public int Config_BusyLed { get; set; }

    public int Config_PasswordSel { get; set; }

    public string Config_PasswordTxt { get; set; }

    public int Config_HomeRev { get; set; }

    public int Config_HomeVfo { get; set; }

    public int Config_Lock { get; set; }

    public int Config_MonTcall { get; set; }

    public int Config_PttDelay { get; set; }

    public int Config_RptArs { get; set; }

    public int Config_SaveRx { get; set; }

    public int Config_VfoMode { get; set; }

    public int Config_Tot { get; set; }

    public int Config_DwRvt { get; set; }

    public int Config_P1 { get; set; }

    public int Config_P2 { get; set; }

    public int TxRx_MicGain { get; set; }

    public int Display_Lamp { get; set; }

    public int Display_LcdDimmer { get; set; }

    public int Display_OpeningMessageSel { get; set; }

    public string Display_OpeningMessageTxt { get; set; }

    public int Display_TempUnit { get; set; }

    public int Scan_DwTime { get; set; }

    public int Scan_Lamp { get; set; }

    public int Scan_ReStart { get; set; }

    public int ScanResume_Scan { get; set; }

    public int ScanResume_Dw { get; set; }

    public int ScanWidth_Vfo { get; set; }

    public int ScanWidth_Memory { get; set; }

    public string Digital_MyCallSign { get; set; }

    public int Digital_AmsTxMode { get; set; }

    public int Digital_VwMode { get; set; }

    public int Digital_GmMode { get; set; }

    public int Digital_SqlType { get; set; }

    public int Digital_DgIdMode { get; set; }

    public int Digital_NormalDgIdCode { get; set; }

    public int Digital_SplitDgIdRxCode { get; set; }

    public int Digital_SplitDgIdTxCode { get; set; }

    public int Digital_SqlCode { get; set; }

    public int Digital_Popup { get; set; }

    public int Digital_StandbyBeep { get; set; }

    public int Gm_Ringer { get; set; }

    public int Gm_Interval { get; set; }

    public int Gm_StatusLed { get; set; }

    public int Signaling_DtmfTxMode { get; set; }

    public int Signaling_DtmfTxDelay { get; set; }

    public int Signaling_DtmfTxSpeed { get; set; }

    public int Signaling_PagerAnserBack { get; set; }

    public int Signaling_PagerRxCode1 { get; set; }

    public int Signaling_PagerRxCode2 { get; set; }

    public int Signaling_PagerTxCode1 { get; set; }

    public int Signaling_PagerTxCode2 { get; set; }

    public int Signaling_SqlLevel { get; set; }

    public int Signaling_SqlExpansion { get; set; }

    public int Signaling_ToneSarchMute { get; set; }

    public int Signaling_ToneSarchSpeed { get; set; }

    public int Signaling_Bell { get; set; }

    public int Signaling_WxAlart { get; set; }

    public int Memory_WriteMode { get; set; }

    public Database()
    {
      for (int index = 0; index < 900; ++index)
        this.NormalMemory.Add(new BandMemory());
      for (int index = 0; index < 99; ++index)
        this.SkipMemory.Add(new BandMemory());
      for (int index = 0; index < 100; ++index)
        this.PmsMemory.Add(new BandMemory());
      for (int index = 0; index < 12; ++index)
        this.HomeMemory.Add(new BandMemory());
      for (int index = 0; index < 12; ++index)
        this.VfoMemory.Add(new BandMemory());
      for (int index = 0; index < 10; ++index)
      {
        this.WxMemory.Add(new BandMemory());
        this.WxMemory[index].RxFrq = Convert.ToDecimal(DataForm.tbl_Wx_Freq[index]);
      }
      for (int index = 0; index < 10; ++index)
        this.DtmfMemory.Add(new ADMS10.DtmfMemory());
      for (int index = 0; index < 24; ++index)
        this.MemoryBank.Add(new ADMS10.MemoryBank());
      this.converts.Add((Database.Converter) new Database.SetMode(this, 1088));
      this.converts.Add((Database.Converter) new Database.Dtmf(this, 2368));
      this.converts.Add((Database.Converter) new Database.WxAN(this, 3648));
      this.converts.Add((Database.Converter) new Database.BankName(this, 3828));
      this.converts.Add((Database.Converter) new Database.MemoryChDir(this, 10240));
      this.converts.Add((Database.Converter) new Database.Memory(this, 4288, this.HomeMemory));
      this.converts.Add((Database.Converter) new Database.Memory(this, 4672, this.VfoMemory));
      this.converts.Add((Database.Converter) new Database.MemoryBankNum(this, 5440));
      this.converts.Add((Database.Converter) new Database.Memory(this, 11584, this.NormalMemory));
      this.converts.Add((Database.Converter) new Database.Memory(this, 40384, this.SkipMemory));
      this.converts.Add((Database.Converter) new Database.Memory(this, 43584, this.PmsMemory));
      this.converts.Add((Database.Converter) new Database.Digital(this, 52928));
      this.converts.Add((Database.Converter) new Database.BandCommon(this, 1472));
      this.converts.Add((Database.Converter) new Database.BandCommon(this, 1536));
      this.converts.Add((Database.Converter) new Database.BandSingle(this, 1600));
      this.converts.Add((Database.Converter) new Database.BandSingle(this, 1728));
      this.converts.Add((Database.Converter) new Database.Dpidinfo(this, 56000));
    }

    public void Decode()
    {
      foreach (Database.Converter convert in this.converts)
        convert.Decode();
    }

    public void Encode()
    {
      foreach (Database.Converter convert in this.converts)
        convert.Encode();
    }

    internal Decimal conv_3byteBcdToDecimal(byte[] bcdBytes)
    {
      Decimal[] numArray = new Decimal[6];
      int index1 = 0;
      int index2 = 0;
      for (; index1 < bcdBytes.Length; ++index1)
      {
        numArray[index2] = (Decimal) ((int) bcdBytes[index1] >> 4);
        numArray[index2 + 1] = (Decimal) ((int) bcdBytes[index1] & 15);
        if (numArray[index2] > new Decimal(9) || numArray[index2 + 1] > new Decimal(9))
          throw new FormatException();
        index2 += 2;
      }
      return numArray[0] * new Decimal(100) + numArray[1] * new Decimal(10) + numArray[2] * new Decimal(1) + numArray[3] / new Decimal(10) + numArray[4] / new Decimal(100) + numArray[5] / new Decimal(1000);
    }

    internal byte[] conv_DecimalTo3byteBcd(Decimal Dec)
    {
      byte[] numArray1 = new byte[6];
      byte[] numArray2 = new byte[3];
      if (!(Dec < new Decimal(1000)) || !(Dec >= new Decimal(0)))
        throw new FormatException();
      long num1 = (long) (Dec * new Decimal(1000));
      numArray1[0] = (byte) ((ulong) num1 % 10UL);
      long num2 = (num1 - (long) numArray1[0]) / 10L;
      numArray1[1] = (byte) ((ulong) num2 % 10UL);
      long num3 = (num2 - (long) numArray1[1]) / 10L;
      numArray1[2] = (byte) ((ulong) num3 % 10UL);
      long num4 = (num3 - (long) numArray1[2]) / 10L;
      numArray1[3] = (byte) ((ulong) num4 % 10UL);
      long num5 = (num4 - (long) numArray1[3]) / 10L;
      numArray1[4] = (byte) ((ulong) num5 % 10UL);
      long num6 = (num5 - (long) numArray1[4]) / 10L;
      numArray1[5] = (byte) ((ulong) num6 % 10UL);
      numArray2[0] = (byte) (((uint) numArray1[5] << 4) + (uint) numArray1[4]);
      numArray2[1] = (byte) (((uint) numArray1[3] << 4) + (uint) numArray1[2]);
      numArray2[2] = (byte) (((uint) numArray1[1] << 4) + (uint) numArray1[0]);
      return numArray2;
    }

    internal Decimal conv_4byteBcdToDecimal(byte[] bcdBytes)
    {
      Decimal[] numArray = new Decimal[8];
      int index1 = 0;
      int index2 = 0;
      for (; index1 < bcdBytes.Length; ++index1)
      {
        numArray[index2] = (Decimal) ((int) bcdBytes[index1] >> 4);
        numArray[index2 + 1] = (Decimal) ((int) bcdBytes[index1] & 15);
        if (numArray[index2] > new Decimal(9) || numArray[index2 + 1] > new Decimal(9))
          throw new FormatException();
        index2 += 2;
      }
      return numArray[0] * new Decimal(100) + numArray[1] * new Decimal(10) + numArray[2] * new Decimal(1) + numArray[3] / new Decimal(10) + numArray[4] / new Decimal(100) + numArray[5] / new Decimal(1000) + numArray[6] / new Decimal(10000) + numArray[7] / new Decimal(100000);
    }

    internal byte[] conv_DecimalTo4byteBcd(Decimal Dec)
    {
      byte[] numArray1 = new byte[8];
      byte[] numArray2 = new byte[4];
      if (!(Dec < new Decimal(1000)) || !(Dec >= new Decimal(0)))
        throw new FormatException();
      long num1 = (long) (Dec * new Decimal(100000));
      numArray1[0] = (byte) ((ulong) num1 % 10UL);
      long num2 = (num1 - (long) numArray1[0]) / 10L;
      numArray1[1] = (byte) ((ulong) num2 % 10UL);
      long num3 = (num2 - (long) numArray1[1]) / 10L;
      numArray1[2] = (byte) ((ulong) num3 % 10UL);
      long num4 = (num3 - (long) numArray1[2]) / 10L;
      numArray1[3] = (byte) ((ulong) num4 % 10UL);
      long num5 = (num4 - (long) numArray1[3]) / 10L;
      numArray1[4] = (byte) ((ulong) num5 % 10UL);
      long num6 = (num5 - (long) numArray1[4]) / 10L;
      numArray1[5] = (byte) ((ulong) num6 % 10UL);
      long num7 = (num6 - (long) numArray1[5]) / 10L;
      numArray1[6] = (byte) ((ulong) num7 % 10UL);
      long num8 = (num7 - (long) numArray1[6]) / 10L;
      numArray1[7] = (byte) ((ulong) num8 % 10UL);
      numArray2[0] = (byte) (((uint) numArray1[7] << 4) + (uint) numArray1[6]);
      numArray2[1] = (byte) (((uint) numArray1[5] << 4) + (uint) numArray1[4]);
      numArray2[2] = (byte) (((uint) numArray1[3] << 4) + (uint) numArray1[2]);
      numArray2[3] = (byte) (((uint) numArray1[1] << 4) + (uint) numArray1[0]);
      return numArray2;
    }

    internal Decimal add_StepFreq(Decimal frq, int stp)
    {
      Decimal num1 = new Decimal(0, 0, 0, false, (byte) 1);
      Decimal num2 = frq;
      for (int index = 0; index < DataForm.tbl_Freq.GetLength(0); ++index)
      {
        if (DataForm.tbl_Freq[index, Settings.Instance.Destination, 0] <= frq && frq < DataForm.tbl_Freq[index, Settings.Instance.Destination, 1])
          num1 = DataForm.tbl_Freq[index, Settings.Instance.Destination, 0];
      }
      Decimal num3 = DataForm.tbl_StepDec[stp];
      if (num3 == new Decimal(833, 0, 0, false, (byte) 5))
      {
        for (int index = 0; index < DataForm.tbl_Add833KHz.Length; ++index)
        {
          Decimal num4 = Math.Truncate(DataForm.tbl_Add833KHz[index] * new Decimal(10000, 0, 0, false, (byte) 1)) / new Decimal(10000, 0, 0, false, (byte) 1);
          if ((frq - num4) % new Decimal(10000, 0, 0, false, (byte) 5) == new Decimal(0))
          {
            num2 = frq + (DataForm.tbl_Add833KHz[index] - num4);
            break;
          }
        }
      }
      else
      {
        Decimal num4 = (frq - num1) % num3;
        if (num4 != new Decimal(0))
          num2 = frq + num3 - num4;
      }
      return num2;
    }

    internal byte get_RefFreq(int step)
    {
      switch (step)
      {
        case 0:
        case 3:
        case 5:
        case 6:
          return 0;
        case 1:
        case 4:
        case 7:
        case 8:
        case 9:
          return 1;
        case 2:
          return 3;
        case 10:
          return 2;
        default:
          throw new FormatException();
      }
    }

    internal static char[] CnvStringToChar(string str, int len)
    {
      char[] chArray = new char[len];
      if (str == null)
        str = "";
      for (int index = 0; index < chArray.Length; ++index)
        chArray[index] = 'ÿ';
      char[] charArray = str.ToCharArray();
      if (charArray.Length > len)
        throw new FormatException();
      for (int index = 0; index < charArray.Length; ++index)
        chArray[index] = charArray[index];
      return chArray;
    }

    internal void Bitset(int address, int value, int mask)
    {
      int num = 0;
      if ((mask & 1) != 0)
        num = 0;
      else if ((mask & 2) != 0)
        num = 1;
      else if ((mask & 4) != 0)
        num = 2;
      else if ((mask & 8) != 0)
        num = 3;
      else if ((mask & 16) != 0)
        num = 4;
      else if ((mask & 32) != 0)
        num = 5;
      else if ((mask & 64) != 0)
        num = 6;
      else if ((mask & 128) != 0)
        num = 7;
      this.dat[address] = (byte) ((value << num) + ((int) this.dat[address] & ~mask));
    }

    internal byte calc_CheckSum(byte[] buf, int offset, int len)
    {
      byte num = 0;
      for (int index = 0; index < len; ++index)
        num += buf[offset + index];
      return num;
    }

    internal void GetDigiatMode(
      int srcDigAnalog,
      int srcAms,
      int srcMode,
      ref byte dstDigAnalog,
      ref byte dstAms)
    {
      if (srcAms == 0)
      {
        if (srcDigAnalog == 0)
        {
          dstDigAnalog = (byte) 0;
          dstAms = (byte) 0;
        }
        else if (srcDigAnalog == 1)
        {
          dstDigAnalog = (byte) 2;
          dstAms = (byte) 0;
        }
        else
        {
          dstDigAnalog = (byte) 3;
          dstAms = (byte) 1;
        }
      }
      else
      {
        dstDigAnalog = (byte) 1;
        switch (srcDigAnalog)
        {
          case 0:
            if (srcMode == 0)
            {
              dstAms = (byte) 2;
              break;
            }
            dstAms = (byte) 3;
            break;
          case 1:
            dstAms = (byte) 0;
            break;
          default:
            dstAms = (byte) 1;
            break;
        }
      }
    }

    private interface Converter
    {
      void Decode();

      void Encode();
    }

    private class SetMode : Database.Converter
    {
      private readonly int ADDR;
      private Database db;

      public SetMode()
      {
      }

      public SetMode(Database db, int address)
      {
        this.db = db;
        this.ADDR = address;
      }

      public void Decode()
      {
        int addr = this.ADDR;
        this.db.Display_OpeningMessageSel = (int) this.db.dat[addr + 53];
        char[] chArray1 = new char[16];
        for (int index = 0; index < chArray1.Length; ++index)
        {
          if (this.db.dat[addr + 56 + index] != byte.MaxValue)
            chArray1[index] = mojiConvert.CnvToMemoryNameChar(this.db.dat[addr + 56 + index]);
        }
        this.db.Display_OpeningMessageTxt = new string(chArray1).Replace("\0", "");
        this.db.Signaling_PagerRxCode1 = (int) this.db.dat[addr + 72];
        this.db.Signaling_PagerRxCode2 = (int) this.db.dat[addr + 73];
        this.db.Signaling_PagerTxCode1 = (int) this.db.dat[addr + 74];
        this.db.Signaling_PagerTxCode2 = (int) this.db.dat[addr + 75];
        char[] chArray2 = new char[4];
        for (int index = 0; index < chArray2.Length; ++index)
        {
          if (this.db.dat[addr + 76 + index] != byte.MaxValue)
            chArray2[index] = mojiConvert.CnvToPasswordChar(this.db.dat[addr + 76 + index]);
        }
        this.db.Config_PasswordTxt = new string(chArray2).Replace("\0", "");
        this.db.Signaling_SqlLevel = (int) this.db.dat[addr + 80];
        for (int index = 0; index < this.db.WxMemory.Count; ++index)
          this.db.WxMemory[index].Att = Convert.ToBoolean(((int) this.db.dat[addr + 86] & 2) >> 1);
        this.db.ScanResume_Scan = (int) this.db.dat[addr + 112];
        this.db.ScanResume_Dw = (int) this.db.dat[addr + 113];
        this.db.Config_Apo = (int) this.db.dat[addr + 115];
        this.db.Gm_Ringer = (int) this.db.dat[addr + 116];
        this.db.Signaling_Bell = (int) this.db.dat[addr + 117] - 1;
        this.db.Config_BeepLevel = (int) this.db.dat[addr + 118];
        this.db.Config_BeepSelect = (int) this.db.dat[addr + 119];
        this.db.Display_LcdDimmer = (int) this.db.dat[addr + 132];
        this.db.Signaling_DtmfTxDelay = (int) this.db.dat[addr + 133];
        this.db.Display_Lamp = (int) this.db.dat[addr + 138];
        this.db.Config_Lock = (int) this.db.dat[addr + 139];
        this.db.TxRx_MicGain = (int) this.db.dat[addr + 141];
        this.db.Scan_DwTime = (int) this.db.dat[addr + 143];
        this.db.Config_PttDelay = (int) this.db.dat[addr + 144];
        this.db.Config_SaveRx = (int) this.db.dat[addr + 145];
        this.db.Scan_ReStart = (int) this.db.dat[addr + 146];
        this.db.Config_Tot = (int) this.db.dat[addr + 154];
        this.db.Signaling_DtmfTxMode = (int) this.db.dat[addr + 158] & 1;
        this.db.Signaling_SqlExpansion = ((int) this.db.dat[addr + 158] & 2) >> 1;
        this.db.Signaling_DtmfTxSpeed = ((int) this.db.dat[addr + 158] & 4) >> 2;
        this.db.Config_RptArs = ((int) this.db.dat[addr + 158] & 8) >> 3;
        this.db.Signaling_ToneSarchSpeed = ((int) this.db.dat[addr + 158] & 16) >> 4;
        this.db.Scan_Lamp = ((int) this.db.dat[addr + 158] & 32) >> 5;
        this.db.Config_VfoMode = ((int) this.db.dat[addr + 158] & 128) >> 7;
        this.db.Config_BeepEdge = ((int) this.db.dat[addr + 159] & 8) >> 3;
        this.db.Config_Bclo = ((int) this.db.dat[addr + 159] & 16) >> 4;
        this.db.Signaling_ToneSarchMute = ((int) this.db.dat[addr + 159] & 64) >> 6;
        this.db.Config_MonTcall = (int) this.db.dat[addr + 160] & 1;
        this.db.Config_HomeRev = ((int) this.db.dat[addr + 160] & 2) >> 1;
        this.db.Memory_WriteMode = (int) this.db.dat[addr + 161] & 1;
        this.db.Gm_Interval = ((int) this.db.dat[addr + 161] & 48) >> 4;
        this.db.Config_PasswordSel = (int) this.db.dat[addr + 162] & 1;
        this.db.Display_TempUnit = ((int) this.db.dat[addr + 162] & 8) >> 3;
        this.db.Signaling_WxAlart = ((int) this.db.dat[addr + 162] & 16) >> 4;
        this.db.Config_DwRvt = (int) this.db.dat[addr + 163] & 1;
        this.db.Signaling_PagerAnserBack = (int) (byte) (((int) this.db.dat[addr + 163] & 4) >> 2);
        this.db.Config_HomeVfo = (int) (byte) (((int) this.db.dat[addr + 163] & 8) >> 3);
        this.db.Config_BusyLed = (int) this.db.dat[addr + 168] & 1;
        this.db.Config_P1 = (int) Database.FT70DtoADMS_KeyList[(int) this.db.dat[addr + 177]];
        this.db.Config_P2 = (int) Database.FT70DtoADMS_KeyList[(int) this.db.dat[addr + 178]];
        if (!Settings.Instance.Recv_flg)
        {
          if (Settings.Instance.Language != 0)
            return;
          if (this.db.Config_P1 > 60)
            --this.db.Config_P1;
          if (this.db.Config_P2 <= 60)
            return;
          --this.db.Config_P2;
        }
        else
        {
          if (Settings.Instance.CpuType != 1 && (Settings.Instance.CpuType != 2 || Settings.Instance.CountryType == 1))
            return;
          if (this.db.Config_P1 > 60)
            --this.db.Config_P1;
          if (this.db.Config_P2 <= 60)
            return;
          --this.db.Config_P2;
        }
      }

      public void Encode()
      {
        int addr = this.ADDR;
        this.db.dat[addr + 53] = (byte) this.db.Display_OpeningMessageSel;
        char[] chArray1 = Database.CnvStringToChar(this.db.Display_OpeningMessageTxt, 16);
        for (int index = 0; index < chArray1.Length; ++index)
          this.db.dat[addr + 56 + index] = mojiConvert.CnvToMemoryNameBin(chArray1[index]);
        this.db.dat[addr + 72] = (byte) this.db.Signaling_PagerRxCode1;
        this.db.dat[addr + 73] = (byte) this.db.Signaling_PagerRxCode2;
        this.db.dat[addr + 74] = (byte) this.db.Signaling_PagerTxCode1;
        this.db.dat[addr + 75] = (byte) this.db.Signaling_PagerTxCode2;
        char[] chArray2 = Database.CnvStringToChar(this.db.Config_PasswordTxt, 4);
        for (int index = 0; index < chArray2.Length; ++index)
          this.db.dat[addr + 76 + index] = mojiConvert.CnvToPasswordBin(chArray2[index]);
        this.db.dat[addr + 80] = (byte) this.db.Signaling_SqlLevel;
        this.db.Bitset(addr + 86, (int) Convert.ToByte(this.db.WxMemory[0].Att), 2);
        this.db.dat[addr + 112] = (byte) this.db.ScanResume_Scan;
        this.db.dat[addr + 113] = (byte) this.db.ScanResume_Dw;
        this.db.dat[addr + 115] = (byte) this.db.Config_Apo;
        this.db.dat[addr + 116] = (byte) this.db.Gm_Ringer;
        this.db.dat[addr + 117] = (byte) (this.db.Signaling_Bell + 1);
        this.db.dat[addr + 118] = (byte) this.db.Config_BeepLevel;
        this.db.dat[addr + 119] = (byte) this.db.Config_BeepSelect;
        this.db.dat[addr + 132] = (byte) this.db.Display_LcdDimmer;
        this.db.dat[addr + 133] = (byte) this.db.Signaling_DtmfTxDelay;
        this.db.dat[addr + 138] = (byte) this.db.Display_Lamp;
        this.db.dat[addr + 139] = (byte) this.db.Config_Lock;
        this.db.dat[addr + 141] = (byte) this.db.TxRx_MicGain;
        this.db.dat[addr + 143] = (byte) this.db.Scan_DwTime;
        this.db.dat[addr + 144] = (byte) this.db.Config_PttDelay;
        this.db.dat[addr + 145] = (byte) this.db.Config_SaveRx;
        this.db.dat[addr + 146] = (byte) this.db.Scan_ReStart;
        this.db.dat[addr + 154] = (byte) this.db.Config_Tot;
        this.db.Bitset(addr + 158, this.db.Signaling_DtmfTxMode, 1);
        this.db.Bitset(addr + 158, this.db.Signaling_SqlExpansion, 2);
        this.db.Bitset(addr + 158, this.db.Signaling_DtmfTxSpeed, 4);
        this.db.Bitset(addr + 158, this.db.Config_RptArs, 8);
        this.db.Bitset(addr + 158, this.db.Signaling_ToneSarchSpeed, 16);
        this.db.Bitset(addr + 158, this.db.Scan_Lamp, 32);
        this.db.Bitset(addr + 158, this.db.Config_VfoMode, 128);
        this.db.Bitset(addr + 159, this.db.Config_BeepEdge, 8);
        this.db.Bitset(addr + 159, this.db.Config_Bclo, 16);
        this.db.Bitset(addr + 159, this.db.Signaling_ToneSarchMute, 64);
        this.db.Bitset(addr + 160, this.db.Config_MonTcall, 1);
        this.db.Bitset(addr + 160, this.db.Config_HomeRev, 2);
        this.db.Bitset(addr + 161, this.db.Memory_WriteMode, 1);
        this.db.Bitset(addr + 161, this.db.Gm_Interval, 48);
        this.db.Bitset(addr + 162, this.db.Config_PasswordSel, 1);
        this.db.Bitset(addr + 162, this.db.Display_TempUnit, 8);
        this.db.Bitset(addr + 162, this.db.Signaling_WxAlart, 16);
        this.db.Bitset(addr + 163, this.db.Config_DwRvt, 1);
        this.db.Bitset(addr + 163, this.db.Signaling_PagerAnserBack, 4);
        this.db.Bitset(addr + 163, this.db.Config_HomeVfo, 8);
        this.db.Bitset(addr + 168, this.db.Config_BusyLed, 1);
        this.db.dat[addr + 177] = Database.ADMStoFT70D_KeyList[this.db.Config_P1];
        this.db.dat[addr + 178] = Database.ADMStoFT70D_KeyList[this.db.Config_P2];
        if (!Settings.Instance.Recv_flg)
        {
          if (Settings.Instance.Language != 0)
            return;
          if (this.db.dat[addr + 177] > (byte) 75)
            ++this.db.dat[addr + 177];
          if (this.db.dat[addr + 178] <= (byte) 75)
            return;
          ++this.db.dat[addr + 178];
        }
        else
        {
          if (Settings.Instance.CpuType != 1 && (Settings.Instance.CpuType != 2 || Settings.Instance.CountryType == 1))
            return;
          if (this.db.dat[addr + 177] > (byte) 75)
            ++this.db.dat[addr + 177];
          if (this.db.dat[addr + 178] <= (byte) 75)
            return;
          ++this.db.dat[addr + 178];
        }
      }
    }

    private class BandCommon : Database.Converter
    {
      private readonly int ADDR;
      private Database db;

      public BandCommon()
      {
      }

      public BandCommon(Database db, int address)
      {
        this.db = db;
        this.ADDR = address;
      }

      public void Decode()
      {
        int addr = this.ADDR;
        for (int index = 0; index < this.db.NormalMemory.Count; ++index)
          this.db.NormalMemory[index].PriorityCH = false;
        int index1 = ((int) this.db.dat[addr + 2] << 8) + (int) this.db.dat[addr + 3];
        if (index1 == (int) ushort.MaxValue)
          return;
        this.db.NormalMemory[index1].PriorityCH = true;
      }

      public void Encode()
      {
        int addr = this.ADDR;
        this.db.dat[addr] = (byte) 0;
        this.db.dat[addr + 2] = byte.MaxValue;
        this.db.dat[addr + 3] = byte.MaxValue;
        for (int index = 0; index < this.db.NormalMemory.Count; ++index)
        {
          if (this.db.NormalMemory[index].PriorityCH)
          {
            this.db.dat[addr + 2] = (byte) ((index & 65280) >> 8);
            this.db.dat[addr + 3] = (byte) (index & (int) byte.MaxValue);
            break;
          }
        }
        this.db.dat[addr + 4] = (byte) 0;
        this.db.dat[addr + 5] = (byte) 0;
        this.db.dat[addr + 6] = (byte) 0;
        this.db.dat[addr + 7] = (byte) 0;
        this.db.dat[addr + 8] = (byte) 0;
        this.db.dat[addr + 14] = (byte) 0;
        this.db.dat[addr + 17] = (byte) 0;
        byte dstDigAnalog = 0;
        byte dstAms = 0;
        BandMemory bandMemory = this.db.VfoMemory[6];
        this.db.GetDigiatMode(bandMemory.DigAnalog, bandMemory.Ams, bandMemory.Mode, ref dstDigAnalog, ref dstAms);
        this.db.dat[addr + 19] = dstDigAnalog;
        this.db.dat[addr + 22] = (byte) ((uint) dstAms + 2U);
        this.db.dat[addr + 63] = this.db.calc_CheckSum(this.db.dat, addr, 63);
      }
    }

    private class BandSingle : Database.Converter
    {
      private readonly int ADDR;
      private Database db;

      public BandSingle()
      {
      }

      public BandSingle(Database db, int address)
      {
        this.db = db;
        this.ADDR = address;
      }

      public void Decode()
      {
        int addr = this.ADDR;
        this.db.ScanWidth_Vfo = (int) this.db.dat[addr + 80] - 3;
        this.db.ScanWidth_Memory = (int) this.db.dat[addr + 81] - 3;
      }

      public void Encode()
      {
        int addr = this.ADDR;
        this.db.dat[addr + 2] = (byte) 1;
        this.db.dat[addr + 3] = (byte) 6;
        this.db.dat[addr + 4] = (byte) 6;
        this.db.dat[addr + 5] = (byte) 1;
        this.db.dat[addr + 6] = (byte) 0;
        this.db.dat[addr + 7] = (byte) 3;
        this.db.dat[addr + 8] = (byte) 0;
        this.db.dat[addr + 9] = (byte) 0;
        this.db.dat[addr + 14] = (byte) 0;
        this.db.dat[addr + 15] = (byte) 0;
        this.db.dat[addr + 16] = (byte) 0;
        this.db.dat[addr + 17] = (byte) 3;
        BandMemory bandMemory = this.db.VfoMemory[6];
        int refFreq = (int) this.db.get_RefFreq(bandMemory.Step);
        this.db.Bitset(addr + 18, refFreq, 3);
        this.db.Bitset(addr + 18, refFreq, 12);
        this.db.Bitset(addr + 18, (int) Convert.ToByte(bandMemory.ClockShift), 16);
        this.db.Bitset(addr + 18, (int) Convert.ToByte(bandMemory.HarfDev), 32);
        this.db.Bitset(addr + 18, (int) Convert.ToByte(bandMemory.Tag), 128);
        this.db.dat[addr + 19] = (byte) (bandMemory.TxOut + 1);
        this.db.dat[addr + 20] = (byte) bandMemory.Step;
        this.db.dat[addr + 21] = (byte) bandMemory.ShiftDir;
        this.db.dat[addr + 22] = (byte) bandMemory.SqlType;
        this.db.dat[addr + 23] = (byte) bandMemory.ToneFrq;
        this.db.dat[addr + 24] = (byte) bandMemory.DcsCode;
        this.db.dat[addr + 25] = (byte) bandMemory.Mode;
        byte[] numArray1 = this.db.conv_DecimalTo4byteBcd(bandMemory.RxFrq);
        this.db.dat[addr + 26] = numArray1[0];
        this.db.dat[addr + 27] = numArray1[1];
        this.db.dat[addr + 28] = numArray1[2];
        this.db.dat[addr + 29] = numArray1[3];
        byte[] numArray2;
        switch (bandMemory.ShiftDir)
        {
          case 0:
            numArray2 = this.db.conv_DecimalTo4byteBcd(bandMemory.ShiftFrq);
            break;
          case 1:
            numArray2 = this.db.conv_DecimalTo4byteBcd(bandMemory.ShiftFrq);
            break;
          case 2:
            numArray2 = this.db.conv_DecimalTo4byteBcd(bandMemory.ShiftFrq);
            break;
          case 3:
            numArray2 = this.db.conv_DecimalTo4byteBcd(bandMemory.TxFrq);
            break;
          default:
            throw new FormatException();
        }
        this.db.dat[addr + 30] = numArray2[0];
        this.db.dat[addr + 31] = numArray2[1];
        this.db.dat[addr + 32] = numArray2[2];
        this.db.dat[addr + 33] = numArray2[3];
        char[] chArray = Database.CnvStringToChar(bandMemory.MemName, 16);
        for (int index = 0; index < chArray.Length; ++index)
          this.db.dat[addr + 36 + index] = mojiConvert.CnvToMemoryNameBin(chArray[index]);
        this.db.dat[addr + 52] = (byte) bandMemory.PrTone;
        this.db.dat[addr + 53] = (byte) bandMemory.DcsDim;
        byte dstDigAnalog = 0;
        byte dstAms = 0;
        this.db.GetDigiatMode(bandMemory.DigAnalog, bandMemory.Ams, bandMemory.Mode, ref dstDigAnalog, ref dstAms);
        this.db.Bitset(addr + 54, (int) dstDigAnalog, 48);
        this.db.Bitset(addr + 54, (int) dstAms, 192);
        this.db.dat[addr + 55] = (byte) bandMemory.Smeter;
        this.db.dat[addr + 56] = (byte) bandMemory.Bell;
        this.db.Bitset(addr + 57, (int) Convert.ToByte(bandMemory.AutoMode), 8);
        this.db.Bitset(addr + 57, (int) Convert.ToByte(bandMemory.AutoStep), 16);
        this.db.Bitset(addr + 57, (int) Convert.ToByte(bandMemory.Att), 32);
        byte[] numArray3 = this.db.conv_DecimalTo4byteBcd(bandMemory.RxFrq);
        this.db.dat[addr + 66] = numArray3[0];
        this.db.dat[addr + 67] = numArray3[1];
        this.db.dat[addr + 68] = numArray3[2];
        this.db.dat[addr + 69] = numArray3[3];
        this.db.dat[addr + 80] = (byte) (this.db.ScanWidth_Vfo + 3);
        this.db.dat[addr + 81] = (byte) (this.db.ScanWidth_Memory + 3);
        this.db.dat[addr + (int) sbyte.MaxValue] = this.db.calc_CheckSum(this.db.dat, addr, (int) sbyte.MaxValue);
      }
    }

    private class Dtmf : Database.Converter
    {
      private readonly int ADDR;
      private Database db;

      public Dtmf()
      {
      }

      public Dtmf(Database db, int address)
      {
        this.db = db;
        this.ADDR = address;
      }

      public void Decode()
      {
        int addr = this.ADDR;
        for (int index1 = 0; index1 < this.db.DtmfMemory.Count; ++index1)
        {
          char[] chArray = new char[16];
          for (int index2 = 0; index2 < chArray.Length; ++index2)
          {
            if (this.db.dat[addr + index2] != byte.MaxValue)
              chArray[index2] = mojiConvert.CnvToDtmfChar(this.db.dat[addr + index2]);
          }
          string str = new string(chArray);
          this.db.DtmfMemory[index1].Code = str.Replace("\0", "");
          addr += 16;
        }
      }

      public void Encode()
      {
        int addr = this.ADDR;
        for (int index1 = 0; index1 < this.db.DtmfMemory.Count; ++index1)
        {
          char[] chArray = Database.CnvStringToChar(this.db.DtmfMemory[index1].Code, 16);
          for (int index2 = 0; index2 < chArray.Length; ++index2)
            this.db.dat[addr + index2] = mojiConvert.CnvToDtmfBin(chArray[index2]);
          addr += 16;
        }
      }
    }

    private class WxAN : Database.Converter
    {
      private readonly int ADDR;
      private Database db;

      public WxAN()
      {
      }

      public WxAN(Database db, int address)
      {
        this.db = db;
        this.ADDR = address;
      }

      public void Decode()
      {
        int addr = this.ADDR;
        for (int index1 = 0; index1 < this.db.WxMemory.Count; ++index1)
        {
          this.db.WxMemory[index1].Tag = Convert.ToBoolean((int) this.db.dat[addr + 1] & 1);
          char[] chArray = new char[16];
          for (int index2 = 0; index2 < chArray.Length; ++index2)
          {
            if (this.db.dat[addr + 2 + index2] != byte.MaxValue)
              chArray[index2] = mojiConvert.CnvToMemoryNameChar(this.db.dat[addr + 2 + index2]);
          }
          string str = new string(chArray);
          this.db.WxMemory[index1].MemName = str.Replace("\0", "");
          addr += 18;
        }
      }

      public void Encode()
      {
        int addr = this.ADDR;
        for (int index1 = 0; index1 < this.db.WxMemory.Count; ++index1)
        {
          int int32 = Convert.ToInt32(this.db.WxMemory[index1].Tag);
          this.db.Bitset(addr + 1, int32, 1);
          char[] chArray = Database.CnvStringToChar(this.db.WxMemory[index1].MemName, 16);
          for (int index2 = 0; index2 < chArray.Length; ++index2)
            this.db.dat[addr + 2 + index2] = mojiConvert.CnvToMemoryNameBin(chArray[index2]);
          addr += 18;
        }
      }
    }

    private class BankName : Database.Converter
    {
      private readonly int ADDR;
      private Database db;

      public BankName()
      {
      }

      public BankName(Database db, int address)
      {
        this.db = db;
        this.ADDR = address;
      }

      public void Decode()
      {
        int addr = this.ADDR;
        for (int index1 = 0; index1 < this.db.MemoryBank.Count; ++index1)
        {
          char[] chArray = new char[16];
          for (int index2 = 0; index2 < chArray.Length; ++index2)
          {
            if (this.db.dat[addr + 2 + index2] != byte.MaxValue)
              chArray[index2] = mojiConvert.CnvToMemoryNameChar(this.db.dat[addr + 2 + index2]);
          }
          string str = new string(chArray);
          this.db.MemoryBank[index1].BankName = str.Replace("\0", "");
          addr += 18;
        }
      }

      public void Encode()
      {
        int addr = this.ADDR;
        for (int index1 = 0; index1 < this.db.MemoryBank.Count; ++index1)
        {
          char[] chArray = Database.CnvStringToChar(this.db.MemoryBank[index1].BankName, 16);
          for (int index2 = 0; index2 < chArray.Length; ++index2)
            this.db.dat[addr + 2 + index2] = mojiConvert.CnvToMemoryNameBin(chArray[index2]);
          addr += 18;
        }
      }
    }

    private class Memory : Database.Converter
    {
      private readonly int ADDR;
      private Database db;
      private BindingList<BandMemory> mem;

      public Memory()
      {
      }

      public Memory(Database database, int address, BindingList<BandMemory> memory)
      {
        this.db = database;
        this.ADDR = address;
        this.mem = memory;
      }

      public void Decode()
      {
        int addr = this.ADDR;
        for (int index1 = 0; index1 < this.mem.Count; ++index1)
        {
          if (this.mem[index1].MemDel)
          {
            this.mem[index1].ClockShift = Convert.ToBoolean(((int) this.db.dat[addr] & 16) >> 4);
            this.mem[index1].HarfDev = Convert.ToBoolean(((int) this.db.dat[addr] & 32) >> 5);
            this.mem[index1].Tag = Convert.ToBoolean(((int) this.db.dat[addr] & 128) >> 7);
            this.mem[index1].Step = (int) this.db.dat[addr + 1] & 15;
            this.mem[index1].ShiftDir = ((int) this.db.dat[addr + 1] & 48) >> 4;
            this.mem[index1].Mode = ((int) this.db.dat[addr + 1] & 192) >> 6;
            byte[] bcdBytes = new byte[3]
            {
              this.db.dat[addr + 2],
              this.db.dat[addr + 3],
              this.db.dat[addr + 4]
            };
            Decimal frq = this.db.conv_3byteBcdToDecimal(bcdBytes);
            this.mem[index1].RxFrq = this.db.add_StepFreq(frq, this.mem[index1].Step);
            this.mem[index1].SqlType = (int) this.db.dat[addr + 5] & 15;
            int num1 = ((int) this.db.dat[addr + 5] & 48) >> 4;
            this.mem[index1].TxOut = (((int) this.db.dat[addr + 5] & 192) >> 6) - 1;
            char[] chArray = new char[16];
            for (int index2 = 0; index2 < chArray.Length; ++index2)
            {
              if (this.db.dat[addr + 8 + index2] != byte.MaxValue)
                chArray[index2] = mojiConvert.CnvToMemoryNameChar(this.db.dat[addr + 8 + index2]);
            }
            string str = new string(chArray);
            this.mem[index1].MemName = str.Replace("\0", "");
            bcdBytes[0] = this.db.dat[addr + 24];
            bcdBytes[1] = this.db.dat[addr + 25];
            bcdBytes[2] = this.db.dat[addr + 26];
            Decimal num2 = this.db.conv_3byteBcdToDecimal(bcdBytes);
            switch (this.mem[index1].ShiftDir)
            {
              case 0:
                this.mem[index1].TxFrq = this.mem[index1].RxFrq;
                break;
              case 1:
                this.mem[index1].TxFrq = this.mem[index1].RxFrq - num2;
                break;
              case 2:
                this.mem[index1].TxFrq = this.mem[index1].RxFrq + num2;
                break;
              case 3:
                this.mem[index1].TxFrq = num2;
                break;
            }
            this.mem[index1].ShiftFrq = num2;
            this.mem[index1].ToneFrq = (int) this.db.dat[addr + 27];
            this.mem[index1].DcsCode = (int) this.db.dat[addr + 28];
            this.mem[index1].PrTone = (int) this.db.dat[addr + 29] & 31;
            this.mem[index1].DcsDim = ((int) this.db.dat[addr + 29] & 224) >> 5;
            this.mem[index1].Smeter = (int) this.db.dat[addr + 30] & 15;
            this.mem[index1].Vibrator = ((int) this.db.dat[addr + 30] & 48) >> 4;
            int num3 = ((int) this.db.dat[addr + 30] & 192) >> 6;
            switch (num1)
            {
              case 0:
                this.mem[index1].Ams = 0;
                this.mem[index1].DigAnalog = 0;
                break;
              case 2:
                this.mem[index1].Ams = 0;
                this.mem[index1].DigAnalog = 1;
                break;
              case 3:
                this.mem[index1].Ams = 0;
                this.mem[index1].DigAnalog = 2;
                break;
              default:
                this.mem[index1].Ams = 1;
                switch (num3)
                {
                  case 0:
                    this.mem[index1].DigAnalog = 1;
                    break;
                  case 1:
                    this.mem[index1].DigAnalog = 2;
                    break;
                  default:
                    this.mem[index1].DigAnalog = 0;
                    break;
                }
                break;
            }
            this.mem[index1].Bell = (int) this.db.dat[addr + 31] & 7;
            this.mem[index1].AutoMode = Convert.ToBoolean(((int) this.db.dat[addr + 31] & 8) >> 3);
            this.mem[index1].AutoStep = Convert.ToBoolean(((int) this.db.dat[addr + 31] & 16) >> 4);
            this.mem[index1].Att = Convert.ToBoolean(((int) this.db.dat[addr + 31] & 32) >> 5);
          }
          addr += 32;
        }
      }

      public void Encode()
      {
        int addr = this.ADDR;
        byte[] numArray1 = new byte[3];
        for (int index1 = 0; index1 < this.mem.Count; ++index1)
        {
          if (this.mem[index1].MemDel)
          {
            int refFreq = (int) this.db.get_RefFreq(this.mem[index1].Step);
            this.db.Bitset(addr, refFreq, 3);
            this.db.Bitset(addr, refFreq, 12);
            this.db.Bitset(addr, (int) Convert.ToByte(this.mem[index1].ClockShift), 16);
            this.db.Bitset(addr, (int) Convert.ToByte(this.mem[index1].HarfDev), 32);
            this.db.Bitset(addr, (int) Convert.ToByte(this.mem[index1].Tag), 128);
            this.db.Bitset(addr + 1, (int) Convert.ToByte(this.mem[index1].Step), 15);
            this.db.Bitset(addr + 1, (int) Convert.ToByte(this.mem[index1].ShiftDir), 48);
            this.db.Bitset(addr + 1, (int) Convert.ToByte(this.mem[index1].Mode), 192);
            byte[] numArray2 = this.db.conv_DecimalTo3byteBcd(this.mem[index1].RxFrq);
            this.db.dat[addr + 2] = numArray2[0];
            this.db.dat[addr + 3] = numArray2[1];
            this.db.dat[addr + 4] = numArray2[2];
            this.db.Bitset(addr + 5, (int) Convert.ToByte(this.mem[index1].SqlType), 15);
            byte dstDigAnalog = 0;
            byte dstAms = 0;
            this.db.GetDigiatMode(this.mem[index1].DigAnalog, this.mem[index1].Ams, this.mem[index1].Mode, ref dstDigAnalog, ref dstAms);
            this.db.Bitset(addr + 5, (int) dstDigAnalog, 48);
            this.db.Bitset(addr + 5, (int) Convert.ToByte(this.mem[index1].TxOut + 1), 192);
            char[] chArray = Database.CnvStringToChar(this.mem[index1].MemName, 16);
            for (int index2 = 0; index2 < chArray.Length; ++index2)
              this.db.dat[addr + 8 + index2] = mojiConvert.CnvToMemoryNameBin(chArray[index2]);
            byte[] numArray3;
            switch (this.mem[index1].ShiftDir)
            {
              case 0:
                numArray3 = this.db.conv_DecimalTo3byteBcd(this.mem[index1].ShiftFrq);
                break;
              case 1:
                numArray3 = this.db.conv_DecimalTo3byteBcd(this.mem[index1].ShiftFrq);
                break;
              case 2:
                numArray3 = this.db.conv_DecimalTo3byteBcd(this.mem[index1].ShiftFrq);
                break;
              case 3:
                numArray3 = this.db.conv_DecimalTo3byteBcd(this.mem[index1].TxFrq);
                break;
              default:
                throw new FormatException();
            }
            this.db.dat[addr + 24] = numArray3[0];
            this.db.dat[addr + 25] = numArray3[1];
            this.db.dat[addr + 26] = numArray3[2];
            this.db.dat[addr + 27] = (byte) this.mem[index1].ToneFrq;
            this.db.dat[addr + 28] = (byte) this.mem[index1].DcsCode;
            this.db.Bitset(addr + 29, (int) Convert.ToByte(this.mem[index1].PrTone), 31);
            this.db.Bitset(addr + 29, (int) Convert.ToByte(this.mem[index1].DcsDim), 224);
            this.db.Bitset(addr + 30, (int) Convert.ToByte(this.mem[index1].Smeter), 15);
            this.db.Bitset(addr + 30, (int) Convert.ToByte(this.mem[index1].Vibrator), 48);
            this.db.Bitset(addr + 30, (int) dstAms, 192);
            this.db.Bitset(addr + 31, (int) Convert.ToByte(this.mem[index1].Bell), 7);
            this.db.Bitset(addr + 31, (int) Convert.ToByte(this.mem[index1].AutoMode), 8);
            this.db.Bitset(addr + 31, (int) Convert.ToByte(this.mem[index1].AutoStep), 16);
            this.db.Bitset(addr + 31, (int) Convert.ToByte(this.mem[index1].Att), 32);
            this.db.Bitset(addr + 31, 0, 192);
          }
          addr += 32;
        }
      }
    }

    private class MemoryBankNum : Database.Converter
    {
      private const int NORMMEM = 0;
      private const int WXMEM = 3;
      private const int NORMCH = 0;
      private const int SKIPCH = 900;
      private const int PMSCH = 1000;
      private readonly int ADDR;
      private Database db;

      public MemoryBankNum()
      {
      }

      public MemoryBankNum(Database db, int address)
      {
        this.db = db;
        this.ADDR = address;
      }

      public void Decode()
      {
        int addr = this.ADDR;
        for (int index1 = 0; index1 < 24; ++index1)
        {
          for (int index2 = 0; index2 < this.db.NormalMemory.Count; ++index2)
            this.db.NormalMemory[index2].Bank[index1] = false;
          for (int index2 = 0; index2 < this.db.SkipMemory.Count; ++index2)
            this.db.SkipMemory[index2].Bank[index1] = false;
          for (int index2 = 0; index2 < this.db.PmsMemory.Count; ++index2)
            this.db.PmsMemory[index2].Bank[index1] = false;
          for (int index2 = 0; index2 < this.db.WxMemory.Count; ++index2)
            this.db.WxMemory[index2].Bank[index1] = false;
        }
        for (int index1 = 0; index1 < 24; ++index1)
        {
          for (int index2 = 0; index2 < 100; ++index2)
          {
            ushort uint16 = Convert.ToUInt16(((int) this.db.dat[addr] << 8) + (int) this.db.dat[addr + 1]);
            int num = ((int) uint16 & 63488) >> 11;
            int index3 = (int) uint16 & 2047;
            switch (num)
            {
              case 0:
                if (index3 < 900)
                {
                  this.db.NormalMemory[index3].Bank[index1] = true;
                  break;
                }
                break;
              case 3:
                this.db.WxMemory[index3].Bank[index1] = true;
                break;
            }
            addr += 2;
          }
        }
      }

      public void Encode()
      {
        int addr1 = this.ADDR;
        this.db.dat[1610] = byte.MaxValue;
        this.db.dat[1611] = byte.MaxValue;
        this.db.dat[1738] = byte.MaxValue;
        this.db.dat[1739] = byte.MaxValue;
        this.db.dat[1612] = byte.MaxValue;
        this.db.dat[1613] = byte.MaxValue;
        this.db.dat[1740] = byte.MaxValue;
        this.db.dat[1741] = byte.MaxValue;
        for (int index = 0; index < 48; ++index)
          this.db.dat[1344 + index] = byte.MaxValue;
        for (int index1 = 0; index1 < 24; ++index1)
        {
          for (int index2 = 0; index2 < 100; ++index2)
          {
            this.db.dat[addr1] = byte.MaxValue;
            this.db.dat[addr1 + 1] = byte.MaxValue;
            addr1 += 2;
          }
        }
        int addr2 = this.ADDR;
        int[] numArray = new int[24];
        for (int index1 = 0; index1 < 24; ++index1)
        {
          numArray[index1] = 0;
          for (int index2 = 0; index2 < this.db.NormalMemory.Count; ++index2)
          {
            if (this.db.NormalMemory[index2].Bank[index1])
            {
              ushort uint16 = Convert.ToUInt16((0 << 11) + index2);
              this.db.dat[addr2 + numArray[index1] + index1 * 100 * 2] = (byte) (((int) uint16 & 65280) >> 8);
              this.db.dat[addr2 + numArray[index1] + index1 * 100 * 2 + 1] = (byte) ((uint) uint16 & (uint) byte.MaxValue);
              this.db.dat[1610] = (byte) ((index1 & 65280) >> 8);
              this.db.dat[1611] = (byte) (index1 & (int) byte.MaxValue);
              this.db.dat[1738] = (byte) ((index1 & 65280) >> 8);
              this.db.dat[1739] = (byte) (index1 & (int) byte.MaxValue);
              this.db.dat[1612] = (byte) 0;
              this.db.dat[1613] = (byte) 0;
              this.db.dat[1740] = (byte) 0;
              this.db.dat[1741] = (byte) 0;
              this.db.dat[1344 + index1 * 2] = (byte) 0;
              this.db.dat[1344 + index1 * 2 + 1] = (byte) 0;
              numArray[index1] += 2;
            }
          }
          for (int index2 = 0; index2 < this.db.WxMemory.Count; ++index2)
          {
            if (this.db.WxMemory[index2].Bank[index1])
            {
              ushort uint16 = Convert.ToUInt16((3 << 11) + index2);
              this.db.dat[addr2 + numArray[index1] + index1 * 100 * 2] = (byte) (((int) uint16 & 65280) >> 8);
              this.db.dat[addr2 + numArray[index1] + index1 * 100 * 2 + 1] = (byte) ((uint) uint16 & (uint) byte.MaxValue);
              this.db.dat[1610] = (byte) ((index1 & 65280) >> 8);
              this.db.dat[1611] = (byte) (index1 & (int) byte.MaxValue);
              this.db.dat[1738] = (byte) ((index1 & 65280) >> 8);
              this.db.dat[1739] = (byte) (index1 & (int) byte.MaxValue);
              this.db.dat[1612] = (byte) 0;
              this.db.dat[1613] = (byte) 0;
              this.db.dat[1740] = (byte) 0;
              this.db.dat[1741] = (byte) 0;
              this.db.dat[1344 + index1 * 2] = (byte) 0;
              this.db.dat[1344 + index1 * 2 + 1] = (byte) 0;
              numArray[index1] += 2;
            }
          }
        }
      }
    }

    private class MemoryChDir : Database.Converter
    {
      private readonly int ADDR;
      private Database db;

      public MemoryChDir()
      {
      }

      public MemoryChDir(Database db, int address)
      {
        this.db = db;
        this.ADDR = address;
      }

      public void Decode()
      {
        int addr = this.ADDR;
        for (int index = 0; index < this.db.NormalMemory.Count; ++index)
        {
          this.db.NormalMemory[index].MemDel = Convert.ToBoolean((int) this.db.dat[addr] & 1);
          this.db.NormalMemory[index].MemUse = !Convert.ToBoolean(((int) this.db.dat[addr] & 2) >> 1);
          this.db.NormalMemory[index].Skip = ((int) this.db.dat[addr] & 12) >> 2;
          ++addr;
        }
        for (int index = 0; index < this.db.SkipMemory.Count; ++index)
        {
          this.db.SkipMemory[index].MemDel = Convert.ToBoolean((int) this.db.dat[addr] & 1);
          this.db.SkipMemory[index].MemUse = !Convert.ToBoolean(((int) this.db.dat[addr] & 2) >> 1);
          this.db.SkipMemory[index].Skip = ((int) this.db.dat[addr] & 12) >> 2;
          ++addr;
        }
        int index1 = addr + 1;
        for (int index2 = 0; index2 < this.db.PmsMemory.Count; ++index2)
        {
          this.db.PmsMemory[index2].MemDel = Convert.ToBoolean((int) this.db.dat[index1] & 1);
          this.db.PmsMemory[index2].MemUse = !Convert.ToBoolean(((int) this.db.dat[index1] & 2) >> 1);
          this.db.PmsMemory[index2].Skip = ((int) this.db.dat[index1] & 12) >> 2;
          ++index1;
        }
        for (int index2 = 0; index2 < this.db.WxMemory.Count; ++index2)
        {
          this.db.WxMemory[index2].MemDel = true;
          this.db.WxMemory[index2].MemUse = false;
          this.db.WxMemory[index2].Skip = ((int) this.db.dat[index1] & 12) >> 2;
          ++index1;
        }
        for (int index2 = 0; index2 < this.db.VfoMemory.Count; ++index2)
        {
          this.db.VfoMemory[index2].MemDel = true;
          this.db.VfoMemory[index2].MemUse = false;
        }
        for (int index2 = 0; index2 < this.db.HomeMemory.Count; ++index2)
        {
          this.db.HomeMemory[index2].MemDel = true;
          this.db.HomeMemory[index2].MemUse = false;
        }
      }

      public void Encode()
      {
        int addr = this.ADDR;
        for (int index = 0; index < this.db.NormalMemory.Count; ++index)
        {
          this.db.Bitset(addr, Convert.ToInt32(this.db.NormalMemory[index].MemDel), 1);
          this.db.Bitset(addr, Convert.ToInt32(!this.db.NormalMemory[index].MemUse), 2);
          this.db.Bitset(addr, Convert.ToInt32(this.db.NormalMemory[index].Skip), 12);
          ++addr;
        }
        for (int index = 0; index < this.db.SkipMemory.Count; ++index)
        {
          this.db.Bitset(addr, Convert.ToInt32(this.db.SkipMemory[index].MemDel), 1);
          this.db.Bitset(addr, Convert.ToInt32(!this.db.SkipMemory[index].MemUse), 2);
          this.db.Bitset(addr, Convert.ToInt32(this.db.SkipMemory[index].Skip), 12);
          ++addr;
        }
        int address = addr + 1;
        for (int index = 0; index < this.db.PmsMemory.Count; ++index)
        {
          this.db.Bitset(address, Convert.ToInt32(this.db.PmsMemory[index].MemDel), 1);
          this.db.Bitset(address, Convert.ToInt32(!this.db.PmsMemory[index].MemUse), 2);
          this.db.Bitset(address, Convert.ToInt32(this.db.PmsMemory[index].Skip), 12);
          ++address;
        }
        for (int index = 0; index < this.db.WxMemory.Count; ++index)
        {
          this.db.Bitset(address, Convert.ToInt32(this.db.WxMemory[index].Skip), 12);
          ++address;
        }
      }
    }

    private class Digital : Database.Converter
    {
      private readonly int ADDR;
      private Database db;

      public Digital()
      {
      }

      public Digital(Database db, int address)
      {
        this.db = db;
        this.ADDR = address;
      }

      public void Decode()
      {
        int addr = this.ADDR;
        this.db.Digital_SqlType = (int) this.db.dat[addr + 2];
        this.db.Digital_SqlCode = (int) this.db.dat[addr + 3] - 1;
        char[] chArray = new char[10];
        for (int index = 0; index < chArray.Length; ++index)
        {
          if (this.db.dat[addr + 6 + index] != byte.MaxValue)
            chArray[index] = mojiConvert.CnvToCallSignChar(this.db.dat[addr + 6 + index]);
        }
        this.db.Digital_MyCallSign = new string(chArray).Replace("\0", "");
        this.db.Digital_Popup = this.db.dat[addr + 109] != (byte) 0 ? (int) this.db.dat[addr + 109] - 9 : 0;
        this.db.Digital_AmsTxMode = this.db.dat[addr + 178] != (byte) 0 ? (int) this.db.dat[addr + 178] - 1 : 0;
        this.db.Digital_StandbyBeep = (int) this.db.dat[addr + 180];
        this.db.Digital_GmMode = (int) this.db.dat[addr + 181];
        this.db.Digital_DgIdMode = (int) this.db.dat[addr + 182];
        this.db.Digital_NormalDgIdCode = (int) this.db.dat[addr + 183];
        this.db.Digital_SplitDgIdRxCode = (int) this.db.dat[addr + 184];
        this.db.Digital_SplitDgIdTxCode = (int) this.db.dat[addr + 185];
        this.db.Digital_VwMode = (int) this.db.dat[addr + 186];
        this.db.Gm_StatusLed = (int) this.db.dat[addr + 187];
      }

      public void Encode()
      {
        int addr = this.ADDR;
        BandMemory bandMemory = this.db.VfoMemory[6];
        this.db.dat[addr] = bandMemory.Ams != 1 ? (bandMemory.DigAnalog != 0 ? (byte) 1 : (byte) 0) : (byte) 2;
        this.db.dat[addr + 2] = (byte) this.db.Digital_SqlType;
        this.db.dat[addr + 3] = (byte) (this.db.Digital_SqlCode + 1);
        char[] chArray = Database.CnvStringToChar(this.db.Digital_MyCallSign, 10);
        for (int index = 0; index < chArray.Length; ++index)
          this.db.dat[addr + 6 + index] = mojiConvert.CnvToCallSignBin(chArray[index]);
        this.db.dat[addr + 109] = this.db.Digital_Popup != 0 ? (byte) (this.db.Digital_Popup + 9) : (byte) 0;
        this.db.dat[addr + 178] = this.db.Digital_AmsTxMode != 0 ? (byte) (this.db.Digital_AmsTxMode + 1) : (byte) 0;
        this.db.dat[addr + 180] = (byte) this.db.Digital_StandbyBeep;
        this.db.dat[addr + 181] = (byte) 1;
        this.db.dat[addr + 182] = (byte) 1;
        this.db.dat[addr + 183] = (byte) 0;
        this.db.dat[addr + 184] = (byte) this.db.Digital_SplitDgIdRxCode;
        this.db.dat[addr + 185] = (byte) this.db.Digital_SplitDgIdTxCode;
        this.db.dat[addr + 186] = (byte) this.db.Digital_VwMode;
        this.db.dat[addr + 187] = (byte) this.db.Gm_StatusLed;
      }
    }

    private class Dpidinfo : Database.Converter
    {
      private readonly int ADDR;
      private Database db;

      public Dpidinfo()
      {
      }

      public Dpidinfo(Database db, int address)
      {
        this.db = db;
        this.ADDR = address;
      }

      public void Decode()
      {
        Array.Copy((Array) this.db.dat, this.ADDR, (Array) this.db.Dpidinfo_data, 0, this.db.Dpidinfo_data.Length);
      }

      public void Encode()
      {
        Array.Copy((Array) this.db.Dpidinfo_data, 0, (Array) this.db.dat, this.ADDR, this.db.Dpidinfo_data.Length);
      }
    }
  }
}
