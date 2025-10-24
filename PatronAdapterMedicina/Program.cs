using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapterMedicina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Se nos muere el paciente";
            Monitor Temperatura = new AdaptadorTemperatura();
            Monitor Corazon = new AdaptadorCardiaco();
            Monitor Arterial = new AdaptadorPresionArterial();


            Temperatura.Lectura();
            Temperatura.Diagnostico();
            Corazon.Lectura();
            Corazon.Diagnostico();
            Arterial.Lectura();
            Arterial.Diagnostico();
            Console.ReadKey();

        }
    }
}
