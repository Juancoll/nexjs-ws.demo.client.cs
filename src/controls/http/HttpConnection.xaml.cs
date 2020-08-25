using System;
using System.Windows;
using System.Windows.Controls;

namespace demo.wsclient.src.controls
{
    /// <summary>
    /// Interaction logic for HttpConnection.xaml
    /// </summary>
    public partial class HttpConnection : UserControl
    {
        public HttpConnection()
        {
            InitializeComponent();
        }
       

        private void _uiButtonSet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpConnection] Set Url");
                Context.Instance.httpapi.Url = _uiTextBoxUrl.Text;
            }
            catch(Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }
        async private void _uiButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpConnection] Register request");
                var response = await Context.Instance.httpapi.Auth.AuthControllerRegisterAsync(new httpclient.Model.AuthLoginDto(
                    _uiTextBoxRegisterEmail.Text, 
                    _uiTextBoxRegisterPassword.Text
                ));
                Console.WriteLine("[HttpConnection] Register response = {0}", response.ToJson());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }
        async private void _uiButtonLoginLocal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpConnection] LocalLogin request");
                var response = await Context.Instance.httpapi.LocalLogin(_uiTextBoxLoginLocalEmail.Text, _uiTextBoxLoginLocalPassword.Text);
                Console.WriteLine("[HttpConnection] LocalLogin response = {0}", response.ToJson());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        async private void _uiButtonLogoutLocal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpConnection] localLogout request");
                await Context.Instance.httpapi.LocalLogout();
                Console.WriteLine("[HttpConnection] localLogout response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        async private void _uiButtonLoginJwt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpConnection] JwtLogin request");
                var response = await Context.Instance.httpapi.JwtLogin(_uiTextBoxLoginJwtEmail.Text, _uiTextBoxLoginJwtPassword.Text);
                Console.WriteLine("[HttpConnection] JwtLogin response = {0}", response.ToJson());
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        private void _uiButtonLogoutJwt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpConnection] JwtLogout request");
                Context.Instance.httpapi.JwtLogout();
                Console.WriteLine("[HttpConnection] JwtLogout response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

       
    }
}
