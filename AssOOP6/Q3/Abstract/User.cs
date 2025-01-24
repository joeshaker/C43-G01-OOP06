using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP6.Q3.Abstract
{
    internal abstract class User
    {
        public  string UserName { get; set; }

        public abstract Discount GetDiscount();



    }
}
