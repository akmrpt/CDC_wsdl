using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emarwsdl.Models
{
    public class CustodyAccountInfo
    {
        public string userId { get; set; }
        public string password { get; set; }
        public string brokerShortCode { get; set; }
        public string cnicNicopPoc { get; set; }
        public string cdcParticipantId { get; set; }
        public string cdcAccountNumber { get; set; }
        public string accOpeningDate { get; set; }
        public string reserved { get; set; }
    }
}