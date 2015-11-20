using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlpha
{
    class Program
    {
        static void Main(string[] args)
        {
            MeasurementCatalog mc = new MeasurementCatalog();
            mc.addSheet("file1", "Nordlandsvej 87g");
            mc.addSheet("file2", "Skolebakken 20");

            mc.printAll();
            /*
            DateTime now;
            while (true)
            {
                now = DateTime.Now;
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(now.ToString());
            }*/
        }
    }
}
