using Bibliothouris.Source.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothouris.Forms.Books
{
    public interface IBookSearchView
    {
        void SetController(BookController bookController);
        void Close();
        void Clear();
        DialogResult ShowDialog();
    }

    public partial class SearchBookForm : Form, IBookSearchView
    {
        private BookController bookController;

        public SearchBookForm()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            searchAuthor.Text = "";
            searchISBN.Text = "";
            searchTitle.Text = "";
        }

        public void SetController(BookController bookController)
        {
            this.bookController = bookController;
        }

        public void ErrorMessage(String error)
        {
            MessageBox.Show(error);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchISBN.Text != "")
            {
                bookController.SearchBookISBN();
            }else if (searchTitle.Text != "")
            {
                bookController.SearchBookTitle();
            }else if (searchAuthor.Text != "")
            {
                bookController.SearchBookAuthord();
            }
        }

        private void checkISBN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkISBN.Checked)
            {
                if (checkISBN.Checked && !checkTitle.Checked && !checkAuthor.Checked)
                {
                    searchISBN.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You can only search on one thing!");
                    checkISBN.Checked = false;
                    searchISBN.Enabled = false;

                }
            }
            else
            {
                searchISBN.Enabled = false;
            }

        }

        private void checkAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAuthor.Checked)
            {
                if (!checkISBN.Checked && !checkTitle.Checked && checkAuthor.Checked)
                {
                    searchAuthor.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You can only search on one thing!");
                    checkAuthor.Checked = false;
                    searchAuthor.Enabled = false;
                }
            }else
            {
                searchAuthor.Enabled = false;
            }

        }

        private void checkTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTitle.Checked)
            {
                if (!checkISBN.Checked && checkTitle.Checked && !checkAuthor.Checked)
                {
                    searchTitle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You can only search on one thing!");
                    checkTitle.Checked = false;
                    searchTitle.Enabled = false;
                }
            }else
            {
                searchTitle.Enabled = false;
            }

        }
    }
}
