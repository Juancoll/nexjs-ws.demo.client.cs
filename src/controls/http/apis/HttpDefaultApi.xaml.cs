using Newtonsoft.Json;
using System;
using System.Windows;
using System.Windows.Controls;

namespace demo.wsclient.src.controls
{
    /// <summary>
    /// Interaction logic for HttpApiDefault.xaml
    /// </summary>
    public partial class HttpDefaultApi : UserControl
    {
        public HttpDefaultApi()
        {
            InitializeComponent();
        }

        async private void _uiButtonGetHello_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpDefaultApi] GetHello request");
                var response = await Context.Instance.httpapi.Default.AppControllerGetHelloAsyncWithHttpInfo();

                Console.WriteLine("[HttpDefaultApi] GetHello response {0}", response.Data);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        async private void _uiButtonGetPackage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[HttpDefaultApi] GetHello request");
                var response = await Context.Instance.httpapi.Default.AppControllerGetPackageAsyncWithHttpInfo();
                Console.WriteLine("[HttpDefaultApi] GetHello response {0}", JsonConvert.SerializeObject(response.Data));
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }
    }
}
