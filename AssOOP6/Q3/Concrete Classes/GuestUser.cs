using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssOOP6.Q3.Abstract;

namespace AssOOP6.Q3.Concrete_Classes
{
    internal class GuestUser:User
    {
        public GuestUser() {

            UserName = "Guest";
        }

        public override Discount GetDiscount()
        {
            return null;
        }
    }
}
