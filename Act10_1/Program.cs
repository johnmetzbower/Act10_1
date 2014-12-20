using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Author author = new Author();
                foreach (String name in author.GetAuthorList())
                {
                    Console.WriteLine(name);
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
