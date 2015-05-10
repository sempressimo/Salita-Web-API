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
    public class VisitController : ApiController
    {
        public IEnumerable<v_RecentVisits> GetAllVisits()
        {
            SalitaEntities db = new SalitaEntities();

            var v = db.v_RecentVisits.Where(p => p.InLounge == true);

            int Count = v.Count();

            return v;
        }
    }
}
