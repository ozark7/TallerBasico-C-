using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
        public class CalculoCorporal
        {
        public void CalcularImc() {

            
            double imc, peso, altura;
            Console.WriteLine("Digite peso(kg) ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite altura(m) ");
            altura = double.Parse(Console.ReadLine());

            
            imc = Math.Round(peso / (double)Math.Pow(altura, 2),2);  

            if (imc < 18.5)
            {
                Console.WriteLine("Su imc es de: " + imc);
                Console.WriteLine("Su estado es de insuficiencia ponderal ");
            }
            else if (imc > 18.5 && imc < 24.9)
            {
                Console.WriteLine("Su imc es de: " + imc);
                Console.WriteLine("Su estado es de intervalo normal ");
            }
            else if (imc >= 25.0)
            {
                Console.WriteLine("Su imc es de: " + imc);
                Console.WriteLine("Su estado es de sobrepeso ");
            }
            else if (imc > 25.0 && imc < 29.9)
            {
                Console.WriteLine("Su imc es de: " + imc);
                Console.WriteLine("Su estado es de preobesidad ");
            }
            else if (imc >= 30.0)
            {
                Console.WriteLine("Su imc es de: " + imc);
                Console.WriteLine("Su estado es de obesidad ");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
