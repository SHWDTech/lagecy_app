using System;

namespace ESMonApp.ScheduleTasks
{
    public class ScheduleTaskExecuteEventArgs : EventArgs
    {
        public bool IsSuccessed { get; set; }
    }
}
