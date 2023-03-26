using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020.parosotventoltizig
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 50; i > 9; i--)

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            Console.ReadKey();
        }
    }
}
