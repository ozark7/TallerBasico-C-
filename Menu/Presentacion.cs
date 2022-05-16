using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Menu
{
    public class Presentacion
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("===========  EJERCICIOS SENCILLOS  ===========");
                Console.WriteLine("== IMC                                 --> 1");
                Console.WriteLine("== SUMA-RESTA                          --> 2");
                Console.WriteLine("== PORCENTAJE                          --> 3");
                Console.WriteLine("== MAYOR DE EDAD                       --> 4");
                Console.WriteLine("== DIVISIÓN-MULTIPLICACIÓN             --> 5");
                Console.WriteLine("========== EJERCICIOS INTERMEDIOS ==========");
                Console.WriteLine("== NUMERO PAR-IMPAR                    --> 6");
                Console.WriteLine("== CREDITO                             --> 7");
                Console.WriteLine("== SERIE FIBONACCI                     --> 8");
                Console.WriteLine("== LOTERIA                             --> 9");
                Console.WriteLine("== TABLA DE MULTIPLICAR                --> 10");


                Console.WriteLine("== SALIR                               -->  0");

                opcion = int.Parse(Console.ReadLine()); 

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        CalculoCorporal imc = new CalculoCorporal();
                        imc.CalcularImc();
                        break;
                    //
                    case 2:
                        Console.Clear();
                        Suma suma1 = new Suma();
                        suma1.Sumar();
                        break;
                    //
                    case 3:
                        Console.Clear();
                        Porcentaje porce = new Porcentaje();
                        porce.Percentage();
                        break;
                    //
                    case 4:
                        Console.Clear();
                        Edad edad = new Edad();
                        edad.EdadCalcular();
                        break;
                    //
                    case 5:
                        Console.Clear();
                        Division dividir = new Division();
                        dividir.Dividir();
                        break;
                    //
                    case 6:
                        Console.Clear();
                        Par par = new Par();
                        par.ParIm();
                        break;
                    //
                    case 7:
                        Console.Clear();
                        Cajero credito = new Cajero();
                        credito.ConsulCredito();
                        break;
                    //
                    case 8:
                        Console.Clear();
                        Fibonacci fibonacci = new Fibonacci();
                        fibonacci.SerieF();
                        break;
                    //
                    case 9:
                        Console.Clear();
                        Loteria loteria = new Loteria();
                        loteria.Lotery();
                        break;
                    case 10:
                        Console.Clear();
                        Multiplicacion tablam = new Multiplicacion();
                        tablam.Multiplicar();
                        break;
                }
                
            } while (opcion != 0);


        }
    }
}
