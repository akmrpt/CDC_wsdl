using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emarwsdl.Models
{
    public class getAccountInfo_obj
    {
        public string userId { get; set; }
        public string password { get; set; }
        public List<getAccountInfo_data> data { get; set; }

    }
}