using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WPFGrupowy
{
    public class Bookmark
    {
        public int PageNumber { get; set; }
        public string Description { get; set; }

        public Bookmark(int pageNumber, string description)
        {
            PageNumber = pageNumber;
            Description = description;
        }
    }
}
