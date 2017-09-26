using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TD2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IZoomable> l1 = new List<IZoomable>();
            Cube c1 = new Cube(1);
            Parallelepipede p1 = new Parallelepipede(9, 5, 7);
            l1.Add(c1);
            l1.Add(p1);
            TestZoomable l2 = new TestZoomable(l1, 10);
            Console.ReadLine();
        }
    }
}
