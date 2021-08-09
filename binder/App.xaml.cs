using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using Hardcodet.Wpf.TaskbarNotification;

namespace binder
{

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private TaskbarIcon taskTrayIcon;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            taskTrayIcon = (TaskbarIcon)FindResource("TaskTrayIcon");
        }

        protected override void OnExit(ExitEventArgs e)
        {

            taskTrayIcon.Dispose();
            base.OnExit(e);
        }
    }
}
