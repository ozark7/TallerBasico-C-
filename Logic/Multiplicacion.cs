using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Multiplicacion
    {
        public void Multiplicar() {

            int n1, n2;

            Console.WriteLine("Digite el numero de la tabla que quiere: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el numero hasta donde quiere que llegue la tabla: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("TABLA DEL " + n1);

            for (int i = 1; i <= n2; i++)
            {
                Console.WriteLine(n1 + " x " + i + " = " + n1 * i);

            }



            Console.ReadKey();
            Console.Clear();
        }
        
    }
}
