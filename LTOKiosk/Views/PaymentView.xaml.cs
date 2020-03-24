using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LTOKiosk.Views
{
    /// <summary>
    /// Interaction logic for PaymentView.xaml
    /// </summary>
    public partial class PaymentView : UserControl
    {
        public PaymentView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (isCashPayment.IsChecked == true) {
                this.Content = new CashPaymentView();
            }
            else if (isCardPayment.IsChecked == true) 
            {
                this.Content = new CreditCardView();
            }
            else if (isGCashPayment.IsChecked == true)
            {
                this.Content = new GCashView();
            }
            else if (isPaymayaPayment.IsChecked == true)
            {
                this.Content = new PayMayaView();
            }
        }
    }
}
