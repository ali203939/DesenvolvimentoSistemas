using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculoDescontoLojaOnline.Model
{
    public class CalcularPagamento
    {
        public decimal CalcularTotal(decimal valorCompra, IDesconto desconto)
        { 
            decimal valorDesconto = desconto.CalcularDesconto(valorCompra);
            return valorCompra -  valorDesconto;
        }
    }
}