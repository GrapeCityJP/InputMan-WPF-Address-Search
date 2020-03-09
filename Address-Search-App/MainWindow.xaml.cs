using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GrapeCity.Windows.JPAddress;

namespace Address_Search_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<AddressInfo> addressInfo1 = gcjpaddress1.GetAddress(gcmask1.Value, false, ZipCodeQueryMode.GeneralZipCode);
            foreach (AddressInfo val in addressInfo1)
            {
                gctextbox1.Text = val.Prefecture + val.City + val.Town + val.Area;
            }
        }
    }
}
