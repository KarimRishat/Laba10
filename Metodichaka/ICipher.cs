using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichaka
{
    interface ICipher
    {
        string encode(string s);
        string decode(string s);
    }
}
