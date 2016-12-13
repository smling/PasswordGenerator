using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = PasswordGenerator.Generate();
            System.Console.WriteLine("Generated Password: "+password);
            System.Console.WriteLine("Length: " + password.Length);
            ConsoleKeyInfo Key=System.Console.ReadKey();
        }
    }
}
