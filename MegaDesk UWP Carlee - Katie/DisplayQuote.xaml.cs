﻿using System;
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
    public sealed partial class DisplayQuote : Page
    {
        public DisplayQuote()
        {
            this.InitializeComponent();                    
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Desk desk = e.Parameter as Desk;
            //DeskQuote quote = e.Parameter as DeskQuote;

            nameBox.Text = desk.CustomerName;
            widthBox.Text = desk.DeskWidth.ToString();
            depthBox.Text = desk.DeskDepth.ToString();
            drawersBox.Text = desk.NumDrawer.ToString();
            materialBox.Text = desk.SurfaceMaterial.ToString();
            shippingBox.Text = desk.ShippingType.ToString();
            priceBox.Text = desk.QuoteAmount.ToString();

        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
