using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploSRP.Service
{
    public class FaturaService
    {
        string fatura = string.Empty;
        public string GerarFatura()
        {
            return $"Fatura gerada com sucesso! {fatura}";
        }
    }
}
