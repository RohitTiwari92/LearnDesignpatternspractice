using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKataGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GreedKata inobj = new GreedKata();
            int[] arr = {3, 5, 5, 5, 1,2  };
           Console.WriteLine( inobj.calcualte(arr));
            Console.ReadKey();
        }
    }
}
