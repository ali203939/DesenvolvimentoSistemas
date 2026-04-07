using AppExercicioISP.Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioISP.Entities
{
    public class Televisao : IControlavel, ISintonizavel
    {
        public void Desligar()
        {
            Console.WriteLine("Televisão desligada.");
        }

        public void Ligar()
        {
        }

        public void MudarCanal(int canal)
        {

        }
    }
}
