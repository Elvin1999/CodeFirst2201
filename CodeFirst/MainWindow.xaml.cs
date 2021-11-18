using CodeFirst.DataAccess;
using CodeFirst.Entities;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LibraryContext context = new LibraryContext();
        public MainWindow()
        {
            InitializeComponent();
            context.Database.CreateIfNotExists();


            #region CategoryAdd

            //context.Categories.Add(new Category {
            //Name="Adventure"
            //});

            //context.Categories.Add(new Category
            //{
            //    Name = "Science"
            //});

            //context.Categories.Add(new Category
            //{
            //    Name = "Programming"
            //});
            //context.SaveChanges();
            #endregion


            #region AuthorAdd

            //context.Authors.Add(new Author
            //{
            //   Firstname="Linus",
            //   Lastname="Torvalds",
            //   Age=35
            //});


            //context.Authors.Add(new Author
            //{
            //    Firstname = "Leyla",
            //    Lastname = "Mammadova",
            //    Age = 22
            //});

            //context.Authors.Add(new Author
            //{
            //    Firstname = "Axmed",
            //    Lastname = "Axmedli",
            //    Age = 18
            //});
            //context.SaveChanges();
            #endregion


            #region BookAdd

            //context.Books.Add(new Book
            //{
            //    AuthorId=1,
            //    CategoryId=1,
            //    Pages=100,
            //    Name="My Best Book"
            //});
            //context.SaveChanges();

            var categories = context.Categories.ToList();
            categoriesDataGrid.ItemsSource = categories;

            var authors = context.Authors.ToList();
            authorsDataGrid.ItemsSource = authors;

            var books = context.Books.ToList();
            booksDataGrid.ItemsSource = books;
            #endregion
        }

  

        private void categoriesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = categoriesDataGrid.SelectedItem as Category;
            if (item != null)
            {
                var books = item.Books.ToList();
                booksDataGrid.ItemsSource = books;
            }
        }
    }
}
