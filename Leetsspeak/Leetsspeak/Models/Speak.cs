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
            Console.WriteLine(array); 
            
        }
    }
    class Program
        {
            static void Main()
        {
            Generator newOne = new Generator();
            newOne.ReplaceLetters("Don't you love these String exercises? I do!");
        }
        }
}
