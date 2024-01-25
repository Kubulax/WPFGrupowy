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

        

        public MainWindow()
        {
            InitializeComponent();
            ListaKsiazek.ItemsSource = DataBase.Books;
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Book selectedbook = (sender as Button).CommandParameter as Book;

            Bookmarks bookmarks = new Bookmarks(selectedbook);
            bookmarks.DataContext = selectedbook;
            bookmarks.ShowDialog();
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {     
            new AddBookPage().ShowDialog();
            ListaKsiazek.ItemsSource = DataBase.Books;
        }

        private void RemoveBook(object sender, RoutedEventArgs e)
        {
            Book selectedbook = (sender as Button).CommandParameter as Book;
            DataBase.RemoveBook(selectedbook);
            ListaKsiazek.DataContext = DataBase.Books;
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

            books = DataBase.Books;
            ListaKsiazek.ItemsSource = listaKsiazek;
        }

        private void AddBookmark(object sender, RoutedEventArgs e)
        {

        }
    }
}
