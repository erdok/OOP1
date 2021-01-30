using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string ProductNamne { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
