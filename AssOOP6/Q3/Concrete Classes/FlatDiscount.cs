using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssOOP6.Q3.Abstract;

namespace AssOOP6.Q3.Concrete_Classes
{
    internal class FlatDiscount:Discount
    {
        public FlatDiscount(decimal fixedAmount):base("FlatDiscount")
        {
            FixedAmount = fixedAmount;
            
        }

        public  decimal FixedAmount { get; set; }

        public override decimal CalculateDiscount(decimal price, int quatity)
        {
            return FixedAmount*Math.Min(quatity,1);

        }
    }
}
