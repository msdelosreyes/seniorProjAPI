using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentAuthorizationWebAPI_CIS4290.Models
{
    public class Login
    {
        public string LoginID { get; set; }

        public string TransactionKey { get; set; }
    }
}