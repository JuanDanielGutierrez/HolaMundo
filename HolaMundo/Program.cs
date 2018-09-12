using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
            Console.ReadKey();
        }

        
        public static String CreateMessage()
        {
            int suma = 2 + 3;
            return "Hola Mundo "+suma;
        }
    }
}
