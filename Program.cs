using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_6
{
 
    class Program
    {

        static void Main(string[] args)
        
        { do
            {
                Console.WriteLine("Welcome to the Pig Latin Translator!");
                Console.WriteLine("Enter a word to be translated:");
                string input = Console.ReadLine();
                input = input.ToLower();
                string vowel = "aeiouAEIOU";
                string number = "0123456789";
                string symbol = "!@#$%^&*()";
                char[] inputArray = input.ToArray();
                char c = input[0]; //tommy: have spent days trying to figure out how to search other indexes, not just Index 0.  
                                    // have also tried various versions of IndexOf,IndexofAny and input.Length but could not get it.
                string firstLetter;
                string restWord;
                string pigLatinWord;
 
                firstLetter = input.Substring(0, 1);
                restWord = input.Substring(1, input.Length - 1);

                if (vowel.Contains(c))
                {
                    pigLatinWord = input + ("way"); //for a vowel
                }

                else
                {
                    pigLatinWord = restWord + (firstLetter + "ay"); //for a consonant , but have
                } //not figured out how to move all consonants from before the vowel.  

                if (number.Contains(c))//but will only run if number is Index 0
                {
                    pigLatinWord = input;
                }

                if (symbol.Contains(c)) //but will only run if symbol is Index 0
                {
                    pigLatinWord = input;
                }

                Console.WriteLine(pigLatinWord);

             } while (Continue() == true);
        } 

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("Does not compute!");
                run = Continue();

            }
            return run;
        }
    }
}
    


    
  

