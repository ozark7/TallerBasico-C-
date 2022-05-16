using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Division
    {
        public void Dividir() {

            float n1, n2, nd, nm;
            Console.WriteLine("Digite numerador(n1): ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite denominador(n2): ");
            n2 = float.Parse(Console.ReadLine());

            nd = n1 / n2;
            nm = n1 * n2;

            Console.WriteLine("La división de " + n1 + " / " + n2 + " es: " + nd);
            Console.WriteLine("La multiplicacion de " + n1 + " * " + n2 + " es: " + nm);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
