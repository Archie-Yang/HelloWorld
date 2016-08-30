using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var buf = new byte[4];
            var rBuf = __makeref(buf[0]);
            **(int**)&rBuf = 0x12345678;
            Console.WriteLine(BitConverter.ToString(buf));
            Console.ReadKey(true);
        }
    }
}
