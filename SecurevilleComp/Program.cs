using System;
using System.Linq;
using System.Text;

namespace SecurevilleComp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                var inputTextArray = userInput.ToCharArray();

                var conv = new CaesarShiftCipher
                {
                    OffSet = -3
                };
                var outputText = new StringBuilder();
                
                foreach (var inputChar in inputTextArray)
                {
                    var outputChar = conv.ConvertChar(inputChar);
                    outputText.Append(outputChar);
                }

                Console.WriteLine(outputText.ToString());
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            var waitInput = Console.ReadLine();
        }
    }
}
