using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LoungeWebApi.Controllers
{
    [EnableCors(origins: "http://salita.azurewebsites.net", headers: "*", methods: "*")]
    public class CustomerController : ApiController
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            SalitaEntities db = new SalitaEntities();

            return db.Customers;
        }

        public IHttpActionResult GetCustomer(string Phone)
        {
            SalitaEntities db = new SalitaEntities();

            var c = db.Customers.FirstOrDefault((p) => p.Phone == Phone);
            if (c == null)
            {
                return NotFound();
            }
            return Ok(c);
        }
    }
}
