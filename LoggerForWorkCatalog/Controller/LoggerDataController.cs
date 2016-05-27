using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerForWorkCatalog.Controller
{
    public static class LoggerDataController
    {
        public static void SwitcherChanger()
        {
            if (Model.LoggerData.Instance.switcherStatus)
                Model.LoggerData.Instance.switcherStatus = false;
            else
                Model.LoggerData.Instance.switcherStatus = true;
        }
    }
}
