using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Domain;

namespace TextbookManagementUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Book> data = ObjectData.Books.ToList();

        private void ShowBook(Book book)
        {
            txt_Id.Text = book.Id.ToString();
            txt_Author.Text = book.Author;
            txt_Isbn.Text = book.Isbn;
            txt_Press.Text = book.Press;
            txt_Title.Text = book.Title;
            txt_Price.Text = book.Price.ToString();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dg_Textbook.ItemsSource = data;

        }

        private void Dg_Textbook_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            
            var bookManage = new BookManage();
            bookManage.SetBooks(data);
            var id = 0;
            int.TryParse(txt_Id.Text, out id);
            data = bookManage.Remove(id);
            dg_Textbook.ItemsSource = data;
        }

        private void Btn_Query_Click(object sender, RoutedEventArgs e)
        {
            var bookManage = new BookManage();
            bookManage.SetBooks(data);
            if (txt_QueryIsbn.Text != "")
            {
                var result = bookManage.FindByIsbn(txt_Isbn.Text);
                dg_Textbook.ItemsSource = result;
            }
            else
            {
                dg_Textbook.ItemsSource = data;
            }
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dg_Textbook_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var book = new Book();
            if (dg_Textbook.CurrentCell.Column != null && dg_Textbook.SelectedIndex != dg_Textbook.ItemsSource.OfType<object>().Count())
            {
                book = (Book)dg_Textbook.CurrentItem;
                ShowBook(book);
            }
        }

        private void Dg_Textbook_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            dg_Textbook.ToolTip = "Double-click a list item to edit the object";
        }
    }
}
