using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written by Spenser DuBois u0482113 - PS1 - CS 3500


namespace LowerCase
{
    /// <summary>
    /// reads lines from its standard input stream, breaks each line into tokens 
    /// (sequences of non-white-space characters delimited by white space), 
    /// converts the tokens into lower case, and writes the new tokens (one per output line) 
    /// to its standard output stream in the order in which they were read.
    /// </summary>
    public class LowerCase
    {
        public static void Main(string[] args)
        {
            String line;
            while ((line = Console.ReadLine()) != null)
            {
                Console.WriteLine(line.ToLower());
            }
        }
    }
}
