using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapterMedicina
{
    public class PresionArterial: Monitor
    {
        private double valor; 
        private double valorMinimo = 79;
        private double valorMaximo = 140;
        private Random random = new Random();


        public override void Lectura()
        {
            valor = Math.Round(random.NextDouble() * (valorMaximo - valorMinimo) + valorMinimo, 1) ;
            Console.WriteLine($"Lectura de Presion: {valor}");
        }

        public override void Diagnostico()
        {
            string estado;

             if (valor >= 81 && valor <= 120)
            {
              estado = "Normal";
            }
            else if (valor > 120 && valor < 129)
            {
                estado = "Elevada Tirando Alarma";
                Alarma();
            }
            else
            {
                estado = "Crítico Tirando Alarma";
                Alarma();
            }

            Console.WriteLine($"Diagnóstico: {estado}");

        }

        public override void Alarma()
        {
            Console.WriteLine(" Alarma de frecuencia Presion Arterial: valor peligroso detectado.");
        }

        //Normal 81-120
        //Elevada 120-129
        //HiperTension 130-139 o 80-89
        //Crisis +180
    }
}
