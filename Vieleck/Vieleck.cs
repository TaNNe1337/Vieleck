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
        public Vieleck(double seitenanzahl, double seitenlaenge)
        {
            berechneFlaecheninhalt(seitenanzahl, seitenlaenge);
        }

        private void berechneFlaecheninhalt(double seitenanzahl, double seitenlaenge)
        {
            this.flaecheninhalt = (seitenanzahl * Math.Pow(seitenlaenge, 2.0) / (4.0 * Math.Tan((Math.PI / seitenanzahl))));
            
        }
    }
}
