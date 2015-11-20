using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlpha
{
    class MeasurementCatalog
    {
        private List<MeasurementSheet> sheets;
        public MeasurementCatalog()
        {
            sheets = new List<MeasurementSheet>();
        }

        /*GETTERS*/
        private int getNewId()
        {
            int newID = 0;
            foreach (MeasurementSheet item in sheets)
            {
                if (item.getID() > newID)
                {
                    newID = item.getID();
                }
            }
            newID = newID + 1;
            return newID;
        }
        public MeasurementSheet getSheet(int ID)
        {
            return sheets[ID - 1];
        }

        /*SETTERS*/
        public void addSheet(String file, String adress)
        {
            sheets.Add(new MeasurementSheet(file, getNewId(), adress));
        }

        /*TESTERS*/
        public void printID(int id)
        {
            sheets[id - 1].printAll();
        }
        public void printAll()
        {
            foreach (MeasurementSheet item in sheets)
            {
                item.printAll();
            }
        }
    }
}
