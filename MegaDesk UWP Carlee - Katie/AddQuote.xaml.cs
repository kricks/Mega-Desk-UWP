using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MegaDesk_UWP_Carlee___Katie
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddQuote : Page
    {


        public AddQuote()
        {
            this.InitializeComponent();

            // material
            List<Desk.Material> materials = new List<Desk.Material>();

            foreach (Desk.Material deskMaterial in Enum.GetValues(typeof(Desk.Material)))
                materials.Add(deskMaterial);

            ComBoxMaterial.ItemsSource = materials;

            // shipping 
            List<DeskQuote.Shipping> shipping = new List<DeskQuote.Shipping>();

            foreach (DeskQuote.Shipping rushDays in Enum.GetValues(typeof(DeskQuote.Shipping)))
                shipping.Add(rushDays);

            ComBoxShipping.ItemsSource = shipping;
        }


        // but save and display quote
        private void butDisplay_Click(object sender, RoutedEventArgs e)
        {
            Desk desk = new Desk();

            switch (ComBoxMaterial.DataContext)
            {
                case "Oak":
                    desk.SurfaceMaterial = Desk.Material.Oak;
                    break;
                case "Laminate":
                    desk.SurfaceMaterial = Desk.Material.Laminate;
                    break;
                case "Pine":
                    desk.SurfaceMaterial = Desk.Material.Pine;
                    break;
                case "Rosewood":
                    desk.SurfaceMaterial = Desk.Material.Rosewood;
                    break;
                case "Veneer":
                    desk.SurfaceMaterial = Desk.Material.Veneer;
                    break;
            }

            DeskQuote quote = new DeskQuote();

            quote.CustomerName = txtBoxName.Text;
            quote.desk = desk;

            switch (ComBoxShipping.DataContext)
            {
                case "Three Days":
                    quote.ShippingType = DeskQuote.Shipping.Rush3Days;
                    break;
                case "Five Days":
                    quote.ShippingType = DeskQuote.Shipping.Rush5Days;
                    break;
                case "Seven Days":
                    quote.ShippingType = DeskQuote.Shipping.Rush7Days;
                    break;
                case "Normal - Fourteen Days":
                    quote.ShippingType = DeskQuote.Shipping.Normal14Days;
                    break;
            }

            // takes this frame and opens up Display Quote frame and needs to pass parameter addQuote to Display quote frame
           this.Frame.Navigate(typeof(DisplayQuote), quote);
        }


        // go back to menu button
        private void butBackMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        // widht combo box
        private void ComBoxWidth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            /* tryto grab data
            var container = sender as ComboBox;
            var selected = container.SelectedItem as ComboBoxItem;

            if (selected != null)
            {
                var width = selected.ComBoxWidth as Int32; //(string or a class)
                if (width != null)
                {
                    // what do i put here?
                }
            }
            */

        }

        private void ComBoxMaterial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboResult == null) return;

            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            ComboResult.Text = item.Content.ToString();
        }
    }
}
