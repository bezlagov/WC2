using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerForWorkCatalog.View
{
    public static class Show
    {
        public static string LabelStatus(bool status)
        {
            if (status) return "Logging OFF";
            else return "Logging ON";
        }
    }
}
