using System;



namespace Speak 
{
    public class Generator
    {
        public char[] ReplaceLetters(string words)
        {
            char[] array = words.ToCharArray();
            // string newString = "";
            for(var i = 0; i<array.Length; i++)
            {
                if(array[i] == 'o')
                {
                    array[i] = 'O';
                } else if(array[i] == 'e') 
                {
                    array[i] = '3';
                } else if(array[i] == 't') 
                {
                    array[i] = '7';
                } else if(array[i] == 'I') 
                {
                    array[i] = '1';
                } 


                for (var j = 1; j<array.Length; j++) {
                    if (array[j] == 's') 
                    {
                        array[j] = 'z';
                    }
                }
            }
            return array;
        }
    }
    class Program
        {
            static void Main()
        {
            Console.WriteLine("Enter a sentence");
            string userInput = Console.ReadLine();
            Generator newOne = new Generator();
            Console.WriteLine(newOne.ReplaceLetters(userInput));
            
        }
    }
}
