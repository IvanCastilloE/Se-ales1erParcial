using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class ImpulsoUnitario
    {
        public List<Muestra> Muestras { get; set; }

        public ImpulsoUnitario()
        {
            Muestras = new List<Muestra>();
        }
        public double evaluar(double tiempo)
        {
            double resultado;

            if (tiempo == 0)
            {
                resultado = 1;
            }
            else
                resultado = 0;

            return resultado;
        }
    }
}
