using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progra_semana2
{
    class Cuadrado : Figura
    {
        public float Lado;

        public Cuadrado(float lado)
        {
            Lado = lado;
        }

        public new float CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
