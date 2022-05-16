using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Par
    {

        public void ParIm() {

            int n1;

            Console.Write("Digite numero: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 %2 == 0)
            {
                Console.WriteLine("Numero par: ");

            }
            else
            {
                Console.WriteLine("Numero impar");
            }

            Console.ReadKey();
            Console.Clear();
        }

    }
}
