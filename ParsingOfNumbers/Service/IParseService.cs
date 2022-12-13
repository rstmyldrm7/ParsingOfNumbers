using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingOfNumbers.Service
{
    public interface IParseService
    {
        Task<string> ParseTheText(string text);
    }
}
