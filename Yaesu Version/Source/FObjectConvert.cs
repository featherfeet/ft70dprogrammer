// Decompiled with JetBrains decompiler
// Type: ADMS10.FObjectConvert
// Assembly: ADMS10, Version=1.0.0.3, Culture=neutral, PublicKeyToken=null
// MVID: 916BD5CA-6D06-4E46-9F0F-EBE01FA730C5
// Assembly location: C:\Program Files (x86)\Yaesu Musen\FT-70D ADMS-10 EXP\ADMS10.exe

using System;

namespace ADMS10
{
  public class FObjectConvert
  {
    public static void ToFObject(Database db, FObject obj)
    {
      db.Buffer.CopyTo((Array) obj.buffer, 0);
      for (int index = 0; index < obj.NormalMemCmnt.Length; ++index)
        obj.NormalMemCmnt[index] = db.NormalMemory[index].Comment;
      for (int index = 0; index < obj.SkipMemCmnt.Length; ++index)
        obj.SkipMemCmnt[index] = db.SkipMemory[index].Comment;
      for (int index = 0; index < obj.PmsMemCmnt.Length; ++index)
        obj.PmsMemCmnt[index] = db.PmsMemory[index].Comment;
      for (int index = 0; index < obj.HomeMemCmnt.Length; ++index)
        obj.HomeMemCmnt[index] = db.HomeMemory[index].Comment;
      for (int index = 0; index < obj.VfoMemCmnt.Length; ++index)
        obj.VfoMemCmnt[index] = db.VfoMemory[index].Comment;
      for (int index = 0; index < obj.WxMemCmnt.Length; ++index)
        obj.WxMemCmnt[index] = db.WxMemory[index].Comment;
    }

    public static void ToDatabase(Database db, FObject obj)
    {
      obj.buffer.CopyTo((Array) db.Buffer, 0);
      for (int index = 0; index < obj.NormalMemCmnt.Length; ++index)
        db.NormalMemory[index].Comment = obj.NormalMemCmnt[index];
      for (int index = 0; index < obj.SkipMemCmnt.Length; ++index)
        db.SkipMemory[index].Comment = obj.SkipMemCmnt[index];
      for (int index = 0; index < obj.PmsMemCmnt.Length; ++index)
        db.PmsMemory[index].Comment = obj.PmsMemCmnt[index];
      for (int index = 0; index < obj.HomeMemCmnt.Length; ++index)
        db.HomeMemory[index].Comment = obj.HomeMemCmnt[index];
      for (int index = 0; index < obj.VfoMemCmnt.Length; ++index)
        db.VfoMemory[index].Comment = obj.VfoMemCmnt[index];
      for (int index = 0; index < obj.WxMemCmnt.Length; ++index)
        db.WxMemory[index].Comment = obj.WxMemCmnt[index];
    }
  }
}
