// Decompiled with JetBrains decompiler
// Type: ADMS10.FObject
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;

namespace ADMS10
{
  [Serializable]
  public class FObject
  {
    public byte[] buffer = new byte[65216];
    public string[] NormalMemCmnt = new string[900];
    public string[] SkipMemCmnt = new string[99];
    public string[] PmsMemCmnt = new string[100];
    public string[] HomeMemCmnt = new string[11];
    public string[] VfoMemCmnt = new string[11];
    public string[] WxMemCmnt = new string[10];
  }
}
