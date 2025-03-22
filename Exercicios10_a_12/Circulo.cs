using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios10_a_12
{
    internal class Circulo
    {
        private double _Raio;

        public Circulo(double raio)
        {
            _Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * (_Raio * _Raio);
        }
    }
}
