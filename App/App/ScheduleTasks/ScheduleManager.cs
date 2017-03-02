using System.Collections.Generic;
using System.Timers;

namespace ESMonApp.ScheduleTasks
{
    public class ScheduleManager
    {
        private static readonly Timer ScheduleTimer = new Timer();

        private static readonly List<IScheduleTask> Tasks = new List<IScheduleTask>();

        static ScheduleManager()
        {
            ScheduleTimer.Interval = 10000;
            ScheduleTimer.Elapsed += ScheduleExecuter;
        }

        public static void SetInterval(double interval)
        {
            ScheduleTimer.Interval = interval;
        }

        public static void Start()
        {
            ScheduleTimer.Start();
        }

        public static void Stop()
        {
            ScheduleTimer.Stop();
        }

        private static void ScheduleExecuter(object sender, ElapsedEventArgs args)
        {
            lock (Tasks)
            {
                foreach (var task in Tasks)
                {
                    task.Execute();
                }
            }
        }

        public static void Register(IScheduleTask task)
        {
            lock (Tasks)
            {
                Tasks.Add(task);
            }
        }

        public static void UnRegister(IScheduleTask task)
        {
            lock (Tasks)
            {
                Tasks.Remove(task);
            }
        }
    }
}
