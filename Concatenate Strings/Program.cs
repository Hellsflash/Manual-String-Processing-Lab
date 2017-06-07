using System;
using System.Text;

namespace Concatenate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();

                sb.Append(input+" ");

            }

            Console.WriteLine(sb);
        }
    }
}
