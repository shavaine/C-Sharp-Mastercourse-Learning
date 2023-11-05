using MiniProjectWPFLibrary;
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
using System.Windows.Shapes;

namespace MiniProjectWPF
{
    /// <summary>
    /// Interaction logic for AddressEntry.xaml
    /// </summary>
    public partial class AddressEntry : Window
    {
        ISaveAddress _parent;
        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void saveAddressButton(object sender, RoutedEventArgs e)
        {
            AddressModel newAddress = new AddressModel();
            newAddress.Address = addressText.Text;
            newAddress.City = cityText.Text;
            newAddress.Region = regionText.Text;
            newAddress.PostalCode = postalCodeText.Text;
            newAddress.Country = countryText.Text;

            _parent.SaveAddress(newAddress);
            Close();
        }
    }
}
