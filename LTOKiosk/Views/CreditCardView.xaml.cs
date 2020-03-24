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
    /// Interaction logic for CreditCardView.xaml
    /// </summary>
    public partial class CreditCardView : UserControl
    {
        public CreditCardView()
        {
            InitializeComponent();
        }

        private void CardNumber_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CardNumber.Text = "";
        }
    }
}
