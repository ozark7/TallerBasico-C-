using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
          public class Cajero
          {

            public void ConsulCredito() {

                String cadena = "holamundo";
                String usuario = "ozark";
                String l,u;
                int cont = 3;


                do
                {

                    Console.Write("Digite usuario: ");
                    u = Console.ReadLine();
                    Console.Write("Digite clave (sin espacios): ");
                    l = Console.ReadLine();
                    if (l.Equals(cadena) && u.Equals(usuario))
                    {
                        Console.Clear();
                        Console.WriteLine("Clave y Usuario correcto, su credito es de 1.000.000: ");
                        cont = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Clave o Usuario incorrecto ");
                        cont = cont - 1;
                        Console.WriteLine("Intentos restantes " + cont+", verifique antes de seguir intentando: ");
                        Console.ReadLine();
                    Console.Clear();
                        
                        if (cont == 0)
                        {
                            Console.Write("Su cuenta ha sido suspendida por 24 horas");
                        }

                    }
                } while (cont != 0);
                
                


                Console.ReadKey();
                Console.Clear();

        }
            
    }
}
