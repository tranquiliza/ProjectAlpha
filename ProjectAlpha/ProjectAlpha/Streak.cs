using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlpha
{
    class Streak
    {
        int dirt;
        int gravel;
        int tiles;
        int tarmac_pavement;
        int tarmac_road;
        int coverStone;
        int cobblestone;
        int start_receiver_grube;
        int rocket;
        int controlled_drilling;
        int pipe_4050;
        int multiPipe;
        int well;
        string note;

        public Streak(int option, int value)
        {
            switch(option)
            {
                case 1:
                    this.dirt = value;
                    break;
                case 2:
                    this.gravel = value;
                    break;
                case 3:
                    this.tiles = value;
                    break;
                case 4:
                    this.tarmac_pavement = value;
                    break;
                case 5:
                    this.tarmac_road = value;
                    break;
                case 6:
                    this.coverStone = value;
                    break;
                case 7:
                    this.cobblestone = value;
                    break;
                case 8:
                    this.start_receiver_grube = value;
                    break;
                case 9:
                    this.rocket = value;
                    break;
                case 10:
                    this.controlled_drilling = value;
                    break;
                case 11:
                    this.pipe_4050 = value;
                    break;
                case 12:
                    this.multiPipe = value;
                    break;
                case 13:
                    this.well = value;
                    break;
            }
        }
        public void addExtra(int option, int value)
        {
            switch (option)
            {
                case 1:
                    this.dirt = value;
                    break;
                case 2:
                    this.gravel = value;
                    break;
                case 3:
                    this.tiles = value;
                    break;
                case 4:
                    this.tarmac_pavement = value;
                    break;
                case 5:
                    this.tarmac_road = value;
                    break;
                case 6:
                    this.coverStone = value;
                    break;
                case 7:
                    this.cobblestone = value;
                    break;
                case 8:
                    this.start_receiver_grube = value;
                    break;
                case 9:
                    this.rocket = value;
                    break;
                case 10:
                    this.controlled_drilling = value;
                    break;
                case 11:
                    this.pipe_4050 = value;
                    break;
                case 12:
                    this.multiPipe = value;
                    break;
                case 13:
                    this.well = value;
                    break;
            }
        }
        public void addNote(string note)
        {
            this.note = note;
        }
        public int getDirt()
        {
            return this.dirt;
        }
        public int getGravel()
        {
            return this.gravel;
        }
        public int getTiles()
        {
            return this.tiles;
        }
        public int getTarmac_Pavement()
        {
            return this.tarmac_pavement;
        }
        public int getTarmac_Road()
        {
            return this.tarmac_road;
        }
        public int getCoverStone()
        {
            return this.coverStone;
        }
        public int getCobblestone()
        {
            return this.cobblestone;
        }
        public int getStart_Receiver_grube()
        {
            return this.start_receiver_grube;
        }
        public int getRocket()
        {
            return this.rocket;
        }
        public int getControlledDrilling()
        {
            return this.controlled_drilling;
        }
        public int getPipe_4050()
        {
            return this.pipe_4050;
        }
        public int getMultiPipe()
        {
            return this.multiPipe;
        }
        public int getWell()
        {
            return this.well;
        }
    }
}
