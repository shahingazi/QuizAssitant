using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Quiz
{
    public interface IAIPrompt
    {
        string GetAnswer(string input);
    }
}
