using System;
using System.Windows;
using System.Windows.Controls;

namespace demo.wsclient.src.controls
{
    /// <summary>
    /// Interaction logic for WSBaseContract.xaml
    /// </summary>
    public partial class WSBaseContract : UserControl
    {
        public WSBaseContract()
        {
            InitializeComponent();
            Context.Instance.wsapi.baseContract.onUpdate.On(() => { Console.WriteLine("[WSBaseContract] onUpdate"); });
            Context.Instance.wsapi.baseContract.onDataUpdate.On((data) => { Console.WriteLine("[WSBaseContract] onDataUpdate data={{ a: {0}, b:{1} }}", data.a, data.b); });
        }

        async private void _uiButtonSubscribe_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[WSBaseContract] Subscribe resquest");
                await Context.Instance.wsapi.baseContract.onUpdate.Subscribe();
                await Context.Instance.wsapi.baseContract.onDataUpdate.Subscribe();
                Console.WriteLine("[WSBaseContract] Subscribe response");
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
                Console.WriteLine("[WSBaseContract] Unsubscribe resquest");
                await Context.Instance.wsapi.baseContract.onUpdate.Unsubscribe();
                await Context.Instance.wsapi.baseContract.onDataUpdate.Unsubscribe();
                Console.WriteLine("[WSBaseContract] Unsubscribe response");
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
                Console.WriteLine("[WSBaseContract] print resquest");
                await Context.Instance.wsapi.baseContract.print();
                Console.WriteLine("[WSBaseContract] print response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }
       async private void _uiButtonDelay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[WSBaseContract] delay resquest");
                await Context.Instance.wsapi.baseContract.delay(2500);
                Console.WriteLine("[WSBaseContract] delay response");
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
                Console.WriteLine("[WSBaseContract] notify resquest");
                await Context.Instance.wsapi.baseContract.notify();
                Console.WriteLine("[WSBaseContract] notify response");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Exception] {0}", ex.Message);
            }
        }

       

    }
}
