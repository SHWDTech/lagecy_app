using System;

namespace ESMonApp.ScheduleTasks
{
    public delegate void ScheduleExecue(object sender, ScheduleTaskExecuteEventArgs e);

    public interface IScheduleTask
    {
        string Name { get; }

        bool Repeatable { get; }

        long Interval { get; }

        ScheduleType ScheduleType { get; }

        DateTime LastExecuteTime { get; }

        bool IsRunning { get; }

        Condition StartCondition { get; set; }

        Condition EndCondition { get; set; }

        void Execute();

        event ScheduleExecue OnScheduleExecuting;
    }
}
