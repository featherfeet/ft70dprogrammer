// Decompiled with JetBrains decompiler
// Type: ADMS10.KeyPressCancel
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System.Windows.Forms;

namespace ADMS10
{
  public class KeyPressCancel
  {
    public static void txt_Freq_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar >= '0' && '9' >= e.KeyChar || (e.KeyChar == '.' || e.KeyChar == '\b'))
        return;
      e.Handled = true;
    }

    public static void txt_GmCallSign_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!mojiConvert.IsCallSign(e.KeyChar) && (e.KeyChar < 'a' || 'z' < e.KeyChar) && e.KeyChar != '\b')
        e.Handled = true;
      else
        e.KeyChar = mojiConvert.CnvToUppercase(e.KeyChar);
    }

    public static void txt_Dtmf_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!mojiConvert.IsDtmf(e.KeyChar) && (e.KeyChar < 'a' || 'd' < e.KeyChar) && e.KeyChar != '\b')
        e.Handled = true;
      else
        e.KeyChar = mojiConvert.CnvToUppercase(e.KeyChar);
    }

    public static void txt_PassWord_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!mojiConvert.IsPW(e.KeyChar) && (e.KeyChar < 'a' || 'd' < e.KeyChar) && e.KeyChar != '\b')
        e.Handled = true;
      else
        e.KeyChar = mojiConvert.CnvToUppercase(e.KeyChar);
    }

    public static void txt_MemoryName_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!mojiConvert.IsMemoryNameChar(e.KeyChar) && (e.KeyChar < 'a' || 'z' < e.KeyChar) && e.KeyChar != '\b')
        e.Handled = true;
      else
        e.KeyChar = mojiConvert.CnvToUppercase(e.KeyChar);
    }
  }
}
