using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploOCPPagamento.Model
{
    public class CalculadoraPagamento ()
    {
        public decimal CalcularTotal(decimal valorCompra, IDesconto desconto)
        {
            return valorCompra - desconto.CalcularDesconto(valorCompra);
        }
    }
}