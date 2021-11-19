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
            ACipher aCipher = new ACipher();
            Console.WriteLine("Input:");
            string s = Console.ReadLine();
            s = aCipher.encode(s);
            s = aCipher.decode(s);
            BCipher bCipher = new BCipher();
            s = bCipher.encode(s);
            s = bCipher.decode(s);
            Console.ReadKey();
        }
    }
}
