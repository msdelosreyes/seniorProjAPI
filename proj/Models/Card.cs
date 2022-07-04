using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentAuthorizationWebAPI_CIS4290.Models
{
    public class Card
    {
        public string LoginId { get; set; }
        public string CardName { get; set; }

        public string CardNum { get; set; }

        public DateTime CardExp { get; set; }

        public int CardCVV { get; set; }

        public int DonAmt { get; set; }
    }
}