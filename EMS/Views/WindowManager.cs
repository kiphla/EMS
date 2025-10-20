using System.Windows;

namespace EMS.Views
{
    public static class WindowManager
    {
        public static void Open(Window parent, Window child)
        {
            child.Owner = parent;
            child.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            parent.Hide();
            child.ShowDialog();
            parent.Show();
        }
    }
}