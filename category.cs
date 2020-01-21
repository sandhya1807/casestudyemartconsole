using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    public class Category
    {
        private int cid;
        private string cname;
        private string details;

        public int Cid { get => cid; set => cid = value; }
        public string Cname { get => cname; set => cname = value; }
        public string Details { get => details; set => details = value; }
    }
}