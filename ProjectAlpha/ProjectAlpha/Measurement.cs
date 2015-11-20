using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlpha
{
    class Measurement
    {
        Double length;
        public Measurement(Double length)
        {
            this.length = length;
        }
        /*GETTERS*/
        public double getLength()
        {
            return this.length;
        }
        /*SETTERS*/
        public void setLength(double l)
        {
            this.length = l;
        }
        /*TESTERS*/
        public void ConsolePrint()
        {
            Console.WriteLine("Lændge: " + this.length);
        }
    }
}
