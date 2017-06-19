using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public sealed class AppLogger
    {
        private static readonly string sr_FileName;
        private static AppLogger s_Instance = null;
        private static object s_LockObj = new object();

        static AppLogger()
        {
            sr_FileName = "LogInformation.log";
        }

        private AppLogger()
        {
        }

        public static AppLogger Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppLogger();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public void WriteToLog(string i_MethodName, string i_Msg)
        {
            using (FileStream fs = File.Open(sr_FileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter log = new StreamWriter(fs))
                {
                    log.WriteLine(string.Format("[TIME: {1}][METHOD: {0}]::{2}", i_MethodName, DateTime.Now, i_Msg));
                }
            }
        }
    }
}
