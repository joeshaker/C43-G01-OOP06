using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssOOP6.Q3.Abstract;

namespace AssOOP6.Q3.Concrete_Classes
{
    internal class RegularUser : User
    {
        public RegularUser()
        {
            UserName = "Regular";
        }

        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}
