using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    public class sellerBo
    {
        static List<seller> slist = new List<seller>();
        List<Items> li = new List<Items>();
        static int sellerid;
        List<SubCategory> lsc = new List<SubCategory>();

        public void InitializeSellerList(int sid, string password, string sname, string email, string postalAddress, string GSTIN, string Bankdetails)
        {

            slist.Add(new seller(sid, password, sname, email, postalAddress, GSTIN, Bankdetails));


        }

        public bool checkseller(int sid, string password)
        {

            seller so = slist.Find(e => e.Sid == sid && e.Password == password);
            if (so != null)
            {
                sellerid = sid;
                return true;
            }
            else
            {

                return false;
            }
        }
        public void DisplayDetailsseller(int sid)
        {
            seller sell = slist.Find(e => e.Sid == sid);
            Console.WriteLine("Details...............");
            Console.WriteLine("Id : " + sell.Sid);
            Console.WriteLine("Name : " + sell.Sname);
            Console.WriteLine("Email  : " + sell.Email);
            Console.WriteLine("Company address : " + sell.PostalAddress);
            Console.WriteLine("GSTIN : " + sell.GSTIN);
            Console.WriteLine("Bank Details  : " + sell.Bankdetails);

        }
        public void Displayproducts(int sid)
        {
            ItemsBO io = new ItemsBO();
            List<Items> tl1 = io.DisplaySellerProducts(sid);

           

            foreach (Items j in tl1)
            {


                Console.WriteLine("Item Id :" + j.Iid + "  IteamNeam  :" + j.Itemname + "   stocknumber :" + j.Stock_number + "   price :" + j.Price + "   remarks :" + j.Remarks + "\n" +
                    j.sbo.Cid + " Category name :" + j.sbo.Cname + " category details :" + j.sbo.Details);

            }
        }
    }
}