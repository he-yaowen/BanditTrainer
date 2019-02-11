using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandit.Helper
{
    public class TextHelper
    {
        public static string ConvertUTF8(byte[] bytes)
        {
            Encoding big5 = Encoding.GetEncoding("Big5");
            UTF8Encoding utf8 = new UTF8Encoding();

            string result = utf8.GetString(Encoding.Convert(big5, utf8, bytes)).Trim('\0');

            if (result == "0") {
                result = "";
            }

            return result;
        }
    }
}
