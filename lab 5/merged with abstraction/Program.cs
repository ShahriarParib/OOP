using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static geometric_shape.circle;

namespace geometric_shape
{
    class Program
    {
        static void Main(string[] args)
        {
            double sarea = 0, barea = 0, parea = 0;
            realstate[] my2 = new realstate[20];
            int id2 = 0, ns = 0, nb = 0, np = 0;
            double area1 = 0, area2 = 0, area3 = 0;
            shape[] my1 = new shape[20];
            int id = 0, nc = 0, nr = 0, ncubes = 0;
        whole:
            {
            portion1:
                {
                    Console.WriteLine("Main menu:");
                    Console.WriteLine("1.Geometric Warehouse");
                    Console.WriteLine("2.Realstate");
                }
                int f = int.Parse(Console.ReadLine());

                if (f == 1)
                {
                portionw:
                    {
                        Console.WriteLine("1.Add a circle\n2.Add a RECTANGLE\n3.Add a cube\n4.Get list\n5.Get statistics\n6.Exit");

                        while (true)
                        {
                            int n = int.Parse(Console.ReadLine());
                            switch (n)
                            {
                                case 1:

                                    Console.WriteLine("Enter radius:\n");
                                    try
                                    {
                                        int r = int.Parse(Console.ReadLine());
                                        my1[id] = new circle(r);
                                        if (r < 0)
                                        {
                                            throw new ArgumentNullException();
                                        }

                                        // area1 = my1[id].calculatearea(my1[id].R, 0, 0);
                                    }
                                    catch (FormatException e)
                                    {
                                        Console.WriteLine("Input value is not in the correct format");
                                        Console.ReadLine();
                                        goto portionw;
                                    }
                                    catch (ArgumentNullException e)
                                    {
                                        Console.WriteLine("Input value can't be negative");
                                        Console.ReadLine();
                                        goto portionw;
                                    }

                                    nc++;
                                    //area1 = area1 + 3.1416 * r * r;
                                    area1 = my1[id].calculatearea(my1[id].R, 0, 0);
                                    my1[id].type = 0;
                                    id++;


                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("Enter height ,and width");
                                        try
                                        {
                                            int h = int.Parse(Console.ReadLine());
                                            int w = int.Parse(Console.ReadLine());
                                            if (h < 0 || w < 0)
                                            {
                                                throw new ArgumentNullException();
                                            }
                                            my1[id] = new rectangle(h, w);

                                        }
                                        catch (FormatException e)
                                        {
                                            Console.WriteLine("Input value is not in the correct format");
                                            Console.ReadLine();
                                            goto portionw;
                                        }
                                        catch (ArgumentNullException e)
                                        {
                                            Console.WriteLine("Input value can't be negative");
                                            Console.ReadLine();
                                            goto portionw;
                                        }

                                        nr++;
                                        area2 = my1[id].calculatearea(0, my1[id].H, my1[id].W);
                                        my1[id].type = 1;
                                        id++;
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Enter height ,width and thickness:");
                                        try
                                        {
                                            int h = int.Parse(Console.ReadLine());
                                            int w = int.Parse(Console.ReadLine());
                                            int t = int.Parse(Console.ReadLine());
                                            if (h < 0 || w < 0 || t < 0)
                                            {
                                                throw new ArgumentNullException();
                                            }

                                            my1[id] = new cube(h, w, t);
                                        }
                                        catch (FormatException e)
                                        {
                                            Console.WriteLine("Input value is not in the correct format");
                                            Console.ReadLine();
                                            goto portionw;
                                        }
                                        catch (ArgumentNullException e)
                                        {
                                            Console.WriteLine("Input value can't be negative");
                                            Console.ReadLine();
                                            goto portionw;
                                        }
                                        ncubes++;
                                        area3 = my1[id].calculatearea(0, my1[id].H, my1[id].W);
                                        my1[id].type = 2;
                                        id++;
                                    }
                                    break;
                                case 4:

                                    for (int i = 0; i < id; i++)
                                    {
                                        if (my1[i].type == 0)
                                        {
                                            Console.WriteLine((i + 1) + " .Circle     " + my1[i].R);
                                        }
                                        else if (my1[i].type == 1)
                                        {
                                            Console.WriteLine((i + 1) + " .Rectangle  " + my1[i].H + " " + my1[i].W);
                                        }
                                        else if (my1[i].type == 2)
                                        {
                                            Console.WriteLine((i + 1) + " .Cube       " + my1[i].H + " " + my1[i].W + " " + my1[i].T);
                                        }
                                    }
                                    break;

                                case 5:
                                    Console.WriteLine("Total shapes:\n" + id);
                                    Console.WriteLine("Total circles:\n" + nc);
                                    Console.WriteLine("Total rectangles:\n" + nr);
                                    Console.WriteLine("Total cubes:\n" + ncubes);
                                    Console.WriteLine("Total area :\n" + (area1 + area2 + area3));
                                    Console.WriteLine("Area of circles:\n" + area1);
                                    Console.WriteLine("Area of rectangles:\n" + area2);
                                    Console.WriteLine("Area of cubes:\n" + area3);

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
                else if (f == 2)
                {
                portionr:
                    {
                        Console.WriteLine("1.Add a School\n2.Add a Building\n3.Add a Park\n4.Get list\n5.Get statistics\n6.Exit");

                        while (true)
                        {
                            int n = int.Parse(Console.ReadLine());
                            switch (n)
                            {
                                case 1:
                                    {
                                        try
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
                                            sarea = sarea + a;
                                        }
                                        catch (FormatException e )
                                        {
                                            Console.WriteLine("Input value is not in the correct format");
                                            Console.ReadLine();
                                            goto portionr;
                                        }
                                        
                                        ns++;
                                        
                                        my2[id2].type = 0;
                                        id2++;
                                    }
                                    break;

                                case 2:
                                    {
                                        try
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
                                            barea = barea + a;

                                        }
                                        catch (FormatException e)
                                        {
                                            Console.WriteLine("Input value is not in the correct format");
                                            Console.ReadLine();
                                            goto portionr;
                                        }
                                        nb++;
                                   
                                        my2[id2].type = 1;
                                        id2++;
                                    }
                                    break;

                                case 3:
                                    {
                                        try
                                        {
                                            Console.WriteLine("Enter Rides:\n");
                                            int ri = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Enter Lakes:\n");
                                            int la = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ënter Area:\n");
                                            int a = int.Parse(Console.ReadLine());
                                            my2[id2] = new park(ri, la, a);
                                            parea = parea + a;
                                        }
                                        catch(FormatException e) 
                                        {
                                            Console.WriteLine("Input value is not in the correct format");
                                            Console.ReadLine();
                                            goto portionr;
                                        }
                                        np++;
                                        
                                        my2[id2].type = 2;
                                        id2++;
                                    }
                                    break;


                                case 4:

                                    for (int i = 0; i < id2; i++)
                                    {
                                        if (my2[i].type == 0)
                                        {
                                            Console.WriteLine((i + 1) + ".School     number of Classes,fields and Libraries   :  " + my2[i].Cls + " " + my2[i].Lib + " " + my2[i].Field);
                                        }
                                        else if (my2[i].type == 1)
                                        {
                                            Console.WriteLine((i + 1) + " .Building  number of Gararges,lifts and Prayer room :  " + my2[i].Gar + " " + my2[i].Lift + " " + my2[i].Pray);
                                        }
                                        else if (my2[i].type == 2)
                                        {
                                            Console.WriteLine((i + 1) + " .Park      number of rides and lakes                :  " + my2[i].Rides + " " + my2[i].Lakes);
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
    }
}
