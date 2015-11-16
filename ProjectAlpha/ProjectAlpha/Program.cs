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
            Measurement test = new Measurement(1, "Nordlandsvej", "Case - 1000");
            //Console.WriteLine(test.sumTotalString());

            Streak s1 = new Streak(1,10);
            test.addMeasurement(s1);

            s1 = new Streak(4, 2);
            test.addMeasurement(s1);
            Console.WriteLine(test.sumTotalString());
            Console.WriteLine(test.sumTotal());
            Console.WriteLine(test.getDate());
            DateTime now;
            while (true)
            {
                now = DateTime.Now;
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(now.ToString());
            }
        }
    }
}
