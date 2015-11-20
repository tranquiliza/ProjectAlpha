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
            mc.addSheet("Test1", "Nordlandsvej 87g");
            mc.addSheet("Test2", "Skolebakken 20");

            mc.getSheet(1).addMeasurement(new Measurement_Dirt(1));
            mc.getSheet(1).addMeasurement(new Measurement_Gravel(2));
            mc.getSheet(1).addMeasurement(new Measurement_Tile(3));
            mc.getSheet(1).addMeasurement(new Measurement_Tarmac_Pavement(4));
            mc.getSheet(1).addMeasurement(new Measurement_Tarmac_Road(5));
            mc.getSheet(1).addMeasurement(new Measurement_Paving(6));
            mc.getSheet(1).addMeasurement(new Measurement_Cobbles(7));
            mc.getSheet(1).addMeasurement(new Measurement_Grube(8));
            mc.getSheet(1).addMeasurement(new Measurement_Rocket(9));
            mc.getSheet(1).addMeasurement(new Measurement_Drilling(10));
            mc.getSheet(1).addMeasurement(new Measurement_Pipe(11));
            mc.getSheet(1).addMeasurement(new Measurement_MultiPipe(12));
            mc.getSheet(1).addMeasurement(new Measurement_Well(13));

            mc.getSheet(2).addMeasurement(new Measurement_Tile(10));
            mc.getSheet(2).addMeasurement(new Measurement_Tarmac_Road(8));
            //mc.getSheet(2).addMeasurement(new Measurement_Drilling(8));
            mc.getSheet(2).addMeasurement(new Measurement_Cobbles(2));
            mc.getSheet(2).addMeasurement(new Measurement_Grube(2));
            mc.getSheet(2).addMeasurement(new Measurement_Tile(50));
            mc.getSheet(2).addMeasurement(new Measurement_Tile(2));
            mc.getSheet(2).addMeasurement(new Measurement_Gravel(15));
            mc.printID(2);
            
            /*
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
