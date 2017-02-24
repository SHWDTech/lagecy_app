namespace ESMonApp.AsyncSocketProtocolCore
{
    public enum ProtocolCmdType
    {
        SysComm = 0xF9, //注册命令,也就是心跳包命令
        ModuleCfg = 0xFA,
        ModuleCtrl = 0xFB,
        DevCtrl = 0xFC,
        DevResponse = 0xFD
    }
}