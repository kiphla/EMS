using EMS.UI.Forms;
using EMS.Core.Utilities;

namespace EMS.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseHelper.InitializeDatabase();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
