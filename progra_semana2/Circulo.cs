using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progra_semana2
{
    class Circulo : Figura
    {
        public float Radio; 

        public Circulo(float radio)
        {
            Radio = radio;
        }

        public new float CalcularArea()
        {
            return 3.14f * Radio * Radio;
        }
    }
}
