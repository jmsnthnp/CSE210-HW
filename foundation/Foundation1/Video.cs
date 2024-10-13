using System;  
using System.Collections.Generic;  

namespace YoutubeVideos  
{  
    public class Video  
    {  
        private string _title;  
        private string _author;  
        private int _length; // Length in seconds  
        private List<Comment> _comments;  

        public Video(string title, string author, int length)  
        {  
            _title = title;  
            _author = author;  
            _length = length;  
            _comments = new List<Comment>();  
        }  

        public void AddComment(Comment comment)  
        {  
            _comments.Add(comment);  
        }  

        public int GetNumberOfComments()  
        {  
            return _comments.Count;  
        }  

        public string GetVideoInfo()  
        {  
            return $"Title: {_title}, Author: {_author}, Length: {_length}s";  
        }  

        public List<string> ListComments()  
        {  
            List<string> commentDetails = new List<string>();  
            foreach (var comment in _comments)  
            {  
                commentDetails.Add(comment.GetCommentDetails());  
            }  
            return commentDetails;  
        }  
    }  
}