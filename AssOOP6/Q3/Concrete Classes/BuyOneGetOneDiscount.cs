using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssOOP6.Q3.Abstract;

namespace AssOOP6.Q3.Concrete_Classes
{
    internal class BuyOneGetOneDiscount:Discount
    {
        public BuyOneGetOneDiscount(string type) : base("BuyOneGetOne")
        {
           
        }

        //public BuyOneGetOneDiscount() {
        //    type = "BuyOneGetOne";
        //}
        public override decimal CalculateDiscount(decimal price, int quatity)
        {
            if (quatity > 2) {

                return (price / 2) * (quatity / 2);

            }
            return price*quatity;
        }

    }
}
