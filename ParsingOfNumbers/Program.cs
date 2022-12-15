using ParsingOfNumbers.Service;
using System;
using System.Threading.Tasks;

namespace ParsingOfNumbers
{
    public class Program
    {
        private readonly IParseService _parseService;
        public Program(IParseService parseService)
        {
            _parseService = parseService;
        }

        public async Task<string> Parse(string text)
        {
            var respText = await _parseService.ParseTheText(text);
            return respText;
        }
        static async Task Main(string[] args)
        {
            var unparsedText = "He paid twenty millions for three such cars";

            IParseService parseService = new ParseService();
            var program = new Program(parseService);

            var parsedText = await program.Parse(unparsedText);

            Console.WriteLine(parsedText);
            Console.ReadLine();
        }
    }
}
