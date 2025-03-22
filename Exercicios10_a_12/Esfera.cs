using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios10_a_12
{
    internal class Esfera
    {
        private double _Raio;

        public Esfera(double raio)
        {
            _Raio = raio;
        }

        public double CalcularVolume()
        {
            return (4.0/3.0) * Math.PI * (_Raio * _Raio * _Raio);
        }
    }
}
