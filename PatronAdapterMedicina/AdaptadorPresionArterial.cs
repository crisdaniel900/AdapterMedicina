using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapterMedicina
{
    public class AdaptadorPresionArterial : Monitor
    {
        Monitor AdapterPresion = new PresionArterial();

        public override void Lectura()
        {
            AdapterPresion.Lectura();
        }

        public override void Diagnostico()
        {
           AdapterPresion.Diagnostico();
        }

        public override void Alarma()
        {
            AdapterPresion.Alarma();
        }
    }
}
