using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateCasa.Factory;

namespace TemplateCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Casa casa;

            Console.WriteLine("Desea construir una casa de madera o una casa de ladrillos?");
            var ans = Console.ReadLine();

            if(ans == "madera")
            {
                casa = new CasaMadera(true, false, true, "Temporal");
            }
            else if(ans == "ladrillo")
            {
                casa = new CasaLadrillos(false, true, false, "Permanente");
            }
            else
            {
                Console.WriteLine("Opcion no valida.");
                return;
            }

            Console.WriteLine("\nConstruyendo: " + casa.Name + ", " + casa.Tipo);
            Console.ReadKey();

            casa.Construir();

            Console.ReadKey();

        }
    }
}
