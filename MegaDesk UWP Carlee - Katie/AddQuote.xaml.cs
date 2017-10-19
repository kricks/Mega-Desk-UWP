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

        public string CustomerName { get; set; }
        public double DeskWidth { get; set; }
        public double Depth { get; set; }
        public int NumDrawer { get; set; }
        public string SurfaceMaterial { get; set; }
        public int ShippingDays { get; set; }

        enum Material
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }

        enum RushDays
        {
            Days3,
            Days5,
            Days7,
            NormalDays14
        }

        public AddQuote()
        {
            this.InitializeComponent();
        }


        // but save and display quote
        private void butDisplay_Click(object sender, RoutedEventArgs e)
        {
            AddQuote addQuote = new AddQuote();

            this.Frame.Navigate(typeof(DisplayQuote), addQuote);
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
