using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bienvenida();
            Calculo_Edad();
        }

        static void Bienvenida()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("| << Bienvenida al calculo de edad por Consola >> |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("---------------------------------------------------");
        }

        static void Calculo_Edad()
        {
            try
            {
                Console.Write("\nIntroduzca su nombre : ");
                String nombre;
                nombre = Console.ReadLine();

                Console.Write("\nIntroduzca su año de nacimiento. << ejemplo: 2000 >> : ");
                int año;
                año = Int32.Parse(Console.ReadLine());

                Console.Write("\nIntroduzca su mes de nacimiento. << ejemplo: 12 >> : ");
                int mes;
                mes = Int32.Parse(Console.ReadLine());

                Console.Write("\nIntroduzca su día de nacimiento. << ejemplo: 20 >> : ");
                int dia;
                dia = Int32.Parse(Console.ReadLine());

                DateTime nacimiento = new DateTime(año, mes, dia); //Fecha de nacimiento
                int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;

                Console.WriteLine();
                Console.WriteLine("******************************************************");
                Console.WriteLine("La edad de : " + nombre + " es de " + edad + " años. ");
                Console.WriteLine("******************************************************");


                Console.Write("\nPress <Enter> to exit... ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nVuelva a intentarlo y asegurese de ingresar correctamente los campos\n");
                Console.WriteLine("<< Error : " + e.Message + " >>");

                Console.Write("\nPress <Enter> to exit... ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n<< Error : " + e.Message + " >>");

                Console.Write("\nPress <Enter> to exit... ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
        }
    }
}
