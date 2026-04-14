using AppExercicioDipBiblioteca.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioDipBiblioteca.Model
{
    public class AcervoFisicoDIP : IAcervo
    {

        public string Titulo { get; set; }
        public string Localizacao { get; set; }

        public AcervoFisicoDIP(string titulo, string localizacao)
        {
            Titulo = titulo;
            Localizacao = localizacao;
        }

        public string GetInfo()
        {
            return $"Título: {Titulo} – Estante {Localizacao}";
        }
    }
}
