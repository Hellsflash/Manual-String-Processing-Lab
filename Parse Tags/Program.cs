using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var oTag = "<upcase>";
            var cTag = "</upcase>";

            int startIndex = text.IndexOf(oTag);

            while (startIndex != -1)
            {
                int endIndex = text.IndexOf(cTag);

                if (endIndex==-1)
                {
                    break;
                }
                var toReplace = text.Substring(startIndex, endIndex + cTag.Length - startIndex);

                var replaced = toReplace.Replace(oTag, String.Empty).Replace(cTag, String.Empty).ToUpper();


                text = text.Replace(toReplace, replaced);

                startIndex = text.IndexOf(oTag);
            }

            Console.WriteLine(text);
        }
    }
}
