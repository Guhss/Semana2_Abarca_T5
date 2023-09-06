using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progra_semana2
{
    internal class Rectangulo : Figura
    {
        public float Base; 
        public float Altura;

        public Rectangulo(float baseRectangulo, float alturaRectangulo)
        {
            Base = baseRectangulo;
            Altura = alturaRectangulo;
        }

        public new float CalcularArea()
        {
            return Base * Altura;
        }
    }
}
