using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste01
{
    class Program
    {
        static void Main(string[] args)
        {
            var geo = new Address();
            geo.Line1 = "30 Frank Lloyd Wright Drive";
            geo.State = "MI";

            geo.GeoCode();

            

            Console.WriteLine("Teste");
            Console.WriteLine(geo.Latitude);
            Console.WriteLine(geo.Longitude);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
