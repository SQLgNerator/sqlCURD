using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Prism.Unity;
using SQLgNerator.sqlCURD.Shell.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SQLgNerator.sqlCURD.Shell
{
    /// <summary>
    /// The bootstrapper class that initialses the applicaiton modules and other components
    /// </summary>
    public class ApplicaitionBootStrapper : UnityBootstrapper
    {
        protected override void InitializeShell()
        {
            base.InitializeShell();

            // set the shell as the main window of the application, and show it to the user
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }

        /// <summary>
        /// Creates the shell or main window of the application.
        /// </summary>
        /// <returns>
        /// The shell of the application.
        /// </returns>
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<IShell>() as Window;
        }

        /// <summary>
        /// Configures the unity container by regestering the application specific classes and interfaces
        /// </summary>
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            this.Container.RegisterType<IShell, ShellView>();
        }
    }
}
