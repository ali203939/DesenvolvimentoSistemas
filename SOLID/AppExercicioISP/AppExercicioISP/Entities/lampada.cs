using AppExercicioISP.Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioISP.Entities
{
    public class lampada : IControlavel
    {
        public void Desligar()
        {
            Console.WriteLine("Lâmpada desligada.");
        }

        public void Ligar()
        {
            
        }
    }
}
