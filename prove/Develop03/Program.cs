using System;  

namespace ScriptureMemorizer  
{  
    public class Program  
    {  
        public static void Main()  
        {  
            // Load scriptures from a file  
            string filePath = @"C:\Users\Image\Desktop\CSE210-HW\prove\Develop03\scriptures.txt";
            ScriptureLibrary library = new ScriptureLibrary(filePath);  
            Scripture scripture = library.GetRandomScripture();  

            while (true)  
            {  
                Console.Clear();  
                
                Console.WriteLine(scripture.GetDisplayText());  
                Console.WriteLine("");
                Console.WriteLine("Type 'next' for a new scripture, or press Enter to hide random words, or type 'quit' to exit:");  

                string input = Console.ReadLine();  

                if (input.ToLower() == "quit")  
                {  
                    break;  
                }  
                else if (input.ToLower() == "next")  
                {  
                    scripture = library.GetRandomScripture(); // Get a new random scripture  
                    continue; // Skip the rest of the loop and display the new scripture  
                }  

                if (scripture.CountVisibleWords() > 0)  
                {  
                    scripture.HideRandomWords(3); // Hide 3 random words  
                }  

                if (scripture.IsCompletelyHidden())  
                {  
                    Console.Clear();  
                    Console.WriteLine("All words are now hidden. Exiting...");  
                    break;  
                }  
            }  
        }  
    }  
}