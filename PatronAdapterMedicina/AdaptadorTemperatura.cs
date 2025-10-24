using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapterMedicina
{
    public  class AdaptadorTemperatura : Monitor
    {
        Monitor AdapterTemperatua = new Temperatura();

        public override void Lectura()
        {
            AdapterTemperatua.Lectura();
        }

        public override void Diagnostico()
        {
           AdapterTemperatua.Diagnostico();
        }

        public override void Alarma()
        {
            AdapterTemperatua.Alarma();
        }
    }
}
