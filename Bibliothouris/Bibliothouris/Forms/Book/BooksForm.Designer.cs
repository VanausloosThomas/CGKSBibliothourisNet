namespace Bibliothouris.Forms.Book
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
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 507);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.bookListView);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView bookListView;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader isbn;
        private System.Windows.Forms.Button addBook;
    }
}