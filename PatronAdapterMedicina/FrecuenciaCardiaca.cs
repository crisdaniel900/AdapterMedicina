using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapterMedicina
{
    public class FrecuenciaCardiaca : Monitor
    {
        private double valor; // Almacena la lectura actual
        private double valorMinimo = 60.0;
        private double valorMaximo = 170.0;
        private Random random = new Random();


        public override void Lectura()
        {
            valor = Math.Round(random.NextDouble() * (valorMaximo - valorMinimo) + valorMinimo, 1);
            Console.WriteLine($"Lectura de frecuencia cardiaca: {valor} LPM");
        }

        public override void Diagnostico()
        {
            string estado;

            if (valor < 60)
            {
              estado = "Baja";
            }
            else if (valor >= 94 && valor <= 165)
            {
                estado = "Normal";
            }

            else if (valor > 166 && valor < 170)
            {
                estado = "Alta, Tirando Alarma"; Alarma();
            }

            else
                estado = "Crítico, Tirando Alarma";

            Console.WriteLine($"Diagnóstico: {estado}");

        }

        public override void Alarma()
        {
            Console.WriteLine(" Alarma de frecuencia cardíaca: valor peligroso detectado.");
        }

        //94-165 Normal
        //60  baja
        //166 Alta

    }
}
