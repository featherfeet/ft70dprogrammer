// Decompiled with JetBrains decompiler
// Type: ADMS10.DefaultFile
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.IO;

namespace ADMS10
{
  [Serializable]
  public class DefaultFile
  {
    public readonly string[] DEFAULTFILENAME = new string[2]
    {
      "default_jp.dat",
      "default_en.dat"
    };
    private byte[] _defaultBuffer;

    public byte[] DefaultBuffer
    {
      get
      {
        return this._defaultBuffer;
      }
      set
      {
        this._defaultBuffer = value;
      }
    }

    public DefaultFile()
    {
      this._defaultBuffer = new byte[65216];
    }

    public void LoadFromDefaultFile()
    {
      FileStream fileStream = new FileStream(this.defaultPath(), FileMode.Open, FileAccess.Read);
      fileStream.Read(this._defaultBuffer, 0, this._defaultBuffer.Length);
      fileStream.Close();
    }

    public void SaveFromDefaultFile()
    {
      new FileStream(this.defaultPath(), FileMode.Create, FileAccess.Write).Write(this._defaultBuffer, 0, this._defaultBuffer.Length);
    }

    private string defaultPath()
    {
      return Directory.GetCurrentDirectory() + "/bin/" + this.DEFAULTFILENAME[Settings.Instance.Language];
    }
  }
}
