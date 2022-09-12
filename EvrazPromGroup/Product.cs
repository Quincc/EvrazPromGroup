using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvrazPromGroup
{
    public class Product
    {
        //private string name;
        //private string codebar;
        //private double price;
        //private double quantity;
        //private Status status;
        public int Id { get; set; }
        public string Codebar { get; set; }
        public string Сustomer { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
    }
}
