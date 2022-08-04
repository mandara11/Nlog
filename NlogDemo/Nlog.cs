using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    public class Nlog
    {
        public static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void LogDebugMode(string Message)
        {
            logger.Debug(Message);
        }

        public void LogError(string Message)
        {
            logger.Error(Message);
        }
        public void LogInformation(string Message)
        {
            logger.Info(Message);
        }
    }
}
