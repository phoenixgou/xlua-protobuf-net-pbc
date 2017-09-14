using System.Collections;
using System.Collections.Generic;
using System.IO;
using TopFun.ClientMsg;
using UnityEngine;
using XLua;

public class myTest
{
    public void Test()
    {
        Debug.Log("say hello!");
    }

    public void luaDecodeString(string ss)
    {
        byte[] sb = System.Text.Encoding.UTF8.GetBytes(ss);

        var decode = Deserialize<GG_User>(sb);
    }

    //public void luaEncodeString(object ss)
    //{
    //    byte[] sb = System.Text.Encoding.UTF8.GetBytes(ss);

    //    var decode = Serialize<GG_User>(sb);
    //}

    byte[] Serialize(object o)
    {
        using (MemoryStream ms = new MemoryStream())
        {

            ProtoBuf.Serializer.Serialize(ms, o);

            byte[] result = new byte[ms.Length];

            ms.Position = 0;

            ms.Read(result, 0, result.Length);

            return result;
        }
    }

    T Deserialize<T>(byte[] b)
    {

        using (MemoryStream ms = new MemoryStream())
        {
            ms.Write(b, 0, b.Length);

            ms.Position = 0;

            return ProtoBuf.Serializer.Deserialize<T>(ms);
        }
    }
}

public class NewBehaviourScript : MonoBehaviour {

    public TextAsset luaFile;

    static void luaEncodeString(string strStream)
    {
        byte[] encode = System.Text.Encoding.Default.GetBytes(strStream);

        var decode = Deserialize<GG_User>(encode);

        //Debug.Log(decode.pwdMd5);
        
    }
	// Use this for initialization
	void Start () {
        GG_User user = new GG_User();
        user.info = new GG_UserInfo();
        user.info.level = 1;
        user.info.diamond = 999998111111;
        user.info.name = "ss";

        var encode = Serialize(user);

        GG_User decode = Deserialize<GG_User>(encode);

        Debug.Log(decode.info.diamond);


        LuaEnv luaenv = new LuaEnv();
        luaenv.AddBuildin("rapidjson", XLua.LuaDLL.Lua.LoadRapidJson);
        luaenv.AddBuildin("lpeg", XLua.LuaDLL.Lua.LoadLpeg);
        luaenv.AddBuildin("protobuf.c", XLua.LuaDLL.Lua.LoadProtobufC);
        luaenv.DoString(luaFile.bytes);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    static byte[] Serialize(object o)
    {
        using (MemoryStream ms = new MemoryStream())
        {

            ProtoBuf.Serializer.Serialize(ms, o);

            byte[] result = new byte[ms.Length];

            ms.Position = 0;

            ms.Read(result, 0, result.Length);

            return result;
        }
    }

    static T Deserialize<T>(byte[] b)
    {

        using (MemoryStream ms = new MemoryStream())
        {
            ms.Write(b, 0, b.Length);

            ms.Position = 0;

            return ProtoBuf.Serializer.Deserialize<T>(ms);
        }
    }
}
