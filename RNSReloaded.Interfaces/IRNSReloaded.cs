﻿using RNSReloaded.Interfaces.Structs;

namespace RNSReloaded.Interfaces;

public unsafe interface IRNSReloaded {
    public event Action? OnReady;
    public event Action<ExecuteItArguments>? OnExecuteIt;

    public static IRNSReloaded Instance = null!;

    public void LimitOnlinePlay();

    public CScript* GetScriptData(int id);
    public int ScriptFindId(string name);
    public int? CodeFunctionFind(string name);
    public RFunctionStringRef GetTheFunction(int id);
    public CInstance* GetGlobalInstance();
    public RValue* FindValue(CInstance* instance, string name);
    public RValue* ArrayGetEntry(RValue* array, int index);
    public string GetString(RValue* value);
    public CRoom* GetCurrentRoom();
    public List<string> GetStructKeys(RValue* value);
    public void CreateString(RValue* value, string str);
}
