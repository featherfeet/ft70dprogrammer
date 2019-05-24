// Decompiled with JetBrains decompiler
// Type: ADMS10.Logger
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.Collections.Generic;
using System.IO;

namespace ADMS10
{
  public class Logger
  {
    private List<Logger.log> loggers = new List<Logger.log>();
    private static DateTime dt;
    private static string TxRx;

    public Logger(Database db, string txrx)
    {
      Logger.TxRx = txrx;
      Logger.dt = DateTime.Now;
      this.loggers.Add(new Logger.log(db, "Full", 0, 65216));
      this.loggers.Add(new Logger.log(db, "BandSnglBakBak", 64, 512));
      this.loggers.Add(new Logger.log(db, "Setmode", 1088, 384));
      this.loggers.Add(new Logger.log(db, "BandCmn", 1472, 64));
      this.loggers.Add(new Logger.log(db, "BandCmnBak", 1536, 64));
      this.loggers.Add(new Logger.log(db, "BandSngl", 1600, 128));
      this.loggers.Add(new Logger.log(db, "BandSnglBak", 1728, 128));
      this.loggers.Add(new Logger.log(db, "Dtmf", 2368, 256));
      this.loggers.Add(new Logger.log(db, "WxAN", 3648, 180));
      this.loggers.Add(new Logger.log(db, "BankName", 3828, 460));
      this.loggers.Add(new Logger.log(db, "MomoryChDir", 10240, 1344));
      this.loggers.Add(new Logger.log(db, "Home", 4288, 384));
      this.loggers.Add(new Logger.log(db, "Vfo", 4672, 384));
      this.loggers.Add(new Logger.log(db, "BankChNum", 5440, 4800));
      this.loggers.Add(new Logger.log(db, "MemoryNorm", 11584, 28800));
      this.loggers.Add(new Logger.log(db, "MemorySkip", 40384, 3200));
      this.loggers.Add(new Logger.log(db, "MemoryPms", 43584, 3200));
      this.loggers.Add(new Logger.log(db, "Digital", 52928, 384));
      this.loggers.Add(new Logger.log(db, "Dpidinfo", 56000, 384));
    }

    public void Save()
    {
      foreach (Logger.log logger in this.loggers)
        logger.Save();
    }

    private class log
    {
      private Database db;
      private string filename;
      private int offset;
      private int size;

      public log()
      {
      }

      public log(Database db, string filename, int offset, int size)
      {
        this.db = db;
        this.filename = filename;
        this.offset = offset;
        this.size = size;
      }

      public void Save()
      {
        string path = this.path() + "//" + Logger.TxRx + "_" + Logger.dt.ToString("yyyyMMdd_HHmm") + "//";
        Directory.CreateDirectory(path);
        byte[] bytes = new byte[this.size];
        Array.Copy((Array) this.db.Buffer, this.offset, (Array) bytes, 0, this.size);
        File.WriteAllBytes(path + this.filename + ".bin", bytes);
      }

      private string path()
      {
        return Directory.GetCurrentDirectory() + "\\log\\";
      }
    }
  }
}
