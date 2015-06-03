using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class ConsoleOutput : Output
    {
        public override void EchoSomethingToALine(string value)
        {
            Console.WriteLine(value);
        }

        public void ChangeColor()
        {

        }
    }
}
