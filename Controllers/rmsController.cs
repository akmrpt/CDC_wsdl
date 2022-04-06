using Emarwsdl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using System.Data.SqlClient;
 


namespace Emarwsdl.Controllers
{
    public class rmsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult RecEmar (EmarkData _obj) 
        {

            //   _obj.ToString(); 


            string msgCode = "";
            string msg = "";

            string cs = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_WSDL_Earmarking";

                cmd.Parameters.AddWithValue("@TrnYear", _obj.TrnYear);
                cmd.Parameters.AddWithValue("@TrnId", _obj.TrnId);
                cmd.Parameters.AddWithValue("@Broker", _obj.Broker);
                cmd.Parameters.AddWithValue("@ElementID", _obj.ElementID);
                cmd.Parameters.AddWithValue("@AccountNumber", _obj.AccountNumber);
                cmd.Parameters.AddWithValue("@SecuritySymbol", _obj.SecuritySymbol);
                cmd.Parameters.AddWithValue("@TradeDirection", _obj.TradeDirection);
                cmd.Parameters.AddWithValue("@Quantity", _obj.Quantity);
                cmd.Parameters.AddWithValue("@Cash", _obj.Cash);
                cmd.Parameters.AddWithValue("@TradeDate",_obj.TradeDate) ; 


                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    msgCode = rdr["msgCode"].ToString();
                    msg = rdr["msg"].ToString();

                }
            }

            Response Robj = new Response();
            Robj.Code = msgCode;
            Robj.Description = msg; //  +_obj.UserID.ToString();
        

            return Ok(Robj); 
        }

        
    }
}
