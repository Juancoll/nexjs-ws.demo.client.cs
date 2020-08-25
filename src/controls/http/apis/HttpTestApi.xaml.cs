using System;
using System.Windows;
using System.Windows.Controls;

namespace demo.wsclient.src.controls
{
    /// <summary>
    /// Interaction logic for HttpTestApi.xaml
    /// </summary>
    public partial class HttpTestApi : UserControl
    {
        public HttpTestApi()
        {
            InitializeComponent();
        }

        async private void _uiButtonNoAuthTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpTestApi] No Auth request");
                await Context.Instance.httpapi.Test.TestControllerTestNoAuthAsync();
                Console.WriteLine("[HttpTestApi] No Auth  response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

       async private void _uiButtonLocalAuthTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpTestApi] Local Auth request");
                await Context.Instance.httpapi.Test.TestControllerTestAuthLocalAsync();
                Console.WriteLine("[HttpTestApi] Local Auth response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        async private void _uiButtonLocalAuthWithRoleTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpTestApi] Local Auth With Role request");
                await Context.Instance.httpapi.Test.TestControllerTestAuthLocalWithRoleAsync();
                Console.WriteLine("[HttpTestApi] Local Auth With Role response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        async private void _uiButtonJwtAuthTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpTestApi] Jwt Auth request");
                await Context.Instance.httpapi.Test.TestControllerTestAuthJwtAsync();
                Console.WriteLine("[HttpTestApi] Jwt Auth response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        async private void _uiButtonJwtAuthWithRoleTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpTestApi] Jwt Auth With Role request");
                await Context.Instance.httpapi.Test.TestControllerTestAuthJwtWithRoleAsync();
                Console.WriteLine("[HttpTestApi] Jwt Auth With Role response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }
    }
}
