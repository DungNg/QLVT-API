using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using QLVT_Database;
using System.Data.Entity;
using System.Configuration;

namespace QLVT_API.Controllers
{
    public class VattuController : ApiController
    {
        // GET: Vattu
        private QL_VATTUEntities db = new QL_VATTUEntities();
        public IEnumerable<SP_VATTU_Result> GET()
        {
            int connStrCnt = ConfigurationManager.ConnectionStrings.Count;
            string csName = "ConnStr" + connStrCnt.ToString();
            System.Configuration.Configuration config = null;
            if (System.Web.HttpContext.Current != null)
            {
                config =
                    System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/");
            }
            else
            {
                config =
                    ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            }
            ConnectionStringsSection csSection = config.ConnectionStrings;
            csSection.ConnectionStrings.Add(new ConnectionStringSettings(csName,
                "metadata = res://*/QLVT_Model.csdl|res://*/QLVT_Model.ssdl|res://*/QLVT_Model.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DUNGNG\\SERVER;initial catalog=QL_VATTU;user id=sa;password=sa;MultipleActiveResultSets=True;App=EntityFramework&quot;", "System.Data.EntityClient"));
            return db.SP_VATTU().ToList();
        }
        public IEnumerable<SP_VATTUbyId_Result> GET(string mavt)
        {
            return db.SP_VATTUbyId(mavt).ToList();
        }

        public int POST(string mavt, string tenvt, string dvt)
        {
            try
            {
                return db.SP_InsertVattu(mavt, tenvt, dvt); //return 1 when success
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int PUT(string mavt,string tenvt,string dvt)
        {
            try
            {
                return db.SP_UpdateVattu(mavt, tenvt, dvt);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int DELETE(string mavt)
        {
            try
            {
                return db.SP_DeleteVattu(mavt);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}