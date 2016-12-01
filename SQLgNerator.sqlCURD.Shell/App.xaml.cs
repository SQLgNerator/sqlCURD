using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SQLgNerator.sqlCURD.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // create the bootstrapper to start the application.
            ApplicaitionBootStrapper bootstrapper = new ApplicaitionBootStrapper();
            bootstrapper.Run();
        }
    }
}
