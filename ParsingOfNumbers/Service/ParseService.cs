using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingOfNumbers.Service
{
    public class ParseService : IParseService
    {
        public async Task<string> ParseTheText(string text)
        {
            //The parsing process will be here
            var unparsedText = "Hello";
            return unparsedText;
        }
    }
}
