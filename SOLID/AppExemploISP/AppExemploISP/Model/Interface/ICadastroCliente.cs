using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploISP.Model.Interface
{
    public interface ICadastroCliente
    {
        void ValidarDados();
        void SalvarBanco();
    }
}
