using System;

public class Video
    {
        public string _title { get; set; }
        public string _author { get; set; }
        public int _length { get; set; } 
        private List<Comment> _comments { get; set; }

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

        public List<Comment> GetComments()
        {
            return _comments;
        }
    }