using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLVT_Database;
namespace QLVT_API.Controllers
{
    public class NhanvienController : ApiController
    {
        readonly QL_VATTUEntities db = new QL_VATTUEntities();
        public IEnumerable<SP_NHANVIEN_Result> GET()
        {
            return db.SP_NHANVIEN().ToList();
        }
    }
}
