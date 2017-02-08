namespace Bibliothouris.Forms.Books
{
    partial class BooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookListView = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBook = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTitle = new System.Windows.Forms.TextBox();
            this.searchAuthor = new System.Windows.Forms.TextBox();
            this.searchISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookListView
            // 
            this.bookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.author,
            this.isbn});
            this.bookListView.Location = new System.Drawing.Point(12, 12);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(998, 455);
            this.bookListView.TabIndex = 1;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 340;
            // 
            // author
            // 
            this.author.Text = "Author";
            this.author.Width = 131;
            // 
            // isbn
            // 
            this.isbn.Text = "ISBN";
            this.isbn.Width = 81;
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(935, 473);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(75, 23);
            this.addBook.TabIndex = 2;
            this.addBook.Text = "Add book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(491, 475);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(160, 84);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search book";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTitle
            // 
            this.searchTitle.Location = new System.Drawing.Point(124, 539);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(361, 20);
            this.searchTitle.TabIndex = 15;
            // 
            // searchAuthor
            // 
            this.searchAuthor.Location = new System.Drawing.Point(124, 506);
            this.searchAuthor.Name = "searchAuthor";
            this.searchAuthor.Size = new System.Drawing.Size(361, 20);
            this.searchAuthor.TabIndex = 14;
            // 
            // searchISBN
            // 
            this.searchISBN.Location = new System.Drawing.Point(124, 475);
            this.searchISBN.Name = "searchISBN";
            this.searchISBN.Size = new System.Drawing.Size(361, 20);
            this.searchISBN.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search on title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search on author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search on ISBN:";
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 578);
            this.Controls.Add(this.searchTitle);
            this.Controls.Add(this.searchAuthor);
            this.Controls.Add(this.searchISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.bookListView);
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookListView;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader isbn;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTitle;
        private System.Windows.Forms.TextBox searchAuthor;
        private System.Windows.Forms.TextBox searchISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}