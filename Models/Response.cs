using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emarwsdl.Models
{
    public class Response
    {
        public string Code { get; set; }
        public string  Description { get; set; }
    }

    public class Response2
    {
        public string  response { get; set; }
        public string responseCode { get; set; }
        public string errorDescription { get; set; }

    }
}