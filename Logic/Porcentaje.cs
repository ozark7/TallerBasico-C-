using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Porcentaje
    {
        public void Percentage() {

            float n1, n2, np;
            Console.WriteLine("Digite numero: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite porcentaje: ");
            n2 = float.Parse(Console.ReadLine());

            np = (n1 * n2)/100;
            Console.WriteLine("El " + n2 +"% "+" de " + n1 + " es: "+np);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
