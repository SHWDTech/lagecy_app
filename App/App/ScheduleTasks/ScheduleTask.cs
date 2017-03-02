using System;
using System.Threading;

namespace ESMonApp.ScheduleTasks
{
    public delegate bool Condition(bool isRunning);

    public class ScheduleTask : IScheduleTask
    {
        public string Name { get; protected set; }

        public bool Repeatable { get; protected set; }

        public long Interval { get; protected set; }

        public event ScheduleExecue OnScheduleExecuting;

        public DateTime LastExecuteTime { get; private set; }

        public ScheduleType ScheduleType { get; protected set; }

        public bool IsRunning { get; protected set; }

        public Condition StartCondition { get; set; }

        public Condition EndCondition { get; set; }

        public ScheduleTask(long interval, bool repeatable, ScheduleType type)
        {
            Interval = interval;
            Repeatable = repeatable;
            ScheduleType = type;
            if (ScheduleType != ScheduleType.StartOnCondition)
            {
                IsRunning = true;
            }
        }

        private void EvaluateStartCondition()
        {
            if (StartCondition == null) throw new NullReferenceException("Null Start Condition");
            IsRunning = StartCondition(IsRunning);
        }

        private void EvaluateEndCondition()
        {
            if (EndCondition == null) throw new NullReferenceException("Null End Condition");
            IsRunning = !EndCondition(IsRunning);
        }

        public virtual void Execute()
        {
            if (ScheduleType == ScheduleType.StartOnCondition)
            {
                EvaluateStartCondition();
            }
            if (!IsRunning) return;
            if (OnScheduleExecuting == null) throw new NullReferenceException("Must set Executing event.");
            var thread = new Thread(DoExecute)
            {
                IsBackground = true
            };
            thread.Start();
        }

        private void DoExecute()
        {
            if ((DateTime.Now - LastExecuteTime).TotalMilliseconds * TimeSpan.TicksPerMillisecond < Interval) return;
            var args = new ScheduleTaskExecuteEventArgs();
            OnScheduleExecuting?.Invoke(this, args);
            FinishExecute(args);
            if (ScheduleType == ScheduleType.StopOnCondition)
            {
                EvaluateEndCondition();
            }
        }

        private void FinishExecute(ScheduleTaskExecuteEventArgs args)
        {
            if (args.IsSuccessed)
            {
                LastExecuteTime = DateTime.Now;
            }
        }
    }
}
