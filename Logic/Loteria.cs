using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Loteria
    {
        public void Lotery() {

            int nGanador = 2003;
            int inte = 3;

            do
            {
                Console.WriteLine("Digite su numero de 4 cifras: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == nGanador)
                {
                    Console.Write("Usted ha ganado la desorbitada suma de MIL MILLONES DE BOLIVARES");
                    inte = 0;
                }
                else
                {
                     inte = inte - 1;
                     Console.Write("Le quedan " + inte + " intentos: ");
                }
            } while (inte != 0);

            Console.Write("Esperamos haya ganado, si no fue asi, siga intentando ");
            

        }
    }
}
