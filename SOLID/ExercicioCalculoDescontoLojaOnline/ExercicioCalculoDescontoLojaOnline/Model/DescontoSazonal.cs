using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculoDescontoLojaOnline.Model
{
    public class DescontoSazonal : IDesconto
    {

        // 15%
        public decimal CalcularDesconto(decimal valorCompra)
        {
            if (DateTime.Now.Month == 3)
            {
                return valorCompra * 0.15m;
            }
            else if (DateTime.Now.Month == 6)
            {
                return valorCompra * 0.10m;
            }
            else if (DateTime.Now.Month == 11)
            {
                return valorCompra * 0.20m;
            }
            else
            {
                return 0;
            }
        }
    }
}