using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    public sealed partial class ViewAllQuotes : Page
    {

        /*
        private object localFolder;
        private object JsonConvert;

        public ViewAllQuotes()
        {
            this.InitializeComponent();
        }

         internal async Task<object> ReadConfigAsync()
        {
            try
            {                
                await AddConfigAsync();
                StorageFile ConfigFile = await localFolder.GetFileAsync("rushOrder.json");
                //Decrypt data
                string StringList = await FileIO.ReadTextAsync(ConfigFile);


                DeskQuote resultTemp = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<DeskQuote>(StringList));
               

                return resultTemp;
            }
            catch (Exception)
            {
                return null;
            }
        
    }

        private Task AddConfigAsync()
        {
            throw new NotImplementedException();
        }
        */
    }
}

