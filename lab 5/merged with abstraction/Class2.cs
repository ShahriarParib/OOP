using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace geometric_shape
{
    public abstract class shape

    {
        public int R { get; set; }
        public int H { get; set; }
        public int W { get; set; }
        public int T { get; set; }
        public int type;
        public double area;
        //public abstract double calculatearea(int r);
        public abstract double calculatearea(int h,int w, int r);


    }
    public class circle : shape
    {
        public double area;
        public circle(int r)
        {

            R = r;

        }
        public override double calculatearea(int r=0, int w = 0, int h= 0)
        {
            return 3.1416 * r * r;
        }
    }
    public class rectangle : shape
    {

        public rectangle(int h, int w)
        {

            H = h;
            W = w;


        }
        public override double calculatearea(int r = 0 ,int h = 0, int w = 0)
        {
            return h*w;
        }
    }
    public class cube : shape
    {

        public cube(int h, int w, int t)
        {
            H = h;
            W = w;
            T = t;

        }
        public override double calculatearea(int r= 0, int h= 0, int w = 0)
        {
            return h * w ;
        }
    }
}
