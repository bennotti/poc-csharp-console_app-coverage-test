using System;

namespace SampleProject
{
    public class Greeter
    {
        public string SayHello(string param)
        {
            if (string.IsNullOrEmpty(param)) return string.Empty;
            return $"Hello {param}";
        }
    }
}
