using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        static public ObservableCollection<Book> Books { get; private set; }

        public DataBase() { if (Books == null) { Books = new ObservableCollection<Book>(); } }

        public static void AddBook(Book book)
        {
            if (Books == null) { Books = new ObservableCollection<Book>(); }
            Books.Add(book);
        }

        public static void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        public void ReadDataBaseFromJsonFile()
        {
            if (File.Exists(dbPath))
            {
                string serializedDataBase = File.ReadAllText(dbPath);
                ObservableCollection<Book> books = JsonConvert.DeserializeObject<ObservableCollection<Book>>(serializedDataBase);

                Books = books;
            }
            else
            {

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
