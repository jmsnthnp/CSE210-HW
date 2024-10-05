using System;  
using System.Collections.Generic;  
using System.IO;  

namespace ScriptureMemorizer
{  
    public class ScriptureLibrary  
    {  
        private List<Scripture> _scriptures;  

        public ScriptureLibrary(string filePath)  
        {  
            _scriptures = new List<Scripture>();  
            LoadScriptures(filePath);  
        }  

        private void LoadScriptures(string filePath)  
        {  
            try  
            {  
                var lines = File.ReadAllLines(filePath);  
                foreach (var line in lines)  
                {  
                    var parts = line.Split('|');  
                    if (parts.Length == 2)  
                    {  
                        var reference = new Reference(parts[0].Trim());  
                        var text = parts[1].Trim();  
                        _scriptures.Add(new Scripture(reference, text));  
                    }  
                }  
            }  
            catch (Exception ex)  
            {  
                Console.WriteLine("An error occurred while loading scriptures: " + ex.Message);  
            }  
        }  

        public Scripture GetRandomScripture()  
        {  
            Random random = new Random();  
            return _scriptures[random.Next(_scriptures.Count)];  
        }  
    }  
}