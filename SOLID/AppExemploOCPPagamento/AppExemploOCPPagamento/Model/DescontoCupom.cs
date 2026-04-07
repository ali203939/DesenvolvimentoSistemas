using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploOCPPagamento.Model
{
    public class DescontoCupom : IDesconto
    {
        public decimal CalcularDesconto(decimal valorCompra)
        {
            return valorCompra * 0.5m;
        }
    }
}
