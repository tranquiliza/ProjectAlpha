using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterFaceProjectAlpha
{
    class Measurement
    {
        private int MeasurementID;
        protected int MaterialID;
        protected Decimal length;
        protected String surface;
        protected String info;
        public Measurement()
        {

        }

        /*GETTERS*/
        public String getListBoxInfo()
        {
            return "ID: " + this.MeasurementID + ", " + this.length + "m, " + this.info;
        }
        public String getInfo()
        {
            return this.info;
        }
        public String getSurface()
        {
            return this.surface;
        }
        public Decimal getLength()
        {
            return this.length;
        }
        public int getMeasurementID()
        {
            return this.MeasurementID;
        }
        /*SETTERS*/
        public void setLength(Decimal l)
        {
            this.length = l;
        }
        public void setMeasurementID(int id)
        {
            this.MeasurementID = id;
        }
        /*TESTERS*/
        public void ConsolePrint()
        {
            Console.WriteLine(
                "MeasureID: " + this.MeasurementID
                + ", Lændge: " + this.length
                + ", " + this.surface
                + ", : " + this.info);
        }
    }


    /// <summary>
    /// Heritage of Measurement!
    /// </summary>
    class Measurement_Dirt : Measurement
    {
        public Measurement_Dirt(Decimal length)
        {
            this.MaterialID = 1;
            this.length = length;
            this.surface = "Dirt";
            this.info = "Jord / Vejrabat";
        }
    }
    class Measurement_Gravel : Measurement
    {
        public Measurement_Gravel(Decimal length)
        {
            this.MaterialID = 2;
            this.length = length;
            this.surface = "Gravel";
            this.info = "Grus / Klippet Græs";
        }
    }
    class Measurement_Tile : Measurement
    {
        public Measurement_Tile(Decimal length)
        {
            this.MaterialID = 3;
            this.length = length;
            this.surface = "Tile";
            this.info = "Fliser";
        }
    }
    class Measurement_Tarmac_Pavement : Measurement
    {
        public Measurement_Tarmac_Pavement(Decimal length)
        {
            this.MaterialID = 4;
            this.length = length;
            this.surface = "Tarmac";
            this.info = "Asfalt / fortov < 8 cm";
        }
    }
    class Measurement_Tarmac_Road : Measurement
    {
        public Measurement_Tarmac_Road(Decimal length)
        {
            this.MaterialID = 5;
            this.length = length;
            this.surface = "Tarmac";
            this.info = "Asfalt / vej < 20 cm";
        }
    }
    class Measurement_Paving : Measurement
    {
        public Measurement_Paving(Decimal length)
        {
            this.MaterialID = 6;
            this.length = length;
            this.surface = "Paving";
            this.info = "Belægningssten";
        }
    }
    class Measurement_Cobbles : Measurement
    {
        public Measurement_Cobbles(Decimal length)
        {
            this.MaterialID = 7;
            this.length = length;
            this.surface = "Cobbles";
            this.info = "Chaus / Brosten";
        }
    }
    class Measurement_Grube : Measurement
    {
        public Measurement_Grube(Decimal length)
        {
            this.MaterialID = 8;
            this.length = length;
            this.surface = "Grube";
            this.info = "Start / Modtage grube";
        }
    }
    class Measurement_Rocket : Measurement
    {
        public Measurement_Rocket(Decimal length)
        {
            this.MaterialID = 9;
            this.length = length;
            this.surface = "Rocket";
            this.info = "Raket 1-2 rør";
        }
    }
    class Measurement_Drilling : Measurement
    {
        public Measurement_Drilling(Decimal length)
        {
            this.MaterialID = 10;
            this.length = length;
            this.surface = "Drilling";
            this.info = "Styret Underboringer";
        }
    }
    class Measurement_Pipe : Measurement
    {
        public Measurement_Pipe(Decimal length)
        {
            this.MaterialID = 11;
            this.length = length;
            this.surface = "Pipe";
            this.info = "Piping ø 40/50";
        }
    }
    class Measurement_MultiPipe : Measurement
    {
        public Measurement_MultiPipe(Decimal length)
        {
            this.MaterialID = 12;
            this.length = length;
            this.surface = "MultiPipe";
            this.info = "Multirør";
        }
    }
    class Measurement_Well : Measurement
    {
        public Measurement_Well(Decimal length)
        {
            this.MaterialID = 13;
            this.length = length;
            this.surface = "Well";
            this.info = "Brønde: ubefæst / befæst";
        }
    }
    /*END OF HERITAGE*/
}
