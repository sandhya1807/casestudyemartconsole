using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    class seller
    {
        private int sid;
        private string password;
        private string sname;
        private string email;
        private string postalAddress;
        private string gSTIN;
        private String bankdetails;

        public int Sid { get => sid; set => sid = value; }
        public string Password { get => password; set => password = value; }
        public string Sname { get => sname; set => sname = value; }
        public string Email { get => email; set => email = value; }
        public string PostalAddress { get => postalAddress; set => postalAddress = value; }
        public string GSTIN { get => gSTIN; set => gSTIN = value; }
        public string Bankdetails { get => bankdetails; set => bankdetails = value; }

        public seller(int sid, string password, string sname, string email, string postalAddress, string GSTIN, string Bankdetails)
        {
            this.sid = sid;
            this.password = password;
            this.sname = sname;
            this.email = email;
            this.postalAddress = postalAddress;
            this.GSTIN = GSTIN;
            this.Bankdetails = Bankdetails;

        }

    }
}