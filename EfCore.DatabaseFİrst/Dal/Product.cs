using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.DatabaseFirst.Dal
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // db'de nullalbe tanımladık.
        public int? Stock { get; set; }
    }
}
