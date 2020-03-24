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
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LTOKiosk.Class;
using System.IO;
using System.Runtime.Serialization.Json;
using static LTOKiosk.Class.LTOVehicles;

namespace LTOKiosk.Views
{
    /// <summary>
    /// Interaction logic for EnterPlateView.xaml
    /// </summary>
    public partial class EnterPlateView : UserControl
    {
        private static readonly HttpClient client = new HttpClient();
        public Rootobject rootObject;
        public EnterPlateView()
        {
            InitializeComponent();
        }


        private void RichTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
            TextRange range = new TextRange(RichTextBox1.CaretPosition, RichTextBox1.CaretPosition);
            range.Text = e.TextComposition.Text.ToUpper();

            RichTextBox1.CaretPosition = range.End.GetInsertionPosition(LogicalDirection.Forward);

            e.Handled = true;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var responseString = await client.GetStringAsync("https://api.roadready.com.ph/vehicle?plate=BGPOOS");
          
            this.Content = new VehicleDetailsView();
            rootObject = new Rootobject(responseString);
            System.Diagnostics.Debug.WriteLine(responseString);
        }

       

    }
}

 
