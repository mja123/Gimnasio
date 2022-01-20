using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    static class Codify
    {
        private static string result;
        public static string toEncode(string password)
        {
            byte[] encode = System.Text.Encoding.Unicode.GetBytes(password);
            result = Convert.ToBase64String(encode);
            return result;
        }

    }
}
