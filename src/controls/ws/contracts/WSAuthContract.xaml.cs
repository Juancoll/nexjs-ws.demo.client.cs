using System;
using System.Windows;
using System.Windows.Controls;

namespace demo.wsclient.src.controls
{
    /// <summary>
    /// Interaction logic for WSAuthContract.xaml
    /// </summary>
    public partial class WSAuthContract : UserControl
    {
        public WSAuthContract()
        {
            InitializeComponent();

            Context.Instance.wsapi.authContract.onUpdate.On(() => { Console.WriteLine("[WSAuthContract] onUpdate"); });
            Context.Instance.wsapi.authContract.onDataUpdate.On((data) => { Console.WriteLine("[WSAuthContract] onDataUpdate data={{ a: {0}, b:{1} }}", data.a, data.b); });
        }

        async private void _uiButtonSubscribe_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[WSAuthContract] Subscribe resquest");
                await Context.Instance.wsapi.authContract.onUpdate.Subscribe();
                await Context.Instance.wsapi.authContract.onDataUpdate.Subscribe();
                Console.WriteLine("[WSAuthContract] Subscribe response");
            }
            catch(Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

        async private void _uiButtonUnsubscribe_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[WSAuthContract] Unsubscribe resquest");
                await Context.Instance.wsapi.authContract.onUpdate.Unsubscribe();
                await Context.Instance.wsapi.authContract.onDataUpdate.Unsubscribe();
                Console.WriteLine("[WSAuthContract] Unsubscribe response");
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
                Console.WriteLine("[WSAuthContract] print resquest");
                await Context.Instance.wsapi.authContract.print();
                Console.WriteLine("[WSAuthContract] print response");
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
                Console.WriteLine("[WSAuthContract] notify resquest");
                await Context.Instance.wsapi.authContract.notify();
                Console.WriteLine("[WSAuthContract] notify response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }
    }
}
