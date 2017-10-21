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
            [Display(Name = "Three Days")]
            Rush3Days,
            [Display(Name = "Five Days")]
            Rush5Days,
            [Display(Name = "Seven Days")]
            Rush7Days,
            [Display(Name = "Five Days")]
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
