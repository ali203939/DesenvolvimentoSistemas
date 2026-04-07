using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculoDescontoLojaOnline.Model
{
    public class DescontoQuantidade : IDesconto
    {
        public decimal CalcularDesconto(decimal valorCompra)
        {
            if (valorCompra > 200)
            {
                return valorCompra * 0.20m;
            }
            else if (valorCompra > 50 && valorCompra <= 200)
            {
                return valorCompra * 0.10m;
            }

            else
            {
                return 0;
            }
        }
    }
}