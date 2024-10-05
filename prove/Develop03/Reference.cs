using System;  

namespace ScriptureMemorizer
{  
    public class Reference  
    {  
        private string _book;  
        private int _chapter;  
        private int _verse;  
        private int _endVerse;  

        public Reference(string book, int chapter, int verse)  
        {  
            _book = book;  
            _chapter = chapter;  
            _verse = verse;  
            _endVerse = verse;
        }  

        public Reference(string book, int chapter, int startVerse, int endVerse)  
        {  
            _book = book;  
            _chapter = chapter;  
            _verse = startVerse;  
            _endVerse = endVerse;  
        }  

        public Reference(string referenceString)  
        {  
            var parts = referenceString.Split(' ');  
            _book = parts[0];  

            var verses = parts[1].Split(':');  
            _chapter = int.Parse(verses[0]);  

            if (verses[1].Contains('-'))  
            {  
                var range = verses[1].Split('-');  
                _verse = int.Parse(range[0]);  
                _endVerse = int.Parse(range[1]);  
            }  
            else  
            {  
                _verse = int.Parse(verses[1]);  
                _endVerse = _verse;
            }  
        }  

        public string GetDisplayText()  
        {  
            return $"{_book} {_chapter}:{_verse}" + (_endVerse > _verse ? $"-{_endVerse}" : "");  
        }  
    }  
}