using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class FileOutput : Output
    {
        private string _filePath;

        public FileOutput(string filePath)
        {
            _filePath = filePath;
        }

        public override void EchoSomethingToALine(string value)
        {
            Console.WriteLine("I should write {0} to {1}", value, _filePath);
        }
    }
}
