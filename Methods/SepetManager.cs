using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        //Convention naming
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi" +" " + urun.ProductName);
        }

        public void Ekle2(string productName, string desciption, double fiyat)
        {
            Console.WriteLine("Sepete eklendi" + " " + productName);
        }
    }
}
