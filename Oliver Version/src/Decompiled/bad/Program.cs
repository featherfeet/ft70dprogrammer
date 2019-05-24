// Decompiled with JetBrains decompiler
// Type: ADMS10.Program
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;
using System.Threading;
using System.Windows.Forms;

namespace ADMS10
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      try
      {
        Debugger.LoadFromXmlFile();
      }
      catch
      {
        Debugger.Instance.localDistribution = false;
      }
      Settings.LoadFromXmlFile();
      using (Mutex mutex = new Mutex(false, Application.ProductName))
      {
        if (!mutex.WaitOne(0, false))
          return;
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run((Form) new AdmsForm());
      }
    }
  }
}
