using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentAuthorizationWebAPI_CIS4290.Models
{
    public class User
    {
        public int Id { get; set; } = 0;
        public string Login { get; set; } = "";
        public string TransactionKey { get; set; } = "";
    }
}