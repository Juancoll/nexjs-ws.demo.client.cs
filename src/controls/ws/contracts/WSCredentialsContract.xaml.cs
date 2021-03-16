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
            Context.Instance.wsapi.credentialContract.onUpdateData.On((data) => { Console.WriteLine("[WSCredentialsContract] onUpdateData data={{ a: {0}, b:{1} }}", data.a, data.b); });
            Context.Instance.wsapi.credentialContract.onUpdateSelection.On(() => { Console.WriteLine("[WSCredentialsContract] onUpdateSelection"); });
            Context.Instance.wsapi.credentialContract.onUpdateSelectionData.On((data) => { Console.WriteLine("[WSCredentialsContract] onUpdateSelectionData data={{ a: {0}, b:{1} }}", data.a, data.b); });
            Context.Instance.wsapi.credentialContract.onUpdateValidation.On(() => { Console.WriteLine("[WSCredentialsContract] onUpdateValidation"); });
            Context.Instance.wsapi.credentialContract.onUpdateValidationData.On((data) => { Console.WriteLine("[WSCredentialsContract] onUpdateValidationData data={{ a: {0}, b:{1} }}", data.a, data.b); });
            Context.Instance.wsapi.credentialContract.onUpdateValidationSelection.On(() => { Console.WriteLine("[WSCredentialsContract] onUpdateValidationSelection"); });
            Context.Instance.wsapi.credentialContract.onUpdateValidationSelectionData.On((data) => { Console.WriteLine("[WSCredentialsContract] onUpdateValidationSelectionData data={{ a: {0}, b:{1} }}", data.a, data.b); });
        }

        async private void _uiButtonSubscribe_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Console.WriteLine("[WSCredentialsContract] Subscribe resquest");
                await Context.Instance.wsapi.credentialContract.onUpdate.Subscribe();
                await Context.Instance.wsapi.credentialContract.onUpdateData.Subscribe();
                await Context.Instance.wsapi.credentialContract.onUpdateSelection.Subscribe();
                await Context.Instance.wsapi.credentialContract.onUpdateSelectionData.Subscribe();
                await Context.Instance.wsapi.credentialContract.onUpdateValidation.Subscribe(2345);
                await Context.Instance.wsapi.credentialContract.onUpdateValidationData.Subscribe(2345);
                await Context.Instance.wsapi.credentialContract.onUpdateValidationSelection.Subscribe(2345);
                await Context.Instance.wsapi.credentialContract.onUpdateValidationSelectionData.Subscribe(2345);
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
                await Context.Instance.wsapi.credentialContract.onUpdate.Unsub();
                await Context.Instance.wsapi.credentialContract.onUpdateData.Unsub();
                await Context.Instance.wsapi.credentialContract.onUpdateSelection.Unsub();
                await Context.Instance.wsapi.credentialContract.onUpdateSelectionData.Unsub();
                await Context.Instance.wsapi.credentialContract.onUpdateValidation.Unsub();
                await Context.Instance.wsapi.credentialContract.onUpdateValidationData.Unsub();
                await Context.Instance.wsapi.credentialContract.onUpdateValidationSelection.Unsub();
                await Context.Instance.wsapi.credentialContract.onUpdateValidationSelectionData.Unsub();
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
