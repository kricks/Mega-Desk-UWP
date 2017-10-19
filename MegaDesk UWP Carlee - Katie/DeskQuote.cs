using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_UWP_Carlee___Katie
{
    class DeskQuote
    {
        //enums
        public enum Shipping
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }

        //properties of desk quote
        public Desk desk { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Shipping ShippingType { get; set; }
        public decimal QuoteAmount { get; set; }
    }
}
