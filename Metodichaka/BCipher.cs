using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichaka
{
    class BCipher : ICipher
    {
        static char[] alphabet1 = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
            'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф',
            'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
        static char[] alphabet2 = {'a','b','c','d','e','f','g','h','i','j',
            'k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        public string encode(string s)
        {
            string news = "";
            foreach (char c in s)
            {
                int i = Array.IndexOf(alphabet1, c);    //ищем срди русских букв
                if (i >= 0 && i <= alphabet1.Length )
                {
                    i = alphabet1.Length - i-1;
                    news += alphabet1[i];
                }
                else
                {
                    i = Array.IndexOf(alphabet2, c);
                    if (i >= 0 && i <= alphabet2.Length)
                    {
                        i = alphabet2.Length - i - 1;
                        news += alphabet2[i];
                    }
                }
            }
            s = news;
            Console.WriteLine("EncodeB: " + s);
            return s;
        }

        public string decode(string s)
        {
            string news = "";
            foreach (char c in s)
            {
                int i = Array.IndexOf(alphabet1, c);    //ищем срди русских букв
                if (i >= 0 && i <= alphabet1.Length)
                {
                    i = alphabet1.Length - i - 1;
                    news += alphabet1[i];
                }
                else
                {
                    i = Array.IndexOf(alphabet2, c);
                    if (i >= 0 && i <= alphabet2.Length)
                    {
                        i = alphabet2.Length - i - 1;
                        news += alphabet2[i];
                    }
                }
            }
            s = news;
            Console.WriteLine("DecodeA: " + s);

            return s;
        }
    }
}
