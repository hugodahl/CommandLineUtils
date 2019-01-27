using System;

using CommandLine;

namespace CommandLineParserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

public class Parameters
{


    public bool Debug {get; private set;}
    public string Info {get; private set;}
    public int Port {get; private set;}
}

}
