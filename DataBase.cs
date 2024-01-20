using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WPFGrupowy
{
    public class DataBase
    {
        private readonly string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Books", "books.db");
        static public List<Book> Books { get; private set; }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        public List<Book> ReadDataBaseFromJsonFile()
        {
            if (File.Exists(dbPath))
            {
                string serializedDataBase = File.ReadAllText(dbPath);
                List<Book> books = JsonConvert.DeserializeObject<List<Book>>(serializedDataBase);

                return books;
            }
            else
            {
                return null;
            }
        }

        public void SaveDataBaseToJsonFile()
        { 
            if (File.Exists(dbPath))
            {

            }
            else
            {

            }
        }
    }
}
