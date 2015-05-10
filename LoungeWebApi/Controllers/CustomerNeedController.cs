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
    public class CustomerNeedController : ApiController
    {
        public IEnumerable<v_CustomerNeeds> GetAllNeeds()
        {
            SalitaEntities db = new SalitaEntities();

            return db.v_CustomerNeeds.Where(p => p.WasFullfilled == false).OrderBy(p => p.RequestDateTime);
        }
    }
}