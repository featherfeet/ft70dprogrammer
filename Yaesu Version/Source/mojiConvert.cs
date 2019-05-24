// Decompiled with JetBrains decompiler
// Type: ADMS10.mojiConvert
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System.Text;

namespace ADMS10
{
  public class mojiConvert
  {
    private static readonly char[] tbl_MemoryNameHankaku = new char[256]
    {
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      ' ',
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      '$',
      '%',
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      '*',
      '+',
      ',',
      '-',
      char.MaxValue,
      '/',
      '0',
      '1',
      '2',
      '3',
      '4',
      '5',
      '6',
      '7',
      '8',
      '9',
      ':',
      char.MaxValue,
      '<',
      '=',
      '>',
      char.MaxValue,
      '@',
      'A',
      'B',
      'C',
      'D',
      'E',
      'F',
      'G',
      'H',
      'I',
      'J',
      'K',
      'L',
      'M',
      'N',
      'O',
      'P',
      'Q',
      'R',
      'S',
      'T',
      'U',
      'V',
      'W',
      'X',
      'Y',
      'Z',
      '[',
      '\\',
      ']',
      char.MaxValue,
      '_',
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      '⊔',
      'Ω',
      'Δ',
      'μ',
      'Σ',
      '○',
      '※',
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue
    };
    private static readonly char[] tbl_CallSign = new char[256]
    {
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      '-',
      char.MaxValue,
      '/',
      '0',
      '1',
      '2',
      '3',
      '4',
      '5',
      '6',
      '7',
      '8',
      '9',
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      'A',
      'B',
      'C',
      'D',
      'E',
      'F',
      'G',
      'H',
      'I',
      'J',
      'K',
      'L',
      'M',
      'N',
      'O',
      'P',
      'Q',
      'R',
      'S',
      'T',
      'U',
      'V',
      'W',
      'X',
      'Y',
      'Z',
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue,
      char.MaxValue
    };
    private static readonly char[] tbl_Dtmf = new char[17]
    {
      '0',
      '1',
      '2',
      '3',
      '4',
      '5',
      '6',
      '7',
      '8',
      '9',
      'A',
      'B',
      'C',
      'D',
      '*',
      '#',
      '-'
    };
    private static readonly char[] tbl_PW = new char[16]
    {
      '0',
      '1',
      '2',
      '3',
      '4',
      '5',
      '6',
      '7',
      '8',
      '9',
      'A',
      'B',
      'C',
      'D',
      '*',
      '#'
    };
    private Encoding jisEnc = Encoding.GetEncoding("iso-2022-jp");
    private const char NON = '\xFFFF';

    public static bool IsCallSign(char c)
    {
      for (int index = 0; index < mojiConvert.tbl_CallSign.Length; ++index)
      {
        if ((int) c == (int) mojiConvert.tbl_CallSign[index])
          return c != char.MaxValue;
      }
      return false;
    }

    public static bool IsDtmf(char c)
    {
      for (int index = 0; index < mojiConvert.tbl_Dtmf.Length; ++index)
      {
        if ((int) c == (int) mojiConvert.tbl_Dtmf[index])
          return c != char.MaxValue;
      }
      return false;
    }

    public static bool IsPW(char c)
    {
      for (int index = 0; index < mojiConvert.tbl_PW.Length; ++index)
      {
        if ((int) c == (int) mojiConvert.tbl_PW[index])
          return c != char.MaxValue;
      }
      return false;
    }

    public static bool IsMemoryNameChar(char c)
    {
      for (int index = 0; index < mojiConvert.tbl_MemoryNameHankaku.Length; ++index)
      {
        if ((int) c == (int) mojiConvert.tbl_MemoryNameHankaku[index])
          return c != char.MaxValue;
      }
      return false;
    }

    public static char CnvToCallSignChar(byte b)
    {
      return mojiConvert.tbl_CallSign[(int) b];
    }

    public static char CnvToMemoryNameChar(byte b)
    {
      return mojiConvert.tbl_MemoryNameHankaku[(int) b];
    }

    public static char CnvToPasswordChar(byte b)
    {
      return mojiConvert.tbl_PW[(int) b];
    }

    public static char CnvToDtmfChar(byte b)
    {
      return mojiConvert.tbl_Dtmf[(int) b];
    }

    public static byte CnvToCallSignBin(char c)
    {
      for (int index = 0; index < mojiConvert.tbl_CallSign.Length; ++index)
      {
        if ((int) c == (int) mojiConvert.tbl_CallSign[index])
          return (byte) index;
      }
      return byte.MaxValue;
    }

    public static byte CnvToMemoryNameBin(char c)
    {
      for (int index = 0; index < mojiConvert.tbl_MemoryNameHankaku.Length; ++index)
      {
        if ((int) c == (int) mojiConvert.tbl_MemoryNameHankaku[index])
          return (byte) index;
      }
      return byte.MaxValue;
    }

    public static byte CnvToPasswordBin(char c)
    {
      for (int index = 0; index < mojiConvert.tbl_PW.Length; ++index)
      {
        if ((int) c == (int) mojiConvert.tbl_PW[index])
          return (byte) index;
      }
      return byte.MaxValue;
    }

    public static byte CnvToDtmfBin(char c)
    {
      for (int index = 0; index < mojiConvert.tbl_Dtmf.Length; ++index)
      {
        if ((int) c == (int) mojiConvert.tbl_Dtmf[index])
          return (byte) index;
      }
      return byte.MaxValue;
    }

    public static char CnvToUppercase(char c)
    {
      if (c >= 'a' && 'z' >= c)
        c -= ' ';
      return c;
    }
  }
}
