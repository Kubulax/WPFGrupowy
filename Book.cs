using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGrupowy
{
    public class Book
    {
        public List<Bookmark> Bookmarks { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime PublishedOn { get; set; }

        public Book (string title, string description, string author, DateTime publishedOn)
        {
            Bookmarks = new List<Bookmark>(); 
            Title = title;
            Description = description;
            Author = author;
            PublishedOn = publishedOn;
        }

        public void AddBookmark (Bookmark bookmark)
        {
            Bookmarks.Add(bookmark);
        }

        public void RemoveBookmark (Bookmark bookmark)
        {
            Bookmarks.Remove(bookmark);
        }
    }
}
