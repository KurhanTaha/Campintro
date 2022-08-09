namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ProductName1 = "Apple";
            string Desciption = "Amasya apple";
            double Cost = 15;

            string[] fruits = new string[] {"Elma" , "Karpuz"};

            Product product1 = new Product();
            product1.Desciption = "Perfect apple";
            product1.ProductName = "Apple";
            product1.Cost = 15.75;
            product1.Id = 200254030;

            Product product2 = new Product();
            product2.ProductName = "Watermelon";
            product2.Cost = 55;
            product2.Desciption = "NumberOneWatermelon";
            product2.Id = 200254034;

            Product[] products = new Product[] {product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Desciption);
                Console.WriteLine(product.Cost);
                Console.WriteLine(product.Id);
                Console.WriteLine(product.ProductName);
                Console.WriteLine("---------------------------");

            }

            Console.WriteLine("-----------Methods----------------");
            //instance- örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            //ekle 2 yerine class kullan daha yararlı
            sepetManager.Ekle2("Elma", "Cok güzel", 15);
        }
    }
}