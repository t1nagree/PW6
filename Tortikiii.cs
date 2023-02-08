using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp26
{
    internal class Tort
    {
        public int PriceForm;
        public int PriceHuge;
        public int PriceTaste;
        public int PriceAmount;
        public int PriceGlaze;
        public int PriceBeautiful;

        public string NameForm;
        public string NameHuge;
        public string NameTaste;
        public string NameAmount;
        public string NameGlaze;
        public string NameBeautiful;
        public static List<Tort> FinalTort = new List<Tort>();
        public int Sum() => this.PriceBeautiful + this.PriceTaste + this.PriceGlaze + this.PriceForm + this.PriceHuge;


        public Tort(int price = 0, string Fname = "",
            string Rname = "", string Vname = "", string Kname = "",
            string Gname = "", string Dname = "")
        {
            this.PriceForm = price;
            this.NameForm = Fname;
            this.NameHuge = Rname;
            this.NameTaste = Vname;
            this.NameAmount = Kname;
            this.NameGlaze = Gname;
            this.NameBeautiful = Dname;
        }
    }
}