using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_URLs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string separator = "://";

            var tokens = input.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length != 2 || tokens[1].IndexOf('/') == -1)
            {

                Console.WriteLine("Invalid URL");
                return;
            }
            else
            {
                var protocol = tokens[0];
                var server = tokens[1].Substring(0, tokens[1].IndexOf('/'));
                var resourse = tokens[1].Substring(tokens[1].IndexOf('/')+1);

                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resourse}"); 

            }

            

        }
    }
}
