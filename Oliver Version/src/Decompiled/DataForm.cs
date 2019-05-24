// Decompiled with JetBrains decompiler
// Type: ADMS10.DataForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Resources;

public class DataForm
{
  public static string[] tbl_Wx_Freq = new string[10]
  {
    "162.550 ",
    "162.400 ",
    "162.475 ",
    "162.425 ",
    "162.450 ",
    "162.500 ",
    "162.525 ",
    "161.650 ",
    "161.775 ",
    "163.275 "
  };
  public static string[] tbl_Step = new string[11]
  {
    "5.0KHz",
    "6.25KHz",
    "8.33KHz",
    "10.0KHz",
    "12.5KHz",
    "15.0KHz",
    "20.0KHz",
    "25.0KHz",
    "50.0KHz",
    "100.0KHz",
    "9.0KHz"
  };
  public static string[] tbl_Step_no_air = new string[9]
  {
    "5.0KHz",
    "6.25KHz",
    "10.0KHz",
    "12.5KHz",
    "15.0KHz",
    "20.0KHz",
    "25.0KHz",
    "50.0KHz",
    "100.0KHz"
  };
  public static string[] tbl_Step_air = new string[10]
  {
    "5.0KHz",
    "6.25KHz",
    "8.33KHz",
    "10.0KHz",
    "12.5KHz",
    "15.0KHz",
    "20.0KHz",
    "25.0KHz",
    "50.0KHz",
    "100.0KHz"
  };
  public static Decimal[] tbl_StepDec = new Decimal[11]
  {
    new Decimal(5, 0, 0, false, (byte) 3),
    new Decimal(625, 0, 0, false, (byte) 5),
    new Decimal(833, 0, 0, false, (byte) 5),
    new Decimal(1, 0, 0, false, (byte) 2),
    new Decimal(125, 0, 0, false, (byte) 4),
    new Decimal(15, 0, 0, false, (byte) 3),
    new Decimal(2, 0, 0, false, (byte) 2),
    new Decimal(25, 0, 0, false, (byte) 3),
    new Decimal(5, 0, 0, false, (byte) 2),
    new Decimal(1, 0, 0, false, (byte) 1),
    new Decimal(9, 0, 0, false, (byte) 3)
  };
  public static object[,] tbl_Default_Jpn = new object[6, 52]
  {
    {
      (object) false,
      (object) "108.00000",
      (object) "108.00000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "AM",
      (object) "OFF",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "88.5 Hz",
      (object) "023",
      (object) "RX同相 TX同相",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "25.0KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    },
    {
      (object) false,
      (object) "145.00000",
      (object) "145.00000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "FM",
      (object) "ON",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "88.5 Hz",
      (object) "023",
      (object) "RX同相 TX同相",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "20.0KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    },
    {
      (object) false,
      (object) "175.75000",
      (object) "175.75000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "FM",
      (object) "OFF",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "88.5 Hz",
      (object) "023",
      (object) "RX同相 TX同相",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "50.0KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    },
    {
      (object) false,
      (object) "380.00000",
      (object) "380.00000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "FM",
      (object) "OFF",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "88.5 Hz",
      (object) "023",
      (object) "RX同相 TX同相",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "12.5KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    },
    {
      (object) false,
      (object) "433.00000",
      (object) "433.00000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "FM",
      (object) "ON",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "88.5 Hz",
      (object) "023",
      (object) "RX同相 TX同相",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "20.0KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    },
    {
      (object) false,
      (object) "481.00000",
      (object) "481.00000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "FM",
      (object) "OFF",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "88.5 Hz",
      (object) "023",
      (object) "RX同相 TX同相",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "50.0KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    }
  };
  public static object[,] tbl_Default_Eng = new object[6, 52]
  {
    {
      (object) false,
      (object) "108.00000",
      (object) "108.00000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "AM",
      (object) "OFF",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "100.0 Hz",
      (object) "023",
      (object) "RX Normal TX Normal",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "25.0KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    },
    {
      (object) false,
      (object) "145.00000",
      (object) "145.00000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "FM",
      (object) "ON",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "100.0 Hz",
      (object) "023",
      (object) "RX Normal TX Normal",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "20.0KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    },
    {
      (object) false,
      (object) "175.75000",
      (object) "175.75000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "FM",
      (object) "OFF",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "100.0 Hz",
      (object) "023",
      (object) "RX Normal TX Normal",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "50.0KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    },
    {
      (object) false,
      (object) "380.00000",
      (object) "380.00000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "FM",
      (object) "OFF",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "100.0 Hz",
      (object) "023",
      (object) "RX Normal TX Normal",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "12.5KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    },
    {
      (object) false,
      (object) "433.00000",
      (object) "433.00000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "FM",
      (object) "ON",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "100.0 Hz",
      (object) "023",
      (object) "RX Normal TX Normal",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "20.0KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    },
    {
      (object) false,
      (object) "481.00000",
      (object) "481.00000",
      (object) "0.00000",
      (object) "OFF",
      (object) true,
      (object) "FM",
      (object) "OFF",
      (object) "ANALOG",
      (object) "",
      (object) "OFF",
      (object) "100.0 Hz",
      (object) "023",
      (object) "RX Normal TX Normal",
      (object) "1600 Hz",
      (object) "HIGH",
      (object) "OFF",
      (object) true,
      (object) "50.0KHz",
      (object) false,
      (object) false,
      (object) false,
      (object) "OFF",
      (object) "OFF",
      (object) "OFF",
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) false,
      (object) ""
    }
  };
  public static readonly Decimal[,,] tbl_Freq = new Decimal[6, 25, 4]
  {
    {
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      }
    },
    {
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(14400000, 0, 0, false, (byte) 5),
        new Decimal(14800000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(14400000, 0, 0, false, (byte) 5),
        new Decimal(14800000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(14400000, 0, 0, false, (byte) 5),
        new Decimal(14600000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(14400000, 0, 0, false, (byte) 5),
        new Decimal(14600000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(14400000, 0, 0, false, (byte) 5),
        new Decimal(14600000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(14400000, 0, 0, false, (byte) 5),
        new Decimal(14600000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(14400000, 0, 0, false, (byte) 5),
        new Decimal(14800000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(13700000, 0, 0, false, (byte) 5),
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(14400000, 0, 0, false, (byte) 5),
        new Decimal(14600001, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      }
    },
    {
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(17400000, 0, 0, false, (byte) 5),
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      }
    },
    {
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(22200000, 0, 0, false, (byte) 5),
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      }
    },
    {
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(43000000, 0, 0, false, (byte) 5),
        new Decimal(45000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(43000000, 0, 0, false, (byte) 5),
        new Decimal(45000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(43000000, 0, 0, false, (byte) 5),
        new Decimal(44000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(43000000, 0, 0, false, (byte) 5),
        new Decimal(44000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(43200000, 0, 0, false, (byte) 5),
        new Decimal(43800000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(43000000, 0, 0, false, (byte) 5),
        new Decimal(44000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(43000000, 0, 0, false, (byte) 5),
        new Decimal(45000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(42000000, 0, 0, false, (byte) 5),
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(43000000, 0, 0, false, (byte) 5),
        new Decimal(44000001, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      }
    },
    {
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      },
      {
        new Decimal(47000000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5),
        new Decimal(10800000, 0, 0, false, (byte) 5),
        new Decimal(58000000, 0, 0, false, (byte) 5)
      }
    }
  };
  public static readonly Decimal[] tbl_Add833KHz = new Decimal[12]
  {
    new Decimal(0, 0, 0, false, (byte) 5),
    new Decimal(833, 0, 0, false, (byte) 5),
    new Decimal(1666, 0, 0, false, (byte) 5),
    new Decimal(2500, 0, 0, false, (byte) 5),
    new Decimal(3333, 0, 0, false, (byte) 5),
    new Decimal(4166, 0, 0, false, (byte) 5),
    new Decimal(5000, 0, 0, false, (byte) 5),
    new Decimal(5833, 0, 0, false, (byte) 5),
    new Decimal(6666, 0, 0, false, (byte) 5),
    new Decimal(7500, 0, 0, false, (byte) 5),
    new Decimal(8333, 0, 0, false, (byte) 5),
    new Decimal(9166, 0, 0, false, (byte) 5)
  };
  public static readonly Decimal[] tbl_Check_Add833KHz = new Decimal[12]
  {
    new Decimal(0, 0, 0, false, (byte) 5),
    new Decimal(33, 0, 0, false, (byte) 5),
    new Decimal(66, 0, 0, false, (byte) 5),
    new Decimal(2500, 0, 0, false, (byte) 5),
    new Decimal(3300, 0, 0, false, (byte) 5),
    new Decimal(4100, 0, 0, false, (byte) 5),
    new Decimal(5000, 0, 0, false, (byte) 5),
    new Decimal(5800, 0, 0, false, (byte) 5),
    new Decimal(6600, 0, 0, false, (byte) 5),
    new Decimal(7500, 0, 0, false, (byte) 5),
    new Decimal(8300, 0, 0, false, (byte) 5),
    new Decimal(9100, 0, 0, false, (byte) 5)
  };
  public static readonly bool[,] tbl_ReadOnlyCell = new bool[6, 25]
  {
    {
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      false,
      true
    },
    {
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false
    },
    {
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      false,
      true
    },
    {
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      false,
      true
    },
    {
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false,
      false
    },
    {
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      true,
      false,
      false,
      false,
      true
    }
  };
  public string[] tbl_BandName = new string[12]
  {
    "AMラジオ",
    "短波",
    "50MHz帯",
    "FMラジオ",
    "未使用",
    "エアバンド",
    "144MHz帯",
    "その他VHF帯",
    "情報無線帯1",
    "430MHz帯",
    "その他UHF帯",
    "情報無線帯2"
  };
  public string[] tbl_BandName_eng = new string[12]
  {
    "AM BC Band",
    "SW Band",
    "50MHz Band",
    "FM BC Band",
    "未使用",
    "AIR Band",
    "144MHz Band",
    "VHF Band",
    "INFO Band1",
    "430MHz Band",
    "UHF Band",
    "INFO Band2"
  };
  public string[] tbl_ShiftDir = new string[4]
  {
    "OFF",
    "-RPT",
    "+RPT",
    "-/+"
  };
  public string[] tbl_ShiftDir_Vfo = new string[3]
  {
    "OFF",
    "-RPT",
    "+RPT"
  };
  public string[] tbl_Mode = new string[3]
  {
    "FM",
    "AM",
    "WFM"
  };
  public string[] tbl_Mode_no_fm = new string[2]
  {
    "FM",
    "AM"
  };
  public string[] tbl_Ams = new string[2]{ "OFF", "ON" };
  public string[] tbl_DigAnalog = new string[3]
  {
    "ANALOG",
    "DN",
    "VW"
  };
  public string[] tbl_DigAnalog_VwOff = new string[2]
  {
    "ANALOG",
    "DN"
  };
  public string[] tbl_SqlType = new string[12]
  {
    "OFF",
    "TONE",
    "TONE SQL",
    "DCS",
    "REV TONE",
    "JR FREQ",
    "PR FREQ",
    "PAGER",
    "-----",
    "D CD",
    "TONE-DCS",
    "D CD-TONE"
  };
  public string[] tbl_SqlType_ExOff_JPN = new string[8]
  {
    "OFF",
    "TONE",
    "TONE SQL",
    "DCS",
    "REV TONE",
    "JR FREQ",
    "PR FREQ",
    "PAGER"
  };
  public string[] tbl_SqlType_ExOn_JPN = new string[11]
  {
    "OFF",
    "TONE",
    "TONE SQL",
    "DCS",
    "REV TONE",
    "JR FREQ",
    "PR FREQ",
    "PAGER",
    "D CD",
    "TONE-DCS",
    "D CD-TONE"
  };
  public string[] tbl_SqlType_ExOff_NonJPN = new string[7]
  {
    "OFF",
    "TONE",
    "TONE SQL",
    "DCS",
    "REV TONE",
    "PR FREQ",
    "PAGER"
  };
  public string[] tbl_SqlType_ExOn_NonJPN = new string[10]
  {
    "OFF",
    "TONE",
    "TONE SQL",
    "DCS",
    "REV TONE",
    "PR FREQ",
    "PAGER",
    "D CD",
    "TONE-DCS",
    "D CD-TONE"
  };
  public string[] tbl_ToneFrq = new string[50]
  {
    "67.0 Hz",
    "69.3 Hz",
    "71.9 Hz",
    "74.4 Hz",
    "77.0 Hz",
    "79.7 Hz",
    "82.5 Hz",
    "85.4 Hz",
    "88.5 Hz",
    "91.5 Hz",
    "94.8 Hz",
    "97.4 Hz",
    "100.0 Hz",
    "103.5 Hz",
    "107.2 Hz",
    "110.9 Hz",
    "114.8 Hz",
    "118.8 Hz",
    "123.0 Hz",
    "127.3 Hz",
    "131.8 Hz",
    "136.5 Hz",
    "141.3 Hz",
    "146.2 Hz",
    "151.4 Hz",
    "156.7 Hz",
    "159.8 Hz",
    "162.2 Hz",
    "165.5 Hz",
    "167.9 Hz",
    "171.3 Hz",
    "173.8 Hz",
    "177.3 Hz",
    "179.9 Hz",
    "183.5 Hz",
    "186.2 Hz",
    "189.9 Hz",
    "192.8 Hz",
    "196.6 Hz",
    "199.5 Hz",
    "203.5 Hz",
    "206.5 Hz",
    "210.7 Hz",
    "218.1 Hz",
    "225.7 Hz",
    "229.1 Hz",
    "233.6 Hz",
    "241.8 Hz",
    "250.3 Hz",
    "254.1 Hz"
  };
  public string[] tbl_DcsCode = new string[104]
  {
    "023",
    "025",
    "026",
    "031",
    "032",
    "036",
    "043",
    "047",
    "051",
    "053",
    "054",
    "065",
    "071",
    "072",
    "073",
    "074",
    "114",
    "115",
    "116",
    "122",
    "125",
    "131",
    "132",
    "134",
    "143",
    "145",
    "152",
    "155",
    "156",
    "162",
    "165",
    "172",
    "174",
    "205",
    "212",
    "223",
    "225",
    "226",
    "243",
    "244",
    "245",
    "246",
    "251",
    "252",
    "255",
    "261",
    "263",
    "265",
    "266",
    "271",
    "274",
    "306",
    "311",
    "315",
    "325",
    "331",
    "332",
    "343",
    "346",
    "351",
    "356",
    "364",
    "365",
    "371",
    "411",
    "412",
    "413",
    "423",
    "431",
    "432",
    "445",
    "446",
    "452",
    "454",
    "455",
    "462",
    "464",
    "465",
    "466",
    "503",
    "506",
    "516",
    "523",
    "526",
    "532",
    "546",
    "565",
    "606",
    "612",
    "624",
    "627",
    "631",
    "632",
    "654",
    "662",
    "664",
    "703",
    "712",
    "723",
    "731",
    "732",
    "734",
    "743",
    "754"
  };
  public string[] tbl_DcsDim = new string[6]
  {
    "RX同相 TX同相",
    "RX反転 TX同相",
    "RX両相 TX同相",
    "RX同相 TX反転",
    "RX反転 TX反転",
    "RX両相 TX反転"
  };
  public string[] tbl_DcsDim_eng = new string[6]
  {
    "RX Normal TX Normal",
    "RX Invert TX Normal",
    "RX Both   TX Normal",
    "RX Normal TX Invert",
    "RX Invert TX Invert",
    "RX Both   TX Invert"
  };
  public string[] tbl_PrTone = new string[28]
  {
    "300 Hz",
    "400 Hz",
    "500 Hz",
    "600 Hz",
    "700 Hz",
    "800 Hz",
    "900 Hz",
    "1000 Hz",
    "1100 Hz",
    "1200 Hz",
    "1300 Hz",
    "1400 Hz",
    "1500 Hz",
    "1600 Hz",
    "1700 Hz",
    "1800 Hz",
    "1900 Hz",
    "2000 Hz",
    "2100 Hz",
    "2200 Hz",
    "2300 Hz",
    "2400 Hz",
    "2500 Hz",
    "2600 Hz",
    "2700 Hz",
    "2800 Hz",
    "2900 Hz",
    "3000 Hz"
  };
  public string[] tbl_TxOutput = new string[3]
  {
    "LOW",
    "MID",
    "HIGH"
  };
  public string[] tbl_Skip = new string[3]
  {
    "OFF",
    "SKIP",
    "SELECT"
  };
  public string[] tbl_Smeter = new string[10]
  {
    "OFF",
    "Level 1",
    "Level 2",
    "Level 3",
    "Level 4",
    "Level 5",
    "Level 6",
    "Level 7",
    "Level 8",
    "Level 9"
  };
  public string[] tbl_Bell = new string[2]{ "OFF", "ON" };
  public string[] tbl_Vibrator = new string[3]
  {
    "OFF",
    "BUSY",
    "SIGNALING"
  };
}
