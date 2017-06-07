using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var specialWords = Console.ReadLine().Split(' ');
            var text = Console.ReadLine().Split(new char[] { ' ', '(', ')', '[', ']', '<', '>', ',', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, int>();


            for (int i = 0; i < specialWords.Length; i++)
            {
                if (!dict.ContainsKey(specialWords[i]))
                {
                    dict.Add(specialWords[i], 0);
                }
                
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (dict.ContainsKey(text[i]))
                {
                    dict[text[i]]++;
                }
                
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
