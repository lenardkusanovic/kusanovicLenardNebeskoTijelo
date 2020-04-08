using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardNebeskoTijelo
{
    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            this.BrzinaOkoOsi = brzinaOkoOsi;
            this.BrzinaOkoSunca = brzinaOkoSunca;
        }
    }
}
