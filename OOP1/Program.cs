using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Category = 2;
            product1.ProductNamne = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            ProductManager productManager = new ProductManager();
            // string isim = "Engin"; üstekki ile alttaki aynı mantık
            productManager.Add();
        }
    }
}
