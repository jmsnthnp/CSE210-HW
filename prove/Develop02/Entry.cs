using System;  

namespace JournalApp  
{  
    public class Entry  
    {  
        private string _date;  
        private string _promptText;  
        private string _entryText;  
        private string _title;  
        private string _mood;  

        public Entry(string date, string title, string promptText, string entryText, string mood)  
        {  
            _date = date;  
            _title = title;  
            _promptText = promptText;  
            _entryText = entryText;  
            _mood = mood;  
        }  

        public string GetFormattedEntry()  
        {  
            return $"{_date}, \"{_title}\", \"{_promptText}\", \"{_entryText}\", \"{_mood}\"";  
        }  

        public void Display()  
        {  
            Console.WriteLine($"Date: {_date}");  
            Console.WriteLine($"Question: {_promptText}");
            Console.WriteLine($"Title: {_title}");  
            Console.WriteLine($"Entry: {_entryText}");  
            Console.WriteLine($"Mood: {_mood}");  
            Console.WriteLine();  
        }  
    }  
}