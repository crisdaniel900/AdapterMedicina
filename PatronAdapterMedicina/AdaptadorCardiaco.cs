using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapterMedicina
{
    public  class AdaptadorCardiaco : Monitor
    {
        Monitor AdapterCardiaco = new FrecuenciaCardiaca();


        public override void Lectura()
        {
            AdapterCardiaco.Lectura();
        }

        public override void Diagnostico()
        {
            AdapterCardiaco.Diagnostico();
        }

        public override void Alarma()
        {
           AdapterCardiaco.Alarma();
        }

    }
}
