using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Emarwsdl.Models;
using Newtonsoft.Json;

namespace Emarwsdl.Controllers
{
    public class TestController : ApiController
    {
        [HttpPost]
        public IHttpActionResult test(Test _obj)
        {
            Response Robj = new Response();
            Robj.Code = "00";
            Robj.Description = "Your Test Message : " + _obj.msg.ToString(); //  +_obj.UserID.ToString();
           

            return Ok(Robj); 
        }
    }
}
