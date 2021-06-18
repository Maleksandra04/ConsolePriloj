using System;
using System.Linq;

namespace ConsolePriloj
{
    class Program
    {
        static void Main( )
        {
            Console.WriteLine(string.Join("", Console.ReadLine().ToArray().Reverse()));
        }
    }
}
