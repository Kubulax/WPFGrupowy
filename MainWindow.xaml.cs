using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFGrupowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = new List<Book>();
        private string title;

        public MainWindow()
        {
            InitializeComponent();
            UpdateList();
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Bookmarks().ShowDialog();
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveBook(object sender, RoutedEventArgs e)
        {

        }

        public void UpdateList()
        {
            Bookmark bookmark = new Bookmark()
            {
                PageNumber = 1,
                Description = "Pierdol się",
            };

            List<Bookmark> listaBookmarkow = new List<Bookmark>();
            listaBookmarkow.Add(bookmark);

            DateTime date = DateTime.Now;

            Book book = new Book(listaBookmarkow, "Siema", "Siema to ja Jacob", "Jacob", date);
            List<Book> listaKsiazek = new List<Book>();
            listaKsiazek.Add(book);

            DataBase dataBase = new DataBase();
            books = dataBase.ReadDataBaseFromJsonFile();
            ListaKsiazek.ItemsSource = listaKsiazek;
        }

        private void AddBookmark(object sender, RoutedEventArgs e)
        {

        }
    }
}
