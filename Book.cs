using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGrupowy
{
    public class Book
    {
        public List<Bookmark> Bookmarks { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime PublishedOn { get; set; }

        public Book (List<Bookmark> bookmarks, string title, string description, string author, DateTime publishedOn)
        {
            Bookmarks = bookmarks;
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
