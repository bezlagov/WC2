using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerForWorkCatalog.Model
{
    class LoggerData
    {
        private static LoggerData _instance;

        public bool switcherStatus { get; set; } = true;
        public static LoggerData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoggerData();
                return _instance;
            }
        }
    }
}
