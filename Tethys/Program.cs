using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tethys
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, x, p, z;
            w = Math.Sqrt(5) + 5 / Math.Sqrt(7) + 7;
            z = Math.Sqrt(12) + 12 / Math.Sqrt(8) + 8;
            p = Math.Sqrt(19) + 19 / Math.Sqrt(2) + 2;
            x = w + z + p;
            Console.WriteLine(x + ' ');
            Console.ReadKey();
        }
    }
}
