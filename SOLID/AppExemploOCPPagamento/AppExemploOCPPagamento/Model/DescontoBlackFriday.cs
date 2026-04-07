using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploOCPPagamento.Model
{
    public class DescontoBlackFriday : IDesconto
    {
        public decimal CalcularDesconto(decimal valorCompra)
        {
            return valorCompra * 0.2m;
        }
    }
}