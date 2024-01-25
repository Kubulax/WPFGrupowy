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
        Book dokbook = new Book();
        public Bookmarks(Book selbook)
        {
            InitializeComponent();
            
            dokbook = selbook;
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("placeholder");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bookmark b = new Bookmark();
            b.PageNumber = int.Parse(page_add.Text);
            b.Description = opis_add.Text;
            dokbook.AddBookmark(b);
            listabookmark.ItemsSource = dokbook.Bookmarks;
        }
    }
}
