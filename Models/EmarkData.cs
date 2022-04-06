using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emarwsdl.Models
{
    public class EmarkData
    {
        public string  UserID { get; set; }
        public string  Password { get; set; }
        public int TrnYear { get; set; }
        public int TrnId { get; set; }

        public string  Broker { get; set; }
        public string  ElementID { get; set; }

        public int AccountNumber { get; set; }
        public string  SecuritySymbol { get; set; }

        public string TradeDirection  { get; set; }
        public long Quantity { get; set; }
        public double Cash { get; set; }

        public string  TradeDate { get; set; }

    }
}