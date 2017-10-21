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

        static int basePrice = 200;
        static int costPerDrawer = 50;

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

            // number of drawers
            List<int> drawerNumber = new List<int>();
            drawerNumber.Add(0);
            drawerNumber.Add(1);
            drawerNumber.Add(2);
            drawerNumber.Add(3);
            drawerNumber.Add(4);
            drawerNumber.Add(5);
            drawerNumber.Add(6);
            drawerNumber.Add(7);

            ComBoxNumberDrawers.ItemsSource = drawerNumber;
        }

        Desk desk = new Desk();
        DeskQuote quote = new DeskQuote();

        // but save and display quote
        private void butDisplay_Click(object sender, RoutedEventArgs e)
        {
            // set desk values to user input
            desk.DeskWidth = float.Parse(txtBoxWidth.Text);
            desk.DeskDepth = float.Parse(txtBoxDepth.Text);
            //desk.NumDrawer = (sender as ComboBox).SelectedItem as string;

            // set deskQuote values to user input
            quote.CustomerName = txtBoxName.Text;
            quote.desk = desk;
            quote.QuoteDate = DateTime.Now;
                                  
            int drawerPrice = getDrawerPrice(desk.NumDrawer);
            float surfaceArea = getSurfaceArea(desk.DeskWidth, desk.DeskDepth);
            float surfaceAreaPrice = getSurfaceAreaPrice(surfaceArea);
            int surfaceMaterialPrice = getSurfaceMaterialPrice(desk.SurfaceMaterial.ToString());
            int orderPrice = getOrderPrice(surfaceArea, quote.ShippingType.ToString());
            quote.QuoteAmount = getQuotePrice(drawerPrice,
                surfaceAreaPrice,
                surfaceMaterialPrice,
                orderPrice);

            // takes this frame and opens up Display Quote frame and needs to pass parameter addQuote to Display quote frame
            this.Frame.Navigate(typeof(DisplayQuote), quote);

        }

        // Calculate cost of drawers
        public int getDrawerPrice(int numberOfDrawers)
        {
            int cost = (costPerDrawer * numberOfDrawers);
            return cost;
        }

        // Get surface area.
        public float getSurfaceArea(float width, float depth)
        {
            float area = (width * depth);
            return area;
        }

        // Calculate cost of surface area.
        public float getSurfaceAreaPrice(float surfaceArea)
        {
            float price;
            if (surfaceArea <= 1000)
            {
                price = 0;
            }
            else
            {
                price = (surfaceArea - 1000);
            }
            return price;
        }

        // Calculates cost of material.
        public int getSurfaceMaterialPrice(string material)
        {
            int cost;
            switch (material)
            {
                case "Oak":
                    cost = 200;
                    return cost;
                case "Laminate":
                    cost = 100;
                    return cost;
                case "Pine":
                    cost = 50;
                    return cost;
                case "Rosewood":
                    cost = 300;
                    return cost;
                case "Veneer":
                    cost = 125;
                    return cost;
                default:
                    cost = 0;
                    return cost;
            }
        }

        // Calculate order type cost
        public int getOrderPrice(double surfaceArea, string orderType)
        {
            int cost;

            switch (orderType)
            {
                case "Rush3Days":
                    if (surfaceArea < 1000)
                    {
                        cost = 60;
                        return cost;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        cost = 70;
                        return cost;
                    }
                    else
                    {
                        cost = 80;
                        return cost;
                    }
                case "Rush5Days":
                    if (surfaceArea < 1000)
                    {
                        cost = 40;
                        return cost;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        cost = 50;
                        return cost;
                    }
                    else
                    {
                        cost = 60;
                        return cost;
                    }
                case "Rush7Days":
                    if (surfaceArea < 1000)
                    {
                        cost = 30;
                        return cost;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        cost = 35;
                        return cost;
                    }
                    else
                    {
                        cost = 40;
                        return cost;
                    }
                default:
                    cost = 0;
                    return cost;
            }       
        }

            public float getQuotePrice(int drawerPrice,
                float surfaceAreaPrice,
                int surfaceMaterialPrice,
                int orderPrice)
            {
                float quotePrice = (drawerPrice
                    + surfaceAreaPrice
                    + surfaceMaterialPrice
                    + orderPrice
                    + basePrice);
                return quotePrice;
            }

            // widht combo box
            private void ComBoxWidth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string width = (sender as ComboBox).SelectedItem as string;
            desk.DeskWidth = int.Parse(width);

        }

        // go back to menu button
        private void butBackMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void ComBoxMaterial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string material = (sender as ComboBox).SelectedItem.ToString();

            switch (material)
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
        }

        private void ComBoxNumberDrawers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string drawers = ComBoxNumberDrawers.SelectedItem.ToString();

            desk.NumDrawer = int.Parse(drawers);
        }

        private void ComBoxShipping_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string shipping = (sender as ComboBox).SelectedItem.ToString();

            switch (shipping)
            {
                case "Rush3Days":
                    quote.ShippingType = DeskQuote.Shipping.Rush3Days;
                    break;
                case "Rush5Days":
                    quote.ShippingType = DeskQuote.Shipping.Rush5Days;
                    break;
                case "Rush7Days":
                    quote.ShippingType = DeskQuote.Shipping.Rush7Days;
                    break;
                case "Normal14Days":
                    quote.ShippingType = DeskQuote.Shipping.Normal14Days;
                    break;
            }
        }
    }
}
