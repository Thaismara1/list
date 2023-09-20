using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list.models
{
    public class product
    {
        public int price { get; set; }

        public string title { get; set; }

        public product(string _title, int _price)
        {
            price = _price;
            title = _title;
        }

        public override string ToString()
        {
            return $"{title} {price}";
        }
    }

}
