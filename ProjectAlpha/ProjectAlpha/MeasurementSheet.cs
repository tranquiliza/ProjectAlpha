using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlpha
{
    class MeasurementSheet
    {
        private string file;
        private int ID;
        private string adress;
        private DateTime date;
        private List<Measurement> measurements;

        public MeasurementSheet(String file, int ID, String adress)
        {
            this.file = file;
            this.ID = ID;
            this.adress = adress;
            measurements = new List<Measurement>();
            date = DateTime.Today;
        }

        /*GETTERS*/
        public int getID()
        {
            return this.ID;
        }
        private int getNewID()
        {
            int newID = 0;
            foreach (Measurement item in measurements)
            {
                if (item.getMeasurementID() > newID)
                {
                    newID = item.getMeasurementID();
                }
            }
            newID += 1;
            return newID;
        }

        /*SETTERS*/
        public void addMeasurement(Measurement m)
        {
            m.setMeasurementID(getNewID());
            measurements.Add(m);
        }
        /*TESTERS*/
        public void printAll()
        {
            Console.WriteLine("Case ID: " + this.ID);
            Console.WriteLine("Adress: " + this.adress);
            Console.WriteLine("Date: " + this.date.ToShortDateString());
            foreach (Measurement item in measurements)
            {
                item.ConsolePrint();
            }
        }
    }
}
