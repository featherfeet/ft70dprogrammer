// Decompiled with JetBrains decompiler
// Type: ADMS10.Debugger
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.IO;
using System.Xml.Serialization;

namespace ADMS10
{
  [Serializable]
  public class Debugger
  {
    private bool _defaultUpdate;
    private bool _datalogger;
    private bool _localDistribution;
    [NonSerialized]
    private static Debugger _instance;

    public bool DefaultUpdate
    {
      get
      {
        return this._defaultUpdate;
      }
      set
      {
        this._defaultUpdate = value;
      }
    }

    public bool Datalogger
    {
      get
      {
        return this._datalogger;
      }
      set
      {
        this._datalogger = value;
      }
    }

    [XmlIgnore]
    public bool localDistribution
    {
      get
      {
        return this._localDistribution;
      }
      set
      {
        this._localDistribution = value;
      }
    }

    public Debugger()
    {
      this._defaultUpdate = false;
      this._datalogger = false;
      this._localDistribution = true;
    }

    [XmlIgnore]
    public static Debugger Instance
    {
      get
      {
        if (Debugger._instance == null)
          Debugger._instance = new Debugger();
        return Debugger._instance;
      }
      set
      {
        Debugger._instance = value;
      }
    }

    public static void LoadFromXmlFile()
    {
      string path = Debugger.settingPath();
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (Debugger));
      FileStream fileStream = new FileStream(path, FileMode.Open);
      object obj = (object) (Debugger) xmlSerializer.Deserialize((Stream) fileStream);
      fileStream.Close();
      Debugger.Instance = (Debugger) obj;
    }

    public static void SaveToXmlFile()
    {
      string path = Debugger.settingPath();
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (Debugger));
      FileStream fileStream = new FileStream(path, FileMode.Create);
      xmlSerializer.Serialize((Stream) fileStream, (object) Debugger.Instance);
      fileStream.Close();
    }

    private static string settingPath()
    {
      return Directory.GetCurrentDirectory() + "\\bin\\debugger.xml";
    }
  }
}
