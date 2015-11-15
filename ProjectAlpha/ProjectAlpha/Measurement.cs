using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlpha
{
    class Measurement
    {
        int caseID;
        DateTime date;
        String street;
        String file;
        List<Streak> measurements = new List<Streak>();

        public Measurement(int id, string street, string file)
        {
            this.caseID = id;
            this.date = DateTime.Now;
            this.street = street;
            this.file = file;
            /* TEST DATA START */ /*
            Streak m1 = new Streak(6, 4);
            Streak m2 = new Streak(5, 3);
            Streak m3 = new Streak(0, 0);
            Streak m4 = new Streak(3, 5);
            Streak m5 = new Streak(1, 14);
            Streak m6 = new Streak(2, 7);
            Streak m7 = new Streak(1, 4);
            Streak m8 = new Streak(10, 10);
            m8.addExtra(8, 1);
            m8.addExtra(13, 1);
            Streak m9 = new Streak(5, 5);
            Streak m10 = new Streak(9, 10);
            m10.addExtra(8, 1);
            measurements.Add(m1);
            measurements.Add(m2);
            measurements.Add(m3);
            measurements.Add(m4);
            measurements.Add(m5);
            measurements.Add(m6);
            measurements.Add(m7);
            measurements.Add(m8);
            measurements.Add(m9);
            measurements.Add(m10);
            /* TEST DATA END */
        }
        public string getDate()
        {
            string answer = "";
            answer += this.date.ToString();
            return answer;
        }
        public void addMeasurement(Streak s)
        {
            measurements.Add(s);
        }
        private int sumDirt()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getDirt();
            }
            return sum;
        }
        private int sumGravel()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getGravel();
            }
            return sum;
        }
        private int sumTiles()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getTiles();
            }
            return sum;
        }
        private int sumTarmac_Pavement()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getTarmac_Pavement();
            }
            return sum;
        }
        private int sumTarmac_Road()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getTarmac_Road();
            }
            return sum;
        }
        private int sumCoverStone()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getCoverStone();
            }
            return sum;
        }
        private int sumCobblestone()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getCobblestone();
            }
            return sum;
        }
        private int sumStart_Receiver_grube()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getStart_Receiver_grube();
            }
            return sum;
        }
        private int sumRocket()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getRocket();
            }
            return sum;
        }
        private int sumControlledDrilling()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getControlledDrilling();
            }
            return sum;
        }
        private int sumPipe_4050()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getPipe_4050();
            }
            return sum;
        }
        private int sumMultiPipe()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getMultiPipe();
            }
            return sum;
        }
        private int sumWell()
        {
            int sum = 0;
            for (int i = 0; i < measurements.Count; i++)
            {
                sum += measurements[i].getWell();
            }
            return sum;
        }
        //test
        public int sumTotal()
        {
            int sum = 0;
            sum = sumDirt() + sumGravel() + sumTiles() + sumTarmac_Pavement() + sumTarmac_Road() + sumCoverStone() + sumCobblestone() + sumStart_Receiver_grube() + sumRocket() + sumControlledDrilling() + sumPipe_4050()
                + sumMultiPipe() + sumWell();
            return sum;
        }
        public string sumTotalString()
        {
            string answer = "Dirt = " + sumDirt() + ", Gravel = " + sumGravel() + ", Tiles = " + sumTiles() + ", Tarmac_Pavement = " + sumTarmac_Pavement();
            answer = 
                "Dirt = " + sumDirt() 
                + ", Gravel = " + sumGravel() 
                + ", Tiles = " + sumTiles() 
                + ", Tarmec_Pavement = " + sumTarmac_Pavement() 
                + ", Tarmec_Road = " + sumTarmac_Road() 
                + ", CoverStone = " + sumCoverStone() 
                + ", Cobblestone = " + sumCobblestone() 
                + ", Start_Receiver_grube = " + sumStart_Receiver_grube() 
                + ", Rocket = " + sumRocket() 
                + ", ControlledDrilling = " + sumControlledDrilling() 
                + ", Pipe 40/50 = " + sumPipe_4050() 
                + ", MultiPipe = " + sumMultiPipe() 
                + ", Well = " + sumWell() 
                + ".";
            return answer;

        }
    }
}
