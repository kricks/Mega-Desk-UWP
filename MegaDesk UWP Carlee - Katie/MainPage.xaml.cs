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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MegaDesk_UWP_Carlee___Katie
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        // add quote button
        private void butAddQuote_Click(object sender, RoutedEventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            this.Frame.Navigate(typeof(AddQuote));
        }

        // view quotes button
        private void butViewAllQuotes_Click(object sender, RoutedEventArgs e)
        {
            ViewAllQuotes viewQuotes = new ViewAllQuotes();
            this.Frame.Navigate(typeof(ViewAllQuotes));
        }

        // search quotes button
        private void butSearchQuotes_Click(object sender, RoutedEventArgs e)
        {
            SearchAllQuotes searchQuote = new SearchAllQuotes();
            this.Frame.Navigate(typeof(SearchAllQuotes));
        }

        //exit button
        private void butExit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
