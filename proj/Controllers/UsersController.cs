using PaymentAuthorizationWebAPI_CIS4290.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PaymentAuthorizationWebAPI_CIS4290.Controllers
{
    public class UsersController : ApiController
    {
        List<User> users = new List<User>();

        public UsersController()
        {
            users.Add(new Models.User { Login = "test", TransactionKey = "123", Id = 1 });
            users.Add(new Models.User { Login = "adroittom", TransactionKey = "456", Id = 2 });
            users.Add(new Models.User { Login = "tanya", TransactionKey = "789", Id = 3 });
        }

        // GET: api/Users
        public List<User> Get()
        {
            return users;
        }

        // GET: api/Users/5
        public User Get(int id)
        {
            return users.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/Users
        public void Post(User val)
        {
            users.Add(val);
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
            
        }
    }
}
