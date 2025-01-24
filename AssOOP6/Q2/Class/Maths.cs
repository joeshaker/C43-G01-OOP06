using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP6.Q2.Class
{
    internal class Maths
    {
        static public double Add(double a, double b) { 
        
            return a + b;
        
        }

        static public double Subtract(double a, double b)
        {

            return a - b;

        }
        static public double Multiply(double a, double b)
        {

            return a * b;

        }
        static public double Divide(double a, double b)
        {

            if (b == 0) 
            {
                Console.WriteLine("Math Error");
            }
            return a / b;

        }
    }
}
