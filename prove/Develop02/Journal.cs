using System;  
using System.Collections.Generic;  
using System.IO;  

namespace JournalApp  
{  
    public class Journal  
    {  
        private List<Entry> _entries;  

        public Journal()  
        {  
            _entries = new List<Entry>();  
        }  

        public void AddEntry(Entry newEntry)  
        {  
            _entries.Add(newEntry);  
        }  

        public void DisplayAll()  
        {  
            if (_entries.Count == 0)  
            {  
                Console.WriteLine("No entries found.");  
                return;  
            }  

            foreach (var entry in _entries)  
            {  
                entry.Display();  
            }  
        }  

        public void SaveToFile(string file)  
        {  
            using (StreamWriter writer = new StreamWriter(file))  
            {  
                foreach (var entry in _entries)  
                {  
                    writer.WriteLine(entry.GetFormattedEntry());  
                }  
            }  
        }  

        public void LoadFromFile(string file)  
        {  
            if (File.Exists(file))  
            {  
                _entries.Clear();  
                string[] lines = File.ReadAllLines(file);  
                foreach (var line in lines)  
                {  
                    var parts = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);  
                    if (parts.Length == 5)  
                    {  
                        var entry = new Entry(parts[0].Trim(), parts[1].Trim().Trim('"'), parts[2].Trim().Trim('"'), parts[3].Trim().Trim('"'), parts[4].Trim().Trim('"'));  
                        _entries.Add(entry);  
                    }  
                }  
            }  
            else  
            {  
                Console.WriteLine("File not found.");  
            }  
        }  
    }  
}