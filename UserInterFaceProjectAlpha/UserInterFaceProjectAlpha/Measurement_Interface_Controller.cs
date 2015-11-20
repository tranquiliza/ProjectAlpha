using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterFaceProjectAlpha
{
    class Measurement_Interface_Controller
    {
        MeasurementCatalog mc = new MeasurementCatalog();

        /*GETTERS*/
        public int getCurrentID(String sag, string gadenavn)
        {
            int id = 0;
            foreach (MeasurementSheet item in mc.getSheets())
            {
                if (item.getFile() == sag && item.getAdress() == gadenavn)
                {
                    id = item.getID();
                    break;
                }
                else id = -1;
            }
            return id;
        }
        public Measurement getNewestMeasurement(int currentID)
        {
            return mc.getSheet(currentID).getLastMeasurement();
        }
        public List<Measurement> getAllMeasurements(int currentID)
        {
            return mc.getSheet(currentID).getMeasurements();
        }
        /*SETTERS*/
        public void deleteMeasurement(int index, int currentID)
        {
            mc.getSheet(currentID).deleteMeasurement(index-1);
        }
        public void newMeasurementSheet(String sag, String gadenavn)
        {
            mc.addSheet(sag, gadenavn);
        }
        public void addMeasurement(int index, Decimal length, int currentID)
        {
            switch (index)
            {
                case 0:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Dirt(length));
                    break;
                case 1:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Gravel(length));
                    break;
                case 2:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Tile(length));
                    break;
                case 3:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Tarmac_Pavement(length));
                    break;
                case 4:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Tarmac_Road(length));
                    break;
                case 5:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Paving(length));
                    break;
                case 6:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Cobbles(length));
                    break;
                case 7:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Grube(length));
                    break;
                case 8:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Rocket(length));
                    break;
                case 9:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Drilling(length));
                    break;
                case 10:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Pipe(length));
                    break;
                case 11:
                    mc.getSheet(currentID).addMeasurement(new Measurement_MultiPipe(length));
                    break;
                case 12:
                    mc.getSheet(currentID).addMeasurement(new Measurement_Well(length));
                    break;
            }
        }
    }
}
