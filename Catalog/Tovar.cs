using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class Tovar
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public double Price { get; set; }

        public Tovar()
        {
            Name = "unknown";
            Country = "unknown";
            Price = 0;
        }
        public Tovar(string name, string country, double price)
        {
            Name = name;
            Country = country;
            Price = price;

        }
        public override string ToString()
        {
            return $"Наименование: {Name}, Страна производитель: {Country}, Цена: {Price}";
        }
    }
}
