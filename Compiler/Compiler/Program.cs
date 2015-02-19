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
            Block1Scanner myScanner = new Block1Scanner();
            myScanner.Init(textSrc, errorList);

            string line;
            // Read and display lines from the file until the end of  
            // the file is reached. 
            while ((line = textSrc.ReadLine()) != null)
            {
                tokenList.Add(myScanner.NextToken());
                //Console.WriteLine(line);
            }

            Console.WriteLine(tokenList.Count);
            foreach (IToken token in tokenList)
            {
                Console.WriteLine("token start line {0}", token.Line);
                Console.WriteLine("token start col {0}", token.Column);
                Console.WriteLine("token type {0}", token.TokenType);
                Console.WriteLine("token value {0}", token.TokenValue);

            }
            Console.ReadLine();


        }
    }
}
