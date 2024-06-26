using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shape
{
    class Program
    {
        static void Main(string[] args)
        {
        portion1:
            {
                Console.WriteLine("Main menu:");
                Console.WriteLine("1.Geometric Warehouse");
                Console.WriteLine("2.Realstate");
            }
            int f = int.Parse(Console.ReadLine());
            int id = 0, nc = 0, nr = 0, ncubes = 0;
    
            if (f == 1)
            {
                double area1 = 0, area2 = 0, area3 = 0;
                shape[] my1 = new shape[20];
                Console.WriteLine("1.Add a circle\n2.Add a RECTANGLE\n3.Add a cube\n4.Get list\n5.Get statistics\n6.Exit");

                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:

                            Console.WriteLine("Enter radius:\n");
                            int r = int.Parse(Console.ReadLine());
                            my1[id] = new circle(r);

                            nc++;
                            area1 = area1 + 3.1416 * r * r;
                            my1[id].type = 0;
                            id++;


                            break;
                        case 2:
                            {
                                Console.WriteLine("Enter height ,and width");
                                int h = int.Parse(Console.ReadLine());
                                int w = int.Parse(Console.ReadLine());
                                my1[id] = new rectangle(h, w);

                                nr++;
                                area2 = area2 + h * w;
                                my1[id].type = 1;
                                id++;
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Enter height ,width and thickness:");
                                int h = int.Parse(Console.ReadLine());
                                int w = int.Parse(Console.ReadLine());
                                int t = int.Parse(Console.ReadLine());
                                my1[id] = new cube(h, w, t);

                                ncubes++;
                                area3 = area3 + h * w;
                                my1[id].type = 2;
                                id++;
                            }
                            break;
                        case 4:

                            for (int i = 0; i < id; i++)
                            {
                                if (my1[i].type == 0)
                                {
                                    Console.WriteLine((i + 1) + " .Circle     " + my1[i].r);
                                }
                                else if (my1[i].type == 1)
                                {
                                    Console.WriteLine((i + 1) + " .Rectangle  " + my1[i].h + " " + my1[i].w);
                                }
                                else if (my1[i].type == 2)
                                {
                                    Console.WriteLine((i + 1) + " .Cube       " + my1[i].h + " " + my1[i].w + " " + my1[i].t);
                                }
                            }
                            break;

                        case 5:
                            double totarea = area1 + area2 +area3;
                            Console.WriteLine("Total shapes:" + id);
                            Console.WriteLine("Total circles:" + nc);
                            Console.WriteLine("Total rectangles:" + nr);
                            Console.WriteLine("Total cubes:" + ncubes);
                            Console.WriteLine("Total area :" + (area1 + area2 + area3));
                            Console.WriteLine("Area of circles:" + area1);
                            Console.WriteLine("Area of rectangles:" + area2);
                            Console.WriteLine("Area of cubes:" + area3);
                            Console.WriteLine("Area Percantage of schools:" + (area1 / totarea) * 100);
                            Console.WriteLine("Area Percantage  of buildings:" + (area2 / totarea) * 100);
                            Console.WriteLine("Area Percantage of parks:" + (area3 / totarea) * 100);


                            break;
                        case 6:
                            goto portion1;
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;

                    }
                }
            }
            else if (f == 2)
            {
                double sarea = 0, barea = 0, parea = 0;
                realstate[] my2 = new realstate[20];
                int id2 = 0, ns = 0, nb = 0, np = 0;
                Console.WriteLine("1.Add a School\n2.Add a Building\n3.Add a Park\n4.Get list\n5.Get statistics\n6.Exit");

                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter Classes:\n");
                                int c = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter libraries:\n");
                                int l = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter fields:\n");
                                int fi = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ënter Area:\n");
                                int a = int.Parse(Console.ReadLine());
                                my2[id2] = new school(c, l, fi, a);
                                ns++;
                                sarea = sarea + a;
                                my2[id2].type = 0;
                                id2++;
                            }
                            break;

                        case 2:
                            {
                                Console.WriteLine("Enter Garage:\n");
                                int ga = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Lift:\n");
                                int li = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Prayer room:\n");
                                int pr = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ënter Area:\n");
                                int a = int.Parse(Console.ReadLine());
                                my2[id2] = new building(ga, li, pr, a);
                                nb++;
                                barea = barea + a;
                                my2[id2].type = 1;
                                id2++;
                            }
                            break;

                        case 3:
                            {
                                Console.WriteLine("Enter Rides:\n");
                                int ri = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Lakes:\n");
                                int la = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ënter Area:\n");
                                int a = int.Parse(Console.ReadLine());
                                my2[id2] = new park(ri, la, a);
                                np++;
                                parea = parea + a;
                                my2[id2].type = 2;
                                id2++;
                            }
                            break;


                        case 4:

                            for (int i = 0; i < id2; i++)
                            {
                                if (my2[i].type == 0)
                                {
                                    Console.WriteLine((i + 1) + ".School     number of Classes,fields and Libraries   :  " + my2[i].cls + " " + my2[i].lib + " " + my2[i].field);
                                }
                                else if (my2[i].type == 1)
                                {
                                    Console.WriteLine((i + 1) + " .Building  number of Gararges,lifts and Prayer room : " + my2[i].gar + " " + my2[i].lift + " " + my2[i].pray);
                                }
                                else if (my2[i].type == 2)
                                {
                                    Console.WriteLine((i + 1) + " .Park      number of rides and lakes                :   " + my2[i].rides + " " + my2[i].lakes);
                                }
                            }
                            break;

                        case 5:
                            double totalarea = sarea + barea + parea;
                            Console.WriteLine("Total infrustructures:\n" + id2);
                            Console.WriteLine("Total Schools:\n" + ns);
                            Console.WriteLine("Total Buildinfs:\n" + nb);
                            Console.WriteLine("Total Parks:\n" + np);
                            Console.WriteLine("Area of  Schools:\n" + sarea);
                            Console.WriteLine("Area of Buildings:\n" + barea);
                            Console.WriteLine("Area of Parks:\n" + parea);
                            Console.WriteLine("Area Percantage of schools:" + (sarea / totalarea) * 100);
                            Console.WriteLine("Area Percantage  of buildings:" + (barea / totalarea) * 100);
                            Console.WriteLine("Area Percantage of parks:" + (parea / totalarea) * 100);


                            break;
                        case 6:
                            goto portion1;
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;




                    }

                }
            }


        }
    }

}