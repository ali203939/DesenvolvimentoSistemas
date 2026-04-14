using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioDipBiblioteca.Model
{
    public class AcervoFisico
    {
        public string Titulo { get; set; }
        public string Localizacao { get; set; }

        public AcervoFisico(string titulo, string localizacao)
        {
            Titulo = titulo;
            Localizacao = localizacao;
        }

        public string GetInfo()
        {
            return $"{Titulo} – Estante {Localizacao}";
        }
    }

}
