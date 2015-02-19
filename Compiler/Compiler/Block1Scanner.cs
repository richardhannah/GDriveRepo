using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllanMilne.Ardkit;

namespace Compiler
{
    class Block1Scanner : Scanner
    {

        protected override IToken getNextToken()
        {
            IToken token = null;
            int state = 0;
            int startLine = 0;
            int startCol = 0;
            StringBuilder strbuf = new StringBuilder();
            while (token == null)
            {
                
                
                Console.WriteLine("Line {0}", line);
                Console.WriteLine("Column {0}", column);
                Console.WriteLine("current char {0}", currentChar);

                switch (state)
                {
                    case 0:
                        if (Char.IsWhiteSpace(currentChar)) state = 0;
                        else if (Char.IsLetter(currentChar)) state = 1;
                        else if (Char.IsDigit(currentChar)) state = 2;
                        else if (currentChar == '=') state = 3;
                        else if (currentChar == '>') state = 4;
                        else if (currentChar == eofChar) state = 98;
                        else state = 99;
                        break;
                    case 1:
                        startLine = line;
                        startCol = column;
                        
                        if (Char.IsLetter(currentChar) || Char.IsDigit(currentChar))
                            state = 1;
                        else token = new Token(Token.IdentifierToken, strbuf.ToString(), startLine, startCol);
                        break;
                    case 2:   // Integer
                        startLine = line;
                        startCol = column;
                        if (Char.IsDigit(currentChar)) state = 2;
                        else token = new Token(Token.IntegerToken, strbuf.ToString(), startLine, startCol);
                        break;
                    case 3:   // “=” token found.
                        startLine = line;
                        startCol = column;
                        token = new Token("=", "", startLine, startCol);
                        break;
                    case 4:   // > or >=
                        startLine = line;
                        startCol = column;
                        if (currentChar == '=') state = 5;
                        else token = new Token(">", "", startLine, startCol);
                        break;
                    case 5:
                        startLine = line;
                        startCol = column;
                        token = new Token(">=", "", startLine, startCol);
                        break;
                    case 98:
                        startLine = line;
                        startCol = column;
                        token = new Token(Token.EndOfFile, "", startLine, startCol); break;
                    case 99:
                        startLine = line;
                        startCol = column;
                        token = new Token(Token.InvalidChar, "", startLine, startCol); break;
                } // end switch.

                if (token == null)
                {
                    if (state != 0)
                    {
                        strbuf.Append(currentChar);
                    }
                    Console.WriteLine(strbuf.ToString());
                    getNextChar();
                }
                // end while token not found.


            }
            return token;


        }
    }
}
