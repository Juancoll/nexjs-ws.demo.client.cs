using System;
using System.Windows.Controls;

namespace demo.wsclient.src.controls
{
    /// <summary>
    /// Interaction logic for WSConnection.xaml
    /// </summary>
    public partial class WSConnection : UserControl
    {
        public WSConnection()
        {
            InitializeComponent();
        }

        private void _uiButtonConnect_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[ui] Connect");
                Context.Instance.wsapi.Ws.Connect(_uiTextBoxUrl.Text, _uiTextBoxPath.Text, _uiTextBoxNsp.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[error] {ex.Message}");
            }
        }

        private void _uiButtonDisconnect_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[ui] Disconnect");
                Context.Instance.wsapi.Ws.Disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[error] {ex.Message}");
            }
        }

        private async void _uiButtonRegister_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[ui] auth.register");
                await Context.Instance.wsapi.Auth.Register(new { email = "admin@nex-group.io", password = "123456" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[error] {ex.Message}");
            }
        }

        private async void _uiButtonLogin_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[ui] auth.register");
                await Context.Instance.wsapi.Auth.Login(new { email = "admin@nex-group.io", password = "123456" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[error] {ex.Message}");
            }
        }

        private async void _uiButtonLogout_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[ui] auth.register");
                await Context.Instance.wsapi.Auth.Logout();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[error] {ex.Message}");
            }
        }
    }
}
