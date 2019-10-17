using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using QLVT_Database;

namespace QLVT_API.Controllers
{
    public class KhoController : ApiController
    {
        private QL_VATTUEntities db = new QL_VATTUEntities();

        // GET: api/Kho
        public IEnumerable<SP_KHO_Result> GET()
        {
            return db.SP_KHO();
        }

        public IEnumerable<SP_KHObyId_Result> GET(string id)
        {
            return db.SP_KHObyId(id);
        }

        
    }
}