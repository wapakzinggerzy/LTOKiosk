using LTOKiosk.Class;
using LTOKiosk.ViewModels;
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
using static LTOKiosk.Class.LTOVehicles;

namespace LTOKiosk.Views
{
    /// <summary>
    /// Interaction logic for VehicleDetailsView.xaml
    /// </summary>
    public partial class VehicleDetailsView : UserControl
    {
        public LTOVehicles vehicles;
        

        public VehicleDetailsView()
        {
            InitializeComponent();
            vehicles = this.Resources["vehiclesData"] as LTOVehicles;
            DataContext = new EnterPlateView();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new RequirementCheckView();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = Rootobject.GetVehicle();

            if (vehicle != null) {
                Label plateLabel = this.FindName("plate_number") as Label;
                Label vehicleLabel = this.FindName("chassis_number") as Label;
                Label chassisLabel = this.FindName("mv_file_number") as Label;
                Label mv_typeLabel = this.FindName("mv_type") as Label;
                Label addressLabel = this.FindName("address") as Label;
                Label nameLabel = this.FindName("name") as Label;
                nameLabel.Content = vehicle.owner.name;
                vehicleLabel.Content = vehicle.chassis_number;
                plateLabel.Content = vehicle.plate_number;
                chassisLabel.Content = vehicle.mv_file_number;
                mv_typeLabel.Content = vehicle.engine_number;
                addressLabel.Content = vehicle.owner.address;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Content = new RequirementCheckView();
        }
    }
}
