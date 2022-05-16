using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Edad
    {
        public void EdadCalcular() 
        {
            int edad;
            Console.WriteLine("Digite edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Mayor de edad: ");
            }
            else if (edad < 18 && edad > 0)
            {
                Console.WriteLine("Menor de edad: ");
            }
            else
            {
                Console.WriteLine("Edad no valida: ");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
