using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progra_semana2
{
    class Triangulo : Figura
    {
        public float Base; 
        public float Altura;

        public Triangulo(float baseTriangulo, float alturaTriangulo)
        {
            Base = baseTriangulo;
            Altura = alturaTriangulo;
        }

        public new float CalcularArea()
        {
            return 0.5f * Base * Altura;
        }
    }
}
