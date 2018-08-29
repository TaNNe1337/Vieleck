using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vieleck
{
    class Vieleck
    {
        private double flaecheninhalt = 0;
        private double seitenanzahl;
        private double seitenlaenge;

        public double Seitenanzahl
        {
            get
            {
                return this.seitenanzahl;
            }
            set
            {
                if (value > 2)
                {
                    this.seitenanzahl = value;
                }
            }
        }
        public double Seitenlaenge
        {
            get
            {
                return this.seitenlaenge;
            }
            set
            {
                if (value > 0)
                {
                    this.seitenlaenge = value;
                }
            }
        }
        public double Flaecheninhalt
        {
            get
            {
                return this.flaecheninhalt;
            }
            set
            {

            }
        }
       

        public void berechneFlaecheninhalt()
        {
            this.flaecheninhalt = (this.seitenanzahl * Math.Pow(this.seitenlaenge, 2.0) / (4.0 * Math.Tan((Math.PI / this.seitenanzahl))));
            
        }
    }
}
