using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssOOP6.Q3.Abstract;

namespace AssOOP6.Q3.Concrete_Classes
{
    internal class PremiumUser:User
    {
        public PremiumUser() {
            UserName = "Premium";
        }
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
