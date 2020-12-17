using System;
using System.Windows;
using System.Windows.Controls;

namespace demo.wsclient.src.controls
{
    /// <summary>
    /// Interaction logic for WSCredentialsContract.xaml
    /// </summary>
    public partial class WSCredentialsContract : UserControl
    {
        public WSCredentialsContract()
        {
            InitializeComponent();
            Context.Instance.wsapi.credentialContract.onUpdate.On(() => { Console.WriteLine("[WSCredentialsContract] onUpdate"); });
            Context.Instance.wsapi.credentialContract.onDataUpdate.On((data) => { Console.WriteLine("[WSCredentialsContract] onDataUpdate data={{ a: {0}, b:{1} }}", data.a, data.b); });
        }

        async private void _uiButtonSubscribe_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[WSCredentialsContract] Subscribe resquest");
                await Context.Instance.wsapi.credentialContract.onUpdate.Subscribe(1212);
                await Context.Instance.wsapi.credentialContract.onDataUpdate.Subscribe(1212);
                Console.WriteLine("[WSCredentialsContract] Subscribe response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        async private void _uiButtonUnsubscribe_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[WSCredentialsContract] Unsubscribe resquest");
                await Context.Instance.wsapi.credentialContract.onUpdate.Unsubscribe();
                await Context.Instance.wsapi.credentialContract.onDataUpdate.Unsubscribe();
                Console.WriteLine("[WSCredentialsContract] Unsubscribe response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        async private void _uiButtonPrint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[WSCredentialsContract] print resquest");
                await Context.Instance.wsapi.credentialContract.print();
                Console.WriteLine("[WSCredentialsContract] print response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        async private void _uiButtonNotify_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[WSCredentialsContract] notify resquest");
                await Context.Instance.wsapi.credentialContract.notify();
                Console.WriteLine("[WSCredentialsContract] notify response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }
    }
}
