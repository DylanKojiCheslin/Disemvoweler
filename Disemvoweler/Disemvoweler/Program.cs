using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {   //this function takes a string input and prints that string with out any vowels(a,e,i,o,u) or spaces
        // an example of the output 
        //Original: <inString>
        //Disemvoweled: <disemvoweled text>
        static string Disemvoweler(string inString) //create funtion, take input
        {
            string x = inString.ToLower();//makes a new string that is the input but in lower case
            string oString = "";//makes empty string to store the <disemvoweled text>
            string vowels = "";//a string to save the vowels that are removed from input
            for (int i = 0; i < x.Length; i++)//loops through the x
            {
                //if it is a vowel it is added to the vowels string
                if (x[i] == 'a'||x[i] == 'e'||x[i] == 'i'||x[i] == 'o'||x[i] == 'u')
                {
                    vowels += x[i];
                }
                //if it is a consonant add it to oString
                else if (x[i] == 'b'||x[i] == 'c'||x[i] == 'd'||x[i] == 'f'||x[i] == 'g'||x[i] == 'h'||x[i] == 'j'||x[i] == 'k'||x[i] == 'l'||x[i] == 'm'||x[i] == 'n'||x[i] == 'p'||x[i] == 'q'||x[i] == 'r'||x[i] == 's'||x[i] == 't'||x[i] == 'v'||x[i] == 'w'||x[i] == 'x'||x[i] == 'y'||x[i] == 'z')
                {
                    oString += x[i];
                }
                
            }
            return oString;
        }
        static void Main(string[] args)
        {
            //declares text to be printed and sent to Disemvoweler function
            string a = "Nickleback is mmy favorite band.Their songwriting can'testc be beat!";
            string b = "How many bears could bear grylls grill if bear grylls could grill bears?";
            string c = "I'm a code ninja, baby. I make the functions and I make the calls.";
            //prints output
            Console.WriteLine("Original: "+a);
            Console.WriteLine("Disemvoweled: "+Disemvoweler(a));
            Console.WriteLine("Original: " + b);
            Console.WriteLine("Disemvoweled: " + Disemvoweler(b));
            Console.WriteLine("Original: " + c);
            Console.WriteLine("Disemvoweled: " + Disemvoweler(c));
            Console.ReadKey();//keeps page open
        }
    }
}
