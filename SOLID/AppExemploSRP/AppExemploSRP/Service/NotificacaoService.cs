using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploSRP.Service
{
    public class NotificacaoService
    {
        public string nome { get; set; }
        public string email { get; set; }

        public string EnviarEmail(string nome, string email)
        {
            return $"Email enviado para o cliente: {nome} no email: {email}";
        }
    }
}
