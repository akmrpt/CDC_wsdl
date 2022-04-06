using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emarwsdl.Models
{
    public class getAccountInfo_data
    {
        public string bankid { get; set; }
        public string bankShortCode { get; set; }
        public string brokerShortCode { get; set; }
        public string fullName { get; set; }
        public string fatherSopuseName { get; set; }
        public string motherMaidenName { get; set; }
        public string dateofBirth { get; set; }


        public string placeofBirth { get; set; }
        public string cnicNicopPoc { get; set; }
        public string uinType { get; set; }
        public string cnicNicopPocDateofIssuance { get; set; }
        public string opfmembershipnumber { get; set; }
        public string passportNumber { get; set; }

        public string nationalities { get; set; }
        public string emailAddress { get; set; }
        public string landlineNumber { get; set; }
        public string cellNumber { get; set; }

        public string completeMailingAddress { get; set; }
        public string fatcaCRSDeclaration { get; set; }
        public string profession { get; set; }
        public string sourceofIncome { get; set; }
        public string existingBankAccountDetailsofcustomer { get; set; }
        public string ibanofNRANCAAccount { get; set; }
        public string uploadedFileNames { get; set; }
        public string numberofDocuments { get; set; }
        public string termsandconditionagreed { get; set; }

        public string selectedBroker { get; set; }
        public string securitymarket { get; set; }
        public string reserved { get; set; }
    }
}