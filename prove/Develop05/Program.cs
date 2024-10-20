// Exceed Requirements  
//   
// -Added new activity: "Gratitude Activity
// -Modified the random selection of prompts and questions to ensure that no prompt or question is repeated until all have been used at least once in the session.  

using System;  

namespace MindfulnessProgram  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
        
            while (true)  
            {  
                Console.Clear();  
                Console.WriteLine("Welcome to the Mindfulness Program!");  
                Console.WriteLine("Please choose an activity:");  
                Console.WriteLine("1. Breathing Activity");  
                Console.WriteLine("2. Reflection Activity");  
                Console.WriteLine("3. Listing Activity");  
                Console.WriteLine("4. Gratitude Activity");  
                Console.WriteLine("5. Exit");  

                string choice = Console.ReadLine();  
                if (choice == "5")  
                {  
                    Console.WriteLine("Thank you for using the program!");  
                    break; // Exit the program  
                }  

                Activity activity = null;  

                switch (choice)  
                {  
                    case "1":  
                        activity = new BreathingActivity();  
                        break;  
                    case "2":  
                        activity = new ReflectingActivity();  
                        break;  
                    case "3":  
                        activity = new ListingActivity();  
                        break;  
                    case "4":  
                        activity = new GratitudeActivity();  
                        break;  
                    default:  
                        Console.WriteLine("Invalid choice. Please try again.");  
                        continue; // Skip the rest of the loop and prompt the user again  
                }  

                activity.Run();  
            }  

        }  
    }  
}
