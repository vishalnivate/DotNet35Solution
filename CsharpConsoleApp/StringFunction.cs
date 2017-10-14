using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    // Rule I Class has to Static
    public static class StringFunction
    {
        //Rule II The Method has to static
        //Rule III the 1st arg of the Method can be made as extantion by adding the key words
        public static string Vishal(this string Value)
        {
            char[] ch = Value.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                sb.Append(ch[i]);
            }
            return sb.ToString();
        }
    }
}
