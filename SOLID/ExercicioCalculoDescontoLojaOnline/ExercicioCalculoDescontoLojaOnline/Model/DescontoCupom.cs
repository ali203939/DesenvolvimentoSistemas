using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculoDescontoLojaOnline.Model
{
    public class DescontoCupom : IDesconto
    {
        public decimal CalcularDesconto(decimal valorCompra)
        {
            return 50m;
        }
    }
}