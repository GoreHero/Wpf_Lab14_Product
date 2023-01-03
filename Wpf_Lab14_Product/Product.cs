using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Lab14_Product
{
    public enum ProductTypes
    {
        Food,
        present
    }
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductCost { get; set; }
        public string LinkPath { get; set; }
        public bool Appointment { get; set; }
        public ProductTypes ProductType { get; set; }

    }
}
