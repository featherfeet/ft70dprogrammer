// Decompiled with JetBrains decompiler
// Type: ADMS10.Settings
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ADMS10
{
  [Serializable]
  public class Settings
  {
    public const int cpuUSA = 0;
    public const int cpuJPN = 1;
    public const int cpuEXP = 2;
    public const int cntryF = 0;
    public const int cntryA = 1;
    public const int cntryB = 2;
    public const int cntryC = 3;
    public const int cntryD = 4;
    public const int cntryH = 5;
    public const int cntryFREE = 6;
    public const int cntryHAM = 7;
    public const int RxExp_X1 = 0;
    public const int RxExp_X2X3 = 1;
    public const int ExpSW_OFF = 0;
    public const int ExpSW_ON = 1;
    public const int expX1 = 0;
    public const int expX2 = 1;
    public const int expX3 = 2;
    public const int F3JP = 0;
    public const int F2JP = 1;
    public const int A1US = 2;
    public const int A2US = 3;
    public const int A3US = 4;
    public const int A1 = 5;
    public const int A2 = 6;
    public const int A3 = 7;
    public const int B1 = 8;
    public const int B2 = 9;
    public const int B3 = 10;
    public const int C1 = 11;
    public const int C2 = 12;
    public const int C3 = 13;
    public const int D1 = 14;
    public const int D2 = 15;
    public const int D3 = 16;
    public const int F1 = 17;
    public const int F2 = 18;
    public const int F3 = 19;
    public const int H1 = 20;
    public const int H2 = 21;
    public const int H3 = 22;
    public const int FREE = 23;
    public const int HAM = 24;
    public const int lngJPN = 0;
    public const int lngENG = 1;
    private const string FILE_NAME = "config.xml";
    private const string FILE_FOLDER_SWITCH = "useAppData";
    private int _cpuType;
    private int _countryType;
    private int _expType;
    private int _expSW;
    private int _destination;
    private int _language;
    private string _comPortName;
    private bool _recv_flg;
    public bool Recv_flg;
    [NonSerialized]
    private static Settings _instance;

    public int CpuType
    {
      get
      {
        return this._cpuType;
      }
      set
      {
        this._cpuType = value;
      }
    }

    public int CountryType
    {
      get
      {
        return this._countryType;
      }
      set
      {
        this._countryType = value;
      }
    }

    public int ExpType
    {
      get
      {
        return this._expType;
      }
      set
      {
        this._expType = value;
      }
    }

    [XmlIgnore]
    public int ExpSW
    {
      get
      {
        return this._expSW;
      }
      set
      {
        this._expSW = value;
      }
    }

    [XmlIgnore]
    public int Destination
    {
      get
      {
        int cpuType = this._cpuType;
        int countryType = this._countryType;
        int expType = this._expType;
        int destination = this._destination;
        int num;
        switch (cpuType)
        {
          case 0:
            switch (expType)
            {
              case 0:
                num = 2;
                break;
              case 1:
                num = 3;
                break;
              default:
                num = 4;
                break;
            }
            break;
          case 1:
            num = expType != 1 ? 0 : 1;
            break;
          default:
            switch (countryType)
            {
              case 0:
                switch (expType)
                {
                  case 0:
                    num = 17;
                    break;
                  case 1:
                    num = 18;
                    break;
                  default:
                    num = 19;
                    break;
                }
                break;
              case 1:
                switch (expType)
                {
                  case 0:
                    num = 5;
                    break;
                  case 1:
                    num = 6;
                    break;
                  default:
                    num = 7;
                    break;
                }
                break;
              case 2:
                switch (expType)
                {
                  case 0:
                    num = 8;
                    break;
                  case 1:
                    num = 9;
                    break;
                  default:
                    num = 10;
                    break;
                }
                break;
              case 3:
                switch (expType)
                {
                  case 0:
                    num = 11;
                    break;
                  case 1:
                    num = 12;
                    break;
                  default:
                    num = 13;
                    break;
                }
                break;
              case 4:
                switch (expType)
                {
                  case 0:
                    num = 14;
                    break;
                  case 1:
                    num = 15;
                    break;
                  default:
                    num = 16;
                    break;
                }
                break;
              case 5:
                switch (expType)
                {
                  case 0:
                    num = 20;
                    break;
                  case 1:
                    num = 21;
                    break;
                  default:
                    num = 22;
                    break;
                }
                break;
              case 6:
                num = 23;
                break;
              case 7:
                num = 24;
                break;
              default:
                num = 23;
                break;
            }
            break;
        }
        this._destination = num;
        return this._destination;
      }
      set
      {
      }
    }

    [XmlIgnore]
    public int Language
    {
      get
      {
        return this._language;
      }
      set
      {
        this._language = value;
      }
    }

    public string ComPortName
    {
      get
      {
        return this._comPortName;
      }
      set
      {
        this._comPortName = value;
      }
    }

    public Settings()
    {
      this._cpuType = 0;
      this._countryType = 0;
      this._expType = 0;
      this._destination = 0;
      this._comPortName = "COM1";
    }

    [XmlIgnore]
    public static Settings Instance
    {
      get
      {
        if (Settings._instance == null)
          Settings._instance = new Settings();
        return Settings._instance;
      }
      set
      {
        Settings._instance = value;
      }
    }

    public static void LoadFromXmlFile()
    {
      Settings.LoadLanguage();
      string path = Settings.settingPath();
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (Settings));
      FileStream fileStream = new FileStream(path, FileMode.Open);
      object obj = (object) (Settings) xmlSerializer.Deserialize((Stream) fileStream);
      fileStream.Close();
      Settings.Instance = (Settings) obj;
      Settings.LoadLanguage();
    }

    public static void SaveToXmlFile()
    {
      string path = Settings.settingPath();
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (Settings));
      FileStream fileStream = new FileStream(path, FileMode.Create);
      xmlSerializer.Serialize((Stream) fileStream, (object) Settings.Instance);
      fileStream.Close();
    }

    private static void LoadLanguage()
    {
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(Directory.GetCurrentDirectory() + "/bin/language.xml");
      string s = "0";
      foreach (XmlNode xmlNode in (XmlNode) xmlDocument.DocumentElement)
        s = xmlNode.InnerText;
      Settings.Instance.Language = int.Parse(s);
    }

    private static string settingPath()
    {
        return Directory.GetCurrentDirectory() + "/config.xml";
    }
  }
}
