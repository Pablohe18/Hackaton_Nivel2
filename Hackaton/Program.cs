using Hackaton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_menu
{
    //carlos pablo Herrera Escobar 1082417
    //Edwin Leonardo Hilario Gómez 1298816
    class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Problema 1: Scramble");
                    Console.WriteLine("2. Problema 2: ");
                    Console.WriteLine("3. Problema 3: Subsecuente");
                    Console.WriteLine("4. Ejercicio 4");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Problema 1: Scramble");
                            Console.WriteLine("Ingresa la primera Frase:");
                            string frase1 = Console.ReadLine();
                            Console.WriteLine("Ingresa la segunda Frase:");
                            string frase2 = Console.ReadLine();
                            var scrable = new Scramble();
                            if (scrable.CompareScramble(frase1, frase2))
                            {
                                Console.WriteLine("Es Scramble");
                            }
                            else
                            {
                                Console.WriteLine("No es Scramble");
                            }

                            break;

                        case 2:
                            Console.WriteLine("Has elegido la opción 2");
                            break;

                        case 3:
                            Console.WriteLine("Has elegido la opción 3");
                            break;
                        case 4:
                            Console.WriteLine("Has elegido la opción 4");
                            break;
                        case 5:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();

        }
    }


}