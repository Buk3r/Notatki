using Notatki.Views;

namespace Notatki
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(NotePage), typeof(NotePage));
        }
    }
}
