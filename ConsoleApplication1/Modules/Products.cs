using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Modules
{
    public class Product
    {
        public Product() : this("") { }
        public Product(string Pin) : this(Pin, "") { }

        public Product(string Pin, string Brand) : this(Pin, Brand, "") { }

        public Product(string Pin, string Brand, string Name)
        {
            this.Pin = Pin;
            this.Brend = Brend;
            this.Name = Name;
        }

        public string Pin { get; set; }
        public string Brend { get; set; }
        public string Name { get; set; }
        public bool Analogs { get; set; }
        public string ArtID { get; set; }
        private double Price_;
        public double Price
        {
            get { return Price_; }
            set
            {
                if (value > 0)
                    Price_ = value;
                else
                    Price_ = 0;

                //(value > 0) ? Price_ = value : Price_ = 0;
            }
        }

        public static void printInfo(List<Product> Products)
        {
            foreach (Product item in Products)
            {

                string info = string.Format("# {0} Pin: {1} \tBrand: {2} \tName: {3}", 1, item.Pin, item.Brend, item.Name);
                Console.WriteLine(info);
            }
        }
    }
}
