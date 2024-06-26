using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shape
{
    public class realstate
    {
        public int type;
        public int Cls { get; set; }
        public int Lib { get; set; } 
        public int Field { get; set; }
        public int Gar { get; set; }
        public int Lift { get; set; }
        public int Pray { get; set; }
        public int Rides { get; set; }
        public int Lakes { get; set; }
        public int Area{ get; set; }

    }
    internal class school : realstate
    {

        public school(int cls, int lib, int field, int area)
        {
            Cls = cls;
            Lib = lib;
            Field = field;
            Area = area;
        }
    }
    internal class building : realstate
    {

        public building(int gar, int lift, int pray, int area)
        {
            Gar = gar;
            Lift = lift;
            Pray = pray;
            Area = area;
        }
    }
    internal class park : realstate
    {

        public park(int rides, int lakes, int area)
        {
            Rides = rides;
            Lakes = lakes;
            Area = area;
        }
    }
}