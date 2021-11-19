using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichaka
{
    class BCipher : ICipher
    {
        public string decode(string s)
        {
            string news = "";
            foreach (char c in s)
            {
                int i = (int)c;
            }
            return s;
        }

        public string encode(string s)
        {
            throw new NotImplementedException();
        }
    }
}
