using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Suma
    {
        public void Sumar()
        {
            int n1, n2, ns, nr;
            Console.WriteLine("Digite primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            ns = n1 + n2;
            Console.WriteLine("La suma de "+n1+" + "+n2+" es: "+ns);

            nr = n1 - n2;
            Console.WriteLine("La resta de " + n1 + " - " + n2 + " es: "+nr);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
