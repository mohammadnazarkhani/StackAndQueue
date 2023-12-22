using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace StackAndQueue
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("PrintManager by using Queues:");
            var printer = new PrintManager<string>();
            printer.AddPrintTask("Document 1");
            printer.AddPrintTask("Document 2");
            printer.AddPrintTask("Document 3");

            printer.Run();

            Console.WriteLine("\nSyntax Validation using stacks: ");
            var code = "(var x = {y: [1, 2, 3]})";
            var linter = new Linter();
            Console.WriteLine("Syntax of the code: {0} {1} correct!",code, (linter.IsBraceSyntaxCorrect(code) ? "is" : "is not"));
        }
    }
}
