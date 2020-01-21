using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    public class Items
    {
        private int iid;
        private double price;
        private string itemname;
        private string description;
        private int stock_number;
        private string remarks;
        private int sid;
        public SubCategory sbo;

        public int Iid { get => iid; set => iid = value; }
        public double Price { get => price; set => price = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public string Description { get => description; set => description = value; }
        public int Stock_number { get => stock_number; set => stock_number = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public int Sid { get => sid; set => sid = value; }

        public Items(int iid, double price, string itemname, string description, int stock_number, string remarks, int sid, SubCategory sco)
        {
            this.iid = iid;
            this.price = price;
            this.itemname = itemname;
            this.Description = description;
            this.Stock_number = stock_number;
            this.Remarks = remarks;
            this.sid = sid;
            this.sbo = sco;

        }

    }
}