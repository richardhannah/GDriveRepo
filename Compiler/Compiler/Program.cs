using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllanMilne.Ardkit;
using System.IO;


namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICompilerError> errorList = new List<ICompilerError>();
            List<IToken> tokenList = new List<IToken>();
            TextReader textSrc = new StreamReader("testfile.txt");
            //Scanner myScanner = new Block1Scanner();
            Scanner myScanner = new PALScanner();
            myScanner.Init(textSrc, errorList);

            string line;
            // Read and display lines from the file until the end of  
            // the file is reached. 
            while ((line = textSrc.ReadLine()) != null)
            {
                tokenList.Add(myScanner.NextToken());
                //Console.WriteLine(line);
            }

            Console.WriteLine("Number of tokens scanned: {0}",tokenList.Count);
            Console.WriteLine(" ");


            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "Type", "Value", "Line", "Column");
            Console.WriteLine("================================================================================");
            foreach (IToken token in tokenList)
            {

                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", token.TokenType, token.TokenValue, token.Line, token.Column);

            }
            Console.ReadLine();


        }
    }
}
