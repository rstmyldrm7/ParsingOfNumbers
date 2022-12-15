using ParsingOfNumbers.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParsingOfNumbers.Service
{
    public class ParseService : IParseService
    {
        public async Task<string> ParseTheText(string text)
        {
            var numbers = DictionaryHelper.GetNumbers();
            var words = DictionaryHelper.GetListOfWords(text);

            StringBuilder result = new StringBuilder();
            string tempString = "";


            for(var i =0; i < words.Count();i++)
            {                
                if (numbers.ContainsKey(words[i]))
                {
                    if (i == words.Count() - 1)
                    {
                        tempString += words[i] + " ";
                        var numericResponse = DictionaryHelper.ParseTheText(tempString);
                        result.Append(numericResponse + " ");
                        continue;
                    }
                    tempString += words[i] + " ";
                }
                else
                {
                    if(!string.IsNullOrEmpty(tempString))
                    {
                        var numericResponse = DictionaryHelper.ParseTheText(tempString);
                        result.Append(numericResponse + " ");
                        tempString = "";
                    }
                    result.Append(words[i] + " ");                    
                }
            }
            return result.ToString();
        }
    }
}

