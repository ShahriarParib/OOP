using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace geometric_shape
{
    public class shape

    {
        public int r = 0;
        public int h = 0;
        public int w = 0;
        public int t = 0;
        public int type;

    }
    public class realstate
    {
        public int type;
        public int cls, lib, field, gar, lift, pray, rides, lakes, area;


    }
    public class circle : shape
    {

        public circle(int r)
        {

            this.r = r;

        }
    }
    public class rectangle : shape
    {

        public rectangle(int h, int w)
        {

            this.h = h;
            this.w = w;


        }
    }
    public class cube : shape
    {

        public cube(int h, int w, int t)
        {
            this.h = h;
            this.w = w;
            this.t = t;

        }
    }
    public class school : realstate
    {

        public school(int cls, int lib, int field, int area)
        {
            this.cls = cls;
            this.lib = lib;
            this.field = field;
            this.area = area;
        }
    }
    public class building : realstate
    {

        public building(int gar, int lift, int pray, int area)
        {
            this.gar = gar;
            this.lift = lift;
            this.pray = pray;
            this.area = area;
        }
    }
    public class park : realstate
    {

        public park(int rides, int lakes, int area)
        {
            this.rides = rides;
            this.lakes = lakes;
            this.area = area;
        }
    }
}

