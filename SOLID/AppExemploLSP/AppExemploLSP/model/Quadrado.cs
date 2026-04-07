using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploLSP.model
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(double altura, double largura) : base(altura, largura)
        {
            if (altura!=largura)
            {
                Console.WriteLine("A altura e largura do quadrado precisam ser iguais.");
            }
        }
    }
}
