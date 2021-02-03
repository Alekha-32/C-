using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            ISpellChecker spellChecker = new EmailApplication();
            ISpellCheckerSpanish spellCheckerSpanish = new EmailApplication();
            Console.WriteLine(spellChecker.performSpellCheck());
            Console.WriteLine(spellCheckerSpanish.PerformSpellCheck());
            Console.ReadLine();
        }
    }
}
