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
    public static class DataBase
    {
        private static readonly string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Books", "books.json");
        public static ObservableCollection<Book> Books { get; private set; }

        static DataBase() 
        { 
            if(Books == null)
            {
                ReadDataBaseFromJsonFile();
            }
        }

        public static void AddBook(Book book)
        {
            Books.Add(book);
            SaveDataBaseToJsonFile();
        }

        public static void RemoveBook(Book book)
        {
            Books.Remove(book);
            SaveDataBaseToJsonFile();
        }

        private static void ReadDataBaseFromJsonFile()
        {
            if (File.Exists(dbPath))
            {
                string serializedDataBase = File.ReadAllText(dbPath);
                ObservableCollection<Book> books = JsonConvert.DeserializeObject<ObservableCollection<Book>>(serializedDataBase);

                Books = books;
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Books"));

                string serializedDataBase = JsonConvert.SerializeObject(new ObservableCollection<Book>());
                File.WriteAllText(dbPath, serializedDataBase);

                Books = new ObservableCollection<Book>();
            }
        }

        public static void SaveDataBaseToJsonFile()
        {
            if (File.Exists(dbPath))
            {
                string serializedDataBase = JsonConvert.SerializeObject(Books);
                File.Delete(dbPath);
                File.WriteAllText(dbPath, serializedDataBase);
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Books"));

                string serializedDataBase = JsonConvert.SerializeObject(new ObservableCollection<Book>());
                File.WriteAllText(dbPath, serializedDataBase);

                Books = new ObservableCollection<Book>();
            }
        }
    }
}
