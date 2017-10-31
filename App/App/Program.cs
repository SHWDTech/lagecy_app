using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Threading;
using ESMonApp.AsyncSocketCore;
using log4net;
using ESMonApp.AsyncSocketProtocol;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ESMonApp
{
    internal static class Program
    {
        public static ILog Logger;
        public static AsyncSocketServer AsyncSocketSvr;
        public static string FileDirectory;
        public static WinLog OutputLog;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExceptionHandler();
            var currentTime = DateTime.Now;
            GlobalContext.Properties["LogDir"] = currentTime.ToString("yyyyMM");
            GlobalContext.Properties["LogFileName"] = "_SocketAsyncServer" + currentTime.ToString("yyyyMMdd");
            Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            FileDirectory = config.AppSettings.Settings["FileDirectory"].Value;
            if (FileDirectory == "")
                FileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Files");
            if (!Directory.Exists(FileDirectory))
                Directory.CreateDirectory(FileDirectory);
            if (!(int.TryParse(config.AppSettings.Settings["ParallelNum"].Value, out var parallelNum)))
                parallelNum = 8000;

            if (!(int.TryParse(config.AppSettings.Settings["WaitResponseTimeOutMS"].Value, out var waitResponseTimeOutMs)))
                waitResponseTimeOutMs = 1 * 60 * 1000;

            if (!(int.TryParse(config.AppSettings.Settings["SocketTimeOutMS"].Value, out var socketTimeOutMs)))
                socketTimeOutMs = 5 * 60 * 1000;

            AsyncSocketSvr = new AsyncSocketServer(parallelNum)
            {
                WaitResponseTimeOutMs = waitResponseTimeOutMs,
                SocketTimeOutMs = socketTimeOutMs
            };
            AsyncSocketSvr.Init();
            DevsManage.Init();

            EsProtocolMgr.Init();

            OutputLog = new WinLog();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ThreadPool.SetMinThreads(200, 200);
            Application.Run(new MainForm());
        }

        private static void ExceptionHandler()
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Logger.Fatal("未处理异常", (Exception)e.ExceptionObject);
            };
            Application.ThreadException += (sender, e) =>
            {
                Logger.Fatal("未处理异常", e.Exception);
            };
        }
    }
}
