using SampleProjectLib;
using System;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Greeter();
            
            Console.WriteLine(obj.SayHello("World!"));
        }
    }
}
