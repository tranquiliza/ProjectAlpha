using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterFaceProjectAlpha
{
    class MeasurementCatalog
    {
        private List<MeasurementSheet> sheets;
        public MeasurementCatalog()
        {
            sheets = new List<MeasurementSheet>();
            sheets.Add(new MeasurementSheet("Test1", getNewId(), "TestAdresse1"));
            sheets.Add(new MeasurementSheet("Test2", getNewId(), "TestAdresse2"));
            sheets.Add(new MeasurementSheet("Test3", getNewId(), "TestAdresse3"));
            sheets.Add(new MeasurementSheet("Test4", getNewId(), "TestAdresse4"));
            sheets.Add(new MeasurementSheet("Test5", getNewId(), "TestAdresse5"));
        }

        /*GETTERS*/
        public List<MeasurementSheet> getSheets()
        {
            return this.sheets;
        }
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
