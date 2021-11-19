using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichaka
{
    class Program
    {
        static void Main(string[] args)
        {
            //ACipher aCipher = new ACipher();
            Console.WriteLine("Input:");
            char s = (int)Console.Read();
            //s = aCipher.encode(s);
            //s = aCipher.decode(s);
            Console.WriteLine((int)((char)s));
            Console.ReadKey();
        }
    }
}
