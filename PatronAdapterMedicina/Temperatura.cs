using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapterMedicina
{
    public class Temperatura : Monitor
    {
        private double valor; // Almacena la lectura actual
        private double valorMinimo = 34.0;
        private double valorMaximo = 40.0;
        private Random random = new Random();


        public override void Lectura()
        {
            valor = Math.Round(random.NextDouble() * (valorMaximo - valorMinimo) + valorMinimo, 1);
            Console.WriteLine($"Lectura de temperatura: {valor} °C");
        }

        public override void Diagnostico()
        {
            string estado;

            if (valor < 35)
            {
                estado = "Hipotermia";
                Alarma();
            }
            else if (valor >= 35 && valor <= 37)
            {

                estado = "Normal";
            }
            else if (valor > 37 && valor < 38)
            {

                estado = "Fiebre, Tirando alarma";
                Alarma();
            }
            else
            {

                estado = "Crítico, Tirando Alarma";
                Alarma();
            }

            Console.WriteLine($"Diagnóstico: {estado}");

        }

        public override void Alarma()
        {
            Console.WriteLine(" Alarma de Temperatura: valor peligroso detectado.");
        }



        //36. 5- 37 Normal
        //37+ Fiebre
        //38 Critico
        //35 Hipotermia
    }
}
