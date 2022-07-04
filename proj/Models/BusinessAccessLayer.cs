using PaymentAuthorizationWebAPI_CIS4290.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationProject4290.Models
{
    public class BusinessAccessLayer
    {
        public string GetLogin(Login login)
        {
            DataAccessLayer dal = new DataAccessLayer();
            string response = dal.GetLogin(login);
            return response;
        }

        public string GetPmt(Card card)
        {
            DataAccessLayer dal = new DataAccessLayer();
            string response = dal.GetPmt(card);
            return response;
        }
    }
}