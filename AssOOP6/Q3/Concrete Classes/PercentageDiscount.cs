using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssOOP6.Q3.Abstract;

namespace AssOOP6.Q3.Concrete_Classes
{
    internal class PercentageDiscount:Discount
    {
        public PercentageDiscount(decimal percentage) : base("PercentageDiscount")
        {
            Percentage = percentage;
        }

        public  decimal Percentage { get; set; }

        public override decimal CalculateDiscount(decimal price, int quatity)
        {
            return price * quatity * (Percentage / 100);
        }
    }
}
