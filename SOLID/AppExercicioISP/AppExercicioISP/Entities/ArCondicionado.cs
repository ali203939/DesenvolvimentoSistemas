using AppExercicioISP.Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioISP.Entities
{
    public class ArCondicionado : IControlavel, IAjustavel
    {
        public void AjustarTemperatura(int graus)
        {
            
        }

        public void Desligar()
        {
            Console.WriteLine("Ar condicionado desligado.");
        }

        public void Ligar()
        {
           
        }
    }
}
