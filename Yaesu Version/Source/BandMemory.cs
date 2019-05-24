// Decompiled with JetBrains decompiler
// Type: ADMS10.BandMemory
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;

namespace ADMS10
{
  public class BandMemory
  {
    public bool PriorityCH { get; set; }

    public Decimal RxFrq { get; set; }

    public Decimal TxFrq { get; set; }

    public Decimal ShiftFrq { get; set; }

    public int ShiftDir { get; set; }

    public int Mode { get; set; }

    public bool AutoMode { get; set; }

    public int Ams { get; set; }

    public int DigAnalog { get; set; }

    public string MemName { get; set; }

    public int SqlType { get; set; }

    public int ToneFrq { get; set; }

    public int PrTone { get; set; }

    public int DcsCode { get; set; }

    public int DcsDim { get; set; }

    public int TxOut { get; set; }

    public int Skip { get; set; }

    public int Step { get; set; }

    public bool AutoStep { get; set; }

    public bool Tag { get; set; }

    public bool MemDel { get; set; }

    public bool MemUse { get; set; }

    public bool Att { get; set; }

    public int Smeter { get; set; }

    public int Bell { get; set; }

    public int Vibrator { get; set; }

    public bool HarfDev { get; set; }

    public bool ClockShift { get; set; }

    public bool[] Bank { get; set; }

    public string Comment { get; set; }

    public BandMemory()
    {
      this.Bank = new bool[24];
    }
  }
}
