// Decompiled with JetBrains decompiler
// Type: ADMS10.DataForm
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace ADMS10
{
  public class DataForm : Form
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
    private object[][,] backupObj = new object[6][,];
    private ResourceManager resources = new ResourceManager("ADMS10.Strings", typeof (DataForm).Assembly);
    private string[] strItem = new string[6];
    private int colmax_Normal = 900;
    private int colmax_Skip = 99;
    private int colmax_Pms = 100;
    private int colmax_Vfo = 12;
    private int colmax_Home = 12;
    private int colmax_Wx = 10;
    private int BankMax = 100;
    public const string RPTOFF = "OFF";
    public const string RPTMINUS = "-RPT";
    public const string RPTPLUS = "+RPT";
    public const string RPTSEMIDUPLEX = "-/+";
    public const string MODEFM = "FM";
    public const string MODEAM = "AM";
    public const string MODEWFM = "WFM";
    public const string AMSOFF = "OFF";
    public const string AMSON = "ON";
    public const string DIGANALOGANALOG = "ANALOG";
    public const string DIGANALOGDN = "DN";
    public const string DIGANALOGVW = "VW";
    public const string SQLOFF = "OFF";
    public const string SQLTONE = "TONE";
    public const string SQLTONESQL = "TONE SQL";
    public const string SQLDCS = "DCS";
    public const string SQLREVTONE = "REV TONE";
    public const string SQLJRFREQ = "JR FREQ";
    public const string SQLPRFREQ = "PR FREQ";
    public const string SQLPAGER = "PAGER";
    public const string SQLNON = "-----";
    public const string SQLDCSENC = "D CD";
    public const string SQLENCTXDCSRX = "TONE-DCS";
    public const string SQLDCSTXDECRX = "D CD-TONE";
    public const string TONE67_0Hz = "67.0 Hz";
    public const string TONE69_3Hz = "69.3 Hz";
    public const string TONE71_9Hz = "71.9 Hz";
    public const string TONE74_4Hz = "74.4 Hz";
    public const string TONE77_0Hz = "77.0 Hz";
    public const string TONE79_7Hz = "79.7 Hz";
    public const string TONE82_5Hz = "82.5 Hz";
    public const string TONE85_4Hz = "85.4 Hz";
    public const string TONE88_5Hz = "88.5 Hz";
    public const string TONE91_5Hz = "91.5 Hz";
    public const string TONE94_8Hz = "94.8 Hz";
    public const string TONE97_4Hz = "97.4 Hz";
    public const string TONE100_0Hz = "100.0 Hz";
    public const string TONE103_5Hz = "103.5 Hz";
    public const string TONE107_2Hz = "107.2 Hz";
    public const string TONE110_9Hz = "110.9 Hz";
    public const string TONE114_8Hz = "114.8 Hz";
    public const string TONE118_8Hz = "118.8 Hz";
    public const string TONE123_0Hz = "123.0 Hz";
    public const string TONE127_3Hz = "127.3 Hz";
    public const string TONE131_8Hz = "131.8 Hz";
    public const string TONE136_5Hz = "136.5 Hz";
    public const string TONE141_3Hz = "141.3 Hz";
    public const string TONE146_2Hz = "146.2 Hz";
    public const string TONE151_4Hz = "151.4 Hz";
    public const string TONE156_7Hz = "156.7 Hz";
    public const string TONE159_8Hz = "159.8 Hz";
    public const string TONE162_2Hz = "162.2 Hz";
    public const string TONE165_5Hz = "165.5 Hz";
    public const string TONE167_9Hz = "167.9 Hz";
    public const string TONE171_3Hz = "171.3 Hz";
    public const string TONE173_8Hz = "173.8 Hz";
    public const string TONE177_3Hz = "177.3 Hz";
    public const string TONE179_9Hz = "179.9 Hz";
    public const string TONE183_5Hz = "183.5 Hz";
    public const string TONE186_2Hz = "186.2 Hz";
    public const string TONE189_9Hz = "189.9 Hz";
    public const string TONE192_8Hz = "192.8 Hz";
    public const string TONE196_6Hz = "196.6 Hz";
    public const string TONE199_5Hz = "199.5 Hz";
    public const string TONE203_5Hz = "203.5 Hz";
    public const string TONE206_5Hz = "206.5 Hz";
    public const string TONE210_7Hz = "210.7 Hz";
    public const string TONE218_1Hz = "218.1 Hz";
    public const string TONE225_7Hz = "225.7 Hz";
    public const string TONE229_1Hz = "229.1 Hz";
    public const string TONE233_6Hz = "233.6 Hz";
    public const string TONE241_8Hz = "241.8 Hz";
    public const string TONE250_3Hz = "250.3 Hz";
    public const string TONE254_1Hz = "254.1 Hz";
    public const string DCS023 = "023";
    public const string DCS025 = "025";
    public const string DCS026 = "026";
    public const string DCS031 = "031";
    public const string DCS032 = "032";
    public const string DCS036 = "036";
    public const string DCS043 = "043";
    public const string DCS047 = "047";
    public const string DCS051 = "051";
    public const string DCS053 = "053";
    public const string DCS054 = "054";
    public const string DCS065 = "065";
    public const string DCS071 = "071";
    public const string DCS072 = "072";
    public const string DCS073 = "073";
    public const string DCS074 = "074";
    public const string DCS114 = "114";
    public const string DCS115 = "115";
    public const string DCS116 = "116";
    public const string DCS122 = "122";
    public const string DCS125 = "125";
    public const string DCS131 = "131";
    public const string DCS132 = "132";
    public const string DCS134 = "134";
    public const string DCS143 = "143";
    public const string DCS145 = "145";
    public const string DCS152 = "152";
    public const string DCS155 = "155";
    public const string DCS156 = "156";
    public const string DCS162 = "162";
    public const string DCS165 = "165";
    public const string DCS172 = "172";
    public const string DCS174 = "174";
    public const string DCS205 = "205";
    public const string DCS212 = "212";
    public const string DCS223 = "223";
    public const string DCS225 = "225";
    public const string DCS226 = "226";
    public const string DCS243 = "243";
    public const string DCS244 = "244";
    public const string DCS245 = "245";
    public const string DCS246 = "246";
    public const string DCS251 = "251";
    public const string DCS252 = "252";
    public const string DCS255 = "255";
    public const string DCS261 = "261";
    public const string DCS263 = "263";
    public const string DCS265 = "265";
    public const string DCS266 = "266";
    public const string DCS271 = "271";
    public const string DCS274 = "274";
    public const string DCS306 = "306";
    public const string DCS311 = "311";
    public const string DCS315 = "315";
    public const string DCS325 = "325";
    public const string DCS331 = "331";
    public const string DCS332 = "332";
    public const string DCS343 = "343";
    public const string DCS346 = "346";
    public const string DCS351 = "351";
    public const string DCS356 = "356";
    public const string DCS364 = "364";
    public const string DCS365 = "365";
    public const string DCS371 = "371";
    public const string DCS411 = "411";
    public const string DCS412 = "412";
    public const string DCS413 = "413";
    public const string DCS423 = "423";
    public const string DCS431 = "431";
    public const string DCS432 = "432";
    public const string DCS445 = "445";
    public const string DCS446 = "446";
    public const string DCS452 = "452";
    public const string DCS454 = "454";
    public const string DCS455 = "455";
    public const string DCS462 = "462";
    public const string DCS464 = "464";
    public const string DCS465 = "465";
    public const string DCS466 = "466";
    public const string DCS503 = "503";
    public const string DCS506 = "506";
    public const string DCS516 = "516";
    public const string DCS523 = "523";
    public const string DCS526 = "526";
    public const string DCS532 = "532";
    public const string DCS546 = "546";
    public const string DCS565 = "565";
    public const string DCS606 = "606";
    public const string DCS612 = "612";
    public const string DCS624 = "624";
    public const string DCS627 = "627";
    public const string DCS631 = "631";
    public const string DCS632 = "632";
    public const string DCS654 = "654";
    public const string DCS662 = "662";
    public const string DCS664 = "664";
    public const string DCS703 = "703";
    public const string DCS712 = "712";
    public const string DCS723 = "723";
    public const string DCS731 = "731";
    public const string DCS732 = "732";
    public const string DCS734 = "734";
    public const string DCS743 = "743";
    public const string DCS754 = "754";
    public const string DCSDIMRXNTXN_JPN = "RX同相 TX同相";
    public const string DCSDIMRXITXN_JPN = "RX反転 TX同相";
    public const string DCSDIMRXBTXN_JPN = "RX両相 TX同相";
    public const string DCSDIMRXNTXI_JPN = "RX同相 TX反転";
    public const string DCSDIMRXITXI_JPN = "RX反転 TX反転";
    public const string DCSDIMRXBTXI_JPN = "RX両相 TX反転";
    public const string DCSDIMRXNTXN_ENG = "RX Normal TX Normal";
    public const string DCSDIMRXITXN_ENG = "RX Invert TX Normal";
    public const string DCSDIMRXBTXN_ENG = "RX Both   TX Normal";
    public const string DCSDIMRXNTXI_ENG = "RX Normal TX Invert";
    public const string DCSDIMRXITXI_ENG = "RX Invert TX Invert";
    public const string DCSDIMRXBTXI_ENG = "RX Both   TX Invert";
    public const string PR300HZ = "300 Hz";
    public const string PR400HZ = "400 Hz";
    public const string PR500HZ = "500 Hz";
    public const string PR600HZ = "600 Hz";
    public const string PR700HZ = "700 Hz";
    public const string PR800HZ = "800 Hz";
    public const string PR900HZ = "900 Hz";
    public const string PR1000HZ = "1000 Hz";
    public const string PR1100HZ = "1100 Hz";
    public const string PR1200HZ = "1200 Hz";
    public const string PR1300HZ = "1300 Hz";
    public const string PR1400HZ = "1400 Hz";
    public const string PR1500HZ = "1500 Hz";
    public const string PR1600HZ = "1600 Hz";
    public const string PR1700HZ = "1700 Hz";
    public const string PR1800HZ = "1800 Hz";
    public const string PR1900HZ = "1900 Hz";
    public const string PR2000HZ = "2000 Hz";
    public const string PR2100HZ = "2100 Hz";
    public const string PR2200HZ = "2200 Hz";
    public const string PR2300HZ = "2300 Hz";
    public const string PR2400HZ = "2400 Hz";
    public const string PR2500HZ = "2500 Hz";
    public const string PR2600HZ = "2600 Hz";
    public const string PR2700HZ = "2700 Hz";
    public const string PR2800HZ = "2800 Hz";
    public const string PR2900HZ = "2900 Hz";
    public const string PR3000HZ = "3000 Hz";
    public const string SOHIGH = "HIGH";
    public const string SOMID = "MID";
    public const string SOLOW = "LOW";
    public const string SKIPOFF = "OFF";
    public const string SKIPSKIP = "SKIP";
    public const string SKIPSELECT = "SELECT";
    public const string STEP5_0KHz = "5.0KHz";
    public const string STEP6_25KHz = "6.25KHz";
    public const string STEP8_33KHz = "8.33KHz";
    public const string STEP10_0KHz = "10.0KHz";
    public const string STEP12_5KHz = "12.5KHz";
    public const string STEP15_0KHz = "15.0KHz";
    public const string STEP20_0KHz = "20.0KHz";
    public const string STEP25_0KHz = "25.0KHz";
    public const string STEP50_0KHz = "50.0KHz";
    public const string STEP100_0KHz = "100.0KHz";
    public const string STEP9_0KHz = "9.0KHz";
    private const string SMATEROFF = "OFF";
    private const string SMATERLv1 = "Level 1";
    private const string SMATERLv2 = "Level 2";
    private const string SMATERLv3 = "Level 3";
    private const string SMATERLv4 = "Level 4";
    private const string SMATERLv5 = "Level 5";
    private const string SMATERLv6 = "Level 6";
    private const string SMATERLv7 = "Level 7";
    private const string SMATERLv8 = "Level 8";
    private const string SMATERLv9 = "Level 9";
    private const string BELLOFF = "OFF";
    private const string BELLON = "ON";
    private const string VIBOFF = "OFF";
    private const string VIBBUSY = "BUSY";
    private const string VIBSIGNALING = "SIGNALING";
    public const int RECVFREQ_MIN = 0;
    public const int RECVFREQ_MAX = 1;
    public const int SENDFREQ_MIN = 2;
    public const int SENDFREQ_MAX = 3;
    private const int DCSPHASEWIDTH_ENG = 130;
    private AdmsForm mfd;
    private Database db;
    private ToolStripMenuItem m;
    private int finedCol;
    private string finedStr;
    private DataForm.TabPageManager _tabPageManager;
    private IContainer components;
    private TabPage tab_Normal;
    private TabPage tab_Skip;
    private TabPage tab_Pms;
    private TabPage tab_Vfo;
    private TabPage tab_Home;
    public TabControl tabc_DataForm;
    public DataGridView dgv_Normal;
    public DataGridView dgv_Skip;
    public DataGridView dgv_Pms;
    public DataGridView dgv_Vfo;
    public DataGridView dgv_Home;
    private TabPage tab_Wx;
    public DataGridView dgv_Wx;
    private DataGridViewCheckBoxColumn col_Skip_Ch;
    private DataGridViewTextBoxColumn col_Skip_RxFrq;
    private DataGridViewTextBoxColumn col_Skip_TxFrq;
    private DataGridViewTextBoxColumn col_Skip_ShiftFrq;
    private DataGridViewComboBoxColumn col_Skip_ShiftDir;
    private DataGridViewCheckBoxColumn col_Skip_AutoMode;
    private DataGridViewComboBoxColumn col_Skip_Mode;
    private DataGridViewComboBoxColumn col_Skip_Ams;
    private DataGridViewComboBoxColumn col_Skip_DigAnalog;
    private DataGridViewTextBoxColumn col_Skip_MemName;
    private DataGridViewComboBoxColumn col_Skip_SqlType;
    private DataGridViewComboBoxColumn col_Skip_ToneFrq;
    private DataGridViewComboBoxColumn col_Skip_DcsCode;
    private DataGridViewComboBoxColumn col_Skip_DcsDim;
    private DataGridViewComboBoxColumn col_Skip_PrTone;
    private DataGridViewComboBoxColumn col_Skip_TxOutput;
    private DataGridViewComboBoxColumn col_Skip_Skip;
    private DataGridViewCheckBoxColumn col_Skip_AutoStep;
    private DataGridViewComboBoxColumn col_Skip_Step;
    private DataGridViewCheckBoxColumn col_Skip_Tag;
    private DataGridViewCheckBoxColumn col_Skip_MemDel;
    private DataGridViewCheckBoxColumn col_Skip_Att;
    private DataGridViewComboBoxColumn col_Skip_Smeter;
    private DataGridViewComboBoxColumn col_Skip_Bell;
    private DataGridViewComboBoxColumn col_Skip_Vibrator;
    private DataGridViewCheckBoxColumn col_Skip_HarfDev;
    private DataGridViewCheckBoxColumn col_Skip_ClockShift;
    private DataGridViewCheckBoxColumn col_Skip_Bank1;
    private DataGridViewCheckBoxColumn col_Skip_Bank2;
    private DataGridViewCheckBoxColumn col_Skip_Bank3;
    private DataGridViewCheckBoxColumn col_Skip_Bank4;
    private DataGridViewCheckBoxColumn col_Skip_Bank5;
    private DataGridViewCheckBoxColumn col_Skip_Bank6;
    private DataGridViewCheckBoxColumn col_Skip_Bank7;
    private DataGridViewCheckBoxColumn col_Skip_Bank8;
    private DataGridViewCheckBoxColumn col_Skip_Bank9;
    private DataGridViewCheckBoxColumn col_Skip_Bank10;
    private DataGridViewCheckBoxColumn col_Skip_Bank11;
    private DataGridViewCheckBoxColumn col_Skip_Bank12;
    private DataGridViewCheckBoxColumn col_Skip_Bank13;
    private DataGridViewCheckBoxColumn col_Skip_Bank14;
    private DataGridViewCheckBoxColumn col_Skip_Bank15;
    private DataGridViewCheckBoxColumn col_Skip_Bank16;
    private DataGridViewCheckBoxColumn col_Skip_Bank17;
    private DataGridViewCheckBoxColumn col_Skip_Bank18;
    private DataGridViewCheckBoxColumn col_Skip_Bank19;
    private DataGridViewCheckBoxColumn col_Skip_Bank20;
    private DataGridViewCheckBoxColumn col_Skip_Bank21;
    private DataGridViewCheckBoxColumn col_Skip_Bank22;
    private DataGridViewCheckBoxColumn col_Skip_Bank23;
    private DataGridViewCheckBoxColumn col_Skip_Bank24;
    private DataGridViewTextBoxColumn col_Skip_Comment;
    private DataGridViewCheckBoxColumn col_Pmf_Ch;
    private DataGridViewTextBoxColumn col_Pmf_RxFrq;
    private DataGridViewTextBoxColumn col_Pmf_TxFrq;
    private DataGridViewTextBoxColumn col_Pmf_ShiftFrq;
    private DataGridViewComboBoxColumn col_Pmf_ShiftDir;
    private DataGridViewCheckBoxColumn col_Pms_AutoMode;
    private DataGridViewComboBoxColumn col_Pmf_Mode;
    private DataGridViewComboBoxColumn col_Pmf_Ams;
    private DataGridViewComboBoxColumn col_Pmf_DigAnalog;
    private DataGridViewTextBoxColumn col_Pmf_MemName;
    private DataGridViewComboBoxColumn col_Pmf_SqlType;
    private DataGridViewComboBoxColumn col_Pmf_ToneFrq;
    private DataGridViewComboBoxColumn col_Pmf_DcsCode;
    private DataGridViewComboBoxColumn col_Pmf_DcsDim;
    private DataGridViewComboBoxColumn col_Pmf_PrTone;
    private DataGridViewComboBoxColumn col_Pmf_TxOutput;
    private DataGridViewComboBoxColumn col_Pmf_Skip;
    private DataGridViewCheckBoxColumn col_Pms_AutoStep;
    private DataGridViewComboBoxColumn col_Pmf_Step;
    private DataGridViewCheckBoxColumn col_Pms_Tag;
    private DataGridViewCheckBoxColumn col_Pmf_MemDel;
    private DataGridViewCheckBoxColumn col_Pmf_Att;
    private DataGridViewComboBoxColumn col_Pmf_Smeter;
    private DataGridViewComboBoxColumn col_Pmf_Bell;
    private DataGridViewComboBoxColumn col_Pmf_Vibrator;
    private DataGridViewCheckBoxColumn col_Pmf_HarfDev;
    private DataGridViewCheckBoxColumn col_Pmf_ClockShift;
    private DataGridViewCheckBoxColumn col_Pmf_Bank1;
    private DataGridViewCheckBoxColumn col_Pmf_Bank2;
    private DataGridViewCheckBoxColumn col_Pmf_Bank3;
    private DataGridViewCheckBoxColumn col_Pmf_Bank4;
    private DataGridViewCheckBoxColumn col_Pmf_Bank5;
    private DataGridViewCheckBoxColumn col_Pmf_Bank6;
    private DataGridViewCheckBoxColumn col_Pmf_Bank7;
    private DataGridViewCheckBoxColumn col_Pmf_Bank8;
    private DataGridViewCheckBoxColumn col_Pmf_Bank9;
    private DataGridViewCheckBoxColumn col_Pmf_Bank10;
    private DataGridViewCheckBoxColumn col_Pmf_Bank11;
    private DataGridViewCheckBoxColumn col_Pmf_Bank12;
    private DataGridViewCheckBoxColumn col_Pmf_Bank13;
    private DataGridViewCheckBoxColumn col_Pmf_Bank14;
    private DataGridViewCheckBoxColumn col_Pmf_Bank15;
    private DataGridViewCheckBoxColumn col_Pmf_Bank16;
    private DataGridViewCheckBoxColumn col_Pmf_Bank17;
    private DataGridViewCheckBoxColumn col_Pmf_Bank18;
    private DataGridViewCheckBoxColumn col_Pmf_Bank19;
    private DataGridViewCheckBoxColumn col_Pmf_Bank20;
    private DataGridViewCheckBoxColumn col_Pmf_Bank21;
    private DataGridViewCheckBoxColumn col_Pmf_Bank22;
    private DataGridViewCheckBoxColumn col_Pmf_Bank23;
    private DataGridViewCheckBoxColumn col_Pmf_Bank24;
    private DataGridViewTextBoxColumn col_Pmf_Comment;
    private DataGridViewCheckBoxColumn col_Vfo_Ch;
    private DataGridViewTextBoxColumn col_Vfo_RxFrq;
    private DataGridViewTextBoxColumn col_Vfo_TxFrq;
    private DataGridViewTextBoxColumn col_Vfo_ShiftFrq;
    private DataGridViewComboBoxColumn col_Vfo_ShiftDir;
    private DataGridViewCheckBoxColumn col_Vfo_AutoMode;
    private DataGridViewComboBoxColumn col_Vfo_Mode;
    private DataGridViewComboBoxColumn col_Vfo_Ams;
    private DataGridViewComboBoxColumn col_Vfo_DigAnalog;
    private DataGridViewTextBoxColumn col_Vfo_MemName;
    private DataGridViewComboBoxColumn col_Vfo_SqlType;
    private DataGridViewComboBoxColumn col_Vfo_ToneFrq;
    private DataGridViewComboBoxColumn col_Vfo_DcsCode;
    private DataGridViewComboBoxColumn col_Vfo_DcsDim;
    private DataGridViewComboBoxColumn col_Vfo_PrTone;
    private DataGridViewComboBoxColumn col_Vfo_TxOutput;
    private DataGridViewComboBoxColumn col_Vfo_Skip;
    private DataGridViewCheckBoxColumn col_Vfo_AutoStep;
    private DataGridViewComboBoxColumn col_Vfo_Step;
    private DataGridViewCheckBoxColumn col_Vfo_Tag;
    private DataGridViewCheckBoxColumn col_Vfo_MemDel;
    private DataGridViewCheckBoxColumn col_Vfo_Att;
    private DataGridViewComboBoxColumn col_Vfo_Smeter;
    private DataGridViewComboBoxColumn col_Vfo_Bell;
    private DataGridViewComboBoxColumn col_Vfo_Vibrator;
    private DataGridViewCheckBoxColumn col_Vfo_HarfDev;
    private DataGridViewCheckBoxColumn col_Vfo_ClockShift;
    private DataGridViewCheckBoxColumn col_Vfo_Bank1;
    private DataGridViewCheckBoxColumn col_Vfo_Bank2;
    private DataGridViewCheckBoxColumn col_Vfo_Bank3;
    private DataGridViewCheckBoxColumn col_Vfo_Bank4;
    private DataGridViewCheckBoxColumn col_Vfo_Bank5;
    private DataGridViewCheckBoxColumn col_Vfo_Bank6;
    private DataGridViewCheckBoxColumn col_Vfo_Bank7;
    private DataGridViewCheckBoxColumn col_Vfo_Bank8;
    private DataGridViewCheckBoxColumn col_Vfo_Bank9;
    private DataGridViewCheckBoxColumn col_Vfo_Bank10;
    private DataGridViewCheckBoxColumn col_Vfo_Bank11;
    private DataGridViewCheckBoxColumn col_Vfo_Bank12;
    private DataGridViewCheckBoxColumn col_Vfo_Bank13;
    private DataGridViewCheckBoxColumn col_Vfo_Bank14;
    private DataGridViewCheckBoxColumn col_Vfo_Bank15;
    private DataGridViewCheckBoxColumn col_Vfo_Bank16;
    private DataGridViewCheckBoxColumn col_Vfo_Bank17;
    private DataGridViewCheckBoxColumn col_Vfo_Bank18;
    private DataGridViewCheckBoxColumn col_Vfo_Bank19;
    private DataGridViewCheckBoxColumn col_Vfo_Bank20;
    private DataGridViewCheckBoxColumn col_Vfo_Bank21;
    private DataGridViewCheckBoxColumn col_Vfo_Bank22;
    private DataGridViewCheckBoxColumn col_Vfo_Bank23;
    private DataGridViewCheckBoxColumn col_Vfo_Bank24;
    private DataGridViewTextBoxColumn col_Vfo_Comment;
    private DataGridViewCheckBoxColumn col_Home_Ch;
    private DataGridViewTextBoxColumn col_Home_RxFrq;
    private DataGridViewTextBoxColumn col_Home_TxFrq;
    private DataGridViewTextBoxColumn col_Home_ShiftFrq;
    private DataGridViewComboBoxColumn col_Home_ShiftDir;
    private DataGridViewCheckBoxColumn col_Home_AutoMode;
    private DataGridViewComboBoxColumn col_Home_Mode;
    private DataGridViewComboBoxColumn col_Home_Ams;
    private DataGridViewComboBoxColumn col_Home_DigAnalog;
    private DataGridViewTextBoxColumn col_Home_MemName;
    private DataGridViewComboBoxColumn col_Home_SqlType;
    private DataGridViewComboBoxColumn col_Home_ToneFrq;
    private DataGridViewComboBoxColumn col_Home_DcsCode;
    private DataGridViewComboBoxColumn col_Home_DcsDim;
    private DataGridViewComboBoxColumn col_Home_PrTone;
    private DataGridViewComboBoxColumn col_Home_TxOutput;
    private DataGridViewComboBoxColumn col_Home_Skip;
    private DataGridViewCheckBoxColumn col_Home_AutoStep;
    private DataGridViewComboBoxColumn col_Home_Step;
    private DataGridViewCheckBoxColumn col_Home_Tag;
    private DataGridViewCheckBoxColumn col_Home_MemDel;
    private DataGridViewCheckBoxColumn col_Home_Att;
    private DataGridViewComboBoxColumn col_Home_Smeter;
    private DataGridViewComboBoxColumn col_Home_Bell;
    private DataGridViewComboBoxColumn col_Home_Vibrator;
    private DataGridViewCheckBoxColumn col_Home_HarfDev;
    private DataGridViewCheckBoxColumn col_Home_ClockShift;
    private DataGridViewCheckBoxColumn col_Home_Bank1;
    private DataGridViewCheckBoxColumn col_Home_Bank2;
    private DataGridViewCheckBoxColumn col_Home_Bank3;
    private DataGridViewCheckBoxColumn col_Home_Bank4;
    private DataGridViewCheckBoxColumn col_Home_Bank5;
    private DataGridViewCheckBoxColumn col_Home_Bank6;
    private DataGridViewCheckBoxColumn col_Home_Bank7;
    private DataGridViewCheckBoxColumn col_Home_Bank8;
    private DataGridViewCheckBoxColumn col_Home_Bank9;
    private DataGridViewCheckBoxColumn col_Home_Bank10;
    private DataGridViewCheckBoxColumn col_Home_Bank11;
    private DataGridViewCheckBoxColumn col_Home_Bank12;
    private DataGridViewCheckBoxColumn col_Home_Bank13;
    private DataGridViewCheckBoxColumn col_Home_Bank14;
    private DataGridViewCheckBoxColumn col_Home_Bank15;
    private DataGridViewCheckBoxColumn col_Home_Bank16;
    private DataGridViewCheckBoxColumn col_Home_Bank17;
    private DataGridViewCheckBoxColumn col_Home_Bank18;
    private DataGridViewCheckBoxColumn col_Home_Bank19;
    private DataGridViewCheckBoxColumn col_Home_Bank20;
    private DataGridViewCheckBoxColumn col_Home_Bank21;
    private DataGridViewCheckBoxColumn col_Home_Bank22;
    private DataGridViewCheckBoxColumn col_Home_Bank23;
    private DataGridViewCheckBoxColumn col_Home_Bank24;
    private DataGridViewTextBoxColumn col_Home_Comment;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn407;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn183;
    private DataGridViewCheckBoxColumn col_Wx_AutoMode;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn184;
    private DataGridViewComboBoxColumn col_Wx_Ams;
    private DataGridViewComboBoxColumn col_Wx_DigAnalog;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn185;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn186;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn187;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn188;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn189;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn190;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn191;
    private DataGridViewCheckBoxColumn col_Wx_AutoStep;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn192;
    private DataGridViewCheckBoxColumn col_Wx_Tag;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn408;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn409;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn193;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn194;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn195;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn410;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn411;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn412;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn413;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn414;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn415;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn416;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn417;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn418;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn419;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn420;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn421;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn422;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn423;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn424;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn425;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn426;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn427;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn428;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn429;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn430;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn431;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn432;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn433;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn434;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn435;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
    private DataGridViewCheckBoxColumn col_Normal_Ch;
    private DataGridViewTextBoxColumn col_Normal_RxFrq;
    private DataGridViewTextBoxColumn col_Normal_TxFrq;
    private DataGridViewTextBoxColumn col_Normal_ShiftFrq;
    private DataGridViewComboBoxColumn col_Normal_ShiftDir;
    private DataGridViewCheckBoxColumn col_Normal_AutoMode;
    private DataGridViewComboBoxColumn col_Normal_Mode;
    private DataGridViewComboBoxColumn col_Normal_Ams;
    private DataGridViewComboBoxColumn col_Normal_DigAnalog;
    private DataGridViewTextBoxColumn col_Normal_MemName;
    private DataGridViewComboBoxColumn col_Normal_SqlType;
    private DataGridViewComboBoxColumn col_Normal_ToneFrq;
    private DataGridViewComboBoxColumn col_Normal_DscCode;
    private DataGridViewComboBoxColumn col_Normal_DscDim;
    private DataGridViewComboBoxColumn col_Normal_PrTone;
    private DataGridViewComboBoxColumn col_Normal_TxOtput;
    private DataGridViewComboBoxColumn col_Normal_Skip;
    private DataGridViewCheckBoxColumn col_Normal_AutoStep;
    private DataGridViewComboBoxColumn col_Normal_Step;
    private DataGridViewCheckBoxColumn col_Normal_Tag;
    private DataGridViewCheckBoxColumn col_Normal_MemDel;
    private DataGridViewCheckBoxColumn col_Normal_Att;
    private DataGridViewComboBoxColumn col_Normal_Smeter;
    private DataGridViewComboBoxColumn col_Normal_Bell;
    private DataGridViewComboBoxColumn col_Normal_Vibrator;
    private DataGridViewCheckBoxColumn col_Normal_HarfDev;
    private DataGridViewCheckBoxColumn col_Normal_ClockShift;
    private DataGridViewCheckBoxColumn col_Normal_Bank1;
    private DataGridViewCheckBoxColumn col_Normal_Bank2;
    private DataGridViewCheckBoxColumn col_Normal_Bank3;
    private DataGridViewCheckBoxColumn col_Normal_Bank4;
    private DataGridViewCheckBoxColumn col_Normal_Bank5;
    private DataGridViewCheckBoxColumn col_Normal_Bank6;
    private DataGridViewCheckBoxColumn col_Normal_Bank7;
    private DataGridViewCheckBoxColumn col_Normal_Bank8;
    private DataGridViewCheckBoxColumn col_Normal_Bank9;
    private DataGridViewCheckBoxColumn col_Normal_Bank10;
    private DataGridViewCheckBoxColumn col_Normal_Bank11;
    private DataGridViewCheckBoxColumn col_Normal_Bank12;
    private DataGridViewCheckBoxColumn col_Normal_Bank13;
    private DataGridViewCheckBoxColumn col_Normal_Bank14;
    private DataGridViewCheckBoxColumn col_Normal_Bank15;
    private DataGridViewCheckBoxColumn col_Normal_Bank16;
    private DataGridViewCheckBoxColumn col_Normal_Bank17;
    private DataGridViewCheckBoxColumn col_Normal_Bank18;
    private DataGridViewCheckBoxColumn col_Normal_Bank19;
    private DataGridViewCheckBoxColumn col_Normal_Bank20;
    private DataGridViewCheckBoxColumn col_Normal_Bank21;
    private DataGridViewCheckBoxColumn col_Normal_Bank22;
    private DataGridViewCheckBoxColumn col_Normal_Bank23;
    private DataGridViewCheckBoxColumn col_Normal_Bank24;
    private DataGridViewTextBoxColumn col_Normal_Comment;

    public string FilePath { get; set; }

    public string FileName { get; set; }

    public bool IsSave { get; set; }

    public bool IsSend { get; set; }

    public string finedHeader_Bak { get; set; }

    public string[] finedVal_Bak { get; set; }

    public ToolStripMenuItem GetMenu()
    {
      return this.m;
    }

    public Database GetDB()
    {
      return this.db;
    }

    public int SelectedIndexTab()
    {
      return this.tabc_DataForm.SelectedIndex;
    }

    public DataGridView SelectedDgv()
    {
      return this.selectedDgv();
    }

    public static int GetBandIdx(Decimal frq)
    {
      return DataForm.bandIdx(frq);
    }

    public string[] GetSTEPList(Decimal frq)
    {
      string[] strArray = DataForm.tbl_Step;
      switch (DataForm.bandIdx(frq))
      {
        case 0:
          strArray = DataForm.tbl_Step_air;
          break;
        case 1:
          strArray = DataForm.tbl_Step_no_air;
          break;
        case 2:
          strArray = DataForm.tbl_Step_no_air;
          break;
        case 3:
          strArray = DataForm.tbl_Step_no_air;
          break;
        case 4:
          strArray = DataForm.tbl_Step_no_air;
          break;
        case 5:
          strArray = DataForm.tbl_Step_no_air;
          break;
      }
      return strArray;
    }

    public DataForm()
    {
    }

    public DataForm(AdmsForm admsform, Database database)
    {
      this.mfd = admsform;
      this.db = database;
      this.InitializeComponent();
      this.SetDcsDimItems();
      this.m = new ToolStripMenuItem();
      this._tabPageManager = new DataForm.TabPageManager(this.tabc_DataForm);
      this._tabPageManager.ChangeTabPageVisible(5, false);
      this.IsSend = Settings.Instance.Language == 0;
      this.backupObj[0] = new object[this.colmax_Normal, 52];
      this.backupObj[2] = new object[this.colmax_Pms, 52];
      this.backupObj[1] = new object[this.colmax_Skip, 52];
      this.backupObj[3] = new object[this.colmax_Home, 52];
      this.backupObj[4] = new object[this.colmax_Vfo, 52];
      this.backupObj[5] = new object[this.colmax_Wx, 52];
      this.finedVal_Bak = new string[52];
      this.reset_Norm();
      this.reset_Skip();
      this.reset_Pms();
      this.reset_Vfo();
      this.reset_Home();
      this.reset_Wx();
      Settings.Instance.Recv_flg = false;
    }

    public void Reset()
    {
      this.reset_Norm();
      this.reset_Skip();
      this.reset_Pms();
      this.reset_Vfo();
      this.reset_Home();
      this.reset_Wx();
    }

    public void WxVisible()
    {
      this._tabPageManager.ChangeTabPageVisible(5, true);
    }

    private void reset_Norm()
    {
      this.dgv_Normal.TopLeftHeaderCell.Value = (object) this.resources.GetString("CHANNELNUM");
      this.dgv_Normal.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_Normal.Rows.Clear();
      this.dgv_Normal.Rows.Add(this.colmax_Normal);
      for (int index = 0; index < this.colmax_Normal; ++index)
        this.dgv_Normal.Rows[index].HeaderCell.Value = (object) (index + 1).ToString();
      this.dgv_Normal.Columns[1].DefaultCellStyle.Format = "n5";
      this.dgv_Normal.Columns[2].DefaultCellStyle.Format = "n5";
      this.dgv_Normal.Columns[3].DefaultCellStyle.Format = "n5";
      this.dgv_Normal.Columns[1].Frozen = true;
      this.dgv_Normal.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgv_Normal.Rows[0].Cells[20].ReadOnly = true;
      if (Settings.Instance.Language == 0)
        return;
      this.dgv_Normal.Columns[13].Width = 130;
    }

    private void reset_Skip()
    {
      this.dgv_Skip.TopLeftHeaderCell.Value = (object) this.resources.GetString("CHANNELNUM");
      this.dgv_Skip.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_Skip.Rows.Clear();
      this.dgv_Skip.Rows.Add(this.colmax_Skip);
      for (int index = 0; index < this.colmax_Skip; ++index)
        this.dgv_Skip.Rows[index].HeaderCell.Value = (object) (index + 901).ToString();
      this.dgv_Skip.Columns[1].DefaultCellStyle.Format = "n5";
      this.dgv_Skip.Columns[2].DefaultCellStyle.Format = "n5";
      this.dgv_Skip.Columns[3].DefaultCellStyle.Format = "n5";
      this.dgv_Skip.Columns[1].Frozen = true;
      this.dgv_Skip.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      if (Settings.Instance.Language == 0)
        return;
      this.dgv_Skip.Columns[13].Width = 130;
    }

    private void reset_Pms()
    {
      this.dgv_Pms.TopLeftHeaderCell.Value = (object) this.resources.GetString("CHANNELNUM");
      this.dgv_Pms.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_Pms.Rows.Clear();
      this.dgv_Pms.Rows.Add(this.colmax_Pms);
      int num = 1;
      for (int index = 0; index < this.colmax_Pms; ++index)
      {
        if (index % 2 == 0)
        {
          this.dgv_Pms.Rows[index].HeaderCell.Value = (object) ("L" + num.ToString());
        }
        else
        {
          this.dgv_Pms.Rows[index].HeaderCell.Value = (object) ("U" + num.ToString());
          ++num;
        }
      }
      this.dgv_Pms.Columns[1].DefaultCellStyle.Format = "n5";
      this.dgv_Pms.Columns[2].DefaultCellStyle.Format = "n5";
      this.dgv_Pms.Columns[3].DefaultCellStyle.Format = "n5";
      this.dgv_Pms.Columns[1].Frozen = true;
      this.dgv_Pms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      if (Settings.Instance.Language == 0)
        return;
      this.dgv_Pms.Columns[13].Width = 130;
    }

    private void reset_Vfo()
    {
      this.dgv_Vfo.TopLeftHeaderCell.Value = (object) this.resources.GetString("BAND");
      this.dgv_Vfo.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_Vfo.Rows.Clear();
      this.dgv_Vfo.Rows.Add(this.colmax_Vfo);
      for (int index = 0; index < this.colmax_Vfo; ++index)
      {
        if (Settings.Instance.Language == 0)
          this.dgv_Vfo.Rows[index].HeaderCell.Value = (object) this.tbl_BandName[index];
        else
          this.dgv_Vfo.Rows[index].HeaderCell.Value = (object) this.tbl_BandName_eng[index];
      }
      this.dgv_Vfo.Rows[4].Visible = false;
      this.dgv_Vfo.Rows[0].Visible = false;
      this.dgv_Vfo.Rows[1].Visible = false;
      this.dgv_Vfo.Rows[2].Visible = false;
      this.dgv_Vfo.Rows[3].Visible = false;
      this.dgv_Vfo.Rows[11].Visible = false;
      this.dgv_Vfo.Columns[1].DefaultCellStyle.Format = "n5";
      this.dgv_Vfo.Columns[2].DefaultCellStyle.Format = "n5";
      this.dgv_Vfo.Columns[3].DefaultCellStyle.Format = "n5";
      this.dgv_Vfo.Columns[1].Frozen = true;
      this.dgv_Vfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      if (Settings.Instance.Language == 0)
        return;
      this.dgv_Vfo.Columns[13].Width = 130;
    }

    private void reset_Home()
    {
      this.dgv_Home.TopLeftHeaderCell.Value = (object) this.resources.GetString("BAND");
      this.dgv_Home.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_Home.Rows.Clear();
      this.dgv_Home.Rows.Add(this.colmax_Home);
      for (int index = 0; index < this.colmax_Home; ++index)
      {
        if (Settings.Instance.Language == 0)
          this.dgv_Home.Rows[index].HeaderCell.Value = (object) this.tbl_BandName[index];
        else
          this.dgv_Home.Rows[index].HeaderCell.Value = (object) this.tbl_BandName_eng[index];
      }
      this.dgv_Home.Rows[4].Visible = false;
      this.dgv_Home.Rows[0].Visible = false;
      this.dgv_Home.Rows[1].Visible = false;
      this.dgv_Home.Rows[2].Visible = false;
      this.dgv_Home.Rows[3].Visible = false;
      this.dgv_Home.Rows[11].Visible = false;
      this.dgv_Home.Columns[1].DefaultCellStyle.Format = "n5";
      this.dgv_Home.Columns[2].DefaultCellStyle.Format = "n5";
      this.dgv_Home.Columns[3].DefaultCellStyle.Format = "n5";
      this.dgv_Home.Columns[1].Frozen = true;
      this.dgv_Home.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      if (Settings.Instance.Language == 0)
        return;
      this.dgv_Home.Columns[13].Width = 130;
    }

    private void reset_Wx()
    {
      this.dgv_Wx.TopLeftHeaderCell.Value = (object) this.resources.GetString("CHANNELNUM");
      this.dgv_Wx.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgv_Wx.Rows.Clear();
      this.dgv_Wx.Rows.Add(this.colmax_Wx);
      for (int index = 0; index < this.colmax_Wx; ++index)
        this.dgv_Wx.Rows[index].HeaderCell.Value = (object) ("A" + (index + 1).ToString());
      this.dgv_Wx.Columns[1].DefaultCellStyle.Format = "n5";
      this.dgv_Wx.Columns[2].DefaultCellStyle.Format = "n5";
      this.dgv_Wx.Columns[3].DefaultCellStyle.Format = "n5";
      this.dgv_Wx.Columns[1].Frozen = true;
      this.dgv_Wx.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      if (Settings.Instance.Language == 0)
        return;
      this.dgv_Wx.Columns[13].Width = 130;
    }

    private void DataForm_Load(object sender, EventArgs e)
    {
      typeof (DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue((object) this.dgv_Normal, (object) true, (object[]) null);
      typeof (DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue((object) this.dgv_Skip, (object) true, (object[]) null);
      typeof (DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue((object) this.dgv_Pms, (object) true, (object[]) null);
      typeof (DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue((object) this.dgv_Vfo, (object) true, (object[]) null);
      typeof (DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue((object) this.dgv_Home, (object) true, (object[]) null);
      typeof (DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue((object) this.dgv_Wx, (object) true, (object[]) null);
      this.FormSet();
    }

    private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.IsSave)
        return;
      string str = this.resources.GetString("ISSAVECLOSE");
      string text;
      if (Settings.Instance.Language == 0)
        text = " '" + this.FileName + "' " + str + "?";
      else
        text = str + " '" + this.FileName + "' ?";
      DialogResult dialogResult = MessageBox.Show(text, this.resources.GetString("INFOMSG"), MessageBoxButtons.YesNoCancel);
      if (dialogResult == DialogResult.Yes)
      {
        if (this.FilePath == null || this.FilePath == "")
          dialogResult = this.mfd.FileSaveAs(this);
        else
          this.mfd.FileSave(this);
      }
      if (dialogResult != DialogResult.Cancel)
        return;
      e.Cancel = true;
    }

    private void dgv_EditingControlShowing(
      object sender,
      DataGridViewEditingControlShowingEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      this.backup();
      if (!(e.Control is DataGridViewTextBoxEditingControl))
        return;
      DataGridViewTextBoxEditingControl control = (DataGridViewTextBoxEditingControl) e.Control;
      control.KeyPress -= new KeyPressEventHandler(KeyPressCancel.txt_Freq_KeyPress);
      control.KeyPress -= new KeyPressEventHandler(KeyPressCancel.txt_MemoryName_KeyPress);
      switch (dataGridView.CurrentCell.ColumnIndex)
      {
        case 1:
        case 2:
        case 3:
          control.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_Freq_KeyPress);
          break;
        case 9:
          control.KeyPress += new KeyPressEventHandler(KeyPressCancel.txt_MemoryName_KeyPress);
          break;
      }
    }

    private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
      switch (e.ColumnIndex)
      {
        case 8:
          this.dgv_DigAnalog(sender, e);
          break;
        case 10:
          this.dgv_SqlType(sender, e);
          break;
      }
    }

    private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      switch (e.ColumnIndex)
      {
        case 1:
          this.dgv_RecvFreq(sender, e);
          break;
        case 2:
          this.dgv_SendFreq(sender, e);
          break;
        case 3:
          this.dgv_ShiftFreq(sender, e);
          break;
        case 4:
          this.dgv_ShiftDir(sender, e);
          break;
        case 9:
          this.dgv_MemoryName(sender, e);
          break;
      }
      this.IsSave = false;
    }

    private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      switch (e.ColumnIndex)
      {
        case 0:
          this.dgv_PriorityCH(sender, e);
          break;
        case 5:
          this.dgv_AutoMode(sender, e);
          break;
        case 17:
          this.dgv_AutoStep(sender, e);
          break;
        case 20:
          this.dgv_MemDir(sender, e);
          break;
        case 21:
          this.dgv_Att(sender, e);
          break;
        default:
          if (e.ColumnIndex < 27 || e.ColumnIndex > 50)
            break;
          this.dgv_MemoryBank(sender, e);
          break;
      }
    }

    private void dgv_PriorityCH(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly || !dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.Equals((object) true))
        return;
      for (int index = 0; index < dataGridView.RowCount; ++index)
        dataGridView.Rows[index].Cells[e.ColumnIndex].Value = (object) false;
      dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (object) true;
    }

    private void dgv_AutoMode(object sender, DataGridViewCellEventArgs e)
    {
      this.inputLimited((DataGridView) sender, e.RowIndex);
    }

    private void dgv_AutoStep(object sender, DataGridViewCellEventArgs e)
    {
      this.inputLimited((DataGridView) sender, e.RowIndex);
    }

    private void dgv_MemDir(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dgv = (DataGridView) sender;
      DataGridViewCell dataGridViewCell = dgv[e.ColumnIndex, e.RowIndex];
      this.inputLimited(dgv, e.RowIndex);
    }

    private void dgv_Att(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      DataGridViewCheckBoxCell viewCheckBoxCell = dataGridView[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
      if (!dataGridView.Equals((object) this.dgv_Wx))
        return;
      if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.Equals((object) true))
      {
        for (int index = 0; index < this.dgv_Wx.RowCount; ++index)
          dataGridView.Rows[index].Cells[e.ColumnIndex].Value = viewCheckBoxCell.TrueValue;
      }
      else
      {
        for (int index = 0; index < this.dgv_Wx.RowCount; ++index)
          dataGridView.Rows[index].Cells[e.ColumnIndex].Value = viewCheckBoxCell.FalseValue;
      }
    }

    private void dgv_MemoryBank(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      DataGridViewCheckBoxCell viewCheckBoxCell = dataGridView[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
      if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.Equals((object) true))
      {
        if (this.get_BankCount(e.ColumnIndex) <= this.BankMax)
        {
          dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = viewCheckBoxCell.TrueValue;
        }
        else
        {
          dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = viewCheckBoxCell.FalseValue;
          int num = (int) MessageBox.Show(this.resources.GetString("BANKERRORMSG"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
        dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = viewCheckBoxCell.FalseValue;
      dataGridView.RefreshEdit();
    }

    private int get_BankCount(int c)
    {
      List<DataGridView> dataGridViewList = new List<DataGridView>();
      dataGridViewList.Add(this.dgv_Normal);
      dataGridViewList.Add(this.dgv_Wx);
      int num = 0;
      foreach (DataGridView dataGridView in dataGridViewList)
      {
        for (int index = 0; index < dataGridView.RowCount; ++index)
        {
          if (dataGridView.Rows[index].Cells[c].EditedFormattedValue.Equals((object) true))
            ++num;
        }
      }
      return num;
    }

    private void dgv_RecvFreq(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dgv = (DataGridView) sender;
      int selectedIndex1 = this.tabc_DataForm.SelectedIndex;
      if (dgv[e.ColumnIndex, e.RowIndex].Value == null)
      {
        int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
      }
      else if (dgv[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
      {
        int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
      }
      else
      {
        Decimal frq;
        try
        {
          frq = Decimal.Parse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString());
        }
        catch
        {
          int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
          return;
        }
        int bandIdx = DataForm.GetBandIdx(frq);
        if (bandIdx == -1)
        {
          this.ShowEntryFreqErrMsg();
          int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
        }
        else if (DataForm.tbl_ReadOnlyCell[bandIdx, Settings.Instance.Destination])
        {
          this.ShowEntryFreqErrMsg();
          int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
        }
        else if ((selectedIndex1 == 3 || selectedIndex1 == 4) && bandIdx + 5 != e.RowIndex)
        {
          this.ShowEntryFreqErrMsg();
          int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
        }
        else if (this.getFreqStep(frq) == new Decimal(-1))
        {
          this.ShowEntryFreqErrMsg();
          int selectedIndex2 = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex2][e.RowIndex, e.ColumnIndex];
        }
        else
        {
          dgv[e.ColumnIndex, e.RowIndex].Value = (object) frq.ToString("N5");
          if (this.isBrank(dgv, e.RowIndex, 2))
          {
            for (int index = 2; index < dgv.ColumnCount; ++index)
              dgv.Rows[e.RowIndex].Cells[index].Value = Settings.Instance.CpuType != 1 ? DataForm.tbl_Default_Eng[bandIdx, index] : DataForm.tbl_Default_Jpn[bandIdx, index];
            dgv.Rows[e.RowIndex].Cells[2].Value = dgv.Rows[e.RowIndex].Cells[1].Value;
          }
          if (this.db.Config_RptArs == 1)
            this.auto_ARS(dgv, e.RowIndex, frq);
          this.inputLimited(dgv, e.RowIndex);
        }
      }
    }

    private void dgv_SendFreq(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dgv = (DataGridView) sender;
      if (dgv[e.ColumnIndex, e.RowIndex].Value == null)
      {
        int selectedIndex = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
      }
      else if (dgv[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
      {
        int selectedIndex = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
      }
      else
      {
        Decimal rFreq;
        Decimal num;
        try
        {
          rFreq = Decimal.Parse(dgv[1, e.RowIndex].Value.ToString());
          num = Decimal.Parse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString());
        }
        catch
        {
          int selectedIndex = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
          return;
        }
        switch (dgv[4, e.RowIndex].Value.ToString())
        {
          case "-RPT":
          case "+RPT":
            if (!DataForm.checkSendFreq(rFreq, num))
            {
              num = rFreq;
              break;
            }
            break;
        }
        if (!DataForm.checkSendFreq(rFreq, num))
        {
          this.ShowEntryFreqErrMsg();
          int selectedIndex = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
        }
        else if (this.tabc_DataForm.SelectedIndex == 4 && DataForm.GetBandIdx(num) + 5 != e.RowIndex)
        {
          this.ShowEntryFreqErrMsg();
          int selectedIndex = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
        }
        else if (this.getFreqStep(num) == new Decimal(-1))
        {
          this.ShowEntryFreqErrMsg();
          int selectedIndex = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
        }
        else
        {
          dgv[e.ColumnIndex, e.RowIndex].Value = (object) num.ToString("N5");
          dgv[4, e.RowIndex].Value = (object) "-/+";
          this.inputLimited(dgv, e.RowIndex);
        }
      }
    }

    private void dgv_ShiftFreq(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dgv = (DataGridView) sender;
      if (dgv[e.ColumnIndex, e.RowIndex].Value == null)
      {
        int selectedIndex = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
      }
      else if (dgv[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
      {
        int selectedIndex = this.tabc_DataForm.SelectedIndex;
        dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
      }
      else
      {
        Decimal sftFreq;
        try
        {
          sftFreq = Decimal.Parse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString());
        }
        catch
        {
          int selectedIndex = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
          return;
        }
        if (!DataForm.checkShiftFreq(sftFreq))
        {
          this.ShowEntryFreqErrMsg();
          int selectedIndex = this.tabc_DataForm.SelectedIndex;
          dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
        }
        else
        {
          dgv[e.ColumnIndex, e.RowIndex].Value = (object) sftFreq.ToString("N5");
          this.inputLimited(dgv, e.RowIndex);
        }
      }
    }

    private void dgv_ShiftDir(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dgv = (DataGridView) sender;
      Decimal rFreq = Decimal.Parse(dgv[1, e.RowIndex].Value.ToString());
      Decimal num = Decimal.Parse(dgv[2, e.RowIndex].Value.ToString());
      Decimal.Parse(dgv[3, e.RowIndex].Value.ToString());
      switch (dgv[4, e.RowIndex].Value.ToString())
      {
        case "-/+":
          if (!DataForm.checkSendFreq(rFreq, num))
            dgv[2, e.RowIndex].Value = (object) rFreq;
          if (this.tabc_DataForm.SelectedIndex == 4 && DataForm.GetBandIdx(num) + 5 != e.RowIndex)
          {
            dgv[2, e.RowIndex].Value = (object) rFreq;
            break;
          }
          break;
      }
      this.inputLimited(dgv, e.RowIndex);
    }

    private void dgv_MemoryName(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dgv = (DataGridView) sender;
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      if (!this.isBrank(dgv, e.RowIndex, e.ColumnIndex))
      {
        foreach (char c in dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToCharArray())
        {
          if (!mojiConvert.IsMemoryNameChar(c))
          {
            dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.backupObj[selectedIndex][e.RowIndex, e.ColumnIndex];
            break;
          }
        }
      }
      if (this.isBrank(dgv, e.RowIndex, e.ColumnIndex))
      {
        dgv.Rows[e.RowIndex].Cells[19].ReadOnly = true;
        dgv.Rows[e.RowIndex].Cells[19].Value = (object) false;
      }
      else
      {
        dgv.Rows[e.RowIndex].Cells[19].ReadOnly = false;
        dgv.Rows[e.RowIndex].Cells[19].Value = (object) true;
      }
    }

    private void dgv_DigAnalog(object sender, DataGridViewCellCancelEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      string str = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
      int digitalVwMode = this.db.Digital_VwMode;
      string[] array = this.tbl_DigAnalog;
      if (digitalVwMode == 1)
        array = this.tbl_DigAnalog_VwOff;
      if (Array.IndexOf<string>(array, str) == -1)
        dataGridView.Rows[e.RowIndex].Cells[8].Value = (object) this.tbl_DigAnalog[0];
      DataGridViewComboBoxCell viewComboBoxCell = (DataGridViewComboBoxCell) dataGridView[8, e.RowIndex];
      viewComboBoxCell.Items.Clear();
      if (digitalVwMode == 1)
        viewComboBoxCell.Items.AddRange((object[]) this.tbl_DigAnalog_VwOff);
      else
        viewComboBoxCell.Items.AddRange((object[]) this.tbl_DigAnalog);
    }

    private void dgv_SqlType(object sender, DataGridViewCellCancelEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      string str = dataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
      int signalingSqlExpansion = this.db.Signaling_SqlExpansion;
      if (Array.IndexOf<string>(this.getSQLTYPEList(signalingSqlExpansion), str) == -1)
        dataGridView.Rows[e.RowIndex].Cells[10].Value = (object) this.tbl_SqlType[0];
      DataGridViewComboBoxCell viewComboBoxCell = (DataGridViewComboBoxCell) dataGridView[10, e.RowIndex];
      viewComboBoxCell.Items.Clear();
      viewComboBoxCell.Items.AddRange((object[]) this.getSQLTYPEList(signalingSqlExpansion));
    }

    private Decimal getFreqStep(Decimal frq)
    {
      DataForm.GetBandIdx(frq);
      string[] tblStep = DataForm.tbl_Step;
      for (int index = this.auto_Step(frq); index >= 0; --index)
      {
        Decimal num = Decimal.Parse(tblStep[index].Replace("KHz", ""));
        if (DataForm.checkStepFreq(frq, num / new Decimal(1000)))
          return num;
      }
      return new Decimal(-1);
    }

    private string[] getSQLTYPEList(int sEX)
    {
      return sEX != 0 ? (Settings.Instance.CountryType != 0 ? this.tbl_SqlType_ExOn_NonJPN : this.tbl_SqlType_ExOn_JPN) : (Settings.Instance.CountryType != 0 ? this.tbl_SqlType_ExOff_NonJPN : this.tbl_SqlType_ExOff_JPN);
    }

    private static bool checkSendFreq(Decimal rFreq, Decimal sFreq)
    {
      int bandIdx = DataForm.GetBandIdx(rFreq);
      int destination = Settings.Instance.Destination;
      return bandIdx != -1 && DataForm.tbl_Freq[bandIdx, destination, 2] <= sFreq && sFreq < DataForm.tbl_Freq[bandIdx, destination, 3];
    }

    private static bool checkShiftFreq(Decimal sftFreq)
    {
      return sftFreq % new Decimal(5000, 0, 0, false, (byte) 5) == new Decimal(0) && new Decimal(0, 0, 0, false, (byte) 5) <= sftFreq && sftFreq <= new Decimal(15000000, 0, 0, false, (byte) 5);
    }

    public void FormSet()
    {
      List<DataGridView> dataGridViewList = new List<DataGridView>();
      List<BindingList<BandMemory>> bindingListList = new List<BindingList<BandMemory>>();
      dataGridViewList.Add(this.dgv_Normal);
      dataGridViewList.Add(this.dgv_Skip);
      dataGridViewList.Add(this.dgv_Pms);
      dataGridViewList.Add(this.dgv_Vfo);
      dataGridViewList.Add(this.dgv_Home);
      dataGridViewList.Add(this.dgv_Wx);
      bindingListList.Add(this.db.NormalMemory);
      bindingListList.Add(this.db.SkipMemory);
      bindingListList.Add(this.db.PmsMemory);
      bindingListList.Add(this.db.VfoMemory);
      bindingListList.Add(this.db.HomeMemory);
      bindingListList.Add(this.db.WxMemory);
      int index1 = 0;
      foreach (DataGridView dgv in dataGridViewList)
      {
        for (int row = 0; row < bindingListList[index1].Count; ++row)
        {
          if (bindingListList[index1][row].MemDel)
          {
            dgv.Rows[row].Cells[0].Value = (object) bindingListList[index1][row].PriorityCH;
            dgv.Rows[row].Cells[1].Value = (object) bindingListList[index1][row].RxFrq;
            dgv.Rows[row].Cells[2].Value = (object) bindingListList[index1][row].TxFrq;
            dgv.Rows[row].Cells[3].Value = (object) bindingListList[index1][row].ShiftFrq;
            dgv.Rows[row].Cells[4].Value = (object) this.tbl_ShiftDir[bindingListList[index1][row].ShiftDir];
            dgv.Rows[row].Cells[6].Value = (object) this.tbl_Mode[bindingListList[index1][row].Mode];
            dgv.Rows[row].Cells[5].Value = (object) bindingListList[index1][row].AutoMode;
            dgv.Rows[row].Cells[7].Value = (object) this.tbl_Ams[bindingListList[index1][row].Ams];
            dgv.Rows[row].Cells[8].Value = (object) this.tbl_DigAnalog[bindingListList[index1][row].DigAnalog];
            dgv.Rows[row].Cells[9].Value = (object) bindingListList[index1][row].MemName;
            dgv.Rows[row].Cells[10].Value = (object) this.tbl_SqlType[bindingListList[index1][row].SqlType];
            dgv.Rows[row].Cells[11].Value = (object) this.tbl_ToneFrq[bindingListList[index1][row].ToneFrq];
            dgv.Rows[row].Cells[12].Value = (object) this.tbl_DcsCode[bindingListList[index1][row].DcsCode];
            dgv.Rows[row].Cells[13].Value = Settings.Instance.Language != 0 ? (object) this.tbl_DcsDim_eng[bindingListList[index1][row].DcsDim] : (object) this.tbl_DcsDim[bindingListList[index1][row].DcsDim];
            dgv.Rows[row].Cells[14].Value = (object) this.tbl_PrTone[bindingListList[index1][row].PrTone];
            dgv.Rows[row].Cells[15].Value = (object) this.tbl_TxOutput[bindingListList[index1][row].TxOut];
            dgv.Rows[row].Cells[16].Value = (object) this.tbl_Skip[bindingListList[index1][row].Skip];
            dgv.Rows[row].Cells[18].Value = (object) DataForm.tbl_Step[bindingListList[index1][row].Step];
            dgv.Rows[row].Cells[17].Value = (object) bindingListList[index1][row].AutoStep;
            dgv.Rows[row].Cells[19].Value = (object) bindingListList[index1][row].Tag;
            dgv.Rows[row].Cells[20].Value = (object) bindingListList[index1][row].MemUse;
            dgv.Rows[row].Cells[21].Value = (object) bindingListList[index1][row].Att;
            dgv.Rows[row].Cells[22].Value = (object) this.tbl_Smeter[bindingListList[index1][row].Smeter];
            dgv.Rows[row].Cells[23].Value = (object) this.tbl_Bell[bindingListList[index1][row].Bell];
            dgv.Rows[row].Cells[24].Value = (object) this.tbl_Vibrator[bindingListList[index1][row].Vibrator];
            dgv.Rows[row].Cells[25].Value = (object) bindingListList[index1][row].HarfDev;
            dgv.Rows[row].Cells[26].Value = (object) bindingListList[index1][row].ClockShift;
            for (int index2 = 0; index2 < 24; ++index2)
              dgv.Rows[row].Cells[27 + index2].Value = (object) bindingListList[index1][row].Bank[index2];
            dgv.Rows[row].Cells[51].Value = (object) bindingListList[index1][row].Comment;
          }
          else
          {
            dgv[0, row].ReadOnly = true;
            for (int index2 = 2; index2 < 52; ++index2)
              dgv[index2, row].ReadOnly = true;
            this.clear(dgv, row);
          }
        }
        ++index1;
        this.allLimited(dgv);
      }
    }

    public void MemSet()
    {
      List<DataGridView> dataGridViewList = new List<DataGridView>();
      List<BindingList<BandMemory>> bindingListList = new List<BindingList<BandMemory>>();
      dataGridViewList.Add(this.dgv_Normal);
      dataGridViewList.Add(this.dgv_Skip);
      dataGridViewList.Add(this.dgv_Pms);
      dataGridViewList.Add(this.dgv_Vfo);
      dataGridViewList.Add(this.dgv_Home);
      dataGridViewList.Add(this.dgv_Wx);
      bindingListList.Add(this.db.NormalMemory);
      bindingListList.Add(this.db.SkipMemory);
      bindingListList.Add(this.db.PmsMemory);
      bindingListList.Add(this.db.VfoMemory);
      bindingListList.Add(this.db.HomeMemory);
      bindingListList.Add(this.db.WxMemory);
      int index1 = 0;
      foreach (DataGridView dgv in dataGridViewList)
      {
        for (int row = 0; row < bindingListList[index1].Count; ++row)
        {
          if (dgv.Rows[row].Cells[1].Value != null && dgv.Rows[row].Cells[1].Value.ToString() != "")
          {
            if (dgv.Rows[row].Cells[0].EditedFormattedValue.Equals((object) true))
              bindingListList[index1][row].PriorityCH = true;
            else
              bindingListList[index1][row].PriorityCH = false;
            bindingListList[index1][row].RxFrq = Decimal.Parse(dgv.Rows[row].Cells[1].Value.ToString());
            bindingListList[index1][row].TxFrq = Decimal.Parse(dgv.Rows[row].Cells[2].Value.ToString());
            if (dgv.Rows[row].Cells[3].Value == null || dgv.Rows[row].Cells[3].Value.ToString() == "")
              bindingListList[index1][row].ShiftFrq = new Decimal(0, 0, 0, false, (byte) 5);
            else
              bindingListList[index1][row].ShiftFrq = Decimal.Parse(dgv.Rows[row].Cells[3].Value.ToString());
            bindingListList[index1][row].ShiftDir = this.GetIndex(dgv, this.tbl_ShiftDir, row, 4);
            bindingListList[index1][row].Mode = this.GetIndex(dgv, this.tbl_Mode, row, 6);
            if (dgv.Rows[row].Cells[5].EditedFormattedValue.Equals((object) true))
              bindingListList[index1][row].AutoMode = true;
            else
              bindingListList[index1][row].AutoMode = false;
            bindingListList[index1][row].Ams = this.GetIndex(dgv, this.tbl_Ams, row, 7);
            bindingListList[index1][row].DigAnalog = this.GetIndex(dgv, this.tbl_DigAnalog, row, 8);
            bindingListList[index1][row].MemName = (string) dgv.Rows[row].Cells[9].Value;
            bindingListList[index1][row].SqlType = this.GetIndex(dgv, this.tbl_SqlType, row, 10);
            bindingListList[index1][row].ToneFrq = this.GetIndex(dgv, this.tbl_ToneFrq, row, 11);
            bindingListList[index1][row].DcsCode = this.GetIndex(dgv, this.tbl_DcsCode, row, 12);
            if (Settings.Instance.Language == 0)
              bindingListList[index1][row].DcsDim = this.GetIndex(dgv, this.tbl_DcsDim, row, 13);
            else
              bindingListList[index1][row].DcsDim = this.GetIndex(dgv, this.tbl_DcsDim_eng, row, 13);
            bindingListList[index1][row].PrTone = this.GetIndex(dgv, this.tbl_PrTone, row, 14);
            bindingListList[index1][row].TxOut = this.GetIndex(dgv, this.tbl_TxOutput, row, 15);
            bindingListList[index1][row].Skip = this.GetIndex(dgv, this.tbl_Skip, row, 16);
            bindingListList[index1][row].Step = this.GetIndex(dgv, DataForm.tbl_Step, row, 18);
            if (dgv.Rows[row].Cells[17].EditedFormattedValue.Equals((object) true))
              bindingListList[index1][row].AutoStep = true;
            else
              bindingListList[index1][row].AutoStep = false;
            if (dgv.Rows[row].Cells[19].EditedFormattedValue.Equals((object) true))
              bindingListList[index1][row].Tag = true;
            else
              bindingListList[index1][row].Tag = false;
            if (dgv.Rows[row].Cells[20].EditedFormattedValue.Equals((object) true))
              bindingListList[index1][row].MemUse = true;
            else
              bindingListList[index1][row].MemUse = false;
            bindingListList[index1][row].MemDel = true;
            if (dgv.Rows[row].Cells[21].EditedFormattedValue.Equals((object) true))
              bindingListList[index1][row].Att = true;
            else
              bindingListList[index1][row].Att = false;
            bindingListList[index1][row].Smeter = this.GetIndex(dgv, this.tbl_Smeter, row, 22);
            bindingListList[index1][row].Bell = this.GetIndex(dgv, this.tbl_Bell, row, 23);
            bindingListList[index1][row].Vibrator = this.GetIndex(dgv, this.tbl_Vibrator, row, 24);
            if (dgv.Rows[row].Cells[25].EditedFormattedValue.Equals((object) true))
              bindingListList[index1][row].HarfDev = true;
            else
              bindingListList[index1][row].HarfDev = false;
            if (dgv.Rows[row].Cells[26].EditedFormattedValue.Equals((object) true))
              bindingListList[index1][row].ClockShift = true;
            else
              bindingListList[index1][row].ClockShift = false;
            for (int index2 = 0; index2 < 24; ++index2)
            {
              if (dgv.Rows[row].Cells[27 + index2].EditedFormattedValue.Equals((object) true))
                bindingListList[index1][row].Bank[index2] = true;
              else
                bindingListList[index1][row].Bank[index2] = false;
            }
            bindingListList[index1][row].Comment = (string) dgv.Rows[row].Cells[51].Value;
          }
          else
            bindingListList[index1][row].MemDel = false;
        }
        ++index1;
      }
    }

    public bool IsCannel1()
    {
      DataGridView dataGridView = this.selectedDgv();
      int rowIndex = dataGridView.SelectedCells[0].RowIndex;
      return dataGridView.Equals((object) this.dgv_Normal) && rowIndex == 0;
    }

    private int GetIndex(DataGridView dgv, string[] tbl, int row, int col)
    {
      for (int index = 0; index < tbl.Length; ++index)
      {
        if (tbl[index] == (string) dgv.Rows[row].Cells[col].Value)
          return index;
      }
      return 0;
    }

    private void inputLimited(DataGridView dgv, int row)
    {
      if (dgv.Rows[row].Cells[1].Value == null)
        dgv.Rows[row].Cells[1].Value = (object) "";
      if (dgv.Rows[row].Cells[2].Value == null)
        dgv.Rows[row].Cells[2].Value = (object) "";
      Decimal result1;
      if (!Decimal.TryParse(dgv.Rows[row].Cells[1].Value.ToString(), out result1))
      {
        dgv.Rows[row].Cells[1].ReadOnly = false;
        dgv.Rows[row].Cells[1].Style.ForeColor = Color.Black;
        for (int index = 0; index < dgv.ColumnCount; ++index)
        {
          if (index != 1)
            dgv.Rows[row].Cells[index].ReadOnly = true;
        }
      }
      else
      {
        Decimal result2;
        if (!Decimal.TryParse(dgv.Rows[row].Cells[2].Value.ToString(), out result2))
          result2 = result1;
        Decimal result3;
        if (!Decimal.TryParse(dgv.Rows[row].Cells[3].Value.ToString(), out result3))
          result3 = new Decimal(0);
        int bandIdx = DataForm.GetBandIdx(result1);
        string str1 = dgv.Rows[row].Cells[18].Value.ToString();
        DataGridViewComboBoxCell viewComboBoxCell1 = (DataGridViewComboBoxCell) dgv[18, row];
        viewComboBoxCell1.Items.Clear();
        viewComboBoxCell1.Items.AddRange((object[]) this.GetSTEPList(result1));
        dgv.Rows[row].Cells[18].Value = Array.IndexOf<string>(this.GetSTEPList(result1), str1) != -1 ? (object) str1 : (Settings.Instance.CpuType != 1 ? DataForm.tbl_Default_Eng[bandIdx, 18] : DataForm.tbl_Default_Jpn[bandIdx, 18]);
        string str2 = dgv.Rows[row].Cells[10].Value.ToString();
        int signalingSqlExpansion = this.db.Signaling_SqlExpansion;
        DataGridViewComboBoxCell viewComboBoxCell2 = (DataGridViewComboBoxCell) dgv[10, row];
        viewComboBoxCell2.Items.Clear();
        if (Array.IndexOf<string>(this.getSQLTYPEList(signalingSqlExpansion), str2) == -1)
          viewComboBoxCell2.Items.AddRange((object[]) this.getSQLTYPEList(1));
        else
          viewComboBoxCell2.Items.AddRange((object[]) this.getSQLTYPEList(signalingSqlExpansion));
        dgv.Rows[row].Cells[10].Value = (object) str2;
        string str3 = dgv.Rows[row].Cells[8].Value.ToString();
        int digitalVwMode = this.db.Digital_VwMode;
        DataGridViewComboBoxCell viewComboBoxCell3 = (DataGridViewComboBoxCell) dgv[8, row];
        viewComboBoxCell3.Items.Clear();
        string[] array = this.tbl_DigAnalog;
        if (digitalVwMode == 1)
          array = this.tbl_DigAnalog_VwOff;
        if (Array.IndexOf<string>(array, str3) == -1)
          viewComboBoxCell3.Items.AddRange((object[]) this.tbl_DigAnalog);
        else if (digitalVwMode == 1)
          viewComboBoxCell3.Items.AddRange((object[]) this.tbl_DigAnalog_VwOff);
        else
          viewComboBoxCell3.Items.AddRange((object[]) this.tbl_DigAnalog);
        dgv.Rows[row].Cells[8].Value = (object) str3;
        if (!dgv.Equals((object) this.dgv_Wx))
        {
          for (int index = 0; index < dgv.ColumnCount; ++index)
          {
            if (!dgv.Equals((object) this.dgv_Vfo) || index != 2)
            {
              dgv.Rows[row].Cells[index].ReadOnly = false;
              dgv.Rows[row].Cells[index].Style.ForeColor = Color.Black;
              if (bandIdx != -1)
                dgv.Rows[row].Cells[index].ReadOnly = DataForm.tbl_ReadOnlyCell[bandIdx, Settings.Instance.Destination];
            }
          }
        }
        switch (this.GetIndex(dgv, this.tbl_ShiftDir, row, 4))
        {
          case 0:
            dgv.Rows[row].Cells[3].ReadOnly = false;
            dgv.Rows[row].Cells[2].Value = dgv.Rows[row].Cells[1].Value;
            break;
          case 1:
            dgv.Rows[row].Cells[3].ReadOnly = false;
            dgv.Rows[row].Cells[2].Value = (object) (result1 - result3);
            break;
          case 2:
            dgv.Rows[row].Cells[3].ReadOnly = false;
            dgv.Rows[row].Cells[2].Value = (object) (result1 + result3);
            break;
          case 3:
            dgv.Rows[row].Cells[3].ReadOnly = true;
            dgv.Rows[row].Cells[3].Value = (object) "0.00000";
            break;
          default:
            throw new FormatException();
        }
        dgv.Rows[row].Cells[6].ReadOnly = dgv.Rows[row].Cells[5].EditedFormattedValue.Equals((object) true);
        if (bandIdx == 1 || bandIdx == 4)
        {
          dgv.Rows[row].Cells[7].ReadOnly = false;
          dgv.Rows[row].Cells[8].ReadOnly = false;
        }
        else
        {
          dgv.Rows[row].Cells[7].ReadOnly = true;
          dgv.Rows[row].Cells[8].ReadOnly = true;
          dgv.Rows[row].Cells[7].Value = (object) this.tbl_Ams[0];
          dgv.Rows[row].Cells[8].Value = (object) this.tbl_DigAnalog[0];
        }
        if (bandIdx != 0 && str1 == "8.33KHz")
          dgv.Rows[row].Cells[17].Value = (object) true;
        dgv.Rows[row].Cells[18].ReadOnly = dgv.Rows[row].Cells[17].EditedFormattedValue.Equals((object) true);
        if (this.isBrank(dgv, row, 9))
        {
          dgv.Rows[row].Cells[19].ReadOnly = true;
          dgv.Rows[row].Cells[19].Value = (object) false;
        }
        else
          dgv.Rows[row].Cells[19].ReadOnly = false;
        if (dgv.Equals((object) this.dgv_Normal) && row == 0)
        {
          dgv.Rows[row].Cells[20].ReadOnly = true;
          dgv.Rows[row].Cells[20].Value = (object) false;
        }
        if (dgv.Rows[row].Cells[20].EditedFormattedValue.Equals((object) true))
        {
          for (int index = 0; index < dgv.ColumnCount; ++index)
          {
            if (index != 20)
              dgv.Rows[row].Cells[index].ReadOnly = true;
          }
        }
        if (dgv.Rows[row].Cells[5].EditedFormattedValue.Equals((object) true))
        {
          int index = this.auto_Mode(result1);
          dgv.Rows[row].Cells[6].Value = (object) this.tbl_Mode[index];
        }
        if (dgv.Rows[row].Cells[17].EditedFormattedValue.Equals((object) true))
        {
          Decimal freqStep = this.getFreqStep(Decimal.Parse(dgv[1, row].Value.ToString()));
          dgv.Rows[row].Cells[18].Value = (object) (freqStep.ToString() + "KHz");
        }
        for (int index = 0; index < dgv.ColumnCount; ++index)
        {
          dgv.Rows[row].Cells[index].Style.ForeColor = !dgv.Rows[row].Cells[index].ReadOnly ? Color.Black : Color.Gray;
          if (index == 2 && !DataForm.checkSendFreq(result1, Decimal.Parse(dgv.Rows[row].Cells[2].Value.ToString())))
            dgv.Rows[row].Cells[2].Style.ForeColor = Color.Red;
        }
      }
    }

    public bool Inport(string[][] str)
    {
      DataGridView dgv = this.selectedDgv();
      this.backup();
      if (dgv.Equals((object) this.dgv_Normal))
        this.reset_Norm();
      else if (dgv.Equals((object) this.dgv_Skip))
        this.reset_Skip();
      else if (dgv.Equals((object) this.dgv_Pms))
        this.reset_Pms();
      else if (dgv.Equals((object) this.dgv_Vfo))
        this.reset_Vfo();
      else if (dgv.Equals((object) this.dgv_Home))
        this.reset_Home();
      else
        this.reset_Wx();
      bool flag;
      try
      {
        int num = int.Parse(str[0][str[0].Length - 1]);
        if (num != this.tabc_DataForm.SelectedIndex)
          throw new Exception();
        if (num == 0 && (str[0][2] == null || str[0][2] == ""))
          throw new Exception();
        int row1 = 0;
        for (int row2 = 0; row2 < dgv.Rows.Count; ++row2)
        {
          if (dgv.Rows[row2].Visible)
          {
            int index = 1;
            this.clear(dgv, row2);
            for (int col = 0; col < dgv.Columns.Count; ++col)
            {
              if (dgv.Columns[col].Visible)
              {
                if (str[row1][index] != null && str[row1][index] != "")
                {
                  switch (col)
                  {
                    case 0:
                    case 5:
                    case 17:
                    case 19:
                    case 20:
                    case 21:
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 29:
                    case 30:
                    case 31:
                    case 32:
                    case 33:
                    case 34:
                    case 35:
                    case 36:
                    case 37:
                    case 38:
                    case 39:
                    case 40:
                    case 41:
                    case 42:
                    case 43:
                    case 44:
                    case 45:
                    case 46:
                    case 47:
                    case 48:
                    case 49:
                    case 50:
                      if ("ON" == str[row1][index])
                      {
                        dgv.Rows[row2].Cells[col].Value = (object) true;
                        break;
                      }
                      if (!("OFF" == str[row1][index]))
                        throw new Exception();
                      dgv.Rows[row2].Cells[col].Value = (object) false;
                      break;
                    case 1:
                      Decimal rcvfrq = Decimal.Parse(str[row1][index]);
                      if (this.tabc_DataForm.SelectedIndex == 5)
                      {
                        if (!(rcvfrq == Decimal.Parse(DataForm.tbl_Wx_Freq[row1])))
                          throw new Exception();
                        dgv.Rows[row2].Cells[col].Value = (object) rcvfrq;
                        break;
                      }
                      Decimal sndfrq = Decimal.Parse(str[row1][index + 1]);
                      Decimal sftfrq = Decimal.Parse(str[row1][index + 2]);
                      string shiftdir = str[row1][index + 3];
                      if (!this.freq_check(rcvfrq, sndfrq, sftfrq, shiftdir, row1))
                        throw new Exception();
                      dgv.Rows[row2].Cells[col].Value = (object) rcvfrq;
                      break;
                    case 2:
                    case 3:
                      dgv.Rows[row2].Cells[col].Value = (object) Decimal.Parse(str[row1][index]);
                      break;
                    case 4:
                      if (this.tabc_DataForm.SelectedIndex == 3)
                      {
                        if (-1 == Array.IndexOf<string>(this.tbl_ShiftDir_Vfo, str[row1][index]))
                          throw new Exception();
                      }
                      else if (-1 == Array.IndexOf<string>(this.tbl_ShiftDir, str[row1][index]))
                        throw new Exception();
                      dgv.Rows[row2].Cells[col].Value = (object) str[row1][index];
                      break;
                    case 9:
                      if (!this.memoryname_check(str[row1][index]))
                        throw new Exception();
                      dgv.Rows[row2].Cells[col].Value = (object) str[row1][index];
                      break;
                    case 12:
                      if (-1 == Array.IndexOf<string>(this.tbl_DcsCode, str[row1][index].PadLeft(3, '0')))
                        throw new Exception();
                      dgv.Rows[row2].Cells[col].Value = (object) str[row1][index].PadLeft(3, '0');
                      break;
                    case 51:
                      dgv.Rows[row2].Cells[col].Value = (object) str[row1][index];
                      break;
                    default:
                      if (-1 == Array.IndexOf<string>(this.selectedDgvList(col), str[row1][index]))
                        throw new Exception();
                      dgv.Rows[row2].Cells[col].Value = (object) str[row1][index];
                      break;
                  }
                }
                ++index;
              }
            }
            ++row1;
          }
        }
        for (int index = 0; index < 24; ++index)
        {
          if (this.get_BankCount(27 + index) > this.BankMax)
            throw new Exception();
        }
        flag = true;
        this.allLimited(dgv);
        this.IsSave = false;
      }
      catch
      {
        this.Undo();
        this.allLimited(dgv);
        flag = false;
      }
      return flag;
    }

    private bool memoryname_check(string name)
    {
      foreach (char c in name.ToCharArray())
      {
        if (!mojiConvert.IsMemoryNameChar(c))
          return false;
      }
      return true;
    }

    private bool freq_check(
      Decimal rcvfrq,
      Decimal sndfrq,
      Decimal sftfrq,
      string shiftdir,
      int row)
    {
      int bandIdx = DataForm.GetBandIdx(rcvfrq);
      if (bandIdx == -1 || DataForm.tbl_ReadOnlyCell[bandIdx, Settings.Instance.Destination] || (this.tabc_DataForm.SelectedIndex == 3 || this.tabc_DataForm.SelectedIndex == 4) && bandIdx != row || this.getFreqStep(rcvfrq) == new Decimal(-1))
        return false;
      switch (shiftdir)
      {
        case "-RPT":
        case "+RPT":
          if (!DataForm.checkSendFreq(rcvfrq, sndfrq))
          {
            sndfrq = rcvfrq;
            break;
          }
          break;
        default:
          if (this.tabc_DataForm.SelectedIndex == 4 && DataForm.GetBandIdx(sndfrq) != row)
            return false;
          break;
      }
      return DataForm.checkSendFreq(rcvfrq, sndfrq) && !(this.getFreqStep(sndfrq) == new Decimal(-1)) && DataForm.checkShiftFreq(sftfrq);
    }

    public string[][] Export()
    {
      DataGridView dataGridView = this.selectedDgv();
      int num = 0;
      for (int index = 0; index < dataGridView.Columns.Count; ++index)
      {
        if (dataGridView.Columns[index].Visible)
          ++num;
      }
      int length = 0;
      for (int index = 0; index < dataGridView.Rows.Count; ++index)
      {
        if (dataGridView.Rows[index].Visible)
          ++length;
      }
      string[][] strArray = new string[length][];
      int index1 = 0;
      for (int index2 = 0; index2 < dataGridView.Rows.Count; ++index2)
      {
        if (dataGridView.Rows[index2].Visible)
        {
          strArray[index1] = new string[num + 2];
          strArray[index1][0] = dataGridView.Rows[index2].HeaderCell.Value.ToString();
          strArray[index1][strArray[index1].Length - 1] = this.tabc_DataForm.SelectedIndex.ToString();
          int index3 = 1;
          for (int index4 = 0; index4 < dataGridView.Columns.Count; ++index4)
          {
            if (dataGridView.Columns[index4].Visible)
            {
              strArray[index1][index3] = "";
              if (dataGridView.Rows[index2].Cells[index4].Value != null)
              {
                switch (index4)
                {
                  case 0:
                  case 5:
                  case 17:
                  case 19:
                  case 20:
                  case 21:
                  case 25:
                  case 26:
                  case 27:
                  case 28:
                  case 29:
                  case 30:
                  case 31:
                  case 32:
                  case 33:
                  case 34:
                  case 35:
                  case 36:
                  case 37:
                  case 38:
                  case 39:
                  case 40:
                  case 41:
                  case 42:
                  case 43:
                  case 44:
                  case 45:
                  case 46:
                  case 47:
                  case 48:
                  case 49:
                  case 50:
                    strArray[index1][index3] = dataGridView.Rows[index2].Cells[1].Value == null || dataGridView.Rows[index2].Cells[1].Value.ToString() == "" ? "" : (!dataGridView.Rows[index2].Cells[index4].EditedFormattedValue.Equals((object) true) ? "OFF" : "ON");
                    break;
                  default:
                    strArray[index1][index3] = this.changeCSVStr(dataGridView.Rows[index2].Cells[index4].Value.ToString());
                    break;
                }
              }
              ++index3;
            }
          }
          ++index1;
        }
      }
      return strArray;
    }

    private string changeCSVStr(string s)
    {
      if (0 <= s.IndexOf("\"") || 0 <= s.IndexOf(","))
      {
        s = s.Replace("\"", "\"\"");
        s = "\"" + s + "\"";
      }
      return s;
    }

    private string[] selectedDgvList(int col)
    {
      string[] strArray = (string[]) null;
      switch (col)
      {
        case 4:
          strArray = this.tbl_ShiftDir;
          break;
        case 6:
          strArray = this.tbl_Mode;
          break;
        case 7:
          strArray = this.tbl_Ams;
          break;
        case 8:
          strArray = this.tbl_DigAnalog;
          break;
        case 10:
          strArray = this.tbl_SqlType;
          break;
        case 11:
          strArray = this.tbl_ToneFrq;
          break;
        case 12:
          strArray = this.tbl_DcsCode;
          break;
        case 13:
          strArray = Settings.Instance.Language != 0 ? this.tbl_DcsDim_eng : this.tbl_DcsDim;
          break;
        case 14:
          strArray = this.tbl_PrTone;
          break;
        case 15:
          strArray = this.tbl_TxOutput;
          break;
        case 16:
          strArray = this.tbl_Skip;
          break;
        case 18:
          strArray = DataForm.tbl_Step;
          break;
        case 22:
          strArray = this.tbl_Smeter;
          break;
        case 23:
          strArray = this.tbl_Bell;
          break;
      }
      return strArray;
    }

    public void Clear()
    {
      if (!this.isDelet())
        return;
      DataGridView dgv = this.selectedDgv();
      int rowIndex = dgv.SelectedCells[0].RowIndex;
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      int index1 = dgv.SelectedCells.Count - 1;
      int num1 = dgv.SelectedCells[0].RowIndex;
      int num2 = dgv.SelectedCells[index1].RowIndex;
      if (num1 > num2)
      {
        int num3 = num1;
        num1 = num2;
        num2 = num3;
      }
      int num4 = num2 - num1 + 1;
      if (selectedIndex == 0 && num1 == 0)
      {
        this.ShowEntryCH0ErrMsg();
      }
      else
      {
        if (num4 > 0)
        {
          this.backup();
          for (int index2 = 0; index2 < num4; ++index2)
            this.clear(dgv, num1 + index2);
        }
        this.allLimited(dgv);
        this.IsSave = false;
      }
    }

    private void clear(DataGridView dgv, int row)
    {
      dgv[0, row].Value = (object) false;
      dgv[1, row].Value = (object) "";
      dgv[2, row].Value = (object) "";
      dgv[3, row].Value = (object) "";
      dgv[4, row].Value = (object) "";
      dgv[6, row].Value = (object) "";
      dgv[5, row].Value = (object) false;
      dgv[7, row].Value = (object) "";
      dgv[8, row].Value = (object) "";
      dgv[9, row].Value = (object) "";
      dgv[10, row].Value = (object) "";
      dgv[11, row].Value = (object) "";
      dgv[12, row].Value = (object) "";
      dgv[13, row].Value = (object) "";
      dgv[13, row].Value = (object) "";
      dgv[14, row].Value = (object) "";
      dgv[15, row].Value = (object) "";
      dgv[16, row].Value = (object) "";
      dgv[18, row].Value = (object) "";
      dgv[17, row].Value = (object) false;
      dgv[19, row].Value = (object) false;
      dgv[20, row].Value = (object) false;
      dgv[21, row].Value = (object) false;
      dgv[22, row].Value = (object) "";
      dgv[23, row].Value = (object) "";
      dgv[24, row].Value = (object) "";
      dgv[25, row].Value = (object) false;
      dgv[26, row].Value = (object) false;
      for (int index = 0; index < 24; ++index)
        dgv[27 + index, row].Value = (object) false;
      dgv[51, row].Value = (object) "";
    }

    public object[] Copy()
    {
      object[] objArray = new object[52];
      DataGridView dataGridView = this.selectedDgv();
      int rowIndex = dataGridView.SelectedCells[0].RowIndex;
      for (int index = 0; index < dataGridView.ColumnCount; ++index)
        objArray[index] = dataGridView.Rows[rowIndex].Cells[index].Value;
      return objArray;
    }

    public void Past(object[] copy)
    {
      DataGridView dgv = this.selectedDgv();
      int rowIndex = dgv.SelectedCells[0].RowIndex;
      if (dgv.Equals((object) this.dgv_Normal) && rowIndex == 0 && (copy[1] == null || copy[1].ToString() == ""))
      {
        this.ShowEntryCH0ErrMsg();
      }
      else
      {
        this.backup();
        for (int index = 1; index < dgv.ColumnCount; ++index)
        {
          dgv.Rows[rowIndex].Cells[index].Value = copy[index];
          if (!dgv.Equals((object) this.dgv_Normal) && index == 16)
            dgv.Rows[rowIndex].Cells[index].Value = (object) "OFF";
          if (!dgv.Equals((object) this.dgv_Normal) && index >= 27 && index <= 50)
            dgv.Rows[rowIndex].Cells[index].Value = (object) false;
        }
        this.allLimited(dgv);
        for (int index = 0; index < 24; ++index)
        {
          if (this.get_BankCount(27 + index) > this.BankMax)
            dgv.Rows[rowIndex].Cells[27 + index].Value = (object) false;
        }
        this.IsSave = false;
      }
    }

    public void Undo()
    {
      DataGridView dgv = this.selectedDgv();
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      if (dgv != null)
      {
        for (int index1 = 0; index1 < dgv.RowCount; ++index1)
        {
          for (int index2 = 0; index2 < dgv.ColumnCount; ++index2)
            dgv.Rows[index1].Cells[index2].Value = this.backupObj[selectedIndex][index1, index2];
        }
      }
      this.allLimited(dgv);
      this.IsSave = false;
    }

    public void Insert()
    {
      if (!this.isDelet())
        return;
      DataGridView dgv = this.selectedDgv();
      int rowIndex = dgv.SelectedCells[0].RowIndex;
      string str = dgv.Rows[dgv.RowCount - 1].Cells[1].Value.ToString();
      if (str != null && str != "" && MessageBox.Show(this.resources.GetString("CHINSERTINFO"), this.resources.GetString("INFOMSG"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.OK)
        return;
      this.backup();
      dgv.Rows.Insert(rowIndex);
      dgv.Rows.RemoveAt(dgv.RowCount - 1);
      this.resetRowNo();
      this.allLimited(dgv);
      this.IsSave = false;
    }

    public void Delete()
    {
      if (!this.isDelet())
        return;
      DataGridView dgv = this.selectedDgv();
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      int index1 = dgv.SelectedCells.Count - 1;
      int index2 = dgv.SelectedCells[0].RowIndex;
      int num1 = dgv.SelectedCells[index1].RowIndex;
      if (index2 > num1)
      {
        int num2 = index2;
        index2 = num1;
        num1 = num2;
      }
      int count = num1 - index2 + 1;
      if (selectedIndex == 0 && index2 == 0)
      {
        this.ShowEntryCH0ErrMsg();
      }
      else
      {
        if (count > 0)
        {
          this.backup();
          for (int index3 = 0; index3 < count; ++index3)
            dgv.Rows.RemoveAt(index2);
          dgv.Rows.Add(count);
          this.resetRowNo();
        }
        this.allLimited(dgv);
        this.IsSave = false;
      }
    }

    private void resetRowNo()
    {
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      DataGridView dataGridView = this.selectedDgv();
      BindingList<BandMemory> bindingList = this.selectedDB();
      for (int index = 0; index < bindingList.Count; ++index)
      {
        switch (selectedIndex)
        {
          case 0:
          case 5:
            dataGridView.Rows[index].HeaderCell.Value = (object) string.Concat((object) (index + 1));
            break;
          case 1:
            dataGridView.Rows[index].HeaderCell.Value = (object) string.Concat((object) (index + 901));
            break;
          case 2:
            if (index % 2 == 1)
            {
              dataGridView.Rows[index].HeaderCell.Value = (object) ("U" + (object) (index / 2 + 1));
              break;
            }
            dataGridView.Rows[index].HeaderCell.Value = (object) ("L" + (object) (index / 2 + 1));
            break;
          default:
            if (Settings.Instance.CpuType == 1)
            {
              dataGridView.Rows[index].HeaderCell.Value = (object) this.tbl_BandName[index];
              break;
            }
            dataGridView.Rows[index].HeaderCell.Value = (object) this.tbl_BandName_eng[index];
            break;
        }
      }
    }

    public void Up()
    {
      if (!this.isUp())
        return;
      DataGridView dgv = this.selectedDgv();
      int rowIndex = dgv.SelectedCells[0].RowIndex;
      this.backup();
      object[] objArray1 = new object[52];
      object[] objArray2 = new object[52];
      for (int index = 0; index < dgv.ColumnCount; ++index)
      {
        objArray1[index] = dgv.Rows[rowIndex].Cells[index].Value;
        objArray2[index] = dgv.Rows[rowIndex - 1].Cells[index].Value;
        dgv.Rows[rowIndex - 1].Cells[index].Value = objArray1[index];
        dgv.Rows[rowIndex].Cells[index].Value = objArray2[index];
      }
      dgv.CurrentCell = dgv[dgv.SelectedCells[0].ColumnIndex, dgv.SelectedCells[0].RowIndex - 1];
      dgv.Focus();
      this.allLimited(dgv);
      this.IsSave = false;
    }

    public void Down()
    {
      if (!this.isDown())
        return;
      DataGridView dgv = this.selectedDgv();
      int rowIndex = dgv.SelectedCells[0].RowIndex;
      this.backup();
      object[] objArray1 = new object[52];
      object[] objArray2 = new object[52];
      for (int index = 0; index < dgv.ColumnCount; ++index)
      {
        objArray1[index] = dgv.Rows[rowIndex].Cells[index].Value;
        objArray2[index] = dgv.Rows[rowIndex + 1].Cells[index].Value;
        dgv.Rows[rowIndex + 1].Cells[index].Value = objArray1[index];
        dgv.Rows[rowIndex].Cells[index].Value = objArray2[index];
      }
      dgv.CurrentCell = dgv[dgv.SelectedCells[0].ColumnIndex, dgv.SelectedCells[0].RowIndex + 1];
      dgv.Focus();
      this.allLimited(dgv);
      this.IsSave = false;
    }

    public void MoveChannel(int channel)
    {
      if (!this.isDelet())
        return;
      DataGridView dgv = this.selectedDgv();
      int rowIndex = dgv.SelectedCells[0].RowIndex;
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      if (channel == 1 && selectedIndex == 0 && this.isBrank(dgv, rowIndex, 1))
      {
        this.ShowEntryCH0ErrMsg();
      }
      else
      {
        this.backup();
        object[] objArray = new object[52];
        for (int index = 0; index < dgv.ColumnCount; ++index)
        {
          objArray[index] = dgv.Rows[rowIndex].Cells[index].Value;
          dgv.Rows[channel - 1].Cells[index].Value = objArray[index];
        }
        this.clear(dgv, rowIndex);
        dgv.CurrentCell = dgv[dgv.SelectedCells[0].ColumnIndex, channel - 1];
        dgv.Focus();
        this.allLimited(dgv);
        this.IsSave = false;
      }
    }

    public bool Fined(int colNum, string data)
    {
      return this.fined(this.selectedDgv(), colNum, 0, data);
    }

    public void FinedNext()
    {
      DataGridView scrDgv = this.selectedDgv();
      this.fined(scrDgv, this.finedCol, scrDgv.SelectedCells[0].RowIndex + 1, this.finedStr);
    }

    private bool fined(DataGridView scrDgv, int colNum, int startRow, string data)
    {
      bool flag = false;
      int num1 = startRow;
      int index1 = num1;
      if (1 <= colNum && colNum <= 3)
      {
        Decimal num2 = data == "" || data == null ? new Decimal(0) : Decimal.Parse(data);
        for (int index2 = num1; index2 < scrDgv.RowCount; ++index2)
        {
          if (scrDgv[colNum, index2].Visible)
          {
            Decimal num3 = scrDgv[colNum, index2].Value != null ? (!(scrDgv[colNum, index2].Value.ToString() == "") ? Decimal.Parse(scrDgv[colNum, index2].Value.ToString()) : new Decimal(0)) : new Decimal(0);
            if (num2 == num3)
            {
              index1 = index2;
              flag = true;
              break;
            }
          }
        }
      }
      else
      {
        if (data == null)
          data = "";
        for (int index2 = num1; index2 < scrDgv.RowCount; ++index2)
        {
          if (scrDgv[colNum, index2].Visible)
          {
            string str = scrDgv[colNum, index2].Value != null ? (!(scrDgv.Columns[colNum] is DataGridViewCheckBoxColumn) ? scrDgv[colNum, index2].Value.ToString() : (!scrDgv[colNum, index2].EditedFormattedValue.Equals((object) true) ? "0" : "1")) : "";
            if (data == str)
            {
              index1 = index2;
              flag = true;
              break;
            }
          }
        }
      }
      if (flag)
      {
        this.finedCol = colNum;
        this.finedStr = data;
        scrDgv.FirstDisplayedScrollingRowIndex = index1;
        scrDgv.CurrentCell = scrDgv[colNum, index1];
        scrDgv.Focus();
        this.mfd.menu_EditFinedNext.Enabled = true;
      }
      else
      {
        int num4 = (int) MessageBox.Show(this.resources.GetString("SEARCHNOHIT"), this.resources.GetString("INFOMSG"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      return flag;
    }

    public bool AddFreq(Decimal startFreq, int addChannel, string step)
    {
      Decimal num1 = Decimal.Parse(step.Replace("KHz", ""));
      Decimal fstep = num1 / new Decimal(1000);
      DataGridView dgv = this.selectedDgv();
      int bandIdx1 = DataForm.GetBandIdx(startFreq);
      if (bandIdx1 == -1 || DataForm.isRecvDisableAria(startFreq))
        return false;
      Decimal frq1 = startFreq + fstep * (Decimal) addChannel - fstep;
      if (DataForm.GetBandIdx(frq1) == -1 || Array.IndexOf<string>(this.GetSTEPList(frq1), step) == -1)
        return false;
      Decimal rFreq = startFreq;
      for (int index = 0; index < addChannel; ++index)
      {
        if (DataForm.isRecvDisableAria(rFreq))
          return false;
        rFreq += fstep;
      }
      if (!DataForm.checkStepFreq(startFreq - DataForm.tbl_Freq[bandIdx1, Settings.Instance.Destination, 0], fstep))
        return false;
      this.backup();
      int index1 = 0;
      if (fstep == new Decimal(833, 0, 0, false, (byte) 5))
      {
        for (int index2 = 0; index2 < DataForm.tbl_Add833KHz.Length; ++index2)
        {
          Decimal num2 = startFreq - DataForm.tbl_Add833KHz[index2];
          if (num2 % new Decimal(10000, 0, 0, false, (byte) 5) == new Decimal(0))
          {
            index1 = index2;
            startFreq = num2;
            break;
          }
        }
      }
      for (int index2 = 0; index2 < addChannel; ++index2)
      {
        int index3 = dgv.SelectedCells[0].RowIndex + index2;
        Decimal frq2;
        if (fstep == new Decimal(833, 0, 0, false, (byte) 5))
        {
          frq2 = startFreq + DataForm.tbl_Add833KHz[index1];
          ++index1;
          if (index1 >= DataForm.tbl_Add833KHz.Length)
          {
            startFreq += new Decimal(10000, 0, 0, false, (byte) 5);
            index1 = 0;
          }
        }
        else
          frq2 = startFreq + fstep * (Decimal) index2;
        dgv[1, index3].Value = (object) frq2.ToString("0.00000");
        dgv[2, index3].Value = (object) frq2.ToString("0.00000");
        int bandIdx2 = DataForm.GetBandIdx(frq2);
        for (int index4 = 3; index4 < dgv.ColumnCount; ++index4)
          dgv.Rows[index3].Cells[index4].Value = Settings.Instance.CpuType != 1 ? (index4 != 11 || Settings.Instance.CountryType != 0 ? DataForm.tbl_Default_Eng[bandIdx2, index4] : DataForm.tbl_Default_Jpn[bandIdx2, index4]) : DataForm.tbl_Default_Jpn[bandIdx2, index4];
        dgv.Rows[index3].Cells[17].Value = (object) false;
        dgv.Rows[index3].Cells[18].Value = (object) (num1.ToString() + "KHz");
      }
      this.allLimited(dgv);
      this.IsSave = false;
      return true;
    }

    public void Sort(int col1, int col2, int updn, int range)
    {
      DataGridView dgv = this.selectedDgv();
      int rowIndex = dgv.SelectedCells[0].RowIndex;
      this.backup();
      int colNum1 = col1;
      int colNum2 = col2 - 1;
      int rowMin;
      int rowMax;
      if (range == 0)
      {
        int index = dgv.SelectedCells.Count - 1;
        rowMin = dgv.SelectedCells[0].RowIndex;
        rowMax = dgv.SelectedCells[index].RowIndex;
        if (rowMin == rowMax)
          return;
        if (rowMin > rowMax)
        {
          int num = rowMin;
          rowMin = rowMax;
          rowMax = num;
        }
      }
      else
      {
        rowMin = 0;
        rowMax = dgv.RowCount - 1;
      }
      if (col2 > 0)
        this.sort(dgv, rowMin, rowMax, colNum1, colNum2, updn);
      else
        this.sort(dgv, rowMin, rowMax, colNum1, 0, updn);
      this.allLimited(dgv);
      this.IsSave = false;
    }

    private void sort(
      DataGridView dgv,
      int rowMin,
      int rowMax,
      int colNum1,
      int colNum2,
      int updn)
    {
      for (int src = rowMin; src < rowMax; ++src)
      {
        for (int dst = src + 1; dst <= rowMax; ++dst)
        {
          Decimal num1 = new Decimal(0);
          if ((dgv[colNum1, src].Value != null || dgv[colNum1, dst].Value != null) && (dgv[colNum1, src].Value == null || dgv[colNum1, dst].Value != null))
          {
            if (dgv[colNum1, src].Value == null && dgv[colNum1, dst].Value != null)
            {
              if (updn == 0)
                this.changeRow(dgv, src, dst);
              if (updn == 1)
                this.changeRow(dgv, src, dst);
            }
            else if ((!(dgv[1, src].Value.ToString() == "") || !(dgv[1, dst].Value.ToString() == "")) && (!(dgv[1, src].Value.ToString() != "") || !(dgv[1, dst].Value.ToString() == "")) && (!(dgv[colNum1, src].Value.ToString() != "") || !(dgv[colNum1, dst].Value.ToString() == "")))
            {
              if (dgv[colNum1, src].Value.ToString() == "" && dgv[colNum1, dst].Value.ToString() != "")
              {
                if (updn == 0)
                  this.changeRow(dgv, src, dst);
                if (updn == 1)
                  this.changeRow(dgv, src, dst);
              }
              else if (dgv[colNum1, src].Value.ToString() != "" && dgv[colNum1, dst].Value.ToString() != "")
              {
                Decimal num2;
                switch (colNum1)
                {
                  case 1:
                  case 2:
                  case 3:
                    num2 = Decimal.Parse(dgv[colNum1, src].Value.ToString()) - Decimal.Parse(dgv[colNum1, dst].Value.ToString());
                    break;
                  case 4:
                  case 6:
                  case 7:
                  case 8:
                  case 10:
                  case 11:
                  case 12:
                  case 13:
                  case 14:
                  case 15:
                  case 16:
                  case 18:
                  case 22:
                  case 23:
                    num2 = (Decimal) ((int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum1), dgv.Rows[src].Cells[colNum1].Value.ToString()) - (int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum1), dgv.Rows[dst].Cells[colNum1].Value.ToString()));
                    break;
                  case 9:
                  case 51:
                    num2 = (Decimal) string.Compare(dgv[colNum1, src].Value.ToString(), dgv[colNum1, dst].Value.ToString());
                    break;
                  default:
                    int num3 = 0;
                    int num4 = 0;
                    if (dgv[colNum1, src].EditedFormattedValue.Equals((object) true))
                      num3 = 1;
                    if (dgv[colNum1, dst].EditedFormattedValue.Equals((object) true))
                      num4 = 1;
                    num2 = (Decimal) (num3 - num4);
                    break;
                }
                if (updn == 0)
                {
                  if (num2 > new Decimal(0))
                    this.changeRow(dgv, src, dst);
                  else if (num2 == new Decimal(0))
                  {
                    Decimal num5 = new Decimal(0);
                    if ((dgv[colNum2, src].Value != null || dgv[colNum2, dst].Value != null) && (dgv[colNum2, src].Value == null || dgv[colNum2, dst].Value != null))
                    {
                      if (dgv[colNum2, src].Value == null && dgv[colNum2, dst].Value != null)
                        this.changeRow(dgv, src, dst);
                      else if (!(dgv[colNum2, src].Value.ToString() != "") || !(dgv[colNum2, dst].Value.ToString() == ""))
                      {
                        if (dgv[colNum2, src].Value.ToString() == "" && dgv[colNum2, dst].Value.ToString() != "")
                          this.changeRow(dgv, src, dst);
                        else if (dgv[colNum2, src].Value.ToString() != "" && dgv[colNum2, dst].Value.ToString() != "")
                        {
                          switch (colNum2)
                          {
                            case 1:
                            case 2:
                            case 3:
                              num5 = Decimal.Parse(dgv[colNum2, src].Value.ToString()) - Decimal.Parse(dgv[colNum2, dst].Value.ToString());
                              break;
                            case 4:
                            case 6:
                            case 7:
                            case 8:
                            case 10:
                            case 11:
                            case 12:
                            case 13:
                            case 14:
                            case 15:
                            case 16:
                            case 18:
                            case 22:
                            case 23:
                              num5 = (Decimal) ((int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum2), dgv.Rows[src].Cells[colNum2].Value.ToString()) - (int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum2), dgv.Rows[dst].Cells[colNum2].Value.ToString()));
                              break;
                            case 9:
                            case 51:
                              num5 = (Decimal) string.Compare(dgv[colNum2, src].Value.ToString(), dgv[colNum2, dst].Value.ToString());
                              break;
                            default:
                              int num6 = 0;
                              int num7 = 0;
                              if (dgv[colNum2, src].EditedFormattedValue.Equals((object) true))
                                num6 = 1;
                              if (dgv[colNum2, dst].EditedFormattedValue.Equals((object) true))
                                num7 = 1;
                              num5 = (Decimal) (num6 - num7);
                              break;
                          }
                        }
                      }
                    }
                    if (num5 > new Decimal(0))
                      this.changeRow(dgv, src, dst);
                  }
                }
                else if (num2 < new Decimal(0))
                  this.changeRow(dgv, src, dst);
                else if (num2 == new Decimal(0))
                {
                  Decimal num5 = new Decimal(0);
                  if ((dgv[colNum2, src].Value != null || dgv[colNum2, dst].Value != null) && (dgv[colNum2, src].Value == null || dgv[colNum2, dst].Value != null))
                  {
                    if (dgv[colNum2, src].Value == null && dgv[colNum2, dst].Value != null)
                      this.changeRow(dgv, src, dst);
                    else if (!(dgv[colNum2, src].Value.ToString() != "") || !(dgv[colNum2, dst].Value.ToString() == ""))
                    {
                      if (dgv[colNum2, src].Value.ToString() == "" && dgv[colNum2, dst].Value.ToString() != "")
                        this.changeRow(dgv, src, dst);
                      else if (dgv[colNum2, src].Value.ToString() != "" && dgv[colNum2, dst].Value.ToString() != "")
                      {
                        switch (colNum2)
                        {
                          case 1:
                          case 2:
                          case 3:
                            num5 = Decimal.Parse(dgv[colNum2, src].Value.ToString()) - Decimal.Parse(dgv[colNum2, dst].Value.ToString());
                            break;
                          case 4:
                          case 6:
                          case 7:
                          case 8:
                          case 10:
                          case 11:
                          case 12:
                          case 13:
                          case 14:
                          case 15:
                          case 16:
                          case 18:
                          case 22:
                          case 23:
                            num5 = (Decimal) ((int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum2), dgv.Rows[src].Cells[colNum2].Value.ToString()) - (int) (byte) Array.IndexOf<string>(this.selectedDgvList(colNum2), dgv.Rows[dst].Cells[colNum2].Value.ToString()));
                            break;
                          case 9:
                          case 51:
                            num5 = (Decimal) string.Compare(dgv[colNum2, src].Value.ToString(), dgv[colNum2, dst].Value.ToString());
                            break;
                          default:
                            int num6 = 0;
                            int num7 = 0;
                            if (dgv[colNum2, src].EditedFormattedValue.Equals((object) true))
                              num6 = 1;
                            if (dgv[colNum2, dst].EditedFormattedValue.Equals((object) true))
                              num7 = 1;
                            num5 = (Decimal) (num6 - num7);
                            break;
                        }
                      }
                    }
                  }
                  if (num5 < new Decimal(0))
                    this.changeRow(dgv, src, dst);
                }
              }
            }
          }
        }
      }
    }

    private void allLimited(DataGridView dgv)
    {
      for (int row = 0; row < dgv.Rows.Count; ++row)
        this.inputLimited(dgv, row);
    }

    private bool isDelet()
    {
      DataGridView dataGridView = this.selectedDgv();
      int rowIndex = dataGridView.SelectedCells[0].RowIndex;
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      if (dataGridView == null)
        return false;
      if (selectedIndex == 0 && rowIndex == 0)
      {
        this.ShowEntryCH0ErrMsg();
        return false;
      }
      return selectedIndex <= 3;
    }

    private bool isUp()
    {
      DataGridView dgv = this.selectedDgv();
      int rowIndex = dgv.SelectedCells[0].RowIndex;
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      if (dgv == null)
        return false;
      if (dgv.SelectedCells[0].RowIndex == 0)
      {
        if (selectedIndex == 0)
          this.ShowEntryCH0ErrMsg();
        return false;
      }
      if (selectedIndex != 0 || dgv.SelectedCells[0].RowIndex != 1 || !this.isBrank(dgv, 1, 1))
        return true;
      this.ShowEntryCH0ErrMsg();
      return false;
    }

    private bool isDown()
    {
      DataGridView dgv = this.selectedDgv();
      int rowIndex = dgv.SelectedCells[0].RowIndex;
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      if (dgv == null || dgv.SelectedCells[0].RowIndex == dgv.RowCount - 1)
        return false;
      if (selectedIndex != 0 || dgv.SelectedCells[0].RowIndex != 0 || !this.isBrank(dgv, 1, 1))
        return true;
      this.ShowEntryCH0ErrMsg();
      return false;
    }

    private bool isBrank(DataGridView dgv, int row, int col)
    {
      return dgv.Rows[row].Cells[col].Value == null || dgv.Rows[row].Cells[col].Value.ToString() == "";
    }

    private DataGridView selectedDgv()
    {
      DataGridView dataGridView = (DataGridView) null;
      switch (this.tabc_DataForm.SelectedIndex)
      {
        case 0:
          dataGridView = this.dgv_Normal;
          break;
        case 1:
          dataGridView = this.dgv_Skip;
          break;
        case 2:
          dataGridView = this.dgv_Pms;
          break;
        case 3:
          dataGridView = this.dgv_Vfo;
          break;
        case 4:
          dataGridView = this.dgv_Home;
          break;
        case 5:
          dataGridView = this.dgv_Wx;
          break;
      }
      return dataGridView;
    }

    private BindingList<BandMemory> selectedDB()
    {
      BindingList<BandMemory> bindingList = (BindingList<BandMemory>) null;
      switch (this.tabc_DataForm.SelectedIndex)
      {
        case 0:
          bindingList = this.db.NormalMemory;
          break;
        case 1:
          bindingList = this.db.SkipMemory;
          break;
        case 2:
          bindingList = this.db.PmsMemory;
          break;
        case 3:
          bindingList = this.db.VfoMemory;
          break;
        case 4:
          bindingList = this.db.HomeMemory;
          break;
        case 5:
          bindingList = this.db.WxMemory;
          break;
      }
      return bindingList;
    }

    private static bool checkStepFreq(Decimal frq, Decimal fstep)
    {
      if (fstep == new Decimal(833, 0, 0, false, (byte) 5))
      {
        for (int index = 0; index < DataForm.tbl_Add833KHz.Length; ++index)
        {
          if ((frq - DataForm.tbl_Add833KHz[index]) % new Decimal(10000, 0, 0, false, (byte) 5) == new Decimal(0))
            return true;
        }
      }
      else if (frq % fstep == new Decimal(0) && fstep != new Decimal(1500, 0, 0, false, (byte) 5))
        return true;
      return false;
    }

    private static int bandIdx(Decimal frq)
    {
      for (int index = 0; index < DataForm.tbl_Freq.GetLength(0); ++index)
      {
        if (DataForm.tbl_Freq[index, Settings.Instance.Destination, 0] <= frq && frq < DataForm.tbl_Freq[index, Settings.Instance.Destination, 1])
          return index;
      }
      return -1;
    }

    private void changeRow(DataGridView dgv, int src, int dst)
    {
      object[] objArray1 = new object[52];
      object[] objArray2 = new object[52];
      for (int index = 0; index < dgv.ColumnCount; ++index)
      {
        objArray1[index] = dgv.Rows[src].Cells[index].Value;
        objArray2[index] = dgv.Rows[dst].Cells[index].Value;
        dgv.Rows[dst].Cells[index].Value = objArray1[index];
        dgv.Rows[src].Cells[index].Value = objArray2[index];
      }
    }

    private void backup()
    {
      DataGridView dataGridView = this.selectedDgv();
      int selectedIndex = this.tabc_DataForm.SelectedIndex;
      if (dataGridView != null)
      {
        for (int index1 = 0; index1 < dataGridView.RowCount; ++index1)
        {
          for (int index2 = 0; index2 < dataGridView.ColumnCount; ++index2)
            this.backupObj[selectedIndex][index1, index2] = dataGridView.Rows[index1].Cells[index2].Value;
        }
      }
      this.mfd.EnableUndo();
    }

    public void EditEnd()
    {
      this.dgv_Normal.EndEdit();
      this.dgv_Skip.EndEdit();
      this.dgv_Pms.EndEdit();
      this.dgv_Vfo.EndEdit();
      this.dgv_Home.EndEdit();
      this.dgv_Wx.EndEdit();
    }

    private static bool isRecvDisableAria(Decimal rFreq)
    {
      bool flag = false;
      int destination = Settings.Instance.Destination;
      int index = DataForm.bandIdx(rFreq);
      if (DataForm.tbl_ReadOnlyCell[index, Settings.Instance.Destination])
        flag = true;
      return flag;
    }

    private int auto_Mode(Decimal frq)
    {
      int num = 0;
      if (Settings.Instance.Destination == 1 || Settings.Instance.Destination == 0 || (Settings.Instance.Destination == 17 || Settings.Instance.Destination == 18) || (Settings.Instance.Destination == 19 || Settings.Instance.Destination == 23))
        num = !(frq < new Decimal(137)) ? (!(frq < new Decimal(222)) ? (!(frq < new Decimal(2504, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(300)) ? (!(frq < new Decimal(336)) ? 0 : 1) : 0) : 1) : 0) : 1;
      else if (Settings.Instance.Destination == 2 || Settings.Instance.Destination == 3 || (Settings.Instance.Destination == 4 || Settings.Instance.Destination == 5) || (Settings.Instance.Destination == 6 || Settings.Instance.Destination == 7 || (Settings.Instance.Destination == 20 || Settings.Instance.Destination == 21)) || Settings.Instance.Destination == 22)
        num = !(frq < new Decimal(137)) ? (!(frq < new Decimal(300)) ? (!(frq < new Decimal(336)) ? 0 : 1) : 0) : 1;
      else if (Settings.Instance.Destination == 8 || Settings.Instance.Destination == 9 || (Settings.Instance.Destination == 10 || Settings.Instance.Destination == 11) || (Settings.Instance.Destination == 12 || Settings.Instance.Destination == 13 || (Settings.Instance.Destination == 14 || Settings.Instance.Destination == 15)) || Settings.Instance.Destination == 16)
        num = !(frq < new Decimal(137)) ? (!(frq < new Decimal(300)) ? (!(frq < new Decimal(320)) ? 0 : 1) : 0) : 1;
      else if (Settings.Instance.Destination == 24 && !(frq < new Decimal(144)))
      {
        if (frq < new Decimal(146))
          num = 0;
        else if (!(frq < new Decimal(430)) && frq < new Decimal(440))
          num = 0;
      }
      return num;
    }

    private int auto_Step(Decimal frq)
    {
      int num = 0;
      if (Settings.Instance.Destination == 1 || Settings.Instance.Destination == 0 || (Settings.Instance.Destination == 17 || Settings.Instance.Destination == 18) || (Settings.Instance.Destination == 19 || Settings.Instance.Destination == 23))
        num = !(frq < new Decimal(137)) ? (!(frq < new Decimal(142)) ? (!(frq < new Decimal(148)) ? (!(frq < new Decimal(156)) ? (!(frq < new Decimal(15745, 0, 0, false, (byte) 2)) ? (!(frq < new Decimal(1606, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(160975, 0, 0, false, (byte) 3)) ? (!(frq < new Decimal(1615, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(1629, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(174)) ? (!(frq < new Decimal(222)) ? (!(frq < new Decimal(2504, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(300)) ? (!(frq < new Decimal(336)) ? (!(frq < new Decimal(430)) ? (!(frq < new Decimal(440)) ? (!(frq < new Decimal(4595, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(4648, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(470)) ? 8 : 4) : 7) : 4) : 6) : 4) : 9) : 4) : 9) : 8) : 3) : 7) : 0) : 7) : 3) : 7) : 3) : 6) : 3) : 7;
      else if (Settings.Instance.Destination == 2 || Settings.Instance.Destination == 3 || (Settings.Instance.Destination == 4 || Settings.Instance.Destination == 5) || (Settings.Instance.Destination == 6 || Settings.Instance.Destination == 7 || (Settings.Instance.Destination == 20 || Settings.Instance.Destination == 21)) || Settings.Instance.Destination == 22)
        num = !(frq < new Decimal(137)) ? (!(frq < new Decimal(144)) ? (!(frq < new Decimal(148)) ? (!(frq < new Decimal(156)) ? (!(frq < new Decimal(15745, 0, 0, false, (byte) 2)) ? (!(frq < new Decimal(1606, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(160975, 0, 0, false, (byte) 3)) ? (!(frq < new Decimal(1615, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(1629, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(174)) ? (!(frq < new Decimal(222)) ? (!(frq < new Decimal(225)) ? (!(frq < new Decimal(300)) ? (!(frq < new Decimal(336)) ? (!(frq < new Decimal(420)) ? (!(frq < new Decimal(450)) ? (!(frq < new Decimal(470)) ? 8 : 4) : 7) : 4) : 9) : 4) : 6) : 8) : 4) : 7) : 4) : 7) : 4) : 7) : 4) : 0) : 4) : 7;
      else if (Settings.Instance.Destination == 8 || Settings.Instance.Destination == 9 || (Settings.Instance.Destination == 10 || Settings.Instance.Destination == 11) || (Settings.Instance.Destination == 12 || Settings.Instance.Destination == 13 || (Settings.Instance.Destination == 14 || Settings.Instance.Destination == 15)) || Settings.Instance.Destination == 16)
        num = !(frq < new Decimal(137)) ? (!(frq < new Decimal(1606, 0, 0, false, (byte) 1)) ? (!(frq < new Decimal(162025, 0, 0, false, (byte) 3)) ? (!(frq < new Decimal(174)) ? (!(frq < new Decimal(222)) ? (!(frq < new Decimal(300)) ? (!(frq < new Decimal(320)) ? (!(frq < new Decimal(430)) ? (!(frq < new Decimal(440)) ? (!(frq < new Decimal(470)) ? 8 : 4) : 7) : 4) : 7) : 4) : 8) : 4) : 7) : 4) : 7;
      else if (Settings.Instance.Destination == 24 && !(frq < new Decimal(144)))
      {
        if (frq < new Decimal(146))
          num = 4;
        else if (!(frq < new Decimal(430)) && frq < new Decimal(440))
          num = 7;
      }
      return num;
    }

    private void rFrqCheck_jpn(DataGridView dgv, int row, Decimal frq)
    {
      if (new Decimal(439) <= frq && frq < new Decimal(440))
      {
        dgv[3, row].Value = (object) new Decimal(5).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[1];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[8];
        dgv[2, row].Value = (object) (frq - new Decimal(5)).ToString("0.00000");
      }
      else
      {
        if (!(new Decimal(3802125, 0, 0, false, (byte) 4) <= frq) || !(frq <= new Decimal(3813125, 0, 0, false, (byte) 4)))
          return;
        dgv[3, row].Value = (object) new Decimal(12635, 0, 0, false, (byte) 2).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[8];
        dgv[2, row].Value = (object) (frq - new Decimal(12635, 0, 0, false, (byte) 2)).ToString("0.00000");
      }
    }

    private void rFrqCheck_usa(DataGridView dgv, int row, Decimal frq)
    {
      if (new Decimal(1451, 0, 0, false, (byte) 1) <= frq && frq < new Decimal(1455, 0, 0, false, (byte) 1))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else if (new Decimal(146) <= frq && frq < new Decimal(1464, 0, 0, false, (byte) 1))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[2];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq + new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else if (new Decimal(1466, 0, 0, false, (byte) 1) <= frq && frq < new Decimal(147))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else if (new Decimal(147) <= frq && frq < new Decimal(1474, 0, 0, false, (byte) 1))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[2];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq + new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else if (new Decimal(1476, 0, 0, false, (byte) 1) <= frq && frq < new Decimal(148))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else if (new Decimal(22392, 0, 0, false, (byte) 2) <= frq && frq <= new Decimal(22498, 0, 0, false, (byte) 2))
      {
        if (Settings.Instance.CpuType != 0)
          return;
        dgv[3, row].Value = (object) new Decimal(16, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(16, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else if (new Decimal(440) < frq && frq < new Decimal(445))
      {
        dgv[3, row].Value = (object) new Decimal(5).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[2];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq + new Decimal(5)).ToString("0.00000");
      }
      else
      {
        if (!(new Decimal(445) < frq) || !(frq < new Decimal(450)))
          return;
        dgv[3, row].Value = (object) new Decimal(5).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(5)).ToString("0.00000");
      }
    }

    private void rFrqCheck_brd(DataGridView dgv, int row, Decimal frq)
    {
      if (new Decimal(1456, 0, 0, false, (byte) 1) <= frq && frq <= new Decimal(1458, 0, 0, false, (byte) 1))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else
      {
        if (!(new Decimal(4382, 0, 0, false, (byte) 1) <= frq) || !(frq < new Decimal(43945, 0, 0, false, (byte) 2)))
          return;
        dgv[3, row].Value = (object) new Decimal(76, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(76, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
    }

    private void rFrqCheck_eu1(DataGridView dgv, int row, Decimal frq)
    {
      if (new Decimal(1456, 0, 0, false, (byte) 1) <= frq && frq <= new Decimal(1458, 0, 0, false, (byte) 1))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else
      {
        if (!(new Decimal(433) <= frq) || !(frq < new Decimal(4334, 0, 0, false, (byte) 1)))
          return;
        dgv[3, row].Value = (object) new Decimal(16, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[2];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq + new Decimal(16, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
    }

    private void rFrqCheck_eu2(DataGridView dgv, int row, Decimal frq)
    {
      if (new Decimal(1456, 0, 0, false, (byte) 1) <= frq && frq <= new Decimal(1458, 0, 0, false, (byte) 1))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else
      {
        if (!(new Decimal(433) <= frq) || !(frq < new Decimal(4334, 0, 0, false, (byte) 1)))
          return;
        dgv[3, row].Value = (object) new Decimal(16, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[2];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq + new Decimal(16, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
    }

    private void rFrqCheck_aus(DataGridView dgv, int row, Decimal frq)
    {
      if (new Decimal(146625, 0, 0, false, (byte) 3) <= frq && frq <= new Decimal(147))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else if (new Decimal(147025, 0, 0, false, (byte) 3) <= frq && frq < new Decimal(14738, 0, 0, false, (byte) 2))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[2];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq + new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else if (new Decimal(147625, 0, 0, false, (byte) 3) <= frq && frq < new Decimal(14798, 0, 0, false, (byte) 2))
      {
        dgv[3, row].Value = (object) new Decimal(6, 0, 0, false, (byte) 1).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(6, 0, 0, false, (byte) 1)).ToString("0.00000");
      }
      else
      {
        if (!(new Decimal(438025, 0, 0, false, (byte) 3) <= frq) || !(frq <= new Decimal(439975, 0, 0, false, (byte) 3)))
          return;
        dgv[3, row].Value = (object) new Decimal(5).ToString("0.00000");
        dgv[4, row].Value = (object) this.tbl_ShiftDir[1];
        dgv[10, row].Value = (object) this.tbl_SqlType[0];
        dgv[11, row].Value = (object) this.tbl_ToneFrq[12];
        dgv[2, row].Value = (object) (frq - new Decimal(5)).ToString("0.00000");
      }
    }

    private void auto_ARS(DataGridView dgv, int row, Decimal frq)
    {
      if (Settings.Instance.CpuType == 1)
        this.rFrqCheck_jpn(dgv, row, frq);
      else if (Settings.Instance.CpuType == 0)
        this.rFrqCheck_usa(dgv, row, frq);
      else if (Settings.Instance.CountryType == 0)
        this.rFrqCheck_jpn(dgv, row, frq);
      else if (Settings.Instance.CountryType == 1)
        this.rFrqCheck_usa(dgv, row, frq);
      else if (Settings.Instance.CountryType == 2)
        this.rFrqCheck_brd(dgv, row, frq);
      else if (Settings.Instance.CountryType == 3)
        this.rFrqCheck_eu1(dgv, row, frq);
      else if (Settings.Instance.CountryType == 4)
      {
        this.rFrqCheck_eu2(dgv, row, frq);
      }
      else
      {
        if (Settings.Instance.CountryType != 5)
          return;
        this.rFrqCheck_aus(dgv, row, frq);
      }
    }

    private void DataForm_Activated(object sender, EventArgs e)
    {
      this.mfd.MenuToolStripSetting(this.tabc_DataForm.SelectedIndex, this.IsSend);
    }

    private void tabc_DataForm_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.mfd.MenuToolStripSetting(this.tabc_DataForm.SelectedIndex, this.IsSend);
    }

    public void ShowEntryFreqErrMsg()
    {
      int num = (int) MessageBox.Show(this.resources.GetString("FREQERRORMSG"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    public void ShowEntryCH0ErrMsg()
    {
      int num = (int) MessageBox.Show(this.resources.GetString("CH0ERRORMSG"), this.resources.GetString("ERRORMSG"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    private void SetDcsDimItems()
    {
      this.strItem[0] = this.resources.GetString("DCSDIMITEM1");
      this.strItem[1] = this.resources.GetString("DCSDIMITEM2");
      this.strItem[2] = this.resources.GetString("DCSDIMITEM3");
      this.strItem[3] = this.resources.GetString("DCSDIMITEM4");
      this.strItem[4] = this.resources.GetString("DCSDIMITEM5");
      this.strItem[5] = this.resources.GetString("DCSDIMITEM6");
      this.col_Skip_DcsDim.Items.Clear();
      this.col_Skip_DcsDim.Items.AddRange((object) this.strItem[0], (object) this.strItem[1], (object) this.strItem[2], (object) this.strItem[3], (object) this.strItem[4], (object) this.strItem[5]);
      this.col_Pmf_DcsDim.Items.Clear();
      this.col_Pmf_DcsDim.Items.AddRange((object) this.strItem[0], (object) this.strItem[1], (object) this.strItem[2], (object) this.strItem[3], (object) this.strItem[4], (object) this.strItem[5]);
      this.col_Vfo_DcsDim.Items.Clear();
      this.col_Vfo_DcsDim.Items.AddRange((object) this.strItem[0], (object) this.strItem[1], (object) this.strItem[2], (object) this.strItem[3], (object) this.strItem[4], (object) this.strItem[5]);
      this.col_Home_DcsDim.Items.Clear();
      this.col_Home_DcsDim.Items.AddRange((object) this.strItem[0], (object) this.strItem[1], (object) this.strItem[2], (object) this.strItem[3], (object) this.strItem[4], (object) this.strItem[5]);
      this.col_Normal_DscDim.Items.Clear();
      this.col_Normal_DscDim.Items.AddRange((object) this.strItem[0], (object) this.strItem[1], (object) this.strItem[2], (object) this.strItem[3], (object) this.strItem[4], (object) this.strItem[5]);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DataForm));
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle11 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle12 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle13 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle14 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle15 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle16 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle17 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle18 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle19 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle20 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle21 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle22 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle23 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle24 = new DataGridViewCellStyle();
      this.tabc_DataForm = new TabControl();
      this.tab_Normal = new TabPage();
      this.dgv_Normal = new DataGridView();
      this.tab_Skip = new TabPage();
      this.dgv_Skip = new DataGridView();
      this.col_Skip_Ch = new DataGridViewCheckBoxColumn();
      this.col_Skip_RxFrq = new DataGridViewTextBoxColumn();
      this.col_Skip_TxFrq = new DataGridViewTextBoxColumn();
      this.col_Skip_ShiftFrq = new DataGridViewTextBoxColumn();
      this.col_Skip_ShiftDir = new DataGridViewComboBoxColumn();
      this.col_Skip_AutoMode = new DataGridViewCheckBoxColumn();
      this.col_Skip_Mode = new DataGridViewComboBoxColumn();
      this.col_Skip_Ams = new DataGridViewComboBoxColumn();
      this.col_Skip_DigAnalog = new DataGridViewComboBoxColumn();
      this.col_Skip_MemName = new DataGridViewTextBoxColumn();
      this.col_Skip_SqlType = new DataGridViewComboBoxColumn();
      this.col_Skip_ToneFrq = new DataGridViewComboBoxColumn();
      this.col_Skip_DcsCode = new DataGridViewComboBoxColumn();
      this.col_Skip_DcsDim = new DataGridViewComboBoxColumn();
      this.col_Skip_PrTone = new DataGridViewComboBoxColumn();
      this.col_Skip_TxOutput = new DataGridViewComboBoxColumn();
      this.col_Skip_Skip = new DataGridViewComboBoxColumn();
      this.col_Skip_AutoStep = new DataGridViewCheckBoxColumn();
      this.col_Skip_Step = new DataGridViewComboBoxColumn();
      this.col_Skip_Tag = new DataGridViewCheckBoxColumn();
      this.col_Skip_MemDel = new DataGridViewCheckBoxColumn();
      this.col_Skip_Att = new DataGridViewCheckBoxColumn();
      this.col_Skip_Smeter = new DataGridViewComboBoxColumn();
      this.col_Skip_Bell = new DataGridViewComboBoxColumn();
      this.col_Skip_Vibrator = new DataGridViewComboBoxColumn();
      this.col_Skip_HarfDev = new DataGridViewCheckBoxColumn();
      this.col_Skip_ClockShift = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank1 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank2 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank3 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank4 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank5 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank6 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank7 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank8 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank9 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank10 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank11 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank12 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank13 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank14 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank15 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank16 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank17 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank18 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank19 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank20 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank21 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank22 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank23 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Bank24 = new DataGridViewCheckBoxColumn();
      this.col_Skip_Comment = new DataGridViewTextBoxColumn();
      this.tab_Pms = new TabPage();
      this.dgv_Pms = new DataGridView();
      this.col_Pmf_Ch = new DataGridViewCheckBoxColumn();
      this.col_Pmf_RxFrq = new DataGridViewTextBoxColumn();
      this.col_Pmf_TxFrq = new DataGridViewTextBoxColumn();
      this.col_Pmf_ShiftFrq = new DataGridViewTextBoxColumn();
      this.col_Pmf_ShiftDir = new DataGridViewComboBoxColumn();
      this.col_Pms_AutoMode = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Mode = new DataGridViewComboBoxColumn();
      this.col_Pmf_Ams = new DataGridViewComboBoxColumn();
      this.col_Pmf_DigAnalog = new DataGridViewComboBoxColumn();
      this.col_Pmf_MemName = new DataGridViewTextBoxColumn();
      this.col_Pmf_SqlType = new DataGridViewComboBoxColumn();
      this.col_Pmf_ToneFrq = new DataGridViewComboBoxColumn();
      this.col_Pmf_DcsCode = new DataGridViewComboBoxColumn();
      this.col_Pmf_DcsDim = new DataGridViewComboBoxColumn();
      this.col_Pmf_PrTone = new DataGridViewComboBoxColumn();
      this.col_Pmf_TxOutput = new DataGridViewComboBoxColumn();
      this.col_Pmf_Skip = new DataGridViewComboBoxColumn();
      this.col_Pms_AutoStep = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Step = new DataGridViewComboBoxColumn();
      this.col_Pms_Tag = new DataGridViewCheckBoxColumn();
      this.col_Pmf_MemDel = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Att = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Smeter = new DataGridViewComboBoxColumn();
      this.col_Pmf_Bell = new DataGridViewComboBoxColumn();
      this.col_Pmf_Vibrator = new DataGridViewComboBoxColumn();
      this.col_Pmf_HarfDev = new DataGridViewCheckBoxColumn();
      this.col_Pmf_ClockShift = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank1 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank2 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank3 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank4 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank5 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank6 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank7 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank8 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank9 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank10 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank11 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank12 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank13 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank14 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank15 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank16 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank17 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank18 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank19 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank20 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank21 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank22 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank23 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Bank24 = new DataGridViewCheckBoxColumn();
      this.col_Pmf_Comment = new DataGridViewTextBoxColumn();
      this.tab_Vfo = new TabPage();
      this.dgv_Vfo = new DataGridView();
      this.col_Vfo_Ch = new DataGridViewCheckBoxColumn();
      this.col_Vfo_RxFrq = new DataGridViewTextBoxColumn();
      this.col_Vfo_TxFrq = new DataGridViewTextBoxColumn();
      this.col_Vfo_ShiftFrq = new DataGridViewTextBoxColumn();
      this.col_Vfo_ShiftDir = new DataGridViewComboBoxColumn();
      this.col_Vfo_AutoMode = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Mode = new DataGridViewComboBoxColumn();
      this.col_Vfo_Ams = new DataGridViewComboBoxColumn();
      this.col_Vfo_DigAnalog = new DataGridViewComboBoxColumn();
      this.col_Vfo_MemName = new DataGridViewTextBoxColumn();
      this.col_Vfo_SqlType = new DataGridViewComboBoxColumn();
      this.col_Vfo_ToneFrq = new DataGridViewComboBoxColumn();
      this.col_Vfo_DcsCode = new DataGridViewComboBoxColumn();
      this.col_Vfo_DcsDim = new DataGridViewComboBoxColumn();
      this.col_Vfo_PrTone = new DataGridViewComboBoxColumn();
      this.col_Vfo_TxOutput = new DataGridViewComboBoxColumn();
      this.col_Vfo_Skip = new DataGridViewComboBoxColumn();
      this.col_Vfo_AutoStep = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Step = new DataGridViewComboBoxColumn();
      this.col_Vfo_Tag = new DataGridViewCheckBoxColumn();
      this.col_Vfo_MemDel = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Att = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Smeter = new DataGridViewComboBoxColumn();
      this.col_Vfo_Bell = new DataGridViewComboBoxColumn();
      this.col_Vfo_Vibrator = new DataGridViewComboBoxColumn();
      this.col_Vfo_HarfDev = new DataGridViewCheckBoxColumn();
      this.col_Vfo_ClockShift = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank1 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank2 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank3 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank4 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank5 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank6 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank7 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank8 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank9 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank10 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank11 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank12 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank13 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank14 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank15 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank16 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank17 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank18 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank19 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank20 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank21 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank22 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank23 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Bank24 = new DataGridViewCheckBoxColumn();
      this.col_Vfo_Comment = new DataGridViewTextBoxColumn();
      this.tab_Home = new TabPage();
      this.dgv_Home = new DataGridView();
      this.col_Home_Ch = new DataGridViewCheckBoxColumn();
      this.col_Home_RxFrq = new DataGridViewTextBoxColumn();
      this.col_Home_TxFrq = new DataGridViewTextBoxColumn();
      this.col_Home_ShiftFrq = new DataGridViewTextBoxColumn();
      this.col_Home_ShiftDir = new DataGridViewComboBoxColumn();
      this.col_Home_AutoMode = new DataGridViewCheckBoxColumn();
      this.col_Home_Mode = new DataGridViewComboBoxColumn();
      this.col_Home_Ams = new DataGridViewComboBoxColumn();
      this.col_Home_DigAnalog = new DataGridViewComboBoxColumn();
      this.col_Home_MemName = new DataGridViewTextBoxColumn();
      this.col_Home_SqlType = new DataGridViewComboBoxColumn();
      this.col_Home_ToneFrq = new DataGridViewComboBoxColumn();
      this.col_Home_DcsCode = new DataGridViewComboBoxColumn();
      this.col_Home_DcsDim = new DataGridViewComboBoxColumn();
      this.col_Home_PrTone = new DataGridViewComboBoxColumn();
      this.col_Home_TxOutput = new DataGridViewComboBoxColumn();
      this.col_Home_Skip = new DataGridViewComboBoxColumn();
      this.col_Home_AutoStep = new DataGridViewCheckBoxColumn();
      this.col_Home_Step = new DataGridViewComboBoxColumn();
      this.col_Home_Tag = new DataGridViewCheckBoxColumn();
      this.col_Home_MemDel = new DataGridViewCheckBoxColumn();
      this.col_Home_Att = new DataGridViewCheckBoxColumn();
      this.col_Home_Smeter = new DataGridViewComboBoxColumn();
      this.col_Home_Bell = new DataGridViewComboBoxColumn();
      this.col_Home_Vibrator = new DataGridViewComboBoxColumn();
      this.col_Home_HarfDev = new DataGridViewCheckBoxColumn();
      this.col_Home_ClockShift = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank1 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank2 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank3 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank4 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank5 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank6 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank7 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank8 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank9 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank10 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank11 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank12 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank13 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank14 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank15 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank16 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank17 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank18 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank19 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank20 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank21 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank22 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank23 = new DataGridViewCheckBoxColumn();
      this.col_Home_Bank24 = new DataGridViewCheckBoxColumn();
      this.col_Home_Comment = new DataGridViewTextBoxColumn();
      this.tab_Wx = new TabPage();
      this.dgv_Wx = new DataGridView();
      this.dataGridViewCheckBoxColumn407 = new DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn86 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn87 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn88 = new DataGridViewTextBoxColumn();
      this.dataGridViewComboBoxColumn183 = new DataGridViewComboBoxColumn();
      this.col_Wx_AutoMode = new DataGridViewCheckBoxColumn();
      this.dataGridViewComboBoxColumn184 = new DataGridViewComboBoxColumn();
      this.col_Wx_Ams = new DataGridViewComboBoxColumn();
      this.col_Wx_DigAnalog = new DataGridViewComboBoxColumn();
      this.dataGridViewTextBoxColumn89 = new DataGridViewTextBoxColumn();
      this.dataGridViewComboBoxColumn185 = new DataGridViewComboBoxColumn();
      this.dataGridViewComboBoxColumn186 = new DataGridViewComboBoxColumn();
      this.dataGridViewComboBoxColumn187 = new DataGridViewComboBoxColumn();
      this.dataGridViewComboBoxColumn188 = new DataGridViewComboBoxColumn();
      this.dataGridViewComboBoxColumn189 = new DataGridViewComboBoxColumn();
      this.dataGridViewComboBoxColumn190 = new DataGridViewComboBoxColumn();
      this.dataGridViewComboBoxColumn191 = new DataGridViewComboBoxColumn();
      this.col_Wx_AutoStep = new DataGridViewCheckBoxColumn();
      this.dataGridViewComboBoxColumn192 = new DataGridViewComboBoxColumn();
      this.col_Wx_Tag = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn408 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn409 = new DataGridViewCheckBoxColumn();
      this.dataGridViewComboBoxColumn193 = new DataGridViewComboBoxColumn();
      this.dataGridViewComboBoxColumn194 = new DataGridViewComboBoxColumn();
      this.dataGridViewComboBoxColumn195 = new DataGridViewComboBoxColumn();
      this.dataGridViewCheckBoxColumn410 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn411 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn412 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn413 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn414 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn415 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn416 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn417 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn418 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn419 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn420 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn421 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn422 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn423 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn424 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn425 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn426 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn427 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn428 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn429 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn430 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn431 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn432 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn433 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn434 = new DataGridViewCheckBoxColumn();
      this.dataGridViewCheckBoxColumn435 = new DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn90 = new DataGridViewTextBoxColumn();
      this.col_Normal_Ch = new DataGridViewCheckBoxColumn();
      this.col_Normal_RxFrq = new DataGridViewTextBoxColumn();
      this.col_Normal_TxFrq = new DataGridViewTextBoxColumn();
      this.col_Normal_ShiftFrq = new DataGridViewTextBoxColumn();
      this.col_Normal_ShiftDir = new DataGridViewComboBoxColumn();
      this.col_Normal_AutoMode = new DataGridViewCheckBoxColumn();
      this.col_Normal_Mode = new DataGridViewComboBoxColumn();
      this.col_Normal_Ams = new DataGridViewComboBoxColumn();
      this.col_Normal_DigAnalog = new DataGridViewComboBoxColumn();
      this.col_Normal_MemName = new DataGridViewTextBoxColumn();
      this.col_Normal_SqlType = new DataGridViewComboBoxColumn();
      this.col_Normal_ToneFrq = new DataGridViewComboBoxColumn();
      this.col_Normal_DscCode = new DataGridViewComboBoxColumn();
      this.col_Normal_DscDim = new DataGridViewComboBoxColumn();
      this.col_Normal_PrTone = new DataGridViewComboBoxColumn();
      this.col_Normal_TxOtput = new DataGridViewComboBoxColumn();
      this.col_Normal_Skip = new DataGridViewComboBoxColumn();
      this.col_Normal_AutoStep = new DataGridViewCheckBoxColumn();
      this.col_Normal_Step = new DataGridViewComboBoxColumn();
      this.col_Normal_Tag = new DataGridViewCheckBoxColumn();
      this.col_Normal_MemDel = new DataGridViewCheckBoxColumn();
      this.col_Normal_Att = new DataGridViewCheckBoxColumn();
      this.col_Normal_Smeter = new DataGridViewComboBoxColumn();
      this.col_Normal_Bell = new DataGridViewComboBoxColumn();
      this.col_Normal_Vibrator = new DataGridViewComboBoxColumn();
      this.col_Normal_HarfDev = new DataGridViewCheckBoxColumn();
      this.col_Normal_ClockShift = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank1 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank2 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank3 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank4 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank5 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank6 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank7 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank8 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank9 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank10 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank11 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank12 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank13 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank14 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank15 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank16 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank17 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank18 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank19 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank20 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank21 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank22 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank23 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Bank24 = new DataGridViewCheckBoxColumn();
      this.col_Normal_Comment = new DataGridViewTextBoxColumn();
      this.tabc_DataForm.SuspendLayout();
      this.tab_Normal.SuspendLayout();
      ((ISupportInitialize) this.dgv_Normal).BeginInit();
      this.tab_Skip.SuspendLayout();
      ((ISupportInitialize) this.dgv_Skip).BeginInit();
      this.tab_Pms.SuspendLayout();
      ((ISupportInitialize) this.dgv_Pms).BeginInit();
      this.tab_Vfo.SuspendLayout();
      ((ISupportInitialize) this.dgv_Vfo).BeginInit();
      this.tab_Home.SuspendLayout();
      ((ISupportInitialize) this.dgv_Home).BeginInit();
      this.tab_Wx.SuspendLayout();
      ((ISupportInitialize) this.dgv_Wx).BeginInit();
      this.SuspendLayout();
      this.tabc_DataForm.Controls.Add((Control) this.tab_Normal);
      this.tabc_DataForm.Controls.Add((Control) this.tab_Skip);
      this.tabc_DataForm.Controls.Add((Control) this.tab_Pms);
      this.tabc_DataForm.Controls.Add((Control) this.tab_Vfo);
      this.tabc_DataForm.Controls.Add((Control) this.tab_Home);
      this.tabc_DataForm.Controls.Add((Control) this.tab_Wx);
      componentResourceManager.ApplyResources((object) this.tabc_DataForm, "tabc_DataForm");
      this.tabc_DataForm.Name = "tabc_DataForm";
      this.tabc_DataForm.SelectedIndex = 0;
      this.tabc_DataForm.SelectedIndexChanged += new EventHandler(this.tabc_DataForm_SelectedIndexChanged);
      this.tab_Normal.BackColor = SystemColors.Control;
      this.tab_Normal.Controls.Add((Control) this.dgv_Normal);
      componentResourceManager.ApplyResources((object) this.tab_Normal, "tab_Normal");
      this.tab_Normal.Name = "tab_Normal";
      this.dgv_Normal.AllowUserToAddRows = false;
      this.dgv_Normal.AllowUserToDeleteRows = false;
      this.dgv_Normal.AllowUserToResizeRows = false;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("MS UI Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 128);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dgv_Normal.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      componentResourceManager.ApplyResources((object) this.dgv_Normal, "dgv_Normal");
      this.dgv_Normal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_Normal.Columns.AddRange((DataGridViewColumn) this.col_Normal_Ch, (DataGridViewColumn) this.col_Normal_RxFrq, (DataGridViewColumn) this.col_Normal_TxFrq, (DataGridViewColumn) this.col_Normal_ShiftFrq, (DataGridViewColumn) this.col_Normal_ShiftDir, (DataGridViewColumn) this.col_Normal_AutoMode, (DataGridViewColumn) this.col_Normal_Mode, (DataGridViewColumn) this.col_Normal_Ams, (DataGridViewColumn) this.col_Normal_DigAnalog, (DataGridViewColumn) this.col_Normal_MemName, (DataGridViewColumn) this.col_Normal_SqlType, (DataGridViewColumn) this.col_Normal_ToneFrq, (DataGridViewColumn) this.col_Normal_DscCode, (DataGridViewColumn) this.col_Normal_DscDim, (DataGridViewColumn) this.col_Normal_PrTone, (DataGridViewColumn) this.col_Normal_TxOtput, (DataGridViewColumn) this.col_Normal_Skip, (DataGridViewColumn) this.col_Normal_AutoStep, (DataGridViewColumn) this.col_Normal_Step, (DataGridViewColumn) this.col_Normal_Tag, (DataGridViewColumn) this.col_Normal_MemDel, (DataGridViewColumn) this.col_Normal_Att, (DataGridViewColumn) this.col_Normal_Smeter, (DataGridViewColumn) this.col_Normal_Bell, (DataGridViewColumn) this.col_Normal_Vibrator, (DataGridViewColumn) this.col_Normal_HarfDev, (DataGridViewColumn) this.col_Normal_ClockShift, (DataGridViewColumn) this.col_Normal_Bank1, (DataGridViewColumn) this.col_Normal_Bank2, (DataGridViewColumn) this.col_Normal_Bank3, (DataGridViewColumn) this.col_Normal_Bank4, (DataGridViewColumn) this.col_Normal_Bank5, (DataGridViewColumn) this.col_Normal_Bank6, (DataGridViewColumn) this.col_Normal_Bank7, (DataGridViewColumn) this.col_Normal_Bank8, (DataGridViewColumn) this.col_Normal_Bank9, (DataGridViewColumn) this.col_Normal_Bank10, (DataGridViewColumn) this.col_Normal_Bank11, (DataGridViewColumn) this.col_Normal_Bank12, (DataGridViewColumn) this.col_Normal_Bank13, (DataGridViewColumn) this.col_Normal_Bank14, (DataGridViewColumn) this.col_Normal_Bank15, (DataGridViewColumn) this.col_Normal_Bank16, (DataGridViewColumn) this.col_Normal_Bank17, (DataGridViewColumn) this.col_Normal_Bank18, (DataGridViewColumn) this.col_Normal_Bank19, (DataGridViewColumn) this.col_Normal_Bank20, (DataGridViewColumn) this.col_Normal_Bank21, (DataGridViewColumn) this.col_Normal_Bank22, (DataGridViewColumn) this.col_Normal_Bank23, (DataGridViewColumn) this.col_Normal_Bank24, (DataGridViewColumn) this.col_Normal_Comment);
      this.dgv_Normal.EnableHeadersVisualStyles = false;
      this.dgv_Normal.Name = "dgv_Normal";
      this.dgv_Normal.RowTemplate.Height = 21;
      this.dgv_Normal.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
      this.dgv_Normal.CellContentClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Normal.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Normal.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
      this.dgv_Normal.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      this.tab_Skip.BackColor = SystemColors.Control;
      this.tab_Skip.Controls.Add((Control) this.dgv_Skip);
      componentResourceManager.ApplyResources((object) this.tab_Skip, "tab_Skip");
      this.tab_Skip.Name = "tab_Skip";
      this.dgv_Skip.AllowUserToAddRows = false;
      this.dgv_Skip.AllowUserToDeleteRows = false;
      this.dgv_Skip.AllowUserToResizeRows = false;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = SystemColors.Control;
      gridViewCellStyle2.Font = new Font("MS UI Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 128);
      gridViewCellStyle2.ForeColor = SystemColors.WindowText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.dgv_Skip.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
      componentResourceManager.ApplyResources((object) this.dgv_Skip, "dgv_Skip");
      this.dgv_Skip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_Skip.Columns.AddRange((DataGridViewColumn) this.col_Skip_Ch, (DataGridViewColumn) this.col_Skip_RxFrq, (DataGridViewColumn) this.col_Skip_TxFrq, (DataGridViewColumn) this.col_Skip_ShiftFrq, (DataGridViewColumn) this.col_Skip_ShiftDir, (DataGridViewColumn) this.col_Skip_AutoMode, (DataGridViewColumn) this.col_Skip_Mode, (DataGridViewColumn) this.col_Skip_Ams, (DataGridViewColumn) this.col_Skip_DigAnalog, (DataGridViewColumn) this.col_Skip_MemName, (DataGridViewColumn) this.col_Skip_SqlType, (DataGridViewColumn) this.col_Skip_ToneFrq, (DataGridViewColumn) this.col_Skip_DcsCode, (DataGridViewColumn) this.col_Skip_DcsDim, (DataGridViewColumn) this.col_Skip_PrTone, (DataGridViewColumn) this.col_Skip_TxOutput, (DataGridViewColumn) this.col_Skip_Skip, (DataGridViewColumn) this.col_Skip_AutoStep, (DataGridViewColumn) this.col_Skip_Step, (DataGridViewColumn) this.col_Skip_Tag, (DataGridViewColumn) this.col_Skip_MemDel, (DataGridViewColumn) this.col_Skip_Att, (DataGridViewColumn) this.col_Skip_Smeter, (DataGridViewColumn) this.col_Skip_Bell, (DataGridViewColumn) this.col_Skip_Vibrator, (DataGridViewColumn) this.col_Skip_HarfDev, (DataGridViewColumn) this.col_Skip_ClockShift, (DataGridViewColumn) this.col_Skip_Bank1, (DataGridViewColumn) this.col_Skip_Bank2, (DataGridViewColumn) this.col_Skip_Bank3, (DataGridViewColumn) this.col_Skip_Bank4, (DataGridViewColumn) this.col_Skip_Bank5, (DataGridViewColumn) this.col_Skip_Bank6, (DataGridViewColumn) this.col_Skip_Bank7, (DataGridViewColumn) this.col_Skip_Bank8, (DataGridViewColumn) this.col_Skip_Bank9, (DataGridViewColumn) this.col_Skip_Bank10, (DataGridViewColumn) this.col_Skip_Bank11, (DataGridViewColumn) this.col_Skip_Bank12, (DataGridViewColumn) this.col_Skip_Bank13, (DataGridViewColumn) this.col_Skip_Bank14, (DataGridViewColumn) this.col_Skip_Bank15, (DataGridViewColumn) this.col_Skip_Bank16, (DataGridViewColumn) this.col_Skip_Bank17, (DataGridViewColumn) this.col_Skip_Bank18, (DataGridViewColumn) this.col_Skip_Bank19, (DataGridViewColumn) this.col_Skip_Bank20, (DataGridViewColumn) this.col_Skip_Bank21, (DataGridViewColumn) this.col_Skip_Bank22, (DataGridViewColumn) this.col_Skip_Bank23, (DataGridViewColumn) this.col_Skip_Bank24, (DataGridViewColumn) this.col_Skip_Comment);
      this.dgv_Skip.EnableHeadersVisualStyles = false;
      this.dgv_Skip.Name = "dgv_Skip";
      this.dgv_Skip.RowTemplate.Height = 21;
      this.dgv_Skip.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
      this.dgv_Skip.CellContentClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Skip.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Skip.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
      this.dgv_Skip.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      componentResourceManager.ApplyResources((object) this.col_Skip_Ch, "col_Skip_Ch");
      this.col_Skip_Ch.Name = "col_Skip_Ch";
      this.col_Skip_Ch.Resizable = DataGridViewTriState.True;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Skip_RxFrq.DefaultCellStyle = gridViewCellStyle3;
      componentResourceManager.ApplyResources((object) this.col_Skip_RxFrq, "col_Skip_RxFrq");
      this.col_Skip_RxFrq.Name = "col_Skip_RxFrq";
      this.col_Skip_RxFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Skip_TxFrq.DefaultCellStyle = gridViewCellStyle4;
      componentResourceManager.ApplyResources((object) this.col_Skip_TxFrq, "col_Skip_TxFrq");
      this.col_Skip_TxFrq.Name = "col_Skip_TxFrq";
      this.col_Skip_TxFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Skip_ShiftFrq.DefaultCellStyle = gridViewCellStyle5;
      componentResourceManager.ApplyResources((object) this.col_Skip_ShiftFrq, "col_Skip_ShiftFrq");
      this.col_Skip_ShiftFrq.Name = "col_Skip_ShiftFrq";
      this.col_Skip_ShiftFrq.Resizable = DataGridViewTriState.True;
      this.col_Skip_ShiftFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Skip_ShiftDir.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_ShiftDir.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_ShiftDir, "col_Skip_ShiftDir");
      this.col_Skip_ShiftDir.Items.AddRange((object) "OFF", (object) "-RPT", (object) "+RPT", (object) "-/+");
      this.col_Skip_ShiftDir.Name = "col_Skip_ShiftDir";
      this.col_Skip_ShiftDir.Resizable = DataGridViewTriState.True;
      this.col_Skip_AutoMode.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_AutoMode, "col_Skip_AutoMode");
      this.col_Skip_AutoMode.IndeterminateValue = (object) "0";
      this.col_Skip_AutoMode.Name = "col_Skip_AutoMode";
      this.col_Skip_AutoMode.Resizable = DataGridViewTriState.True;
      this.col_Skip_AutoMode.TrueValue = (object) "1";
      this.col_Skip_Mode.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_Mode.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_Mode, "col_Skip_Mode");
      this.col_Skip_Mode.Items.AddRange((object) "FM", (object) "AM");
      this.col_Skip_Mode.Name = "col_Skip_Mode";
      this.col_Skip_Mode.Resizable = DataGridViewTriState.True;
      this.col_Skip_Ams.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_Ams.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_Ams, "col_Skip_Ams");
      this.col_Skip_Ams.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Skip_Ams.Name = "col_Skip_Ams";
      this.col_Skip_DigAnalog.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_DigAnalog.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_DigAnalog, "col_Skip_DigAnalog");
      this.col_Skip_DigAnalog.Items.AddRange((object) "ANALOG", (object) "DN", (object) "VW");
      this.col_Skip_DigAnalog.Name = "col_Skip_DigAnalog";
      componentResourceManager.ApplyResources((object) this.col_Skip_MemName, "col_Skip_MemName");
      this.col_Skip_MemName.MaxInputLength = 6;
      this.col_Skip_MemName.Name = "col_Skip_MemName";
      this.col_Skip_MemName.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Skip_SqlType.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_SqlType.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_SqlType, "col_Skip_SqlType");
      this.col_Skip_SqlType.Items.AddRange((object) "OFF", (object) "TONE", (object) "TONE SQL", (object) "DCS", (object) "REV TONE", (object) "JR FREQ", (object) "PR FREQ", (object) "PAGER", (object) "D CD", (object) "TONE-DCS", (object) "D CD-TONE");
      this.col_Skip_SqlType.Name = "col_Skip_SqlType";
      this.col_Skip_SqlType.Resizable = DataGridViewTriState.True;
      this.col_Skip_ToneFrq.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_ToneFrq.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_ToneFrq, "col_Skip_ToneFrq");
      this.col_Skip_ToneFrq.Items.AddRange((object) "67.0 Hz", (object) "69.3 Hz", (object) "71.9 Hz", (object) "74.4 Hz", (object) "77.0 Hz", (object) "79.7 Hz", (object) "82.5 Hz", (object) "85.4 Hz", (object) "88.5 Hz", (object) "91.5 Hz", (object) "94.8 Hz", (object) "97.4 Hz", (object) "100.0 Hz", (object) "103.5 Hz", (object) "107.2 Hz", (object) "110.9 Hz", (object) "114.8 Hz", (object) "118.8 Hz", (object) "123.0 Hz", (object) "127.3 Hz", (object) "131.8 Hz", (object) "136.5 Hz", (object) "141.3 Hz", (object) "146.2 Hz", (object) "151.4 Hz", (object) "156.7 Hz", (object) "159.8 Hz", (object) "162.2 Hz", (object) "165.5 Hz", (object) "167.9 Hz", (object) "171.3 Hz", (object) "173.8 Hz", (object) "177.3 Hz", (object) "179.9 Hz", (object) "183.5 Hz", (object) "186.2 Hz", (object) "189.9 Hz", (object) "192.8 Hz", (object) "196.6 Hz", (object) "199.5 Hz", (object) "203.5 Hz", (object) "206.5 Hz", (object) "210.7 Hz", (object) "218.1 Hz", (object) "225.7 Hz", (object) "229.1 Hz", (object) "233.6 Hz", (object) "241.8 Hz", (object) "250.3 Hz", (object) "254.1 Hz");
      this.col_Skip_ToneFrq.Name = "col_Skip_ToneFrq";
      this.col_Skip_ToneFrq.Resizable = DataGridViewTriState.True;
      this.col_Skip_DcsCode.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_DcsCode.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_DcsCode, "col_Skip_DcsCode");
      this.col_Skip_DcsCode.Items.AddRange((object) "023", (object) "025", (object) "026", (object) "031", (object) "032", (object) "036", (object) "043", (object) "047", (object) "051", (object) "053", (object) "054", (object) "065", (object) "071", (object) "072", (object) "073", (object) "074", (object) "114", (object) "115", (object) "116", (object) "122", (object) "125", (object) "131", (object) "132", (object) "134", (object) "143", (object) "145", (object) "152", (object) "155", (object) "156", (object) "162", (object) "165", (object) "172", (object) "174", (object) "205", (object) "212", (object) "223", (object) "225", (object) "226", (object) "243", (object) "244", (object) "245", (object) "246", (object) "251", (object) "252", (object) "255", (object) "261", (object) "263", (object) "265", (object) "266", (object) "271", (object) "274", (object) "306", (object) "311", (object) "315", (object) "325", (object) "331", (object) "332", (object) "343", (object) "346", (object) "351", (object) "356", (object) "364", (object) "365", (object) "371", (object) "411", (object) "412", (object) "413", (object) "423", (object) "431", (object) "432", (object) "445", (object) "446", (object) "452", (object) "454", (object) "455", (object) "462", (object) "464", (object) "465", (object) "466", (object) "503", (object) "506", (object) "516", (object) "523", (object) "526", (object) "532", (object) "546", (object) "565", (object) "606", (object) "612", (object) "624", (object) "627", (object) "631", (object) "632", (object) "654", (object) "662", (object) "664", (object) "703", (object) "712", (object) "723", (object) "731", (object) "732", (object) "734", (object) "743", (object) "754");
      this.col_Skip_DcsCode.Name = "col_Skip_DcsCode";
      this.col_Skip_DcsCode.Resizable = DataGridViewTriState.True;
      this.col_Skip_DcsDim.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_DcsDim.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_DcsDim, "col_Skip_DcsDim");
      this.col_Skip_DcsDim.Items.AddRange((object) "RX同相 TX同相", (object) "RX反転 TX同相", (object) "RX両相 TX同相", (object) "RX同相 TX反転", (object) "RX反転 TX反転", (object) "RX両相 TX反転");
      this.col_Skip_DcsDim.Name = "col_Skip_DcsDim";
      this.col_Skip_DcsDim.Resizable = DataGridViewTriState.True;
      this.col_Skip_PrTone.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_PrTone.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_PrTone, "col_Skip_PrTone");
      this.col_Skip_PrTone.Items.AddRange((object) "300 Hz", (object) "400 Hz", (object) "500 Hz", (object) "600 Hz", (object) "700 Hz", (object) "800 Hz", (object) "900 Hz", (object) "1000 Hz", (object) "1100 Hz", (object) "1200 Hz", (object) "1300 Hz", (object) "1400 Hz", (object) "1500 Hz", (object) "1600 Hz", (object) "1700 Hz", (object) "1800 Hz", (object) "1900 Hz", (object) "2000 Hz", (object) "2100 Hz", (object) "2200 Hz", (object) "2300 Hz", (object) "2400 Hz", (object) "2500 Hz", (object) "2600 Hz", (object) "2700 Hz", (object) "2800 Hz", (object) "2900 Hz", (object) "3000 Hz");
      this.col_Skip_PrTone.Name = "col_Skip_PrTone";
      this.col_Skip_PrTone.Resizable = DataGridViewTriState.True;
      this.col_Skip_TxOutput.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_TxOutput.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_TxOutput, "col_Skip_TxOutput");
      this.col_Skip_TxOutput.Items.AddRange((object) "LOW", (object) "MID", (object) "HIGH");
      this.col_Skip_TxOutput.Name = "col_Skip_TxOutput";
      this.col_Skip_TxOutput.Resizable = DataGridViewTriState.True;
      this.col_Skip_Skip.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_Skip.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_Skip, "col_Skip_Skip");
      this.col_Skip_Skip.Items.AddRange((object) "OFF", (object) "SKIP", (object) "SELECT");
      this.col_Skip_Skip.Name = "col_Skip_Skip";
      this.col_Skip_Skip.Resizable = DataGridViewTriState.True;
      this.col_Skip_AutoStep.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_AutoStep, "col_Skip_AutoStep");
      this.col_Skip_AutoStep.IndeterminateValue = (object) "0";
      this.col_Skip_AutoStep.Name = "col_Skip_AutoStep";
      this.col_Skip_AutoStep.Resizable = DataGridViewTriState.True;
      this.col_Skip_AutoStep.TrueValue = (object) "1";
      this.col_Skip_Step.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_Step.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_Step, "col_Skip_Step");
      this.col_Skip_Step.Items.AddRange((object) "5.0KHz", (object) "6.25KHz", (object) "8.33KHz", (object) "10.0KHz", (object) "12.5KHz", (object) "15.0KHz", (object) "20.0KHz", (object) "25.0KHz", (object) "50.0KHz", (object) "100.0KHz");
      this.col_Skip_Step.Name = "col_Skip_Step";
      this.col_Skip_Step.Resizable = DataGridViewTriState.True;
      this.col_Skip_Tag.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Tag, "col_Skip_Tag");
      this.col_Skip_Tag.IndeterminateValue = (object) "0";
      this.col_Skip_Tag.Name = "col_Skip_Tag";
      this.col_Skip_Tag.TrueValue = (object) "1";
      this.col_Skip_MemDel.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_MemDel, "col_Skip_MemDel");
      this.col_Skip_MemDel.IndeterminateValue = (object) "0";
      this.col_Skip_MemDel.Name = "col_Skip_MemDel";
      this.col_Skip_MemDel.Resizable = DataGridViewTriState.True;
      this.col_Skip_MemDel.TrueValue = (object) "1";
      this.col_Skip_Att.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Att, "col_Skip_Att");
      this.col_Skip_Att.IndeterminateValue = (object) "0";
      this.col_Skip_Att.Name = "col_Skip_Att";
      this.col_Skip_Att.Resizable = DataGridViewTriState.True;
      this.col_Skip_Att.TrueValue = (object) "1";
      this.col_Skip_Smeter.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_Smeter.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_Smeter, "col_Skip_Smeter");
      this.col_Skip_Smeter.Items.AddRange((object) "OFF", (object) "Level 1", (object) "Level 2", (object) "Level 3", (object) "Level 4", (object) "Level 5", (object) "Level 6", (object) "Level 7", (object) "Level 8", (object) "Level 9");
      this.col_Skip_Smeter.Name = "col_Skip_Smeter";
      this.col_Skip_Smeter.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bell.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_Bell.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_Bell, "col_Skip_Bell");
      this.col_Skip_Bell.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Skip_Bell.Name = "col_Skip_Bell";
      this.col_Skip_Bell.Resizable = DataGridViewTriState.True;
      this.col_Skip_Vibrator.DisplayStyleForCurrentCellOnly = true;
      this.col_Skip_Vibrator.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Skip_Vibrator, "col_Skip_Vibrator");
      this.col_Skip_Vibrator.Items.AddRange((object) "OFF", (object) "BUSY", (object) "SIGNALING");
      this.col_Skip_Vibrator.Name = "col_Skip_Vibrator";
      this.col_Skip_Vibrator.Resizable = DataGridViewTriState.True;
      this.col_Skip_HarfDev.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_HarfDev, "col_Skip_HarfDev");
      this.col_Skip_HarfDev.IndeterminateValue = (object) "0";
      this.col_Skip_HarfDev.Name = "col_Skip_HarfDev";
      this.col_Skip_HarfDev.Resizable = DataGridViewTriState.True;
      this.col_Skip_HarfDev.TrueValue = (object) "1";
      this.col_Skip_ClockShift.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_ClockShift, "col_Skip_ClockShift");
      this.col_Skip_ClockShift.IndeterminateValue = (object) "0";
      this.col_Skip_ClockShift.Name = "col_Skip_ClockShift";
      this.col_Skip_ClockShift.Resizable = DataGridViewTriState.True;
      this.col_Skip_ClockShift.TrueValue = (object) "1";
      this.col_Skip_Bank1.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank1, "col_Skip_Bank1");
      this.col_Skip_Bank1.IndeterminateValue = (object) "0";
      this.col_Skip_Bank1.Name = "col_Skip_Bank1";
      this.col_Skip_Bank1.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank1.TrueValue = (object) "1";
      this.col_Skip_Bank2.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank2, "col_Skip_Bank2");
      this.col_Skip_Bank2.IndeterminateValue = (object) "0";
      this.col_Skip_Bank2.Name = "col_Skip_Bank2";
      this.col_Skip_Bank2.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank2.TrueValue = (object) "1";
      this.col_Skip_Bank3.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank3, "col_Skip_Bank3");
      this.col_Skip_Bank3.IndeterminateValue = (object) "0";
      this.col_Skip_Bank3.Name = "col_Skip_Bank3";
      this.col_Skip_Bank3.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank3.TrueValue = (object) "1";
      this.col_Skip_Bank4.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank4, "col_Skip_Bank4");
      this.col_Skip_Bank4.IndeterminateValue = (object) "0";
      this.col_Skip_Bank4.Name = "col_Skip_Bank4";
      this.col_Skip_Bank4.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank4.TrueValue = (object) "1";
      this.col_Skip_Bank5.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank5, "col_Skip_Bank5");
      this.col_Skip_Bank5.IndeterminateValue = (object) "0";
      this.col_Skip_Bank5.Name = "col_Skip_Bank5";
      this.col_Skip_Bank5.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank5.TrueValue = (object) "1";
      this.col_Skip_Bank6.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank6, "col_Skip_Bank6");
      this.col_Skip_Bank6.IndeterminateValue = (object) "0";
      this.col_Skip_Bank6.Name = "col_Skip_Bank6";
      this.col_Skip_Bank6.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank6.TrueValue = (object) "1";
      this.col_Skip_Bank7.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank7, "col_Skip_Bank7");
      this.col_Skip_Bank7.IndeterminateValue = (object) "0";
      this.col_Skip_Bank7.Name = "col_Skip_Bank7";
      this.col_Skip_Bank7.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank7.TrueValue = (object) "1";
      this.col_Skip_Bank8.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank8, "col_Skip_Bank8");
      this.col_Skip_Bank8.IndeterminateValue = (object) "0";
      this.col_Skip_Bank8.Name = "col_Skip_Bank8";
      this.col_Skip_Bank8.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank8.TrueValue = (object) "1";
      this.col_Skip_Bank9.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank9, "col_Skip_Bank9");
      this.col_Skip_Bank9.IndeterminateValue = (object) "0";
      this.col_Skip_Bank9.Name = "col_Skip_Bank9";
      this.col_Skip_Bank9.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank9.TrueValue = (object) "1";
      this.col_Skip_Bank10.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank10, "col_Skip_Bank10");
      this.col_Skip_Bank10.IndeterminateValue = (object) "0";
      this.col_Skip_Bank10.Name = "col_Skip_Bank10";
      this.col_Skip_Bank10.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank10.TrueValue = (object) "1";
      this.col_Skip_Bank11.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank11, "col_Skip_Bank11");
      this.col_Skip_Bank11.IndeterminateValue = (object) "0";
      this.col_Skip_Bank11.Name = "col_Skip_Bank11";
      this.col_Skip_Bank11.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank11.TrueValue = (object) "1";
      this.col_Skip_Bank12.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank12, "col_Skip_Bank12");
      this.col_Skip_Bank12.IndeterminateValue = (object) "0";
      this.col_Skip_Bank12.Name = "col_Skip_Bank12";
      this.col_Skip_Bank12.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank12.TrueValue = (object) "1";
      this.col_Skip_Bank13.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank13, "col_Skip_Bank13");
      this.col_Skip_Bank13.IndeterminateValue = (object) "0";
      this.col_Skip_Bank13.Name = "col_Skip_Bank13";
      this.col_Skip_Bank13.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank13.TrueValue = (object) "1";
      this.col_Skip_Bank14.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank14, "col_Skip_Bank14");
      this.col_Skip_Bank14.IndeterminateValue = (object) "0";
      this.col_Skip_Bank14.Name = "col_Skip_Bank14";
      this.col_Skip_Bank14.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank14.TrueValue = (object) "1";
      this.col_Skip_Bank15.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank15, "col_Skip_Bank15");
      this.col_Skip_Bank15.IndeterminateValue = (object) "0";
      this.col_Skip_Bank15.Name = "col_Skip_Bank15";
      this.col_Skip_Bank15.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank15.TrueValue = (object) "1";
      this.col_Skip_Bank16.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank16, "col_Skip_Bank16");
      this.col_Skip_Bank16.IndeterminateValue = (object) "0";
      this.col_Skip_Bank16.Name = "col_Skip_Bank16";
      this.col_Skip_Bank16.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank16.TrueValue = (object) "1";
      this.col_Skip_Bank17.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank17, "col_Skip_Bank17");
      this.col_Skip_Bank17.IndeterminateValue = (object) "0";
      this.col_Skip_Bank17.Name = "col_Skip_Bank17";
      this.col_Skip_Bank17.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank17.TrueValue = (object) "1";
      this.col_Skip_Bank18.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank18, "col_Skip_Bank18");
      this.col_Skip_Bank18.IndeterminateValue = (object) "0";
      this.col_Skip_Bank18.Name = "col_Skip_Bank18";
      this.col_Skip_Bank18.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank18.TrueValue = (object) "1";
      this.col_Skip_Bank19.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank19, "col_Skip_Bank19");
      this.col_Skip_Bank19.IndeterminateValue = (object) "0";
      this.col_Skip_Bank19.Name = "col_Skip_Bank19";
      this.col_Skip_Bank19.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank19.TrueValue = (object) "1";
      this.col_Skip_Bank20.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank20, "col_Skip_Bank20");
      this.col_Skip_Bank20.IndeterminateValue = (object) "0";
      this.col_Skip_Bank20.Name = "col_Skip_Bank20";
      this.col_Skip_Bank20.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank20.TrueValue = (object) "1";
      this.col_Skip_Bank21.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank21, "col_Skip_Bank21");
      this.col_Skip_Bank21.IndeterminateValue = (object) "0";
      this.col_Skip_Bank21.Name = "col_Skip_Bank21";
      this.col_Skip_Bank21.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank21.TrueValue = (object) "1";
      this.col_Skip_Bank22.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank22, "col_Skip_Bank22");
      this.col_Skip_Bank22.IndeterminateValue = (object) "0";
      this.col_Skip_Bank22.Name = "col_Skip_Bank22";
      this.col_Skip_Bank22.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank22.TrueValue = (object) "1";
      this.col_Skip_Bank23.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank23, "col_Skip_Bank23");
      this.col_Skip_Bank23.IndeterminateValue = (object) "0";
      this.col_Skip_Bank23.Name = "col_Skip_Bank23";
      this.col_Skip_Bank23.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank23.TrueValue = (object) "1";
      this.col_Skip_Bank24.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Skip_Bank24, "col_Skip_Bank24");
      this.col_Skip_Bank24.IndeterminateValue = (object) "0";
      this.col_Skip_Bank24.Name = "col_Skip_Bank24";
      this.col_Skip_Bank24.Resizable = DataGridViewTriState.True;
      this.col_Skip_Bank24.TrueValue = (object) "1";
      componentResourceManager.ApplyResources((object) this.col_Skip_Comment, "col_Skip_Comment");
      this.col_Skip_Comment.MaxInputLength = 256;
      this.col_Skip_Comment.Name = "col_Skip_Comment";
      this.col_Skip_Comment.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.tab_Pms.BackColor = SystemColors.Control;
      this.tab_Pms.Controls.Add((Control) this.dgv_Pms);
      componentResourceManager.ApplyResources((object) this.tab_Pms, "tab_Pms");
      this.tab_Pms.Name = "tab_Pms";
      this.dgv_Pms.AllowUserToAddRows = false;
      this.dgv_Pms.AllowUserToDeleteRows = false;
      this.dgv_Pms.AllowUserToResizeRows = false;
      gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle6.BackColor = SystemColors.Control;
      gridViewCellStyle6.Font = new Font("MS UI Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 128);
      gridViewCellStyle6.ForeColor = SystemColors.WindowText;
      gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle6.WrapMode = DataGridViewTriState.True;
      this.dgv_Pms.ColumnHeadersDefaultCellStyle = gridViewCellStyle6;
      componentResourceManager.ApplyResources((object) this.dgv_Pms, "dgv_Pms");
      this.dgv_Pms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_Pms.Columns.AddRange((DataGridViewColumn) this.col_Pmf_Ch, (DataGridViewColumn) this.col_Pmf_RxFrq, (DataGridViewColumn) this.col_Pmf_TxFrq, (DataGridViewColumn) this.col_Pmf_ShiftFrq, (DataGridViewColumn) this.col_Pmf_ShiftDir, (DataGridViewColumn) this.col_Pms_AutoMode, (DataGridViewColumn) this.col_Pmf_Mode, (DataGridViewColumn) this.col_Pmf_Ams, (DataGridViewColumn) this.col_Pmf_DigAnalog, (DataGridViewColumn) this.col_Pmf_MemName, (DataGridViewColumn) this.col_Pmf_SqlType, (DataGridViewColumn) this.col_Pmf_ToneFrq, (DataGridViewColumn) this.col_Pmf_DcsCode, (DataGridViewColumn) this.col_Pmf_DcsDim, (DataGridViewColumn) this.col_Pmf_PrTone, (DataGridViewColumn) this.col_Pmf_TxOutput, (DataGridViewColumn) this.col_Pmf_Skip, (DataGridViewColumn) this.col_Pms_AutoStep, (DataGridViewColumn) this.col_Pmf_Step, (DataGridViewColumn) this.col_Pms_Tag, (DataGridViewColumn) this.col_Pmf_MemDel, (DataGridViewColumn) this.col_Pmf_Att, (DataGridViewColumn) this.col_Pmf_Smeter, (DataGridViewColumn) this.col_Pmf_Bell, (DataGridViewColumn) this.col_Pmf_Vibrator, (DataGridViewColumn) this.col_Pmf_HarfDev, (DataGridViewColumn) this.col_Pmf_ClockShift, (DataGridViewColumn) this.col_Pmf_Bank1, (DataGridViewColumn) this.col_Pmf_Bank2, (DataGridViewColumn) this.col_Pmf_Bank3, (DataGridViewColumn) this.col_Pmf_Bank4, (DataGridViewColumn) this.col_Pmf_Bank5, (DataGridViewColumn) this.col_Pmf_Bank6, (DataGridViewColumn) this.col_Pmf_Bank7, (DataGridViewColumn) this.col_Pmf_Bank8, (DataGridViewColumn) this.col_Pmf_Bank9, (DataGridViewColumn) this.col_Pmf_Bank10, (DataGridViewColumn) this.col_Pmf_Bank11, (DataGridViewColumn) this.col_Pmf_Bank12, (DataGridViewColumn) this.col_Pmf_Bank13, (DataGridViewColumn) this.col_Pmf_Bank14, (DataGridViewColumn) this.col_Pmf_Bank15, (DataGridViewColumn) this.col_Pmf_Bank16, (DataGridViewColumn) this.col_Pmf_Bank17, (DataGridViewColumn) this.col_Pmf_Bank18, (DataGridViewColumn) this.col_Pmf_Bank19, (DataGridViewColumn) this.col_Pmf_Bank20, (DataGridViewColumn) this.col_Pmf_Bank21, (DataGridViewColumn) this.col_Pmf_Bank22, (DataGridViewColumn) this.col_Pmf_Bank23, (DataGridViewColumn) this.col_Pmf_Bank24, (DataGridViewColumn) this.col_Pmf_Comment);
      this.dgv_Pms.EnableHeadersVisualStyles = false;
      this.dgv_Pms.Name = "dgv_Pms";
      this.dgv_Pms.RowTemplate.Height = 21;
      this.dgv_Pms.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
      this.dgv_Pms.CellContentClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Pms.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Pms.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
      this.dgv_Pms.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      componentResourceManager.ApplyResources((object) this.col_Pmf_Ch, "col_Pmf_Ch");
      this.col_Pmf_Ch.Name = "col_Pmf_Ch";
      this.col_Pmf_Ch.Resizable = DataGridViewTriState.True;
      gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Pmf_RxFrq.DefaultCellStyle = gridViewCellStyle7;
      componentResourceManager.ApplyResources((object) this.col_Pmf_RxFrq, "col_Pmf_RxFrq");
      this.col_Pmf_RxFrq.Name = "col_Pmf_RxFrq";
      this.col_Pmf_RxFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Pmf_TxFrq.DefaultCellStyle = gridViewCellStyle8;
      componentResourceManager.ApplyResources((object) this.col_Pmf_TxFrq, "col_Pmf_TxFrq");
      this.col_Pmf_TxFrq.Name = "col_Pmf_TxFrq";
      this.col_Pmf_TxFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Pmf_ShiftFrq.DefaultCellStyle = gridViewCellStyle9;
      componentResourceManager.ApplyResources((object) this.col_Pmf_ShiftFrq, "col_Pmf_ShiftFrq");
      this.col_Pmf_ShiftFrq.Name = "col_Pmf_ShiftFrq";
      this.col_Pmf_ShiftFrq.Resizable = DataGridViewTriState.True;
      this.col_Pmf_ShiftFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Pmf_ShiftDir.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_ShiftDir.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_ShiftDir, "col_Pmf_ShiftDir");
      this.col_Pmf_ShiftDir.Items.AddRange((object) "OFF", (object) "-RPT", (object) "+RPT", (object) "-/+");
      this.col_Pmf_ShiftDir.Name = "col_Pmf_ShiftDir";
      this.col_Pmf_ShiftDir.Resizable = DataGridViewTriState.True;
      this.col_Pms_AutoMode.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pms_AutoMode, "col_Pms_AutoMode");
      this.col_Pms_AutoMode.IndeterminateValue = (object) "0";
      this.col_Pms_AutoMode.Name = "col_Pms_AutoMode";
      this.col_Pms_AutoMode.TrueValue = (object) "1";
      this.col_Pmf_Mode.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_Mode.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_Mode, "col_Pmf_Mode");
      this.col_Pmf_Mode.Items.AddRange((object) "FM", (object) "AM");
      this.col_Pmf_Mode.Name = "col_Pmf_Mode";
      this.col_Pmf_Mode.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Ams.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_Ams.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_Ams, "col_Pmf_Ams");
      this.col_Pmf_Ams.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Pmf_Ams.Name = "col_Pmf_Ams";
      this.col_Pmf_DigAnalog.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_DigAnalog.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_DigAnalog, "col_Pmf_DigAnalog");
      this.col_Pmf_DigAnalog.Items.AddRange((object) "ANALOG", (object) "DN", (object) "VW");
      this.col_Pmf_DigAnalog.Name = "col_Pmf_DigAnalog";
      componentResourceManager.ApplyResources((object) this.col_Pmf_MemName, "col_Pmf_MemName");
      this.col_Pmf_MemName.MaxInputLength = 6;
      this.col_Pmf_MemName.Name = "col_Pmf_MemName";
      this.col_Pmf_MemName.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Pmf_SqlType.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_SqlType.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_SqlType, "col_Pmf_SqlType");
      this.col_Pmf_SqlType.Items.AddRange((object) "OFF", (object) "TONE", (object) "TONE SQL", (object) "DCS", (object) "REV TONE", (object) "JR FREQ", (object) "PR FREQ", (object) "PAGER", (object) "D CD", (object) "TONE-DCS", (object) "D CD-TONE");
      this.col_Pmf_SqlType.Name = "col_Pmf_SqlType";
      this.col_Pmf_SqlType.Resizable = DataGridViewTriState.True;
      this.col_Pmf_ToneFrq.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_ToneFrq.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_ToneFrq, "col_Pmf_ToneFrq");
      this.col_Pmf_ToneFrq.Items.AddRange((object) "67.0 Hz", (object) "69.3 Hz", (object) "71.9 Hz", (object) "74.4 Hz", (object) "77.0 Hz", (object) "79.7 Hz", (object) "82.5 Hz", (object) "85.4 Hz", (object) "88.5 Hz", (object) "91.5 Hz", (object) "94.8 Hz", (object) "97.4 Hz", (object) "100.0 Hz", (object) "103.5 Hz", (object) "107.2 Hz", (object) "110.9 Hz", (object) "114.8 Hz", (object) "118.8 Hz", (object) "123.0 Hz", (object) "127.3 Hz", (object) "131.8 Hz", (object) "136.5 Hz", (object) "141.3 Hz", (object) "146.2 Hz", (object) "151.4 Hz", (object) "156.7 Hz", (object) "159.8 Hz", (object) "162.2 Hz", (object) "165.5 Hz", (object) "167.9 Hz", (object) "171.3 Hz", (object) "173.8 Hz", (object) "177.3 Hz", (object) "179.9 Hz", (object) "183.5 Hz", (object) "186.2 Hz", (object) "189.9 Hz", (object) "192.8 Hz", (object) "196.6 Hz", (object) "199.5 Hz", (object) "203.5 Hz", (object) "206.5 Hz", (object) "210.7 Hz", (object) "218.1 Hz", (object) "225.7 Hz", (object) "229.1 Hz", (object) "233.6 Hz", (object) "241.8 Hz", (object) "250.3 Hz", (object) "254.1 Hz");
      this.col_Pmf_ToneFrq.Name = "col_Pmf_ToneFrq";
      this.col_Pmf_ToneFrq.Resizable = DataGridViewTriState.True;
      this.col_Pmf_DcsCode.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_DcsCode.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_DcsCode, "col_Pmf_DcsCode");
      this.col_Pmf_DcsCode.Items.AddRange((object) "023", (object) "025", (object) "026", (object) "031", (object) "032", (object) "036", (object) "043", (object) "047", (object) "051", (object) "053", (object) "054", (object) "065", (object) "071", (object) "072", (object) "073", (object) "074", (object) "114", (object) "115", (object) "116", (object) "122", (object) "125", (object) "131", (object) "132", (object) "134", (object) "143", (object) "145", (object) "152", (object) "155", (object) "156", (object) "162", (object) "165", (object) "172", (object) "174", (object) "205", (object) "212", (object) "223", (object) "225", (object) "226", (object) "243", (object) "244", (object) "245", (object) "246", (object) "251", (object) "252", (object) "255", (object) "261", (object) "263", (object) "265", (object) "266", (object) "271", (object) "274", (object) "306", (object) "311", (object) "315", (object) "325", (object) "331", (object) "332", (object) "343", (object) "346", (object) "351", (object) "356", (object) "364", (object) "365", (object) "371", (object) "411", (object) "412", (object) "413", (object) "423", (object) "431", (object) "432", (object) "445", (object) "446", (object) "452", (object) "454", (object) "455", (object) "462", (object) "464", (object) "465", (object) "466", (object) "503", (object) "506", (object) "516", (object) "523", (object) "526", (object) "532", (object) "546", (object) "565", (object) "606", (object) "612", (object) "624", (object) "627", (object) "631", (object) "632", (object) "654", (object) "662", (object) "664", (object) "703", (object) "712", (object) "723", (object) "731", (object) "732", (object) "734", (object) "743", (object) "754");
      this.col_Pmf_DcsCode.Name = "col_Pmf_DcsCode";
      this.col_Pmf_DcsCode.Resizable = DataGridViewTriState.True;
      this.col_Pmf_DcsDim.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_DcsDim.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_DcsDim, "col_Pmf_DcsDim");
      this.col_Pmf_DcsDim.Items.AddRange((object) "RX同相 TX同相", (object) "RX反転 TX同相", (object) "RX両相 TX同相", (object) "RX同相 TX反転", (object) "RX反転 TX反転", (object) "RX両相 TX反転");
      this.col_Pmf_DcsDim.Name = "col_Pmf_DcsDim";
      this.col_Pmf_DcsDim.Resizable = DataGridViewTriState.True;
      this.col_Pmf_PrTone.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_PrTone.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_PrTone, "col_Pmf_PrTone");
      this.col_Pmf_PrTone.Items.AddRange((object) "300 Hz", (object) "400 Hz", (object) "500 Hz", (object) "600 Hz", (object) "700 Hz", (object) "800 Hz", (object) "900 Hz", (object) "1000 Hz", (object) "1100 Hz", (object) "1200 Hz", (object) "1300 Hz", (object) "1400 Hz", (object) "1500 Hz", (object) "1600 Hz", (object) "1700 Hz", (object) "1800 Hz", (object) "1900 Hz", (object) "2000 Hz", (object) "2100 Hz", (object) "2200 Hz", (object) "2300 Hz", (object) "2400 Hz", (object) "2500 Hz", (object) "2600 Hz", (object) "2700 Hz", (object) "2800 Hz", (object) "2900 Hz", (object) "3000 Hz");
      this.col_Pmf_PrTone.Name = "col_Pmf_PrTone";
      this.col_Pmf_PrTone.Resizable = DataGridViewTriState.True;
      this.col_Pmf_TxOutput.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_TxOutput.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_TxOutput, "col_Pmf_TxOutput");
      this.col_Pmf_TxOutput.Items.AddRange((object) "LOW", (object) "MID", (object) "HIGH");
      this.col_Pmf_TxOutput.Name = "col_Pmf_TxOutput";
      this.col_Pmf_TxOutput.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Skip.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_Skip.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_Skip, "col_Pmf_Skip");
      this.col_Pmf_Skip.Items.AddRange((object) "OFF", (object) "SKIP", (object) "SELECT");
      this.col_Pmf_Skip.Name = "col_Pmf_Skip";
      this.col_Pmf_Skip.Resizable = DataGridViewTriState.True;
      this.col_Pms_AutoStep.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pms_AutoStep, "col_Pms_AutoStep");
      this.col_Pms_AutoStep.IndeterminateValue = (object) "0";
      this.col_Pms_AutoStep.Name = "col_Pms_AutoStep";
      this.col_Pms_AutoStep.TrueValue = (object) "1";
      this.col_Pmf_Step.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_Step.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_Step, "col_Pmf_Step");
      this.col_Pmf_Step.Items.AddRange((object) "5.0KHz", (object) "6.25KHz", (object) "8.33KHz", (object) "10.0KHz", (object) "12.5KHz", (object) "15.0KHz", (object) "20.0KHz", (object) "25.0KHz", (object) "50.0KHz", (object) "100.0KHz");
      this.col_Pmf_Step.Name = "col_Pmf_Step";
      this.col_Pmf_Step.Resizable = DataGridViewTriState.True;
      this.col_Pms_Tag.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pms_Tag, "col_Pms_Tag");
      this.col_Pms_Tag.IndeterminateValue = (object) "0";
      this.col_Pms_Tag.Name = "col_Pms_Tag";
      this.col_Pms_Tag.Resizable = DataGridViewTriState.True;
      this.col_Pms_Tag.TrueValue = (object) "1";
      this.col_Pmf_MemDel.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_MemDel, "col_Pmf_MemDel");
      this.col_Pmf_MemDel.IndeterminateValue = (object) "0";
      this.col_Pmf_MemDel.Name = "col_Pmf_MemDel";
      this.col_Pmf_MemDel.Resizable = DataGridViewTriState.True;
      this.col_Pmf_MemDel.TrueValue = (object) "1";
      this.col_Pmf_Att.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Att, "col_Pmf_Att");
      this.col_Pmf_Att.IndeterminateValue = (object) "0";
      this.col_Pmf_Att.Name = "col_Pmf_Att";
      this.col_Pmf_Att.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Att.TrueValue = (object) "1";
      this.col_Pmf_Smeter.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_Smeter.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_Smeter, "col_Pmf_Smeter");
      this.col_Pmf_Smeter.Items.AddRange((object) "OFF", (object) "Level 1", (object) "Level 2", (object) "Level 3", (object) "Level 4", (object) "Level 5", (object) "Level 6", (object) "Level 7", (object) "Level 8", (object) "Level 9");
      this.col_Pmf_Smeter.Name = "col_Pmf_Smeter";
      this.col_Pmf_Smeter.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bell.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_Bell.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bell, "col_Pmf_Bell");
      this.col_Pmf_Bell.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Pmf_Bell.Name = "col_Pmf_Bell";
      this.col_Pmf_Bell.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Vibrator.DisplayStyleForCurrentCellOnly = true;
      this.col_Pmf_Vibrator.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Pmf_Vibrator, "col_Pmf_Vibrator");
      this.col_Pmf_Vibrator.Items.AddRange((object) "OFF", (object) "BUSY", (object) "SIGNALING");
      this.col_Pmf_Vibrator.Name = "col_Pmf_Vibrator";
      this.col_Pmf_Vibrator.Resizable = DataGridViewTriState.True;
      this.col_Pmf_HarfDev.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_HarfDev, "col_Pmf_HarfDev");
      this.col_Pmf_HarfDev.IndeterminateValue = (object) "0";
      this.col_Pmf_HarfDev.Name = "col_Pmf_HarfDev";
      this.col_Pmf_HarfDev.Resizable = DataGridViewTriState.True;
      this.col_Pmf_HarfDev.TrueValue = (object) "1";
      this.col_Pmf_ClockShift.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_ClockShift, "col_Pmf_ClockShift");
      this.col_Pmf_ClockShift.IndeterminateValue = (object) "0";
      this.col_Pmf_ClockShift.Name = "col_Pmf_ClockShift";
      this.col_Pmf_ClockShift.Resizable = DataGridViewTriState.True;
      this.col_Pmf_ClockShift.TrueValue = (object) "1";
      this.col_Pmf_Bank1.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank1, "col_Pmf_Bank1");
      this.col_Pmf_Bank1.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank1.Name = "col_Pmf_Bank1";
      this.col_Pmf_Bank1.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank1.TrueValue = (object) "1";
      this.col_Pmf_Bank2.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank2, "col_Pmf_Bank2");
      this.col_Pmf_Bank2.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank2.Name = "col_Pmf_Bank2";
      this.col_Pmf_Bank2.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank2.TrueValue = (object) "1";
      this.col_Pmf_Bank3.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank3, "col_Pmf_Bank3");
      this.col_Pmf_Bank3.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank3.Name = "col_Pmf_Bank3";
      this.col_Pmf_Bank3.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank3.TrueValue = (object) "1";
      this.col_Pmf_Bank4.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank4, "col_Pmf_Bank4");
      this.col_Pmf_Bank4.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank4.Name = "col_Pmf_Bank4";
      this.col_Pmf_Bank4.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank4.TrueValue = (object) "1";
      this.col_Pmf_Bank5.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank5, "col_Pmf_Bank5");
      this.col_Pmf_Bank5.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank5.Name = "col_Pmf_Bank5";
      this.col_Pmf_Bank5.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank5.TrueValue = (object) "1";
      this.col_Pmf_Bank6.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank6, "col_Pmf_Bank6");
      this.col_Pmf_Bank6.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank6.Name = "col_Pmf_Bank6";
      this.col_Pmf_Bank6.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank6.TrueValue = (object) "1";
      this.col_Pmf_Bank7.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank7, "col_Pmf_Bank7");
      this.col_Pmf_Bank7.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank7.Name = "col_Pmf_Bank7";
      this.col_Pmf_Bank7.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank7.TrueValue = (object) "1";
      this.col_Pmf_Bank8.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank8, "col_Pmf_Bank8");
      this.col_Pmf_Bank8.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank8.Name = "col_Pmf_Bank8";
      this.col_Pmf_Bank8.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank8.TrueValue = (object) "1";
      this.col_Pmf_Bank9.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank9, "col_Pmf_Bank9");
      this.col_Pmf_Bank9.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank9.Name = "col_Pmf_Bank9";
      this.col_Pmf_Bank9.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank9.TrueValue = (object) "1";
      this.col_Pmf_Bank10.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank10, "col_Pmf_Bank10");
      this.col_Pmf_Bank10.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank10.Name = "col_Pmf_Bank10";
      this.col_Pmf_Bank10.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank10.TrueValue = (object) "1";
      this.col_Pmf_Bank11.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank11, "col_Pmf_Bank11");
      this.col_Pmf_Bank11.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank11.Name = "col_Pmf_Bank11";
      this.col_Pmf_Bank11.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank11.TrueValue = (object) "1";
      this.col_Pmf_Bank12.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank12, "col_Pmf_Bank12");
      this.col_Pmf_Bank12.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank12.Name = "col_Pmf_Bank12";
      this.col_Pmf_Bank12.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank12.TrueValue = (object) "1";
      this.col_Pmf_Bank13.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank13, "col_Pmf_Bank13");
      this.col_Pmf_Bank13.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank13.Name = "col_Pmf_Bank13";
      this.col_Pmf_Bank13.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank13.TrueValue = (object) "1";
      this.col_Pmf_Bank14.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank14, "col_Pmf_Bank14");
      this.col_Pmf_Bank14.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank14.Name = "col_Pmf_Bank14";
      this.col_Pmf_Bank14.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank14.TrueValue = (object) "1";
      this.col_Pmf_Bank15.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank15, "col_Pmf_Bank15");
      this.col_Pmf_Bank15.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank15.Name = "col_Pmf_Bank15";
      this.col_Pmf_Bank15.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank15.TrueValue = (object) "1";
      this.col_Pmf_Bank16.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank16, "col_Pmf_Bank16");
      this.col_Pmf_Bank16.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank16.Name = "col_Pmf_Bank16";
      this.col_Pmf_Bank16.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank16.TrueValue = (object) "1";
      this.col_Pmf_Bank17.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank17, "col_Pmf_Bank17");
      this.col_Pmf_Bank17.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank17.Name = "col_Pmf_Bank17";
      this.col_Pmf_Bank17.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank17.TrueValue = (object) "1";
      this.col_Pmf_Bank18.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank18, "col_Pmf_Bank18");
      this.col_Pmf_Bank18.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank18.Name = "col_Pmf_Bank18";
      this.col_Pmf_Bank18.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank18.TrueValue = (object) "1";
      this.col_Pmf_Bank19.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank19, "col_Pmf_Bank19");
      this.col_Pmf_Bank19.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank19.Name = "col_Pmf_Bank19";
      this.col_Pmf_Bank19.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank19.TrueValue = (object) "1";
      this.col_Pmf_Bank20.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank20, "col_Pmf_Bank20");
      this.col_Pmf_Bank20.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank20.Name = "col_Pmf_Bank20";
      this.col_Pmf_Bank20.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank20.TrueValue = (object) "1";
      this.col_Pmf_Bank21.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank21, "col_Pmf_Bank21");
      this.col_Pmf_Bank21.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank21.Name = "col_Pmf_Bank21";
      this.col_Pmf_Bank21.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank21.TrueValue = (object) "1";
      this.col_Pmf_Bank22.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank22, "col_Pmf_Bank22");
      this.col_Pmf_Bank22.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank22.Name = "col_Pmf_Bank22";
      this.col_Pmf_Bank22.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank22.TrueValue = (object) "1";
      this.col_Pmf_Bank23.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank23, "col_Pmf_Bank23");
      this.col_Pmf_Bank23.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank23.Name = "col_Pmf_Bank23";
      this.col_Pmf_Bank23.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank23.TrueValue = (object) "1";
      this.col_Pmf_Bank24.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Bank24, "col_Pmf_Bank24");
      this.col_Pmf_Bank24.IndeterminateValue = (object) "0";
      this.col_Pmf_Bank24.Name = "col_Pmf_Bank24";
      this.col_Pmf_Bank24.Resizable = DataGridViewTriState.True;
      this.col_Pmf_Bank24.TrueValue = (object) "1";
      componentResourceManager.ApplyResources((object) this.col_Pmf_Comment, "col_Pmf_Comment");
      this.col_Pmf_Comment.MaxInputLength = 256;
      this.col_Pmf_Comment.Name = "col_Pmf_Comment";
      this.col_Pmf_Comment.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.tab_Vfo.BackColor = SystemColors.Control;
      this.tab_Vfo.Controls.Add((Control) this.dgv_Vfo);
      componentResourceManager.ApplyResources((object) this.tab_Vfo, "tab_Vfo");
      this.tab_Vfo.Name = "tab_Vfo";
      this.dgv_Vfo.AllowUserToAddRows = false;
      this.dgv_Vfo.AllowUserToDeleteRows = false;
      this.dgv_Vfo.AllowUserToResizeRows = false;
      gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle10.BackColor = SystemColors.Control;
      gridViewCellStyle10.Font = new Font("MS UI Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 128);
      gridViewCellStyle10.ForeColor = SystemColors.WindowText;
      gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle10.WrapMode = DataGridViewTriState.True;
      this.dgv_Vfo.ColumnHeadersDefaultCellStyle = gridViewCellStyle10;
      componentResourceManager.ApplyResources((object) this.dgv_Vfo, "dgv_Vfo");
      this.dgv_Vfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_Vfo.Columns.AddRange((DataGridViewColumn) this.col_Vfo_Ch, (DataGridViewColumn) this.col_Vfo_RxFrq, (DataGridViewColumn) this.col_Vfo_TxFrq, (DataGridViewColumn) this.col_Vfo_ShiftFrq, (DataGridViewColumn) this.col_Vfo_ShiftDir, (DataGridViewColumn) this.col_Vfo_AutoMode, (DataGridViewColumn) this.col_Vfo_Mode, (DataGridViewColumn) this.col_Vfo_Ams, (DataGridViewColumn) this.col_Vfo_DigAnalog, (DataGridViewColumn) this.col_Vfo_MemName, (DataGridViewColumn) this.col_Vfo_SqlType, (DataGridViewColumn) this.col_Vfo_ToneFrq, (DataGridViewColumn) this.col_Vfo_DcsCode, (DataGridViewColumn) this.col_Vfo_DcsDim, (DataGridViewColumn) this.col_Vfo_PrTone, (DataGridViewColumn) this.col_Vfo_TxOutput, (DataGridViewColumn) this.col_Vfo_Skip, (DataGridViewColumn) this.col_Vfo_AutoStep, (DataGridViewColumn) this.col_Vfo_Step, (DataGridViewColumn) this.col_Vfo_Tag, (DataGridViewColumn) this.col_Vfo_MemDel, (DataGridViewColumn) this.col_Vfo_Att, (DataGridViewColumn) this.col_Vfo_Smeter, (DataGridViewColumn) this.col_Vfo_Bell, (DataGridViewColumn) this.col_Vfo_Vibrator, (DataGridViewColumn) this.col_Vfo_HarfDev, (DataGridViewColumn) this.col_Vfo_ClockShift, (DataGridViewColumn) this.col_Vfo_Bank1, (DataGridViewColumn) this.col_Vfo_Bank2, (DataGridViewColumn) this.col_Vfo_Bank3, (DataGridViewColumn) this.col_Vfo_Bank4, (DataGridViewColumn) this.col_Vfo_Bank5, (DataGridViewColumn) this.col_Vfo_Bank6, (DataGridViewColumn) this.col_Vfo_Bank7, (DataGridViewColumn) this.col_Vfo_Bank8, (DataGridViewColumn) this.col_Vfo_Bank9, (DataGridViewColumn) this.col_Vfo_Bank10, (DataGridViewColumn) this.col_Vfo_Bank11, (DataGridViewColumn) this.col_Vfo_Bank12, (DataGridViewColumn) this.col_Vfo_Bank13, (DataGridViewColumn) this.col_Vfo_Bank14, (DataGridViewColumn) this.col_Vfo_Bank15, (DataGridViewColumn) this.col_Vfo_Bank16, (DataGridViewColumn) this.col_Vfo_Bank17, (DataGridViewColumn) this.col_Vfo_Bank18, (DataGridViewColumn) this.col_Vfo_Bank19, (DataGridViewColumn) this.col_Vfo_Bank20, (DataGridViewColumn) this.col_Vfo_Bank21, (DataGridViewColumn) this.col_Vfo_Bank22, (DataGridViewColumn) this.col_Vfo_Bank23, (DataGridViewColumn) this.col_Vfo_Bank24, (DataGridViewColumn) this.col_Vfo_Comment);
      this.dgv_Vfo.EnableHeadersVisualStyles = false;
      this.dgv_Vfo.Name = "dgv_Vfo";
      this.dgv_Vfo.RowTemplate.Height = 21;
      this.dgv_Vfo.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
      this.dgv_Vfo.CellContentClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Vfo.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Vfo.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
      this.dgv_Vfo.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      componentResourceManager.ApplyResources((object) this.col_Vfo_Ch, "col_Vfo_Ch");
      this.col_Vfo_Ch.Name = "col_Vfo_Ch";
      this.col_Vfo_Ch.Resizable = DataGridViewTriState.True;
      gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Vfo_RxFrq.DefaultCellStyle = gridViewCellStyle11;
      componentResourceManager.ApplyResources((object) this.col_Vfo_RxFrq, "col_Vfo_RxFrq");
      this.col_Vfo_RxFrq.Name = "col_Vfo_RxFrq";
      this.col_Vfo_RxFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Vfo_TxFrq.DefaultCellStyle = gridViewCellStyle12;
      componentResourceManager.ApplyResources((object) this.col_Vfo_TxFrq, "col_Vfo_TxFrq");
      this.col_Vfo_TxFrq.Name = "col_Vfo_TxFrq";
      this.col_Vfo_TxFrq.ReadOnly = true;
      this.col_Vfo_TxFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Vfo_ShiftFrq.DefaultCellStyle = gridViewCellStyle13;
      componentResourceManager.ApplyResources((object) this.col_Vfo_ShiftFrq, "col_Vfo_ShiftFrq");
      this.col_Vfo_ShiftFrq.Name = "col_Vfo_ShiftFrq";
      this.col_Vfo_ShiftFrq.Resizable = DataGridViewTriState.True;
      this.col_Vfo_ShiftFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Vfo_ShiftDir.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_ShiftDir.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_ShiftDir, "col_Vfo_ShiftDir");
      this.col_Vfo_ShiftDir.Items.AddRange((object) "OFF", (object) "-RPT", (object) "+RPT");
      this.col_Vfo_ShiftDir.Name = "col_Vfo_ShiftDir";
      this.col_Vfo_ShiftDir.Resizable = DataGridViewTriState.True;
      this.col_Vfo_AutoMode.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_AutoMode, "col_Vfo_AutoMode");
      this.col_Vfo_AutoMode.IndeterminateValue = (object) "0";
      this.col_Vfo_AutoMode.Name = "col_Vfo_AutoMode";
      this.col_Vfo_AutoMode.Resizable = DataGridViewTriState.True;
      this.col_Vfo_AutoMode.TrueValue = (object) "1";
      this.col_Vfo_Mode.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_Mode.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_Mode, "col_Vfo_Mode");
      this.col_Vfo_Mode.Items.AddRange((object) "FM", (object) "AM");
      this.col_Vfo_Mode.Name = "col_Vfo_Mode";
      this.col_Vfo_Mode.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Ams.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_Ams.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_Ams, "col_Vfo_Ams");
      this.col_Vfo_Ams.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Vfo_Ams.Name = "col_Vfo_Ams";
      this.col_Vfo_DigAnalog.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_DigAnalog.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_DigAnalog, "col_Vfo_DigAnalog");
      this.col_Vfo_DigAnalog.Items.AddRange((object) "ANALOG", (object) "DN", (object) "VW");
      this.col_Vfo_DigAnalog.Name = "col_Vfo_DigAnalog";
      componentResourceManager.ApplyResources((object) this.col_Vfo_MemName, "col_Vfo_MemName");
      this.col_Vfo_MemName.MaxInputLength = 32;
      this.col_Vfo_MemName.Name = "col_Vfo_MemName";
      this.col_Vfo_MemName.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Vfo_SqlType.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_SqlType.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_SqlType, "col_Vfo_SqlType");
      this.col_Vfo_SqlType.Items.AddRange((object) "OFF", (object) "TONE", (object) "TONE SQL", (object) "DCS", (object) "REV TONE", (object) "JR FREQ", (object) "PR FREQ", (object) "PAGER", (object) "D CD", (object) "TONE-DCS", (object) "D CD-TONE");
      this.col_Vfo_SqlType.Name = "col_Vfo_SqlType";
      this.col_Vfo_SqlType.Resizable = DataGridViewTriState.True;
      this.col_Vfo_ToneFrq.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_ToneFrq.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_ToneFrq, "col_Vfo_ToneFrq");
      this.col_Vfo_ToneFrq.Items.AddRange((object) "67.0 Hz", (object) "69.3 Hz", (object) "71.9 Hz", (object) "74.4 Hz", (object) "77.0 Hz", (object) "79.7 Hz", (object) "82.5 Hz", (object) "85.4 Hz", (object) "88.5 Hz", (object) "91.5 Hz", (object) "94.8 Hz", (object) "97.4 Hz", (object) "100.0 Hz", (object) "103.5 Hz", (object) "107.2 Hz", (object) "110.9 Hz", (object) "114.8 Hz", (object) "118.8 Hz", (object) "123.0 Hz", (object) "127.3 Hz", (object) "131.8 Hz", (object) "136.5 Hz", (object) "141.3 Hz", (object) "146.2 Hz", (object) "151.4 Hz", (object) "156.7 Hz", (object) "159.8 Hz", (object) "162.2 Hz", (object) "165.5 Hz", (object) "167.9 Hz", (object) "171.3 Hz", (object) "173.8 Hz", (object) "177.3 Hz", (object) "179.9 Hz", (object) "183.5 Hz", (object) "186.2 Hz", (object) "189.9 Hz", (object) "192.8 Hz", (object) "196.6 Hz", (object) "199.5 Hz", (object) "203.5 Hz", (object) "206.5 Hz", (object) "210.7 Hz", (object) "218.1 Hz", (object) "225.7 Hz", (object) "229.1 Hz", (object) "233.6 Hz", (object) "241.8 Hz", (object) "250.3 Hz", (object) "254.1 Hz");
      this.col_Vfo_ToneFrq.Name = "col_Vfo_ToneFrq";
      this.col_Vfo_ToneFrq.Resizable = DataGridViewTriState.True;
      this.col_Vfo_DcsCode.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_DcsCode.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_DcsCode, "col_Vfo_DcsCode");
      this.col_Vfo_DcsCode.Items.AddRange((object) "023", (object) "025", (object) "026", (object) "031", (object) "032", (object) "036", (object) "043", (object) "047", (object) "051", (object) "053", (object) "054", (object) "065", (object) "071", (object) "072", (object) "073", (object) "074", (object) "114", (object) "115", (object) "116", (object) "122", (object) "125", (object) "131", (object) "132", (object) "134", (object) "143", (object) "145", (object) "152", (object) "155", (object) "156", (object) "162", (object) "165", (object) "172", (object) "174", (object) "205", (object) "212", (object) "223", (object) "225", (object) "226", (object) "243", (object) "244", (object) "245", (object) "246", (object) "251", (object) "252", (object) "255", (object) "261", (object) "263", (object) "265", (object) "266", (object) "271", (object) "274", (object) "306", (object) "311", (object) "315", (object) "325", (object) "331", (object) "332", (object) "343", (object) "346", (object) "351", (object) "356", (object) "364", (object) "365", (object) "371", (object) "411", (object) "412", (object) "413", (object) "423", (object) "431", (object) "432", (object) "445", (object) "446", (object) "452", (object) "454", (object) "455", (object) "462", (object) "464", (object) "465", (object) "466", (object) "503", (object) "506", (object) "516", (object) "523", (object) "526", (object) "532", (object) "546", (object) "565", (object) "606", (object) "612", (object) "624", (object) "627", (object) "631", (object) "632", (object) "654", (object) "662", (object) "664", (object) "703", (object) "712", (object) "723", (object) "731", (object) "732", (object) "734", (object) "743", (object) "754");
      this.col_Vfo_DcsCode.Name = "col_Vfo_DcsCode";
      this.col_Vfo_DcsCode.Resizable = DataGridViewTriState.True;
      this.col_Vfo_DcsDim.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_DcsDim.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_DcsDim, "col_Vfo_DcsDim");
      this.col_Vfo_DcsDim.Items.AddRange((object) "RX同相 TX同相", (object) "RX反転 TX同相", (object) "RX両相 TX同相", (object) "RX同相 TX反転", (object) "RX反転 TX反転", (object) "RX両相 TX反転");
      this.col_Vfo_DcsDim.Name = "col_Vfo_DcsDim";
      this.col_Vfo_DcsDim.Resizable = DataGridViewTriState.True;
      this.col_Vfo_PrTone.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_PrTone.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_PrTone, "col_Vfo_PrTone");
      this.col_Vfo_PrTone.Items.AddRange((object) "300 Hz", (object) "400 Hz", (object) "500 Hz", (object) "600 Hz", (object) "700 Hz", (object) "800 Hz", (object) "900 Hz", (object) "1000 Hz", (object) "1100 Hz", (object) "1200 Hz", (object) "1300 Hz", (object) "1400 Hz", (object) "1500 Hz", (object) "1600 Hz", (object) "1700 Hz", (object) "1800 Hz", (object) "1900 Hz", (object) "2000 Hz", (object) "2100 Hz", (object) "2200 Hz", (object) "2300 Hz", (object) "2400 Hz", (object) "2500 Hz", (object) "2600 Hz", (object) "2700 Hz", (object) "2800 Hz", (object) "2900 Hz", (object) "3000 Hz");
      this.col_Vfo_PrTone.Name = "col_Vfo_PrTone";
      this.col_Vfo_PrTone.Resizable = DataGridViewTriState.True;
      this.col_Vfo_TxOutput.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_TxOutput.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_TxOutput, "col_Vfo_TxOutput");
      this.col_Vfo_TxOutput.Items.AddRange((object) "LOW", (object) "MID", (object) "HIGH");
      this.col_Vfo_TxOutput.Name = "col_Vfo_TxOutput";
      this.col_Vfo_TxOutput.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Skip.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_Skip.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_Skip, "col_Vfo_Skip");
      this.col_Vfo_Skip.Items.AddRange((object) "OFF", (object) "SKIP", (object) "SELECT");
      this.col_Vfo_Skip.Name = "col_Vfo_Skip";
      this.col_Vfo_Skip.Resizable = DataGridViewTriState.True;
      this.col_Vfo_AutoStep.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_AutoStep, "col_Vfo_AutoStep");
      this.col_Vfo_AutoStep.IndeterminateValue = (object) "0";
      this.col_Vfo_AutoStep.Name = "col_Vfo_AutoStep";
      this.col_Vfo_AutoStep.Resizable = DataGridViewTriState.True;
      this.col_Vfo_AutoStep.TrueValue = (object) "1";
      this.col_Vfo_Step.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_Step.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_Step, "col_Vfo_Step");
      this.col_Vfo_Step.Items.AddRange((object) "5.0KHz", (object) "6.25KHz", (object) "8.33KHz", (object) "10.0KHz", (object) "12.5KHz", (object) "15.0KHz", (object) "20.0KHz", (object) "25.0KHz", (object) "50.0KHz", (object) "100.0KHz");
      this.col_Vfo_Step.Name = "col_Vfo_Step";
      this.col_Vfo_Step.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Tag.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Tag, "col_Vfo_Tag");
      this.col_Vfo_Tag.IndeterminateValue = (object) "0";
      this.col_Vfo_Tag.Name = "col_Vfo_Tag";
      this.col_Vfo_Tag.TrueValue = (object) "1";
      this.col_Vfo_MemDel.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_MemDel, "col_Vfo_MemDel");
      this.col_Vfo_MemDel.IndeterminateValue = (object) "0";
      this.col_Vfo_MemDel.Name = "col_Vfo_MemDel";
      this.col_Vfo_MemDel.Resizable = DataGridViewTriState.True;
      this.col_Vfo_MemDel.TrueValue = (object) "1";
      this.col_Vfo_Att.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Att, "col_Vfo_Att");
      this.col_Vfo_Att.IndeterminateValue = (object) "0";
      this.col_Vfo_Att.Name = "col_Vfo_Att";
      this.col_Vfo_Att.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Att.TrueValue = (object) "1";
      this.col_Vfo_Smeter.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_Smeter.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_Smeter, "col_Vfo_Smeter");
      this.col_Vfo_Smeter.Items.AddRange((object) "OFF", (object) "Level 1", (object) "Level 2", (object) "Level 3", (object) "Level 4", (object) "Level 5", (object) "Level 6", (object) "Level 7", (object) "Level 8", (object) "Level 9");
      this.col_Vfo_Smeter.Name = "col_Vfo_Smeter";
      this.col_Vfo_Smeter.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bell.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_Bell.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bell, "col_Vfo_Bell");
      this.col_Vfo_Bell.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Vfo_Bell.Name = "col_Vfo_Bell";
      this.col_Vfo_Bell.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Vibrator.DisplayStyleForCurrentCellOnly = true;
      this.col_Vfo_Vibrator.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Vfo_Vibrator, "col_Vfo_Vibrator");
      this.col_Vfo_Vibrator.Items.AddRange((object) "OFF", (object) "BUSY", (object) "SIGNALING");
      this.col_Vfo_Vibrator.Name = "col_Vfo_Vibrator";
      this.col_Vfo_Vibrator.Resizable = DataGridViewTriState.True;
      this.col_Vfo_HarfDev.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_HarfDev, "col_Vfo_HarfDev");
      this.col_Vfo_HarfDev.IndeterminateValue = (object) "0";
      this.col_Vfo_HarfDev.Name = "col_Vfo_HarfDev";
      this.col_Vfo_HarfDev.Resizable = DataGridViewTriState.True;
      this.col_Vfo_HarfDev.TrueValue = (object) "1";
      this.col_Vfo_ClockShift.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_ClockShift, "col_Vfo_ClockShift");
      this.col_Vfo_ClockShift.IndeterminateValue = (object) "0";
      this.col_Vfo_ClockShift.Name = "col_Vfo_ClockShift";
      this.col_Vfo_ClockShift.Resizable = DataGridViewTriState.True;
      this.col_Vfo_ClockShift.TrueValue = (object) "1";
      this.col_Vfo_Bank1.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank1, "col_Vfo_Bank1");
      this.col_Vfo_Bank1.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank1.Name = "col_Vfo_Bank1";
      this.col_Vfo_Bank1.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank1.TrueValue = (object) "1";
      this.col_Vfo_Bank2.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank2, "col_Vfo_Bank2");
      this.col_Vfo_Bank2.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank2.Name = "col_Vfo_Bank2";
      this.col_Vfo_Bank2.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank2.TrueValue = (object) "1";
      this.col_Vfo_Bank3.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank3, "col_Vfo_Bank3");
      this.col_Vfo_Bank3.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank3.Name = "col_Vfo_Bank3";
      this.col_Vfo_Bank3.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank3.TrueValue = (object) "1";
      this.col_Vfo_Bank4.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank4, "col_Vfo_Bank4");
      this.col_Vfo_Bank4.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank4.Name = "col_Vfo_Bank4";
      this.col_Vfo_Bank4.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank4.TrueValue = (object) "1";
      this.col_Vfo_Bank5.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank5, "col_Vfo_Bank5");
      this.col_Vfo_Bank5.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank5.Name = "col_Vfo_Bank5";
      this.col_Vfo_Bank5.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank5.TrueValue = (object) "1";
      this.col_Vfo_Bank6.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank6, "col_Vfo_Bank6");
      this.col_Vfo_Bank6.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank6.Name = "col_Vfo_Bank6";
      this.col_Vfo_Bank6.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank6.TrueValue = (object) "1";
      this.col_Vfo_Bank7.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank7, "col_Vfo_Bank7");
      this.col_Vfo_Bank7.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank7.Name = "col_Vfo_Bank7";
      this.col_Vfo_Bank7.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank7.TrueValue = (object) "1";
      this.col_Vfo_Bank8.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank8, "col_Vfo_Bank8");
      this.col_Vfo_Bank8.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank8.Name = "col_Vfo_Bank8";
      this.col_Vfo_Bank8.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank8.TrueValue = (object) "1";
      this.col_Vfo_Bank9.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank9, "col_Vfo_Bank9");
      this.col_Vfo_Bank9.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank9.Name = "col_Vfo_Bank9";
      this.col_Vfo_Bank9.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank9.TrueValue = (object) "1";
      this.col_Vfo_Bank10.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank10, "col_Vfo_Bank10");
      this.col_Vfo_Bank10.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank10.Name = "col_Vfo_Bank10";
      this.col_Vfo_Bank10.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank10.TrueValue = (object) "1";
      this.col_Vfo_Bank11.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank11, "col_Vfo_Bank11");
      this.col_Vfo_Bank11.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank11.Name = "col_Vfo_Bank11";
      this.col_Vfo_Bank11.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank11.TrueValue = (object) "1";
      this.col_Vfo_Bank12.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank12, "col_Vfo_Bank12");
      this.col_Vfo_Bank12.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank12.Name = "col_Vfo_Bank12";
      this.col_Vfo_Bank12.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank12.TrueValue = (object) "1";
      this.col_Vfo_Bank13.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank13, "col_Vfo_Bank13");
      this.col_Vfo_Bank13.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank13.Name = "col_Vfo_Bank13";
      this.col_Vfo_Bank13.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank13.TrueValue = (object) "1";
      this.col_Vfo_Bank14.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank14, "col_Vfo_Bank14");
      this.col_Vfo_Bank14.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank14.Name = "col_Vfo_Bank14";
      this.col_Vfo_Bank14.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank14.TrueValue = (object) "1";
      this.col_Vfo_Bank15.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank15, "col_Vfo_Bank15");
      this.col_Vfo_Bank15.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank15.Name = "col_Vfo_Bank15";
      this.col_Vfo_Bank15.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank15.TrueValue = (object) "1";
      this.col_Vfo_Bank16.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank16, "col_Vfo_Bank16");
      this.col_Vfo_Bank16.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank16.Name = "col_Vfo_Bank16";
      this.col_Vfo_Bank16.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank16.TrueValue = (object) "1";
      this.col_Vfo_Bank17.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank17, "col_Vfo_Bank17");
      this.col_Vfo_Bank17.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank17.Name = "col_Vfo_Bank17";
      this.col_Vfo_Bank17.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank17.TrueValue = (object) "1";
      this.col_Vfo_Bank18.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank18, "col_Vfo_Bank18");
      this.col_Vfo_Bank18.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank18.Name = "col_Vfo_Bank18";
      this.col_Vfo_Bank18.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank18.TrueValue = (object) "1";
      this.col_Vfo_Bank19.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank19, "col_Vfo_Bank19");
      this.col_Vfo_Bank19.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank19.Name = "col_Vfo_Bank19";
      this.col_Vfo_Bank19.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank19.TrueValue = (object) "1";
      this.col_Vfo_Bank20.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank20, "col_Vfo_Bank20");
      this.col_Vfo_Bank20.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank20.Name = "col_Vfo_Bank20";
      this.col_Vfo_Bank20.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank20.TrueValue = (object) "1";
      this.col_Vfo_Bank21.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank21, "col_Vfo_Bank21");
      this.col_Vfo_Bank21.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank21.Name = "col_Vfo_Bank21";
      this.col_Vfo_Bank21.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank21.TrueValue = (object) "1";
      this.col_Vfo_Bank22.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank22, "col_Vfo_Bank22");
      this.col_Vfo_Bank22.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank22.Name = "col_Vfo_Bank22";
      this.col_Vfo_Bank22.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank22.TrueValue = (object) "1";
      this.col_Vfo_Bank23.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank23, "col_Vfo_Bank23");
      this.col_Vfo_Bank23.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank23.Name = "col_Vfo_Bank23";
      this.col_Vfo_Bank23.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank23.TrueValue = (object) "1";
      this.col_Vfo_Bank24.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Bank24, "col_Vfo_Bank24");
      this.col_Vfo_Bank24.IndeterminateValue = (object) "0";
      this.col_Vfo_Bank24.Name = "col_Vfo_Bank24";
      this.col_Vfo_Bank24.Resizable = DataGridViewTriState.True;
      this.col_Vfo_Bank24.TrueValue = (object) "1";
      componentResourceManager.ApplyResources((object) this.col_Vfo_Comment, "col_Vfo_Comment");
      this.col_Vfo_Comment.MaxInputLength = 256;
      this.col_Vfo_Comment.Name = "col_Vfo_Comment";
      this.col_Vfo_Comment.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.tab_Home.BackColor = SystemColors.Control;
      this.tab_Home.Controls.Add((Control) this.dgv_Home);
      componentResourceManager.ApplyResources((object) this.tab_Home, "tab_Home");
      this.tab_Home.Name = "tab_Home";
      this.dgv_Home.AllowUserToAddRows = false;
      this.dgv_Home.AllowUserToDeleteRows = false;
      this.dgv_Home.AllowUserToResizeRows = false;
      gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle14.BackColor = SystemColors.Control;
      gridViewCellStyle14.Font = new Font("MS UI Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 128);
      gridViewCellStyle14.ForeColor = SystemColors.WindowText;
      gridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle14.WrapMode = DataGridViewTriState.True;
      this.dgv_Home.ColumnHeadersDefaultCellStyle = gridViewCellStyle14;
      componentResourceManager.ApplyResources((object) this.dgv_Home, "dgv_Home");
      this.dgv_Home.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_Home.Columns.AddRange((DataGridViewColumn) this.col_Home_Ch, (DataGridViewColumn) this.col_Home_RxFrq, (DataGridViewColumn) this.col_Home_TxFrq, (DataGridViewColumn) this.col_Home_ShiftFrq, (DataGridViewColumn) this.col_Home_ShiftDir, (DataGridViewColumn) this.col_Home_AutoMode, (DataGridViewColumn) this.col_Home_Mode, (DataGridViewColumn) this.col_Home_Ams, (DataGridViewColumn) this.col_Home_DigAnalog, (DataGridViewColumn) this.col_Home_MemName, (DataGridViewColumn) this.col_Home_SqlType, (DataGridViewColumn) this.col_Home_ToneFrq, (DataGridViewColumn) this.col_Home_DcsCode, (DataGridViewColumn) this.col_Home_DcsDim, (DataGridViewColumn) this.col_Home_PrTone, (DataGridViewColumn) this.col_Home_TxOutput, (DataGridViewColumn) this.col_Home_Skip, (DataGridViewColumn) this.col_Home_AutoStep, (DataGridViewColumn) this.col_Home_Step, (DataGridViewColumn) this.col_Home_Tag, (DataGridViewColumn) this.col_Home_MemDel, (DataGridViewColumn) this.col_Home_Att, (DataGridViewColumn) this.col_Home_Smeter, (DataGridViewColumn) this.col_Home_Bell, (DataGridViewColumn) this.col_Home_Vibrator, (DataGridViewColumn) this.col_Home_HarfDev, (DataGridViewColumn) this.col_Home_ClockShift, (DataGridViewColumn) this.col_Home_Bank1, (DataGridViewColumn) this.col_Home_Bank2, (DataGridViewColumn) this.col_Home_Bank3, (DataGridViewColumn) this.col_Home_Bank4, (DataGridViewColumn) this.col_Home_Bank5, (DataGridViewColumn) this.col_Home_Bank6, (DataGridViewColumn) this.col_Home_Bank7, (DataGridViewColumn) this.col_Home_Bank8, (DataGridViewColumn) this.col_Home_Bank9, (DataGridViewColumn) this.col_Home_Bank10, (DataGridViewColumn) this.col_Home_Bank11, (DataGridViewColumn) this.col_Home_Bank12, (DataGridViewColumn) this.col_Home_Bank13, (DataGridViewColumn) this.col_Home_Bank14, (DataGridViewColumn) this.col_Home_Bank15, (DataGridViewColumn) this.col_Home_Bank16, (DataGridViewColumn) this.col_Home_Bank17, (DataGridViewColumn) this.col_Home_Bank18, (DataGridViewColumn) this.col_Home_Bank19, (DataGridViewColumn) this.col_Home_Bank20, (DataGridViewColumn) this.col_Home_Bank21, (DataGridViewColumn) this.col_Home_Bank22, (DataGridViewColumn) this.col_Home_Bank23, (DataGridViewColumn) this.col_Home_Bank24, (DataGridViewColumn) this.col_Home_Comment);
      this.dgv_Home.EnableHeadersVisualStyles = false;
      this.dgv_Home.Name = "dgv_Home";
      this.dgv_Home.RowTemplate.Height = 21;
      this.dgv_Home.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
      this.dgv_Home.CellContentClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Home.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Home.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
      this.dgv_Home.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      componentResourceManager.ApplyResources((object) this.col_Home_Ch, "col_Home_Ch");
      this.col_Home_Ch.Name = "col_Home_Ch";
      this.col_Home_Ch.Resizable = DataGridViewTriState.True;
      gridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Home_RxFrq.DefaultCellStyle = gridViewCellStyle15;
      componentResourceManager.ApplyResources((object) this.col_Home_RxFrq, "col_Home_RxFrq");
      this.col_Home_RxFrq.Name = "col_Home_RxFrq";
      this.col_Home_RxFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Home_TxFrq.DefaultCellStyle = gridViewCellStyle16;
      componentResourceManager.ApplyResources((object) this.col_Home_TxFrq, "col_Home_TxFrq");
      this.col_Home_TxFrq.Name = "col_Home_TxFrq";
      this.col_Home_TxFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Home_ShiftFrq.DefaultCellStyle = gridViewCellStyle17;
      componentResourceManager.ApplyResources((object) this.col_Home_ShiftFrq, "col_Home_ShiftFrq");
      this.col_Home_ShiftFrq.Name = "col_Home_ShiftFrq";
      this.col_Home_ShiftFrq.Resizable = DataGridViewTriState.True;
      this.col_Home_ShiftFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Home_ShiftDir.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_ShiftDir.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_ShiftDir, "col_Home_ShiftDir");
      this.col_Home_ShiftDir.Items.AddRange((object) "OFF", (object) "-RPT", (object) "+RPT", (object) "-/+");
      this.col_Home_ShiftDir.Name = "col_Home_ShiftDir";
      this.col_Home_ShiftDir.Resizable = DataGridViewTriState.True;
      this.col_Home_AutoMode.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_AutoMode, "col_Home_AutoMode");
      this.col_Home_AutoMode.IndeterminateValue = (object) "0";
      this.col_Home_AutoMode.Name = "col_Home_AutoMode";
      this.col_Home_AutoMode.TrueValue = (object) "1";
      this.col_Home_Mode.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_Mode.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_Mode, "col_Home_Mode");
      this.col_Home_Mode.Items.AddRange((object) "FM", (object) "AM");
      this.col_Home_Mode.Name = "col_Home_Mode";
      this.col_Home_Mode.Resizable = DataGridViewTriState.True;
      this.col_Home_Ams.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_Ams.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_Ams, "col_Home_Ams");
      this.col_Home_Ams.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Home_Ams.Name = "col_Home_Ams";
      this.col_Home_DigAnalog.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_DigAnalog.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_DigAnalog, "col_Home_DigAnalog");
      this.col_Home_DigAnalog.Items.AddRange((object) "ANALOG", (object) "DN", (object) "VW");
      this.col_Home_DigAnalog.Name = "col_Home_DigAnalog";
      componentResourceManager.ApplyResources((object) this.col_Home_MemName, "col_Home_MemName");
      this.col_Home_MemName.MaxInputLength = 6;
      this.col_Home_MemName.Name = "col_Home_MemName";
      this.col_Home_MemName.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Home_SqlType.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_SqlType.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_SqlType, "col_Home_SqlType");
      this.col_Home_SqlType.Items.AddRange((object) "OFF", (object) "TONE", (object) "TONE SQL", (object) "DCS", (object) "REV TONE", (object) "JR FREQ", (object) "PR FREQ", (object) "PAGER", (object) "D CD", (object) "TONE-DCS", (object) "D CD-TONE");
      this.col_Home_SqlType.Name = "col_Home_SqlType";
      this.col_Home_SqlType.Resizable = DataGridViewTriState.True;
      this.col_Home_ToneFrq.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_ToneFrq.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_ToneFrq, "col_Home_ToneFrq");
      this.col_Home_ToneFrq.Items.AddRange((object) "67.0 Hz", (object) "69.3 Hz", (object) "71.9 Hz", (object) "74.4 Hz", (object) "77.0 Hz", (object) "79.7 Hz", (object) "82.5 Hz", (object) "85.4 Hz", (object) "88.5 Hz", (object) "91.5 Hz", (object) "94.8 Hz", (object) "97.4 Hz", (object) "100.0 Hz", (object) "103.5 Hz", (object) "107.2 Hz", (object) "110.9 Hz", (object) "114.8 Hz", (object) "118.8 Hz", (object) "123.0 Hz", (object) "127.3 Hz", (object) "131.8 Hz", (object) "136.5 Hz", (object) "141.3 Hz", (object) "146.2 Hz", (object) "151.4 Hz", (object) "156.7 Hz", (object) "159.8 Hz", (object) "162.2 Hz", (object) "165.5 Hz", (object) "167.9 Hz", (object) "171.3 Hz", (object) "173.8 Hz", (object) "177.3 Hz", (object) "179.9 Hz", (object) "183.5 Hz", (object) "186.2 Hz", (object) "189.9 Hz", (object) "192.8 Hz", (object) "196.6 Hz", (object) "199.5 Hz", (object) "203.5 Hz", (object) "206.5 Hz", (object) "210.7 Hz", (object) "218.1 Hz", (object) "225.7 Hz", (object) "229.1 Hz", (object) "233.6 Hz", (object) "241.8 Hz", (object) "250.3 Hz", (object) "254.1 Hz");
      this.col_Home_ToneFrq.Name = "col_Home_ToneFrq";
      this.col_Home_ToneFrq.Resizable = DataGridViewTriState.True;
      this.col_Home_DcsCode.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_DcsCode.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_DcsCode, "col_Home_DcsCode");
      this.col_Home_DcsCode.Items.AddRange((object) "023", (object) "025", (object) "026", (object) "031", (object) "032", (object) "036", (object) "043", (object) "047", (object) "051", (object) "053", (object) "054", (object) "065", (object) "071", (object) "072", (object) "073", (object) "074", (object) "114", (object) "115", (object) "116", (object) "122", (object) "125", (object) "131", (object) "132", (object) "134", (object) "143", (object) "145", (object) "152", (object) "155", (object) "156", (object) "162", (object) "165", (object) "172", (object) "174", (object) "205", (object) "212", (object) "223", (object) "225", (object) "226", (object) "243", (object) "244", (object) "245", (object) "246", (object) "251", (object) "252", (object) "255", (object) "261", (object) "263", (object) "265", (object) "266", (object) "271", (object) "274", (object) "306", (object) "311", (object) "315", (object) "325", (object) "331", (object) "332", (object) "343", (object) "346", (object) "351", (object) "356", (object) "364", (object) "365", (object) "371", (object) "411", (object) "412", (object) "413", (object) "423", (object) "431", (object) "432", (object) "445", (object) "446", (object) "452", (object) "454", (object) "455", (object) "462", (object) "464", (object) "465", (object) "466", (object) "503", (object) "506", (object) "516", (object) "523", (object) "526", (object) "532", (object) "546", (object) "565", (object) "606", (object) "612", (object) "624", (object) "627", (object) "631", (object) "632", (object) "654", (object) "662", (object) "664", (object) "703", (object) "712", (object) "723", (object) "731", (object) "732", (object) "734", (object) "743", (object) "754");
      this.col_Home_DcsCode.Name = "col_Home_DcsCode";
      this.col_Home_DcsCode.Resizable = DataGridViewTriState.True;
      this.col_Home_DcsDim.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_DcsDim.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_DcsDim, "col_Home_DcsDim");
      this.col_Home_DcsDim.Items.AddRange((object) "RX同相 TX同相", (object) "RX反転 TX同相", (object) "RX両相 TX同相", (object) "RX同相 TX反転", (object) "RX反転 TX反転", (object) "RX両相 TX反転");
      this.col_Home_DcsDim.Name = "col_Home_DcsDim";
      this.col_Home_DcsDim.Resizable = DataGridViewTriState.True;
      this.col_Home_PrTone.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_PrTone.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_PrTone, "col_Home_PrTone");
      this.col_Home_PrTone.Items.AddRange((object) "300 Hz", (object) "400 Hz", (object) "500 Hz", (object) "600 Hz", (object) "700 Hz", (object) "800 Hz", (object) "900 Hz", (object) "1000 Hz", (object) "1100 Hz", (object) "1200 Hz", (object) "1300 Hz", (object) "1400 Hz", (object) "1500 Hz", (object) "1600 Hz", (object) "1700 Hz", (object) "1800 Hz", (object) "1900 Hz", (object) "2000 Hz", (object) "2100 Hz", (object) "2200 Hz", (object) "2300 Hz", (object) "2400 Hz", (object) "2500 Hz", (object) "2600 Hz", (object) "2700 Hz", (object) "2800 Hz", (object) "2900 Hz", (object) "3000 Hz");
      this.col_Home_PrTone.Name = "col_Home_PrTone";
      this.col_Home_PrTone.Resizable = DataGridViewTriState.True;
      this.col_Home_TxOutput.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_TxOutput.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_TxOutput, "col_Home_TxOutput");
      this.col_Home_TxOutput.Items.AddRange((object) "LOW", (object) "MID", (object) "HIGH");
      this.col_Home_TxOutput.Name = "col_Home_TxOutput";
      this.col_Home_TxOutput.Resizable = DataGridViewTriState.True;
      this.col_Home_Skip.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_Skip.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_Skip, "col_Home_Skip");
      this.col_Home_Skip.Items.AddRange((object) "OFF", (object) "SKIP", (object) "SELECT");
      this.col_Home_Skip.Name = "col_Home_Skip";
      this.col_Home_Skip.Resizable = DataGridViewTriState.True;
      this.col_Home_AutoStep.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_AutoStep, "col_Home_AutoStep");
      this.col_Home_AutoStep.IndeterminateValue = (object) "0";
      this.col_Home_AutoStep.Name = "col_Home_AutoStep";
      this.col_Home_AutoStep.TrueValue = (object) "1";
      this.col_Home_Step.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_Step.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_Step, "col_Home_Step");
      this.col_Home_Step.Items.AddRange((object) "5.0KHz", (object) "6.25KHz", (object) "8.33KHz", (object) "10.0KHz", (object) "12.5KHz", (object) "15.0KHz", (object) "20.0KHz", (object) "25.0KHz", (object) "50.0KHz", (object) "100.0KHz");
      this.col_Home_Step.Name = "col_Home_Step";
      this.col_Home_Step.Resizable = DataGridViewTriState.True;
      this.col_Home_Tag.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Tag, "col_Home_Tag");
      this.col_Home_Tag.IndeterminateValue = (object) "0";
      this.col_Home_Tag.Name = "col_Home_Tag";
      this.col_Home_Tag.TrueValue = (object) "1";
      this.col_Home_MemDel.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_MemDel, "col_Home_MemDel");
      this.col_Home_MemDel.IndeterminateValue = (object) "0";
      this.col_Home_MemDel.Name = "col_Home_MemDel";
      this.col_Home_MemDel.Resizable = DataGridViewTriState.True;
      this.col_Home_MemDel.TrueValue = (object) "1";
      this.col_Home_Att.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Att, "col_Home_Att");
      this.col_Home_Att.IndeterminateValue = (object) "0";
      this.col_Home_Att.Name = "col_Home_Att";
      this.col_Home_Att.Resizable = DataGridViewTriState.True;
      this.col_Home_Att.TrueValue = (object) "1";
      this.col_Home_Smeter.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_Smeter.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_Smeter, "col_Home_Smeter");
      this.col_Home_Smeter.Items.AddRange((object) "OFF", (object) "Level 1", (object) "Level 2", (object) "Level 3", (object) "Level 4", (object) "Level 5", (object) "Level 6", (object) "Level 7", (object) "Level 8", (object) "Level 9");
      this.col_Home_Smeter.Name = "col_Home_Smeter";
      this.col_Home_Smeter.Resizable = DataGridViewTriState.True;
      this.col_Home_Bell.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_Bell.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_Bell, "col_Home_Bell");
      this.col_Home_Bell.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Home_Bell.Name = "col_Home_Bell";
      this.col_Home_Bell.Resizable = DataGridViewTriState.True;
      this.col_Home_Vibrator.DisplayStyleForCurrentCellOnly = true;
      this.col_Home_Vibrator.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Home_Vibrator, "col_Home_Vibrator");
      this.col_Home_Vibrator.Items.AddRange((object) "OFF", (object) "BUSY", (object) "SIGNALING");
      this.col_Home_Vibrator.Name = "col_Home_Vibrator";
      this.col_Home_Vibrator.Resizable = DataGridViewTriState.True;
      this.col_Home_HarfDev.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_HarfDev, "col_Home_HarfDev");
      this.col_Home_HarfDev.IndeterminateValue = (object) "0";
      this.col_Home_HarfDev.Name = "col_Home_HarfDev";
      this.col_Home_HarfDev.Resizable = DataGridViewTriState.True;
      this.col_Home_HarfDev.TrueValue = (object) "1";
      this.col_Home_ClockShift.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_ClockShift, "col_Home_ClockShift");
      this.col_Home_ClockShift.IndeterminateValue = (object) "0";
      this.col_Home_ClockShift.Name = "col_Home_ClockShift";
      this.col_Home_ClockShift.Resizable = DataGridViewTriState.True;
      this.col_Home_ClockShift.TrueValue = (object) "1";
      this.col_Home_Bank1.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank1, "col_Home_Bank1");
      this.col_Home_Bank1.IndeterminateValue = (object) "0";
      this.col_Home_Bank1.Name = "col_Home_Bank1";
      this.col_Home_Bank1.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank1.TrueValue = (object) "1";
      this.col_Home_Bank2.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank2, "col_Home_Bank2");
      this.col_Home_Bank2.IndeterminateValue = (object) "0";
      this.col_Home_Bank2.Name = "col_Home_Bank2";
      this.col_Home_Bank2.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank2.TrueValue = (object) "1";
      this.col_Home_Bank3.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank3, "col_Home_Bank3");
      this.col_Home_Bank3.IndeterminateValue = (object) "0";
      this.col_Home_Bank3.Name = "col_Home_Bank3";
      this.col_Home_Bank3.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank3.TrueValue = (object) "1";
      this.col_Home_Bank4.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank4, "col_Home_Bank4");
      this.col_Home_Bank4.IndeterminateValue = (object) "0";
      this.col_Home_Bank4.Name = "col_Home_Bank4";
      this.col_Home_Bank4.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank4.TrueValue = (object) "1";
      this.col_Home_Bank5.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank5, "col_Home_Bank5");
      this.col_Home_Bank5.IndeterminateValue = (object) "0";
      this.col_Home_Bank5.Name = "col_Home_Bank5";
      this.col_Home_Bank5.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank5.TrueValue = (object) "1";
      this.col_Home_Bank6.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank6, "col_Home_Bank6");
      this.col_Home_Bank6.IndeterminateValue = (object) "0";
      this.col_Home_Bank6.Name = "col_Home_Bank6";
      this.col_Home_Bank6.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank6.TrueValue = (object) "1";
      this.col_Home_Bank7.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank7, "col_Home_Bank7");
      this.col_Home_Bank7.IndeterminateValue = (object) "0";
      this.col_Home_Bank7.Name = "col_Home_Bank7";
      this.col_Home_Bank7.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank7.TrueValue = (object) "1";
      this.col_Home_Bank8.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank8, "col_Home_Bank8");
      this.col_Home_Bank8.IndeterminateValue = (object) "0";
      this.col_Home_Bank8.Name = "col_Home_Bank8";
      this.col_Home_Bank8.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank8.TrueValue = (object) "1";
      this.col_Home_Bank9.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank9, "col_Home_Bank9");
      this.col_Home_Bank9.IndeterminateValue = (object) "0";
      this.col_Home_Bank9.Name = "col_Home_Bank9";
      this.col_Home_Bank9.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank9.TrueValue = (object) "1";
      this.col_Home_Bank10.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank10, "col_Home_Bank10");
      this.col_Home_Bank10.IndeterminateValue = (object) "0";
      this.col_Home_Bank10.Name = "col_Home_Bank10";
      this.col_Home_Bank10.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank10.TrueValue = (object) "1";
      this.col_Home_Bank11.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank11, "col_Home_Bank11");
      this.col_Home_Bank11.IndeterminateValue = (object) "0";
      this.col_Home_Bank11.Name = "col_Home_Bank11";
      this.col_Home_Bank11.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank11.TrueValue = (object) "1";
      this.col_Home_Bank12.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank12, "col_Home_Bank12");
      this.col_Home_Bank12.IndeterminateValue = (object) "0";
      this.col_Home_Bank12.Name = "col_Home_Bank12";
      this.col_Home_Bank12.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank12.TrueValue = (object) "1";
      this.col_Home_Bank13.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank13, "col_Home_Bank13");
      this.col_Home_Bank13.IndeterminateValue = (object) "0";
      this.col_Home_Bank13.Name = "col_Home_Bank13";
      this.col_Home_Bank13.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank13.TrueValue = (object) "1";
      this.col_Home_Bank14.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank14, "col_Home_Bank14");
      this.col_Home_Bank14.IndeterminateValue = (object) "0";
      this.col_Home_Bank14.Name = "col_Home_Bank14";
      this.col_Home_Bank14.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank14.TrueValue = (object) "1";
      this.col_Home_Bank15.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank15, "col_Home_Bank15");
      this.col_Home_Bank15.IndeterminateValue = (object) "0";
      this.col_Home_Bank15.Name = "col_Home_Bank15";
      this.col_Home_Bank15.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank15.TrueValue = (object) "1";
      this.col_Home_Bank16.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank16, "col_Home_Bank16");
      this.col_Home_Bank16.IndeterminateValue = (object) "0";
      this.col_Home_Bank16.Name = "col_Home_Bank16";
      this.col_Home_Bank16.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank16.TrueValue = (object) "1";
      this.col_Home_Bank17.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank17, "col_Home_Bank17");
      this.col_Home_Bank17.IndeterminateValue = (object) "0";
      this.col_Home_Bank17.Name = "col_Home_Bank17";
      this.col_Home_Bank17.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank17.TrueValue = (object) "1";
      this.col_Home_Bank18.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank18, "col_Home_Bank18");
      this.col_Home_Bank18.IndeterminateValue = (object) "0";
      this.col_Home_Bank18.Name = "col_Home_Bank18";
      this.col_Home_Bank18.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank18.TrueValue = (object) "1";
      this.col_Home_Bank19.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank19, "col_Home_Bank19");
      this.col_Home_Bank19.IndeterminateValue = (object) "0";
      this.col_Home_Bank19.Name = "col_Home_Bank19";
      this.col_Home_Bank19.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank19.TrueValue = (object) "1";
      this.col_Home_Bank20.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank20, "col_Home_Bank20");
      this.col_Home_Bank20.IndeterminateValue = (object) "0";
      this.col_Home_Bank20.Name = "col_Home_Bank20";
      this.col_Home_Bank20.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank20.TrueValue = (object) "1";
      this.col_Home_Bank21.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank21, "col_Home_Bank21");
      this.col_Home_Bank21.IndeterminateValue = (object) "0";
      this.col_Home_Bank21.Name = "col_Home_Bank21";
      this.col_Home_Bank21.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank21.TrueValue = (object) "1";
      this.col_Home_Bank22.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank22, "col_Home_Bank22");
      this.col_Home_Bank22.IndeterminateValue = (object) "0";
      this.col_Home_Bank22.Name = "col_Home_Bank22";
      this.col_Home_Bank22.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank22.TrueValue = (object) "1";
      this.col_Home_Bank23.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank23, "col_Home_Bank23");
      this.col_Home_Bank23.IndeterminateValue = (object) "0";
      this.col_Home_Bank23.Name = "col_Home_Bank23";
      this.col_Home_Bank23.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank23.TrueValue = (object) "1";
      this.col_Home_Bank24.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Home_Bank24, "col_Home_Bank24");
      this.col_Home_Bank24.IndeterminateValue = (object) "0";
      this.col_Home_Bank24.Name = "col_Home_Bank24";
      this.col_Home_Bank24.Resizable = DataGridViewTriState.True;
      this.col_Home_Bank24.TrueValue = (object) "1";
      componentResourceManager.ApplyResources((object) this.col_Home_Comment, "col_Home_Comment");
      this.col_Home_Comment.MaxInputLength = 256;
      this.col_Home_Comment.Name = "col_Home_Comment";
      this.col_Home_Comment.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.tab_Wx.BackColor = SystemColors.Control;
      this.tab_Wx.Controls.Add((Control) this.dgv_Wx);
      componentResourceManager.ApplyResources((object) this.tab_Wx, "tab_Wx");
      this.tab_Wx.Name = "tab_Wx";
      this.dgv_Wx.AllowUserToAddRows = false;
      this.dgv_Wx.AllowUserToDeleteRows = false;
      this.dgv_Wx.AllowUserToResizeRows = false;
      gridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle18.BackColor = SystemColors.Control;
      gridViewCellStyle18.Font = new Font("MS UI Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 128);
      gridViewCellStyle18.ForeColor = SystemColors.WindowText;
      gridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle18.WrapMode = DataGridViewTriState.True;
      this.dgv_Wx.ColumnHeadersDefaultCellStyle = gridViewCellStyle18;
      componentResourceManager.ApplyResources((object) this.dgv_Wx, "dgv_Wx");
      this.dgv_Wx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_Wx.Columns.AddRange((DataGridViewColumn) this.dataGridViewCheckBoxColumn407, (DataGridViewColumn) this.dataGridViewTextBoxColumn86, (DataGridViewColumn) this.dataGridViewTextBoxColumn87, (DataGridViewColumn) this.dataGridViewTextBoxColumn88, (DataGridViewColumn) this.dataGridViewComboBoxColumn183, (DataGridViewColumn) this.col_Wx_AutoMode, (DataGridViewColumn) this.dataGridViewComboBoxColumn184, (DataGridViewColumn) this.col_Wx_Ams, (DataGridViewColumn) this.col_Wx_DigAnalog, (DataGridViewColumn) this.dataGridViewTextBoxColumn89, (DataGridViewColumn) this.dataGridViewComboBoxColumn185, (DataGridViewColumn) this.dataGridViewComboBoxColumn186, (DataGridViewColumn) this.dataGridViewComboBoxColumn187, (DataGridViewColumn) this.dataGridViewComboBoxColumn188, (DataGridViewColumn) this.dataGridViewComboBoxColumn189, (DataGridViewColumn) this.dataGridViewComboBoxColumn190, (DataGridViewColumn) this.dataGridViewComboBoxColumn191, (DataGridViewColumn) this.col_Wx_AutoStep, (DataGridViewColumn) this.dataGridViewComboBoxColumn192, (DataGridViewColumn) this.col_Wx_Tag, (DataGridViewColumn) this.dataGridViewCheckBoxColumn408, (DataGridViewColumn) this.dataGridViewCheckBoxColumn409, (DataGridViewColumn) this.dataGridViewComboBoxColumn193, (DataGridViewColumn) this.dataGridViewComboBoxColumn194, (DataGridViewColumn) this.dataGridViewComboBoxColumn195, (DataGridViewColumn) this.dataGridViewCheckBoxColumn410, (DataGridViewColumn) this.dataGridViewCheckBoxColumn411, (DataGridViewColumn) this.dataGridViewCheckBoxColumn412, (DataGridViewColumn) this.dataGridViewCheckBoxColumn413, (DataGridViewColumn) this.dataGridViewCheckBoxColumn414, (DataGridViewColumn) this.dataGridViewCheckBoxColumn415, (DataGridViewColumn) this.dataGridViewCheckBoxColumn416, (DataGridViewColumn) this.dataGridViewCheckBoxColumn417, (DataGridViewColumn) this.dataGridViewCheckBoxColumn418, (DataGridViewColumn) this.dataGridViewCheckBoxColumn419, (DataGridViewColumn) this.dataGridViewCheckBoxColumn420, (DataGridViewColumn) this.dataGridViewCheckBoxColumn421, (DataGridViewColumn) this.dataGridViewCheckBoxColumn422, (DataGridViewColumn) this.dataGridViewCheckBoxColumn423, (DataGridViewColumn) this.dataGridViewCheckBoxColumn424, (DataGridViewColumn) this.dataGridViewCheckBoxColumn425, (DataGridViewColumn) this.dataGridViewCheckBoxColumn426, (DataGridViewColumn) this.dataGridViewCheckBoxColumn427, (DataGridViewColumn) this.dataGridViewCheckBoxColumn428, (DataGridViewColumn) this.dataGridViewCheckBoxColumn429, (DataGridViewColumn) this.dataGridViewCheckBoxColumn430, (DataGridViewColumn) this.dataGridViewCheckBoxColumn431, (DataGridViewColumn) this.dataGridViewCheckBoxColumn432, (DataGridViewColumn) this.dataGridViewCheckBoxColumn433, (DataGridViewColumn) this.dataGridViewCheckBoxColumn434, (DataGridViewColumn) this.dataGridViewCheckBoxColumn435, (DataGridViewColumn) this.dataGridViewTextBoxColumn90);
      this.dgv_Wx.EnableHeadersVisualStyles = false;
      this.dgv_Wx.Name = "dgv_Wx";
      this.dgv_Wx.RowTemplate.Height = 21;
      this.dgv_Wx.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
      this.dgv_Wx.CellContentClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Wx.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dgv_CellContentClick);
      this.dgv_Wx.CellEndEdit += new DataGridViewCellEventHandler(this.dgv_CellEndEdit);
      this.dgv_Wx.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn407, "dataGridViewCheckBoxColumn407");
      this.dataGridViewCheckBoxColumn407.Name = "dataGridViewCheckBoxColumn407";
      this.dataGridViewCheckBoxColumn407.Resizable = DataGridViewTriState.True;
      gridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn86.DefaultCellStyle = gridViewCellStyle19;
      componentResourceManager.ApplyResources((object) this.dataGridViewTextBoxColumn86, "dataGridViewTextBoxColumn86");
      this.dataGridViewTextBoxColumn86.Name = "dataGridViewTextBoxColumn86";
      this.dataGridViewTextBoxColumn86.ReadOnly = true;
      this.dataGridViewTextBoxColumn86.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn87.DefaultCellStyle = gridViewCellStyle20;
      componentResourceManager.ApplyResources((object) this.dataGridViewTextBoxColumn87, "dataGridViewTextBoxColumn87");
      this.dataGridViewTextBoxColumn87.Name = "dataGridViewTextBoxColumn87";
      this.dataGridViewTextBoxColumn87.ReadOnly = true;
      this.dataGridViewTextBoxColumn87.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dataGridViewTextBoxColumn88.DefaultCellStyle = gridViewCellStyle21;
      componentResourceManager.ApplyResources((object) this.dataGridViewTextBoxColumn88, "dataGridViewTextBoxColumn88");
      this.dataGridViewTextBoxColumn88.Name = "dataGridViewTextBoxColumn88";
      this.dataGridViewTextBoxColumn88.Resizable = DataGridViewTriState.True;
      this.dataGridViewTextBoxColumn88.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.dataGridViewComboBoxColumn183.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn183.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn183, "dataGridViewComboBoxColumn183");
      this.dataGridViewComboBoxColumn183.Items.AddRange((object) "OFF", (object) "-RPT", (object) "+RPT", (object) "-/+");
      this.dataGridViewComboBoxColumn183.Name = "dataGridViewComboBoxColumn183";
      this.dataGridViewComboBoxColumn183.Resizable = DataGridViewTriState.True;
      this.col_Wx_AutoMode.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Wx_AutoMode, "col_Wx_AutoMode");
      this.col_Wx_AutoMode.IndeterminateValue = (object) "0";
      this.col_Wx_AutoMode.Name = "col_Wx_AutoMode";
      this.col_Wx_AutoMode.TrueValue = (object) "1";
      this.dataGridViewComboBoxColumn184.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn184.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn184, "dataGridViewComboBoxColumn184");
      this.dataGridViewComboBoxColumn184.Items.AddRange((object) "FM", (object) "AM");
      this.dataGridViewComboBoxColumn184.Name = "dataGridViewComboBoxColumn184";
      this.dataGridViewComboBoxColumn184.Resizable = DataGridViewTriState.True;
      this.col_Wx_Ams.DisplayStyleForCurrentCellOnly = true;
      this.col_Wx_Ams.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Wx_Ams, "col_Wx_Ams");
      this.col_Wx_Ams.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Wx_Ams.Name = "col_Wx_Ams";
      this.col_Wx_DigAnalog.DisplayStyleForCurrentCellOnly = true;
      this.col_Wx_DigAnalog.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Wx_DigAnalog, "col_Wx_DigAnalog");
      this.col_Wx_DigAnalog.Items.AddRange((object) "ANALOG", (object) "DN", (object) "VW");
      this.col_Wx_DigAnalog.Name = "col_Wx_DigAnalog";
      componentResourceManager.ApplyResources((object) this.dataGridViewTextBoxColumn89, "dataGridViewTextBoxColumn89");
      this.dataGridViewTextBoxColumn89.MaxInputLength = 6;
      this.dataGridViewTextBoxColumn89.Name = "dataGridViewTextBoxColumn89";
      this.dataGridViewTextBoxColumn89.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.dataGridViewComboBoxColumn185.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn185.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn185, "dataGridViewComboBoxColumn185");
      this.dataGridViewComboBoxColumn185.Items.AddRange((object) "OFF", (object) "TONE", (object) "TONE SQL", (object) "DCS", (object) "REV TONE", (object) "JR FREQ", (object) "PR FREQ", (object) "PAGER", (object) "D CD", (object) "TONE-DCS", (object) "D CD-TONE");
      this.dataGridViewComboBoxColumn185.Name = "dataGridViewComboBoxColumn185";
      this.dataGridViewComboBoxColumn185.Resizable = DataGridViewTriState.True;
      this.dataGridViewComboBoxColumn186.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn186.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn186, "dataGridViewComboBoxColumn186");
      this.dataGridViewComboBoxColumn186.Items.AddRange((object) "67.0 Hz", (object) "69.3 Hz", (object) "71.9 Hz", (object) "74.4 Hz", (object) "77.0 Hz", (object) "79.7 Hz", (object) "82.5 Hz", (object) "85.4 Hz", (object) "88.5 Hz", (object) "91.5 Hz", (object) "94.8 Hz", (object) "97.4 Hz", (object) "100.0 Hz", (object) "103.5 Hz", (object) "107.2 Hz", (object) "110.9 Hz", (object) "114.8 Hz", (object) "118.8 Hz", (object) "123.0 Hz", (object) "127.3 Hz", (object) "131.8 Hz", (object) "136.5 Hz", (object) "141.3 Hz", (object) "146.2 Hz", (object) "151.4 Hz", (object) "156.7 Hz", (object) "159.8 Hz", (object) "162.2 Hz", (object) "165.5 Hz", (object) "167.9 Hz", (object) "171.3 Hz", (object) "173.8 Hz", (object) "177.3 Hz", (object) "179.9 Hz", (object) "183.5 Hz", (object) "186.2 Hz", (object) "189.9 Hz", (object) "192.8 Hz", (object) "196.6 Hz", (object) "199.5 Hz", (object) "203.5 Hz", (object) "206.5 Hz", (object) "210.7 Hz", (object) "218.1 Hz", (object) "225.7 Hz", (object) "229.1 Hz", (object) "233.6 Hz", (object) "241.8 Hz", (object) "250.3 Hz", (object) "254.1 Hz");
      this.dataGridViewComboBoxColumn186.Name = "dataGridViewComboBoxColumn186";
      this.dataGridViewComboBoxColumn186.Resizable = DataGridViewTriState.True;
      this.dataGridViewComboBoxColumn187.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn187.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn187, "dataGridViewComboBoxColumn187");
      this.dataGridViewComboBoxColumn187.Items.AddRange((object) "023", (object) "025", (object) "026", (object) "031", (object) "032", (object) "036", (object) "043", (object) "047", (object) "051", (object) "053", (object) "054", (object) "065", (object) "071", (object) "072", (object) "073", (object) "074", (object) "114", (object) "115", (object) "116", (object) "122", (object) "125", (object) "131", (object) "132", (object) "134", (object) "143", (object) "145", (object) "152", (object) "155", (object) "156", (object) "162", (object) "165", (object) "172", (object) "174", (object) "205", (object) "212", (object) "223", (object) "225", (object) "226", (object) "243", (object) "244", (object) "245", (object) "246", (object) "251", (object) "252", (object) "255", (object) "261", (object) "263", (object) "265", (object) "266", (object) "271", (object) "274", (object) "306", (object) "311", (object) "315", (object) "325", (object) "331", (object) "332", (object) "343", (object) "346", (object) "351", (object) "356", (object) "364", (object) "365", (object) "371", (object) "411", (object) "412", (object) "413", (object) "423", (object) "431", (object) "432", (object) "445", (object) "446", (object) "452", (object) "454", (object) "455", (object) "462", (object) "464", (object) "465", (object) "466", (object) "503", (object) "506", (object) "516", (object) "523", (object) "526", (object) "532", (object) "546", (object) "565", (object) "606", (object) "612", (object) "624", (object) "627", (object) "631", (object) "632", (object) "654", (object) "662", (object) "664", (object) "703", (object) "712", (object) "723", (object) "731", (object) "732", (object) "734", (object) "743", (object) "754");
      this.dataGridViewComboBoxColumn187.Name = "dataGridViewComboBoxColumn187";
      this.dataGridViewComboBoxColumn187.Resizable = DataGridViewTriState.True;
      this.dataGridViewComboBoxColumn188.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn188.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn188, "dataGridViewComboBoxColumn188");
      this.dataGridViewComboBoxColumn188.Items.AddRange((object) "RX Normal TX Normal", (object) "RX Invert TX Normal", (object) "RX Both   TX Normal", (object) "RX Normal TX Invert", (object) "RX Invert TX Invert", (object) "RX Both   TX Invert");
      this.dataGridViewComboBoxColumn188.Name = "dataGridViewComboBoxColumn188";
      this.dataGridViewComboBoxColumn188.Resizable = DataGridViewTriState.True;
      this.dataGridViewComboBoxColumn189.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn189.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn189, "dataGridViewComboBoxColumn189");
      this.dataGridViewComboBoxColumn189.Items.AddRange((object) "300 Hz", (object) "400 Hz", (object) "500 Hz", (object) "600 Hz", (object) "700 Hz", (object) "800 Hz", (object) "900 Hz", (object) "1000 Hz", (object) "1100 Hz", (object) "1200 Hz", (object) "1300 Hz", (object) "1400 Hz", (object) "1500 Hz", (object) "1600 Hz", (object) "1700 Hz", (object) "1800 Hz", (object) "1900 Hz", (object) "2000 Hz", (object) "2100 Hz", (object) "2200 Hz", (object) "2300 Hz", (object) "2400 Hz", (object) "2500 Hz", (object) "2600 Hz", (object) "2700 Hz", (object) "2800 Hz", (object) "2900 Hz", (object) "3000 Hz");
      this.dataGridViewComboBoxColumn189.Name = "dataGridViewComboBoxColumn189";
      this.dataGridViewComboBoxColumn189.Resizable = DataGridViewTriState.True;
      this.dataGridViewComboBoxColumn190.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn190.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn190, "dataGridViewComboBoxColumn190");
      this.dataGridViewComboBoxColumn190.Items.AddRange((object) "LOW", (object) "MID", (object) "HIGH");
      this.dataGridViewComboBoxColumn190.Name = "dataGridViewComboBoxColumn190";
      this.dataGridViewComboBoxColumn190.Resizable = DataGridViewTriState.True;
      this.dataGridViewComboBoxColumn191.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn191.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn191, "dataGridViewComboBoxColumn191");
      this.dataGridViewComboBoxColumn191.Items.AddRange((object) "OFF", (object) "SKIP", (object) "SELECT");
      this.dataGridViewComboBoxColumn191.Name = "dataGridViewComboBoxColumn191";
      this.dataGridViewComboBoxColumn191.Resizable = DataGridViewTriState.True;
      this.col_Wx_AutoStep.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Wx_AutoStep, "col_Wx_AutoStep");
      this.col_Wx_AutoStep.IndeterminateValue = (object) "0";
      this.col_Wx_AutoStep.Name = "col_Wx_AutoStep";
      this.col_Wx_AutoStep.TrueValue = (object) "1";
      this.dataGridViewComboBoxColumn192.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn192.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn192, "dataGridViewComboBoxColumn192");
      this.dataGridViewComboBoxColumn192.Items.AddRange((object) "5.0KHz", (object) "6.25KHz", (object) "8.33KHz", (object) "10.0KHz", (object) "12.5KHz", (object) "15.0KHz", (object) "20.0KHz", (object) "25.0KHz", (object) "50.0KHz", (object) "100.0KHz");
      this.dataGridViewComboBoxColumn192.Name = "dataGridViewComboBoxColumn192";
      this.dataGridViewComboBoxColumn192.Resizable = DataGridViewTriState.True;
      this.col_Wx_Tag.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Wx_Tag, "col_Wx_Tag");
      this.col_Wx_Tag.IndeterminateValue = (object) "0";
      this.col_Wx_Tag.Name = "col_Wx_Tag";
      this.col_Wx_Tag.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn408.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn408, "dataGridViewCheckBoxColumn408");
      this.dataGridViewCheckBoxColumn408.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn408.Name = "dataGridViewCheckBoxColumn408";
      this.dataGridViewCheckBoxColumn408.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn408.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn409.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn409, "dataGridViewCheckBoxColumn409");
      this.dataGridViewCheckBoxColumn409.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn409.Name = "dataGridViewCheckBoxColumn409";
      this.dataGridViewCheckBoxColumn409.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn409.TrueValue = (object) "1";
      this.dataGridViewComboBoxColumn193.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn193.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn193, "dataGridViewComboBoxColumn193");
      this.dataGridViewComboBoxColumn193.Items.AddRange((object) "OFF", (object) "Level 1", (object) "Level 2", (object) "Level 3", (object) "Level 4", (object) "Level 5", (object) "Level 6", (object) "Level 7", (object) "Level 8", (object) "Level 9");
      this.dataGridViewComboBoxColumn193.Name = "dataGridViewComboBoxColumn193";
      this.dataGridViewComboBoxColumn193.Resizable = DataGridViewTriState.True;
      this.dataGridViewComboBoxColumn194.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn194.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn194, "dataGridViewComboBoxColumn194");
      this.dataGridViewComboBoxColumn194.Items.AddRange((object) "OFF", (object) "ON");
      this.dataGridViewComboBoxColumn194.Name = "dataGridViewComboBoxColumn194";
      this.dataGridViewComboBoxColumn194.Resizable = DataGridViewTriState.True;
      this.dataGridViewComboBoxColumn195.DisplayStyleForCurrentCellOnly = true;
      this.dataGridViewComboBoxColumn195.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.dataGridViewComboBoxColumn195, "dataGridViewComboBoxColumn195");
      this.dataGridViewComboBoxColumn195.Items.AddRange((object) "OFF", (object) "BUSY", (object) "SIGNALING");
      this.dataGridViewComboBoxColumn195.Name = "dataGridViewComboBoxColumn195";
      this.dataGridViewCheckBoxColumn410.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn410, "dataGridViewCheckBoxColumn410");
      this.dataGridViewCheckBoxColumn410.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn410.Name = "dataGridViewCheckBoxColumn410";
      this.dataGridViewCheckBoxColumn410.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn410.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn411.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn411, "dataGridViewCheckBoxColumn411");
      this.dataGridViewCheckBoxColumn411.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn411.Name = "dataGridViewCheckBoxColumn411";
      this.dataGridViewCheckBoxColumn411.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn411.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn412.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn412, "dataGridViewCheckBoxColumn412");
      this.dataGridViewCheckBoxColumn412.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn412.Name = "dataGridViewCheckBoxColumn412";
      this.dataGridViewCheckBoxColumn412.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn412.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn413.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn413, "dataGridViewCheckBoxColumn413");
      this.dataGridViewCheckBoxColumn413.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn413.Name = "dataGridViewCheckBoxColumn413";
      this.dataGridViewCheckBoxColumn413.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn413.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn414.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn414, "dataGridViewCheckBoxColumn414");
      this.dataGridViewCheckBoxColumn414.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn414.Name = "dataGridViewCheckBoxColumn414";
      this.dataGridViewCheckBoxColumn414.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn414.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn415.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn415, "dataGridViewCheckBoxColumn415");
      this.dataGridViewCheckBoxColumn415.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn415.Name = "dataGridViewCheckBoxColumn415";
      this.dataGridViewCheckBoxColumn415.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn415.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn416.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn416, "dataGridViewCheckBoxColumn416");
      this.dataGridViewCheckBoxColumn416.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn416.Name = "dataGridViewCheckBoxColumn416";
      this.dataGridViewCheckBoxColumn416.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn416.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn417.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn417, "dataGridViewCheckBoxColumn417");
      this.dataGridViewCheckBoxColumn417.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn417.Name = "dataGridViewCheckBoxColumn417";
      this.dataGridViewCheckBoxColumn417.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn417.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn418.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn418, "dataGridViewCheckBoxColumn418");
      this.dataGridViewCheckBoxColumn418.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn418.Name = "dataGridViewCheckBoxColumn418";
      this.dataGridViewCheckBoxColumn418.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn418.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn419.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn419, "dataGridViewCheckBoxColumn419");
      this.dataGridViewCheckBoxColumn419.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn419.Name = "dataGridViewCheckBoxColumn419";
      this.dataGridViewCheckBoxColumn419.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn419.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn420.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn420, "dataGridViewCheckBoxColumn420");
      this.dataGridViewCheckBoxColumn420.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn420.Name = "dataGridViewCheckBoxColumn420";
      this.dataGridViewCheckBoxColumn420.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn420.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn421.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn421, "dataGridViewCheckBoxColumn421");
      this.dataGridViewCheckBoxColumn421.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn421.Name = "dataGridViewCheckBoxColumn421";
      this.dataGridViewCheckBoxColumn421.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn421.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn422.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn422, "dataGridViewCheckBoxColumn422");
      this.dataGridViewCheckBoxColumn422.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn422.Name = "dataGridViewCheckBoxColumn422";
      this.dataGridViewCheckBoxColumn422.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn422.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn423.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn423, "dataGridViewCheckBoxColumn423");
      this.dataGridViewCheckBoxColumn423.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn423.Name = "dataGridViewCheckBoxColumn423";
      this.dataGridViewCheckBoxColumn423.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn423.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn424.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn424, "dataGridViewCheckBoxColumn424");
      this.dataGridViewCheckBoxColumn424.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn424.Name = "dataGridViewCheckBoxColumn424";
      this.dataGridViewCheckBoxColumn424.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn424.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn425.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn425, "dataGridViewCheckBoxColumn425");
      this.dataGridViewCheckBoxColumn425.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn425.Name = "dataGridViewCheckBoxColumn425";
      this.dataGridViewCheckBoxColumn425.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn425.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn426.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn426, "dataGridViewCheckBoxColumn426");
      this.dataGridViewCheckBoxColumn426.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn426.Name = "dataGridViewCheckBoxColumn426";
      this.dataGridViewCheckBoxColumn426.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn426.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn427.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn427, "dataGridViewCheckBoxColumn427");
      this.dataGridViewCheckBoxColumn427.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn427.Name = "dataGridViewCheckBoxColumn427";
      this.dataGridViewCheckBoxColumn427.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn427.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn428.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn428, "dataGridViewCheckBoxColumn428");
      this.dataGridViewCheckBoxColumn428.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn428.Name = "dataGridViewCheckBoxColumn428";
      this.dataGridViewCheckBoxColumn428.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn428.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn429.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn429, "dataGridViewCheckBoxColumn429");
      this.dataGridViewCheckBoxColumn429.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn429.Name = "dataGridViewCheckBoxColumn429";
      this.dataGridViewCheckBoxColumn429.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn429.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn430.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn430, "dataGridViewCheckBoxColumn430");
      this.dataGridViewCheckBoxColumn430.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn430.Name = "dataGridViewCheckBoxColumn430";
      this.dataGridViewCheckBoxColumn430.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn430.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn431.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn431, "dataGridViewCheckBoxColumn431");
      this.dataGridViewCheckBoxColumn431.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn431.Name = "dataGridViewCheckBoxColumn431";
      this.dataGridViewCheckBoxColumn431.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn431.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn432.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn432, "dataGridViewCheckBoxColumn432");
      this.dataGridViewCheckBoxColumn432.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn432.Name = "dataGridViewCheckBoxColumn432";
      this.dataGridViewCheckBoxColumn432.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn432.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn433.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn433, "dataGridViewCheckBoxColumn433");
      this.dataGridViewCheckBoxColumn433.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn433.Name = "dataGridViewCheckBoxColumn433";
      this.dataGridViewCheckBoxColumn433.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn433.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn434.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn434, "dataGridViewCheckBoxColumn434");
      this.dataGridViewCheckBoxColumn434.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn434.Name = "dataGridViewCheckBoxColumn434";
      this.dataGridViewCheckBoxColumn434.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn434.TrueValue = (object) "1";
      this.dataGridViewCheckBoxColumn435.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.dataGridViewCheckBoxColumn435, "dataGridViewCheckBoxColumn435");
      this.dataGridViewCheckBoxColumn435.IndeterminateValue = (object) "0";
      this.dataGridViewCheckBoxColumn435.Name = "dataGridViewCheckBoxColumn435";
      this.dataGridViewCheckBoxColumn435.Resizable = DataGridViewTriState.True;
      this.dataGridViewCheckBoxColumn435.TrueValue = (object) "1";
      componentResourceManager.ApplyResources((object) this.dataGridViewTextBoxColumn90, "dataGridViewTextBoxColumn90");
      this.dataGridViewTextBoxColumn90.MaxInputLength = 256;
      this.dataGridViewTextBoxColumn90.Name = "dataGridViewTextBoxColumn90";
      this.dataGridViewTextBoxColumn90.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Normal_Ch.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Ch, "col_Normal_Ch");
      this.col_Normal_Ch.IndeterminateValue = (object) "0";
      this.col_Normal_Ch.Name = "col_Normal_Ch";
      this.col_Normal_Ch.Resizable = DataGridViewTriState.True;
      this.col_Normal_Ch.TrueValue = (object) "1";
      gridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle22.Format = "N4";
      gridViewCellStyle22.NullValue = (object) null;
      this.col_Normal_RxFrq.DefaultCellStyle = gridViewCellStyle22;
      componentResourceManager.ApplyResources((object) this.col_Normal_RxFrq, "col_Normal_RxFrq");
      this.col_Normal_RxFrq.Name = "col_Normal_RxFrq";
      this.col_Normal_RxFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Normal_TxFrq.DefaultCellStyle = gridViewCellStyle23;
      componentResourceManager.ApplyResources((object) this.col_Normal_TxFrq, "col_Normal_TxFrq");
      this.col_Normal_TxFrq.Name = "col_Normal_TxFrq";
      this.col_Normal_TxFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      gridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.col_Normal_ShiftFrq.DefaultCellStyle = gridViewCellStyle24;
      componentResourceManager.ApplyResources((object) this.col_Normal_ShiftFrq, "col_Normal_ShiftFrq");
      this.col_Normal_ShiftFrq.Name = "col_Normal_ShiftFrq";
      this.col_Normal_ShiftFrq.Resizable = DataGridViewTriState.True;
      this.col_Normal_ShiftFrq.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Normal_ShiftDir.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_ShiftDir.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_ShiftDir, "col_Normal_ShiftDir");
      this.col_Normal_ShiftDir.Items.AddRange((object) "OFF", (object) "-RPT", (object) "+RPT", (object) "-/+");
      this.col_Normal_ShiftDir.Name = "col_Normal_ShiftDir";
      this.col_Normal_ShiftDir.Resizable = DataGridViewTriState.True;
      this.col_Normal_AutoMode.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_AutoMode, "col_Normal_AutoMode");
      this.col_Normal_AutoMode.IndeterminateValue = (object) "0";
      this.col_Normal_AutoMode.Name = "col_Normal_AutoMode";
      this.col_Normal_AutoMode.TrueValue = (object) "1";
      this.col_Normal_Mode.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_Mode.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_Mode, "col_Normal_Mode");
      this.col_Normal_Mode.Items.AddRange((object) "FM", (object) "AM");
      this.col_Normal_Mode.Name = "col_Normal_Mode";
      this.col_Normal_Mode.Resizable = DataGridViewTriState.True;
      this.col_Normal_Ams.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_Ams.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_Ams, "col_Normal_Ams");
      this.col_Normal_Ams.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Normal_Ams.Name = "col_Normal_Ams";
      this.col_Normal_DigAnalog.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_DigAnalog.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_DigAnalog, "col_Normal_DigAnalog");
      this.col_Normal_DigAnalog.Items.AddRange((object) "ANALOG", (object) "DN", (object) "VW");
      this.col_Normal_DigAnalog.Name = "col_Normal_DigAnalog";
      componentResourceManager.ApplyResources((object) this.col_Normal_MemName, "col_Normal_MemName");
      this.col_Normal_MemName.MaxInputLength = 6;
      this.col_Normal_MemName.Name = "col_Normal_MemName";
      this.col_Normal_MemName.SortMode = DataGridViewColumnSortMode.NotSortable;
      this.col_Normal_SqlType.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_SqlType.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_SqlType, "col_Normal_SqlType");
      this.col_Normal_SqlType.Items.AddRange((object) "OFF", (object) "TONE", (object) "TONE SQL", (object) "DCS", (object) "REV TONE", (object) "JR FREQ", (object) "PR FREQ", (object) "PAGER", (object) "D CD", (object) "TONE-DCS", (object) "D CD-TONE");
      this.col_Normal_SqlType.Name = "col_Normal_SqlType";
      this.col_Normal_SqlType.Resizable = DataGridViewTriState.True;
      this.col_Normal_ToneFrq.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_ToneFrq.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_ToneFrq, "col_Normal_ToneFrq");
      this.col_Normal_ToneFrq.Items.AddRange((object) "67.0 Hz", (object) "69.3 Hz", (object) "71.9 Hz", (object) "74.4 Hz", (object) "77.0 Hz", (object) "79.7 Hz", (object) "82.5 Hz", (object) "85.4 Hz", (object) "88.5 Hz", (object) "91.5 Hz", (object) "94.8 Hz", (object) "97.4 Hz", (object) "100.0 Hz", (object) "103.5 Hz", (object) "107.2 Hz", (object) "110.9 Hz", (object) "114.8 Hz", (object) "118.8 Hz", (object) "123.0 Hz", (object) "127.3 Hz", (object) "131.8 Hz", (object) "136.5 Hz", (object) "141.3 Hz", (object) "146.2 Hz", (object) "151.4 Hz", (object) "156.7 Hz", (object) "159.8 Hz", (object) "162.2 Hz", (object) "165.5 Hz", (object) "167.9 Hz", (object) "171.3 Hz", (object) "173.8 Hz", (object) "177.3 Hz", (object) "179.9 Hz", (object) "183.5 Hz", (object) "186.2 Hz", (object) "189.9 Hz", (object) "192.8 Hz", (object) "196.6 Hz", (object) "199.5 Hz", (object) "203.5 Hz", (object) "206.5 Hz", (object) "210.7 Hz", (object) "218.1 Hz", (object) "225.7 Hz", (object) "229.1 Hz", (object) "233.6 Hz", (object) "241.8 Hz", (object) "250.3 Hz", (object) "254.1 Hz");
      this.col_Normal_ToneFrq.Name = "col_Normal_ToneFrq";
      this.col_Normal_ToneFrq.Resizable = DataGridViewTriState.True;
      this.col_Normal_DscCode.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_DscCode.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_DscCode, "col_Normal_DscCode");
      this.col_Normal_DscCode.Items.AddRange((object) "023", (object) "025", (object) "026", (object) "031", (object) "032", (object) "036", (object) "043", (object) "047", (object) "051", (object) "053", (object) "054", (object) "065", (object) "071", (object) "072", (object) "073", (object) "074", (object) "114", (object) "115", (object) "116", (object) "122", (object) "125", (object) "131", (object) "132", (object) "134", (object) "143", (object) "145", (object) "152", (object) "155", (object) "156", (object) "162", (object) "165", (object) "172", (object) "174", (object) "205", (object) "212", (object) "223", (object) "225", (object) "226", (object) "243", (object) "244", (object) "245", (object) "246", (object) "251", (object) "252", (object) "255", (object) "261", (object) "263", (object) "265", (object) "266", (object) "271", (object) "274", (object) "306", (object) "311", (object) "315", (object) "325", (object) "331", (object) "332", (object) "343", (object) "346", (object) "351", (object) "356", (object) "364", (object) "365", (object) "371", (object) "411", (object) "412", (object) "413", (object) "423", (object) "431", (object) "432", (object) "445", (object) "446", (object) "452", (object) "454", (object) "455", (object) "462", (object) "464", (object) "465", (object) "466", (object) "503", (object) "506", (object) "516", (object) "523", (object) "526", (object) "532", (object) "546", (object) "565", (object) "606", (object) "612", (object) "624", (object) "627", (object) "631", (object) "632", (object) "654", (object) "662", (object) "664", (object) "703", (object) "712", (object) "723", (object) "731", (object) "732", (object) "734", (object) "743", (object) "754");
      this.col_Normal_DscCode.Name = "col_Normal_DscCode";
      this.col_Normal_DscCode.Resizable = DataGridViewTriState.True;
      this.col_Normal_DscDim.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_DscDim.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_DscDim, "col_Normal_DscDim");
      this.col_Normal_DscDim.Items.AddRange((object) "RX同相 TX同相", (object) "RX反転 TX同相", (object) "RX両相 TX同相", (object) "RX同相 TX反転", (object) "RX反転 TX反転", (object) "RX両相 TX反転");
      this.col_Normal_DscDim.Name = "col_Normal_DscDim";
      this.col_Normal_DscDim.Resizable = DataGridViewTriState.True;
      this.col_Normal_PrTone.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_PrTone.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_PrTone, "col_Normal_PrTone");
      this.col_Normal_PrTone.Items.AddRange((object) "300 Hz", (object) "400 Hz", (object) "500 Hz", (object) "600 Hz", (object) "700 Hz", (object) "800 Hz", (object) "900 Hz", (object) "1000 Hz", (object) "1100 Hz", (object) "1200 Hz", (object) "1300 Hz", (object) "1400 Hz", (object) "1500 Hz", (object) "1600 Hz", (object) "1700 Hz", (object) "1800 Hz", (object) "1900 Hz", (object) "2000 Hz", (object) "2100 Hz", (object) "2200 Hz", (object) "2300 Hz", (object) "2400 Hz", (object) "2500 Hz", (object) "2600 Hz", (object) "2700 Hz", (object) "2800 Hz", (object) "2900 Hz", (object) "3000 Hz");
      this.col_Normal_PrTone.Name = "col_Normal_PrTone";
      this.col_Normal_PrTone.Resizable = DataGridViewTriState.True;
      this.col_Normal_TxOtput.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_TxOtput.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_TxOtput, "col_Normal_TxOtput");
      this.col_Normal_TxOtput.Items.AddRange((object) "LOW", (object) "MID", (object) "HIGH");
      this.col_Normal_TxOtput.Name = "col_Normal_TxOtput";
      this.col_Normal_TxOtput.Resizable = DataGridViewTriState.True;
      this.col_Normal_Skip.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_Skip.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_Skip, "col_Normal_Skip");
      this.col_Normal_Skip.Items.AddRange((object) "OFF", (object) "SKIP", (object) "SELECT");
      this.col_Normal_Skip.Name = "col_Normal_Skip";
      this.col_Normal_Skip.Resizable = DataGridViewTriState.True;
      this.col_Normal_AutoStep.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_AutoStep, "col_Normal_AutoStep");
      this.col_Normal_AutoStep.IndeterminateValue = (object) "0";
      this.col_Normal_AutoStep.Name = "col_Normal_AutoStep";
      this.col_Normal_AutoStep.TrueValue = (object) "1";
      this.col_Normal_Step.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_Step.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_Step, "col_Normal_Step");
      this.col_Normal_Step.Items.AddRange((object) "5.0KHz", (object) "6.25KHz", (object) "8.33KHz", (object) "10.0KHz", (object) "12.5KHz", (object) "15.0KHz", (object) "20.0KHz", (object) "25.0KHz", (object) "50.0KHz", (object) "100.0KHz");
      this.col_Normal_Step.Name = "col_Normal_Step";
      this.col_Normal_Step.Resizable = DataGridViewTriState.True;
      this.col_Normal_Tag.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Tag, "col_Normal_Tag");
      this.col_Normal_Tag.IndeterminateValue = (object) "0";
      this.col_Normal_Tag.Name = "col_Normal_Tag";
      this.col_Normal_Tag.TrueValue = (object) "1";
      this.col_Normal_MemDel.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_MemDel, "col_Normal_MemDel");
      this.col_Normal_MemDel.IndeterminateValue = (object) "0";
      this.col_Normal_MemDel.Name = "col_Normal_MemDel";
      this.col_Normal_MemDel.Resizable = DataGridViewTriState.True;
      this.col_Normal_MemDel.TrueValue = (object) "1";
      this.col_Normal_Att.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Att, "col_Normal_Att");
      this.col_Normal_Att.IndeterminateValue = (object) "0";
      this.col_Normal_Att.Name = "col_Normal_Att";
      this.col_Normal_Att.Resizable = DataGridViewTriState.True;
      this.col_Normal_Att.TrueValue = (object) "1";
      this.col_Normal_Smeter.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_Smeter.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_Smeter, "col_Normal_Smeter");
      this.col_Normal_Smeter.Items.AddRange((object) "OFF", (object) "Level 1", (object) "Level 2", (object) "Level 3", (object) "Level 4", (object) "Level 5", (object) "Level 6", (object) "Level 7", (object) "Level 8", (object) "Level 9");
      this.col_Normal_Smeter.Name = "col_Normal_Smeter";
      this.col_Normal_Smeter.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bell.AutoComplete = false;
      this.col_Normal_Bell.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_Bell.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_Bell, "col_Normal_Bell");
      this.col_Normal_Bell.Items.AddRange((object) "OFF", (object) "ON");
      this.col_Normal_Bell.Name = "col_Normal_Bell";
      this.col_Normal_Bell.Resizable = DataGridViewTriState.True;
      this.col_Normal_Vibrator.AutoComplete = false;
      this.col_Normal_Vibrator.DisplayStyleForCurrentCellOnly = true;
      this.col_Normal_Vibrator.FlatStyle = FlatStyle.Flat;
      componentResourceManager.ApplyResources((object) this.col_Normal_Vibrator, "col_Normal_Vibrator");
      this.col_Normal_Vibrator.Items.AddRange((object) "OFF", (object) "BUSY", (object) "SIGNALING");
      this.col_Normal_Vibrator.Name = "col_Normal_Vibrator";
      this.col_Normal_Vibrator.Resizable = DataGridViewTriState.True;
      this.col_Normal_HarfDev.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_HarfDev, "col_Normal_HarfDev");
      this.col_Normal_HarfDev.IndeterminateValue = (object) "0";
      this.col_Normal_HarfDev.Name = "col_Normal_HarfDev";
      this.col_Normal_HarfDev.Resizable = DataGridViewTriState.True;
      this.col_Normal_HarfDev.TrueValue = (object) "1";
      this.col_Normal_ClockShift.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_ClockShift, "col_Normal_ClockShift");
      this.col_Normal_ClockShift.IndeterminateValue = (object) "0";
      this.col_Normal_ClockShift.Name = "col_Normal_ClockShift";
      this.col_Normal_ClockShift.Resizable = DataGridViewTriState.True;
      this.col_Normal_ClockShift.TrueValue = (object) "1";
      this.col_Normal_Bank1.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank1, "col_Normal_Bank1");
      this.col_Normal_Bank1.IndeterminateValue = (object) "0";
      this.col_Normal_Bank1.Name = "col_Normal_Bank1";
      this.col_Normal_Bank1.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank1.TrueValue = (object) "1";
      this.col_Normal_Bank2.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank2, "col_Normal_Bank2");
      this.col_Normal_Bank2.IndeterminateValue = (object) "0";
      this.col_Normal_Bank2.Name = "col_Normal_Bank2";
      this.col_Normal_Bank2.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank2.TrueValue = (object) "1";
      this.col_Normal_Bank3.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank3, "col_Normal_Bank3");
      this.col_Normal_Bank3.IndeterminateValue = (object) "0";
      this.col_Normal_Bank3.Name = "col_Normal_Bank3";
      this.col_Normal_Bank3.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank3.TrueValue = (object) "1";
      this.col_Normal_Bank4.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank4, "col_Normal_Bank4");
      this.col_Normal_Bank4.IndeterminateValue = (object) "0";
      this.col_Normal_Bank4.Name = "col_Normal_Bank4";
      this.col_Normal_Bank4.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank4.TrueValue = (object) "1";
      this.col_Normal_Bank5.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank5, "col_Normal_Bank5");
      this.col_Normal_Bank5.IndeterminateValue = (object) "0";
      this.col_Normal_Bank5.Name = "col_Normal_Bank5";
      this.col_Normal_Bank5.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank5.TrueValue = (object) "1";
      this.col_Normal_Bank6.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank6, "col_Normal_Bank6");
      this.col_Normal_Bank6.IndeterminateValue = (object) "0";
      this.col_Normal_Bank6.Name = "col_Normal_Bank6";
      this.col_Normal_Bank6.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank6.TrueValue = (object) "1";
      this.col_Normal_Bank7.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank7, "col_Normal_Bank7");
      this.col_Normal_Bank7.IndeterminateValue = (object) "0";
      this.col_Normal_Bank7.Name = "col_Normal_Bank7";
      this.col_Normal_Bank7.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank7.TrueValue = (object) "1";
      this.col_Normal_Bank8.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank8, "col_Normal_Bank8");
      this.col_Normal_Bank8.IndeterminateValue = (object) "0";
      this.col_Normal_Bank8.Name = "col_Normal_Bank8";
      this.col_Normal_Bank8.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank8.TrueValue = (object) "1";
      this.col_Normal_Bank9.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank9, "col_Normal_Bank9");
      this.col_Normal_Bank9.IndeterminateValue = (object) "0";
      this.col_Normal_Bank9.Name = "col_Normal_Bank9";
      this.col_Normal_Bank9.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank9.TrueValue = (object) "1";
      this.col_Normal_Bank10.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank10, "col_Normal_Bank10");
      this.col_Normal_Bank10.IndeterminateValue = (object) "0";
      this.col_Normal_Bank10.Name = "col_Normal_Bank10";
      this.col_Normal_Bank10.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank10.TrueValue = (object) "1";
      this.col_Normal_Bank11.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank11, "col_Normal_Bank11");
      this.col_Normal_Bank11.IndeterminateValue = (object) "0";
      this.col_Normal_Bank11.Name = "col_Normal_Bank11";
      this.col_Normal_Bank11.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank11.TrueValue = (object) "1";
      this.col_Normal_Bank12.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank12, "col_Normal_Bank12");
      this.col_Normal_Bank12.IndeterminateValue = (object) "0";
      this.col_Normal_Bank12.Name = "col_Normal_Bank12";
      this.col_Normal_Bank12.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank12.TrueValue = (object) "1";
      this.col_Normal_Bank13.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank13, "col_Normal_Bank13");
      this.col_Normal_Bank13.IndeterminateValue = (object) "0";
      this.col_Normal_Bank13.Name = "col_Normal_Bank13";
      this.col_Normal_Bank13.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank13.TrueValue = (object) "1";
      this.col_Normal_Bank14.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank14, "col_Normal_Bank14");
      this.col_Normal_Bank14.IndeterminateValue = (object) "0";
      this.col_Normal_Bank14.Name = "col_Normal_Bank14";
      this.col_Normal_Bank14.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank14.TrueValue = (object) "1";
      this.col_Normal_Bank15.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank15, "col_Normal_Bank15");
      this.col_Normal_Bank15.IndeterminateValue = (object) "0";
      this.col_Normal_Bank15.Name = "col_Normal_Bank15";
      this.col_Normal_Bank15.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank15.TrueValue = (object) "1";
      this.col_Normal_Bank16.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank16, "col_Normal_Bank16");
      this.col_Normal_Bank16.IndeterminateValue = (object) "0";
      this.col_Normal_Bank16.Name = "col_Normal_Bank16";
      this.col_Normal_Bank16.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank16.TrueValue = (object) "1";
      this.col_Normal_Bank17.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank17, "col_Normal_Bank17");
      this.col_Normal_Bank17.IndeterminateValue = (object) "0";
      this.col_Normal_Bank17.Name = "col_Normal_Bank17";
      this.col_Normal_Bank17.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank17.TrueValue = (object) "1";
      this.col_Normal_Bank18.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank18, "col_Normal_Bank18");
      this.col_Normal_Bank18.IndeterminateValue = (object) "0";
      this.col_Normal_Bank18.Name = "col_Normal_Bank18";
      this.col_Normal_Bank18.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank18.TrueValue = (object) "1";
      this.col_Normal_Bank19.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank19, "col_Normal_Bank19");
      this.col_Normal_Bank19.IndeterminateValue = (object) "0";
      this.col_Normal_Bank19.Name = "col_Normal_Bank19";
      this.col_Normal_Bank19.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank19.TrueValue = (object) "1";
      this.col_Normal_Bank20.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank20, "col_Normal_Bank20");
      this.col_Normal_Bank20.IndeterminateValue = (object) "0";
      this.col_Normal_Bank20.Name = "col_Normal_Bank20";
      this.col_Normal_Bank20.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank20.TrueValue = (object) "1";
      this.col_Normal_Bank21.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank21, "col_Normal_Bank21");
      this.col_Normal_Bank21.IndeterminateValue = (object) "0";
      this.col_Normal_Bank21.Name = "col_Normal_Bank21";
      this.col_Normal_Bank21.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank21.TrueValue = (object) "1";
      this.col_Normal_Bank22.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank22, "col_Normal_Bank22");
      this.col_Normal_Bank22.IndeterminateValue = (object) "0";
      this.col_Normal_Bank22.Name = "col_Normal_Bank22";
      this.col_Normal_Bank22.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank22.TrueValue = (object) "1";
      this.col_Normal_Bank23.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank23, "col_Normal_Bank23");
      this.col_Normal_Bank23.IndeterminateValue = (object) "0";
      this.col_Normal_Bank23.Name = "col_Normal_Bank23";
      this.col_Normal_Bank23.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank23.TrueValue = (object) "1";
      this.col_Normal_Bank24.FalseValue = (object) "0";
      componentResourceManager.ApplyResources((object) this.col_Normal_Bank24, "col_Normal_Bank24");
      this.col_Normal_Bank24.IndeterminateValue = (object) "0";
      this.col_Normal_Bank24.Name = "col_Normal_Bank24";
      this.col_Normal_Bank24.Resizable = DataGridViewTriState.True;
      this.col_Normal_Bank24.TrueValue = (object) "1";
      componentResourceManager.ApplyResources((object) this.col_Normal_Comment, "col_Normal_Comment");
      this.col_Normal_Comment.MaxInputLength = 256;
      this.col_Normal_Comment.Name = "col_Normal_Comment";
      this.col_Normal_Comment.SortMode = DataGridViewColumnSortMode.NotSortable;
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.tabc_DataForm);
      this.Name = nameof (DataForm);
      this.Activated += new EventHandler(this.DataForm_Activated);
      this.FormClosing += new FormClosingEventHandler(this.DataForm_FormClosing);
      this.Load += new EventHandler(this.DataForm_Load);
      this.MdiChildActivate += new EventHandler(this.DataForm_Activated);
      this.tabc_DataForm.ResumeLayout(false);
      this.tab_Normal.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_Normal).EndInit();
      this.tab_Skip.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_Skip).EndInit();
      this.tab_Pms.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_Pms).EndInit();
      this.tab_Vfo.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_Vfo).EndInit();
      this.tab_Home.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_Home).EndInit();
      this.tab_Wx.ResumeLayout(false);
      ((ISupportInitialize) this.dgv_Wx).EndInit();
      this.ResumeLayout(false);
    }

    public enum MemoryTab
    {
      NORMAL,
      SKIP,
      PMS,
      VFO,
      HOME,
      WX,
      MAX,
    }

    public enum MemoryCol
    {
      PRIORITYCH,
      RECVFREQ,
      SENDFREQ,
      SHIFTFREQ,
      SHIFTDIR,
      AUTOMODE,
      MODE,
      AMS,
      DIGANALOG,
      MEMORYNAME,
      SQLTYPE,
      TONEFREQ,
      DCSCODE,
      DCSPHASE,
      PRTONE,
      SENDOUT,
      SKIP,
      AUTOSTEP,
      STEP,
      TAG,
      MEMORYDIR,
      ATT,
      SMETERSQL,
      BELL,
      VIBRATOR,
      HALFDEV,
      CLOCKSHIFT,
      BANK1,
      BANK2,
      BANK3,
      BANK4,
      BANK5,
      BANK6,
      BANK7,
      BANK8,
      BANK9,
      BANK10,
      BANK11,
      BANK12,
      BANK13,
      BANK14,
      BANK15,
      BANK16,
      BANK17,
      BANK18,
      BANK19,
      BANK20,
      BANK21,
      BANK22,
      BANK23,
      BANK24,
      COMMENT,
      MAX,
    }

    public enum MemoryRow
    {
      AMBC,
      SW,
      _50MHz,
      FMBC,
      RSV,
      AIR,
      _144MHz,
      VHF,
      INFO1,
      _430MHz,
      UHF,
      INFO2,
      MAX,
    }

    private class TabPageManager
    {
      private DataForm.TabPageManager.TabPageInfo[] _tabPageInfos;
      private TabControl _tabControl;

      public TabPageManager(TabControl crl)
      {
        this._tabControl = crl;
        this._tabPageInfos = new DataForm.TabPageManager.TabPageInfo[this._tabControl.TabPages.Count];
        for (int index = 0; index < this._tabControl.TabPages.Count; ++index)
          this._tabPageInfos[index] = new DataForm.TabPageManager.TabPageInfo(this._tabControl.TabPages[index], true);
      }

      public void ChangeTabPageVisible(int index, bool v)
      {
        if (this._tabPageInfos[index].Visible == v)
          return;
        this._tabPageInfos[index].Visible = v;
        this._tabControl.SuspendLayout();
        this._tabControl.TabPages.Clear();
        for (int index1 = 0; index1 < this._tabPageInfos.Length; ++index1)
        {
          if (this._tabPageInfos[index1].Visible)
            this._tabControl.TabPages.Add(this._tabPageInfos[index1].TabPage);
        }
        this._tabControl.ResumeLayout();
      }

      private class TabPageInfo
      {
        public TabPage TabPage;
        public bool Visible;

        public TabPageInfo(TabPage page, bool v)
        {
          this.TabPage = page;
          this.Visible = v;
        }
      }
    }
  }
}
