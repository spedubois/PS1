using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written by Spenser DuBois u0482113 - PS1 - CS 3500

namespace Format
{
    /// <summary>
    /// reads lines from its standard input stream, breaks each line into tokens, 
    /// and writes the tokens to its standard output stream, n tokens per one line of output, 
    /// in the order in which they were read. If no argument is found or the argument is a negative number,
    /// n defaults to 1.
    /// </summary>
   public class Format
   {
        public static void Main(string[] args)
        {
            // numTokens = n 
            int numTokens;
            if(args.Length == 1)
            {
                if(int.Parse(args[0]) < 0)
                {
                    numTokens = 1;
                }
                numTokens = int.Parse(args[0]);
            }

            else
            {
                numTokens = 1;
            }

            String line;
            while ((line = Console.ReadLine()) != null)
            {
                String[] tokens = line.Split(' ');

                if(tokens.Length == 0)
                {
                    continue;
                }

                int n = 0;
                while(n < tokens.Length)
                {
                    String build = "";
                    for(int i = 0; i < numTokens; i++)
                    {
                        if(n == tokens.Length)
                        {
                            while((line = Console.ReadLine()).Length != 0)
                            {
                                line = Console.ReadLine();
                            }

                            tokens = line.Split(' ');
                            n = 0;
                          if(Console.ReadLine() == null)
                            {
                                break;
                            }
                            else
                            {
                                line = Console.ReadLine();
                                tokens = line.Split(' ');
                                n = 0;
                            }
                        }
                        build += tokens[n++] + " ";
                    }
                    Console.WriteLine(build.TrimEnd());
                }

            }

        }

    }
}

