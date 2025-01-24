using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP6.Q3.Abstract
{
    internal abstract class Discount
    {
        protected Discount(string type)
        {
            this.type = type;
        }

        public  string type { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quatity);
    }
}
