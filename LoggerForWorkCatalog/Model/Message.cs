using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerForWorkCatalog.Model
{
    class LogMessage
    {
        DateTime DateInfomation { get; set; }
        LogLevel LoggingLevel { get; set; }
        string ErrorCode { get; set; }
        string Sender { get; set; }
        int ThreadId { get; set; }
        string MessageToLog { get; set; }

        public LogMessage(DateTime dateInformation, LogLevel loggingLevel, string errorCode, string sender, int threadId, string messageToLog)
        {
            DateInfomation = dateInformation;
            LoggingLevel = loggingLevel;
            ErrorCode = errorCode;
            Sender = sender;
            ThreadId = threadId;
            MessageToLog = messageToLog;
        }
    }
}
