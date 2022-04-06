using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using System.Data.SqlClient;
using Emarwsdl.Models;
using Newtonsoft.Json;

namespace Emarwsdl.Controllers
{
    public class sendCustodyAccountInfoController : ApiController
    {
        [HttpPost]
        public IHttpActionResult getAcc(CustodyAccountInfo _obj)
        {
            string sjson = "";
            string msgCode = "00";
            string msg = "";
            string msgError = "";
            // create a json from object 
            sjson = JsonConvert.SerializeObject(_obj);


            string cs = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_WSDL_sendCustodyAccountInfo";

                cmd.Parameters.AddWithValue("@json", sjson);


                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    msgCode = rdr["msgCode"].ToString();
                    msg = rdr["msg"].ToString();
                    msgError = rdr["msgError"].ToString();

                }
            }

            Response2 Robj = new Response2();
            Robj.responseCode = msgCode;
            Robj.response = msg; //  +_obj.UserID.ToString();
            Robj.errorDescription = msgError;

            return Ok(Robj);
        }
    }
}
