using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP6.Q1
{
    internal class _3DPoints:ICloneable
    {
        public _3DPoints() { 
        }
        public _3DPoints(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public _3DPoints(int x, int y):this(x , y,0 )
        {
            this.X = x;
            this.Y = y;
        }

        public _3DPoints(int x) : this(x, 0, 0)
        {
            this.X = x;
        }


        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString()
        {
            return $"Point Coordinates:({X},{Y},{Z})";
        }

        public object Clone() {
        
            return new _3DPoints(this.X, this.Y, this.Z);
        
        }


    }
}
