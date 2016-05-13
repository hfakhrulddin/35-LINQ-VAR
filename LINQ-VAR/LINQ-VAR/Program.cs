using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_VAR
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Arr = { "Hussen", "Fakhrulddin" };

            var o = from x in Arr where x.Length > 5 select new { Len = x.Length, Value = x };
            foreach (var x in o)
            {
                Console.WriteLine(x.Len + " " + x.Value);
            }
            Console.ReadLine();
        }
    }
}
