using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoggerForWorkCatalog
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            if (Model.LoggerData.Instance.switcherStatus)
            {
                lblStatus.Content = View.Show.LabelStatus(Model.LoggerData.Instance.switcherStatus);
                lblStatus.Foreground = Brushes.Blue;
            }
            else
            {
                lblStatus.Content = View.Show.LabelStatus(Model.LoggerData.Instance.switcherStatus);
                lblStatus.Foreground = Brushes.Red;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StatusSwitcher();
        }
        private void StatusSwitcher()
        {
                Controller.LoggerDataController.SwitcherChanger();
                Init();
        }
    }
}
