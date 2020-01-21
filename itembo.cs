using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    public class ItemsBO
    {
        static List<Items> li = new List<Items>();
        static List<SubCategory> lsc = new List<SubCategory>();
        public void Additems(int cid, string cname, int sbid, string sbname, string details, float GST, int iid, string itemname, double price, string description, int stock_number, string remarks, int sid)
        {
            SubCategory sco = new SubCategory(sbid, cid, cname, sbname, details, GST);
            lsc.Add(sco);
            Items i = new Items(iid, price, itemname, description, stock_number, remarks, sid, sco);
            li.Add(i);
            Console.Write("The items added are : \n");
            foreach (Category ij in lsc)
            {
                Console.WriteLine("CategoryId :" + ij.Cid + "   Category Name :" + ij.Cname + "  Category Details :" + ij.Details);

            }
            foreach (SubCategory ik in lsc)
            {


                Console.WriteLine("SubCategory Id :" + ik.Sbid + "  SubCategory Name :" + ik.Sbname + "   SubCategory Desc :" + ik.Details); ;

            }


            foreach (Items j in li)
            {


                Console.WriteLine("Item Id :" + j.Iid + "  ItemNeam  :" + j.Itemname + "   stocknumber :" + j.Stock_number + "   price :" + j.Price + "   remarks :" + j.Remarks);

            }
        }

        public List<Items> DisplaySellerProducts(int sellerid)
        {
            List<Items> tp = li.Where(e => e.Sid == sellerid).ToList();
            return tp;
        }
        public void DisplaybuyerProducts()
        {

            Console.WriteLine("Category Id \t Category Name \t  Category Desc");
            foreach (Category i in lsc)
            {
                Console.WriteLine(i.Cid + "\t\t" + i.Cname + "\t\t" + i.Details);
            }
            Console.WriteLine("Enter Cid for which you want to go to Subcategory");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("SubCategory Id \t\t SubCategory Name  \t \t SubCategory Desc");

            foreach (SubCategory i in lsc)
            {
                if (i.Cid == ch)
                {

                    Console.WriteLine(i.Sbid + "\t\t" + i.Sbname + "\t\t" + i.Details);
                }
            }
            Console.WriteLine("Enter scid for which you want to go to Items");
            int ch1 = int.Parse(Console.ReadLine());
            foreach (Items jk in li)
            {
                if (jk.Iid == ch1)
                {

                    Console.WriteLine("Item id :" + jk.Iid + "\t\tItem name :" + jk.Itemname + "\t\tItem price :" + jk.Price + "\t\tStock number :" + jk.Stock_number + "\t\tItem Description :" + jk.Remarks);
                }
            }
        }

        public void SearchByName()
        {
            int flag = 0;
            string s = "";
            Console.WriteLine("Enter Item Name that you want to search");
            String name = Console.ReadLine();
            foreach (Items i in li)
            {

                if (i.Itemname == name)
                {
                    s = "Item Id : " + i.Iid + "\t\t Item Name : " + i.Itemname + "  \t\t Item Price : " + i.Price + "\t stock number : " + i.Stock_number + " \t Item Description:" + i.Remarks;

                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;

                }
            }

            if (flag == 1)
                Console.WriteLine("Item Not Found");
            else
            {

                Console.WriteLine(s);
            }
        }


        public void SearchById()
        {
            int flag = 0;
            string s = "";
            Console.WriteLine("Enter Item ID that you want to search");
            int id = int.Parse(Console.ReadLine());
            foreach (Items i in li)
            {

                if (i.Iid == id)
                {

                    s = "Item Id : " + i.Iid + "\t\t Item Name : " + i.Itemname + " \t \t Item Price : " + i.Price + "\t\t stock number : " + i.Stock_number + " \t\t Item Description:" + i.Remarks;

                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;

                }
            }

            if (flag == 1)
                Console.WriteLine("Item Not Found");
            else
            {

                Console.WriteLine(s);
            }
        }
        public void SearchByPrice()
        {
            Console.WriteLine("Enter Item price range  that you want to search:");
            Console.WriteLine("Enter minimum price :");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter maximum price :");
            int max = int.Parse(Console.ReadLine());
            int flag = 0;
            string s = "";
            foreach (Items i in li)
            {

                if (i.Price > min && i.Price < max)
                {
                    s += "Item Id : " + i.Iid + "\t Item Name : " + i.Itemname + "  \t Item Price : " + i.Price + "\t stock number : " + i.Stock_number + " \t Item Description:" + i.Remarks + "\n";

                    flag = 0;

                }
                else
                {
                    flag = 1;

                }
            }

            if (flag == 1)
                Console.WriteLine("Item Not Found");
            else
            {
                Console.WriteLine(s);
            }
        }

        public void SearchByCategory()
        {
            int flag = 0;
            string s = "";
            Console.WriteLine("Enter Item Category that you want to search");
            String name = Console.ReadLine();
            foreach (Category scb in lsc)
            {

                if (scb.Cname == name)
                {

                    foreach (Items i in li)
                        s = "Item Id : " + i.Iid + "\t Item Name : " + i.Itemname + "  \t Item Price : " + i.Price + "\t stock number : " + i.Stock_number + " \t Item Description:" + i.Remarks;

                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;
                }
            }

            if (flag == 1)
                Console.WriteLine("Item Not Found");
            else
            {

                Console.WriteLine(s);
            }
        }


        public void BuyIteam()
        {
            int flag = 0;
            string s = "";
            Console.WriteLine("Enter Item Name to Buy :");
            String name = Console.ReadLine();
            foreach (Items i in li)
            {

                if (i.Itemname == name)
                {

                    // Console.WriteLine("Item Id : " + i.iid + "\t Item Name : " + i.itemname + "  \t Item Price : " + i.price + "\t stock number : " + i.stock_number + " \t Item Description:" + i.remarks);
                    // foreach (Items i in li)
                    s = "Item Id : " + i.Iid + "\n Item Name : " + i.Itemname + "  \n Item Price : " + i.Price + "\n stock number : " + i.Stock_number + " \n Item Description:" + i.Remarks;

                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;
                    //  Console.WriteLine("iteam not found");
                }
            }

            if (flag == 1)
                Console.WriteLine("Item Not Found");
            else
            {
                // Console.WriteLine("Item Id \t Item Name  \t Item Price\t stock number  \t Item Description");
                Console.WriteLine("purchased Iteam Details :\n");
                Console.WriteLine(s);
            }
        }



    }

}
