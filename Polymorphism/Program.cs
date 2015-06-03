using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output consoleVar = new ConsoleOutput();
            //Output fileVar = new FileOutput("C:/Work/Claim/foo.txt");

            Output outputVar;
            string response = Console.ReadLine();
            if (response == "h")
            {
                outputVar = new ConsoleOutput();
            }
            else
            {
                outputVar = new FileOutput("C:/Work/Claim/foo.txt");
            }

            WriteSomeStuffToOutput(outputVar);
            //WriteSomeStuffToOutput(fieVar);

            Foo(outputVar as ConsoleOutput);
            //Foo(fileOutput);

            Console.ReadLine();
        }

        static void WriteSomeStuffToOutput(Output output)
        {
            output.EchoSomethingToALine("Howdy");
            output.EchoSomethingToALine("Goodbye");
        }

        static void Foo(ConsoleOutput output)
        {
            if (output == null)
            {
                return;
            }

            output.EchoSomethingToALine("Needs console output");
            output.ChangeColor();
        }
    }

    abstract class Output
    {
        public abstract void EchoSomethingToALine(string value);
    }
}
