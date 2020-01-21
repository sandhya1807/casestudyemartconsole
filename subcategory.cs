using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    public class SubCategory : Category
    {
        private int sbid;
        private string sbname;
        private float gST;

        public int Sbid { get => sbid; set => sbid = value; }
        public string Sbname { get => sbname; set => sbname = value; }
        public float GST { get => gST; set => gST = value; }

        public SubCategory(int sbid, int cid, string cname, string sbname, string details, float GST)
        {
            this.sbid = sbid;
            this.Sbname = sbname;
            this.Cname = cname;
            this.Cid = cid;
            this.Details = details;
            this.GST = GST;
        }
    }
}