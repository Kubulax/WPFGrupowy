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
    /// Logika interakcji dla klasy AddBookPage.xaml
    /// </summary>
    public partial class AddBookPage : Window
    {
        public AddBookPage()
        {
            InitializeComponent();
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            List<Bookmark> b = new List<Bookmark>();
            Book book = new Book(b,tytul_texbox.Text,opis_texbox.Text,autor_texbox.Text,dataWydania_texbox.DisplayDate);

            DataBase.AddBook(book);
        }
    }
}
