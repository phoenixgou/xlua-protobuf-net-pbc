//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GG_User.proto
// Note: requires additional types generated from: GG_UserInfo.proto
namespace TopFun.ClientMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GG_User")]
  public partial class GG_User : global::ProtoBuf.IExtensible
  {
    public GG_User() {}
    
    private TopFun.ClientMsg.GG_UserInfo _info;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public TopFun.ClientMsg.GG_UserInfo info
    {
      get { return _info; }
      set { _info = value; }
    }
    private long _diamond1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"diamond1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long diamond1
    {
      get { return _diamond1; }
      set { _diamond1 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}