using PaymentAuthorizationWebAPI_CIS4290.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationProject4290.Models;

namespace WebApplicationProject4290.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public sealed class HttpContext : IServiceProvider
        {
            public object GetService(Type serviceType)
            {
                throw new NotImplementedException();
            }
        }

        [Route("api/values/GetLogin")]
        [HttpPost]
        public string GetLogin(Login login)
        {
            BusinessAccessLayer bal = new BusinessAccessLayer();
            string response = bal.GetLogin(login);
            
            return response;
        }

        [Route("api/values/GetPmt")]
        [HttpPost]
        public string GetPmt(Card card)
        {
            BusinessAccessLayer bal = new BusinessAccessLayer();
            string response = bal.GetPmt(card);
            return response;
        }
    }
}
