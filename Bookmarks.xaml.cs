using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WPFGrupowy
{
    /// <summary>
    /// Logika interakcji dla klasy Bookmarks.xaml
    /// </summary>
    public partial class Bookmarks : Window
    {    
        public Bookmarks(Book book)
        {
            InitializeComponent();

            listabookmark.ItemsSource = book.Bookmarks;
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //string message = "Opis" + (DataContext as Book).Description;
            //MessageBox.Show(message);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bookmark bookmark = new Bookmark(int.Parse(page_add.Text), opis_add.Text);
            (DataContext as Book).AddBookmark(bookmark);
            listabookmark.ItemsSource = (DataContext as Book).Bookmarks;
        }
    }
}
