using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichaka
{
    class ACipher:ICipher
    {
        public string encode(string s)
        {
            string news = "";
            foreach (char c in s)
            {
                switch (c)
                {
                    case 'Z':
                        news += 'A';
                        break;
                    case 'z':
                        news += 'a';
                        break;
                    case 'Я':
                        news += 'А';
                        break;
                    case 'я':
                        news += 'а';
                        break;
                    default:
                        news += (char)((int)c + 1);
                        break;
                }
            }
            s = news;
            Console.WriteLine("EncodeA: "+s);
            return s;
        }
        public string decode(string s)
        {
            string news = "";
            foreach (char c in s)
            {
                switch (c)
                {
                    case 'A':
                        news += 'Z';
                        break;
                    case 'a':
                        news += 'z';
                        break;
                    case 'А':
                        news += 'Я';
                        break;
                    case 'а':
                        news += 'я';
                        break;
                    default:
                        news += (char)((int)c - 1);
                        break;
                }
            }
            s = news;
            Console.WriteLine("DecodeA: " + s);
            return s;
        }
    }
}
