using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PaymentAuthorizationWebAPI_CIS4290.Models;

namespace WebApplicationProject4290.Models
{
    public class DataAccessLayer
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapicon"].ConnectionString);
        SqlDataAdapter da = null;
        DataTable dt = null;

        public string GetLogin(Login login)
        {
            da = new SqlDataAdapter(
                "Select * From Users where LoginID = '"+ login.LoginID + "' and TransactionKey = '" + login.TransactionKey + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return "Logged In";
            else
                return "Not valid user";
        }

        public string GetPmt(Card card)  
        {
            da = new SqlDataAdapter(
                "Select * From CreditCard Where CardHolder = '" + card.CardName + "' and CardNumber = '" + card.CardNum +
                "' and CVV = '" + card.CardCVV + "' and CardEXP = '" + card.CardExp + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
                return "Card invalid";

            DateTime expVal = (DateTime)dt.Rows[0][3];
            string creditFundStr = dt.Rows[0][5].ToString();
            int creditFundVal = Convert.ToInt32(creditFundStr);
            string holdVal = dt.Rows[0][6].ToString();
            
            DateTime now = DateTime.Now;
            int dtComp = DateTime.Compare(now, expVal);

            if (dt.Rows.Count > 0 && holdVal == "no " && dtComp < 0 && card.DonAmt < creditFundVal)
                return "Payment confirmed. Authorization Code: " + rngString();
            else if (holdVal == "yes")
                return "Card is on hold";
            else if (dtComp > 0)
                return "Card is expired";
            else if (card.DonAmt > creditFundVal)
                return "Insufficient funds";
            else
                return "Card invalid";
        }

        private string rngString ()
        {
            var randNum = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 20; i++)
                sb.Append(randNum.Next(0, 9));

            return sb.ToString();
        }
    }
}