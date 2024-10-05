using System;  
using System.Collections.Generic;  
using System.Linq;  

namespace ScriptureMemorizer
{  
    public class Scripture  
    {  
        private Reference _reference;  
        private List<Word> _words;  

        public Scripture(Reference reference, string text)  
        {  
            _reference = reference;  
            _words = text.Split(' ').Select(w => new Word(w)).ToList();  
        }  

        public void HideRandomWords(int numberToHide)  
        {  
            Random random = new Random();  

            for (int i = 0; i < numberToHide; i++)  
            {  
                int index = random.Next(_words.Count);  
                _words[index].Hide();  
            }  
        }  

        public string GetDisplayText()  
        {  
            return $"{_reference.GetDisplayText()}: " + string.Join(" ", _words.Select(w => w.GetDisplayText()));  
        }  

        public bool IsCompletelyHidden()  
        {  
            return _words.All(w => w.IsHidden());  
        }  

        public int CountVisibleWords()  
        {  
            return _words.Count(w => !w.IsHidden());  
        }  
    }  
}