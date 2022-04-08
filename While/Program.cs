using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            String contra1, contra2 = "";
            Console.WriteLine("Escribe tu contrasena: ");
            contra1 = Console.ReadLine();
            while(contra1 != contra2)
            {
                Console.WriteLine("Confirma tu contrasena");
                contra2 = Console.ReadLine();
            }
            Console.WriteLine("Contasena gurdada");
            Console.ReadKey();
        }
    }
}
