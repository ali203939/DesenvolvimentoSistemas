using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploLSP.model
{
    public class CalcularArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo paralelogramo)
        {
            Console.Clear();
            Console.WriteLine("Cálculo da área do Paralelogramo\r\n");
            Console.WriteLine(paralelogramo.Altura + "*" + paralelogramo.Largura);
            Console.WriteLine();
            Console.WriteLine("Área: " + paralelogramo.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            double altura, largura;

            Console.WriteLine("Digite a largura do paralelogramo:");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do paralelogramo:");
            altura = Convert.ToDouble(Console.ReadLine());

            var quadrado = new Quadrado(largura, altura);
            var retangulo = new Retangulo(largura, altura);

            ObterAreaParalelogramo(quadrado);
            ObterAreaParalelogramo(retangulo);
        }
    }
}
