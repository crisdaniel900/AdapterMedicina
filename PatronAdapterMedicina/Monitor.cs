using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapterMedicina
{
    public abstract  class Monitor
    {
        public abstract void Lectura();
        public abstract void Diagnostico();

        public abstract void Alarma();

        //public abstract void Alarma();
    }
}
