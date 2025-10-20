using EMS.Views;
using System.Configuration;
using System.Data;
using System.Windows;
using EMS.Core.Data;

namespace EMS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Initialize the database
            using (var context = new AppDbContext())
            {
                DbInitializer.Initialize(context);
            }

            LoginWindow login = new LoginWindow();
            login.Show();
        }
    }
}
