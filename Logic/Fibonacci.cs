using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Fibonacci
    {
        public void SerieF() {

            int a, b, limite, i, auxiliar;

            Console.Write("Digite numero donde sea mostrar la serie: ");
            
            limite = int.Parse(Console.ReadLine());
            Console.WriteLine("========");

            a = 0;
            b = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = a;
                Console.WriteLine(a);
                a = b;
                b = auxiliar + a;
                

            }
            Console.WriteLine("========");
            Console.WriteLine("ESTOS SON LOS PRIMEROS "+limite+" NUMEROS DE LA SERIE");
            Console.ReadKey();
            Console.Clear();

        
        }



    }
}
