using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_menu
{
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
                    Console.WriteLine("2. Ejercicio 2");
                    Console.WriteLine("3. Ejercicio 3");
                    Console.WriteLine("4. Ejercicio 4");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:

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

    public static class problemas
    {
        public static bool scrable(string frase1, string frase2)
        {
            bool scrable = false;
            if (frase1.Length == frase2.Length)
            {
                int positions = frase1.Length;
                
            }
            else
            {
                scrable = false;
            }
            return scrable;
        }
    }
}