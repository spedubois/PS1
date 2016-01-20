using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written by Spenser DuBois u0482113 - PS1 - CS 3500

namespace Palindrome
{
    /// <summary>
    ///  reads lines from its standard input stream and determines whether or not they are palindromes.  
    ///  (Palindromes are strings that are identical when reversed.)  
    ///  All lines that are palindromes should be written to the standard output stream in the order
    ///  in which they were read.
    /// </summary>
    public class Palindrome
    {
        public static void Main(string[] args)
        {
            String line;
            while ((line = Console.ReadLine()) != null)
            {
                char[] lineReverseArray = line.Reverse().ToArray();
                String build = "";
                for(int i = 0; i < line.Length; i++)
                {
                    build += lineReverseArray[i];
                }
                if(line == build)
                {
                    Console.WriteLine(line);
                }
               
            }
        }
    }
}
