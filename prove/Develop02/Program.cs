using System;  

namespace JournalApp  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Journal journal = new Journal();  
            PromptGenerator promptGenerator = new PromptGenerator();  
            bool running = true;  

            while (running)  
            {  
                Console.WriteLine("");  
                Console.WriteLine("Journal Menu:");  
                Console.WriteLine("1. Write a new entry");  
                Console.WriteLine("2. Display the journal");  
                Console.WriteLine("3. Save the journal to a file");  
                Console.WriteLine("4. Load the journal from a file");  
                Console.WriteLine("5. Exit");  
                Console.Write("Choose an option (1-5): ");  
                string choice = Console.ReadLine();  
                Console.WriteLine("");  

                switch (choice)  
                {  
                    case "1":  
                         // Write a new entry
                        string prompt = promptGenerator.GetRandomPrompt();  
                        Console.WriteLine($"Today's Question: {prompt}");  
                        Console.WriteLine(""); 
                        Console.Write("Your entry title: ");  
                        string entryTitle = Console.ReadLine();  
                        Console.Write("Your entry: ");  
                        string entryText = Console.ReadLine();  
                        Console.Write("How are you feeling today? ");  
                        string mood = Console.ReadLine();  
                        Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), entryTitle, prompt, entryText, mood);  
                        journal.AddEntry(entry);  
                        Console.WriteLine("Entry added.\n");  
                        break;  

                    case "2":  
                        // Display the journal  
                        Console.WriteLine("\nYour Journal Entries:");  
                        journal.DisplayAll();  
                        break;  

                    case "3":  
                        // Save the journal to a file  
                        Console.Write("Enter filename to save (CSV format): ");  
                        string saveFileName = Console.ReadLine();  
                        journal.SaveToFile(saveFileName);  
                        Console.WriteLine("Journal saved.\n");  
                        break;  

                    case "4":  
                        // Load the journal from a file  
                        Console.Write("Enter filename to load (CSV format): ");  
                        string loadFileName = Console.ReadLine();  
                        journal.LoadFromFile(loadFileName);  
                        Console.WriteLine("Journal loaded.\n");  
                        break;  

                    case "5":  
                        // Exit  
                        running = false;  
                        Console.WriteLine("Exiting the program. Goodbye!");  
                        break;  

                    default:  
                        Console.WriteLine("Invalid option. Please choose again.\n");  
                        break;  
                }  
            }  
        }  
    }  
}