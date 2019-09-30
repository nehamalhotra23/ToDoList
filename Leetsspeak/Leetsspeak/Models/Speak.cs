using System;



namespace Speak 
{
    public class Generator
    {
        public void ReplaceLetters(string words)
        {
            char[] array = words.ToCharArray();
            // string newString = "";
            for(var i = 0; i<array.Length; i++)
            {
                if(array[i] == 'o')
                {
                    array[i] = '0';
                }
                
                
                // newString += letter.ToString().Replace("o","O");
                // newString += letter.ToString().Replace("e","3");
                //    Console.WriteLine(letter.ToString().Replace("o","0"));
                //    Console.WriteLine(letter.ToString().Replace("e","3"));
                //    Console.WriteLine(letter.ToString().Replace("I","1"));
                //    Console.WriteLine(letter.ToString().Replace("t", "7"));
                   // if s is the first letter of the word then replace it with a Z
                    // Console.WriteLine(newString);
                
            }
            Console.WriteLine(array); 
            
        }
    }
    class Program
        {
            static void Main()
        {
            Generator newOne = new Generator();
            newOne.ReplaceLetters("epicodus");
        }
        }
}
