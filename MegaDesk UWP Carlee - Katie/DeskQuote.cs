using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            [Display(Name = "Three Day")]
            Rush3Days,
            [Display(Name = "Five Day")]
            Rush5Days,
            [Display(Name = "Seven Day")]
            Rush7Days,
            [Display(Name = "Five Day")]
            Normal14Days
        }

        //properties of desk quote
        public Desk desk { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Shipping ShippingType { get; set; }
        public float QuoteAmount { get; set; }
    }
}
