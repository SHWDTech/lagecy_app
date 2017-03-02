namespace ESMonApp.ScheduleTasks
{
    public enum ScheduleType : byte
    {
        Standard = 0x00,

        StopOnCondition = 0x01,

        StartOnCondition = 0x02
    }
}
