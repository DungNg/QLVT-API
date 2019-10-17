using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLVT_Database;

namespace QLVT_API.Controllers
{
    public class CT_PhatsinhController : ApiController
    {
        private QL_VATTUEntities db = new QL_VATTUEntities();
        public IEnumerable<SP_CT_PHATSINH_Result> GET()
        {
            return db.SP_CT_PHATSINH();
        }

        public IEnumerable<SP_CT_PHATSINHbyId_Result> GET(string id)
        {
            return db.SP_CT_PHATSINHbyId(id);
        }
    }
}
