using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioDipBiblioteca.Model.Interface
{
    public interface IAcervo
    {
        public string Titulo { get; set; }
        public string GetInfo();
    }
}
