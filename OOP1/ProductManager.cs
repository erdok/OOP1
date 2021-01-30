using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) // (strig isim ) ile aynı
        {
            Console.WriteLine(product.ProductNamne + "eklendi");

        }

        public void Update (Product product)  // void emir kipi git yap işlemlerini yapar
        {
            Console.WriteLine(product.ProductNamne +"güncellendi");

        }

       
    }

}
