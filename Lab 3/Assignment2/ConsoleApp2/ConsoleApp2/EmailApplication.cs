using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EmailApplication : ISpellCheckerSpanish, ISpellChecker
    {

        string ISpellCheckerSpanish.PerformSpellCheck()
        {
            return "Performed spell check using Spanish";
        }

        string ISpellChecker.performSpellCheck()
        {
            return "Performed spell check using English";
        }
    }
}
