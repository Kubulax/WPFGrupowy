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

        

        private void AddBookmark(object sender, RoutedEventArgs e)
        {

        }
    }
}
