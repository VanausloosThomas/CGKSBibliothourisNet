namespace Bibliothouris.Forms.Books
{
    partial class SearchBookForm
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
            this.searchTitle = new System.Windows.Forms.TextBox();
            this.searchAuthor = new System.Windows.Forms.TextBox();
            this.searchISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.checkISBN = new System.Windows.Forms.CheckBox();
            this.checkAuthor = new System.Windows.Forms.CheckBox();
            this.checkTitle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // searchTitle
            // 
            this.searchTitle.Enabled = false;
            this.searchTitle.Location = new System.Drawing.Point(124, 70);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(361, 20);
            this.searchTitle.TabIndex = 14;
            // 
            // searchAuthor
            // 
            this.searchAuthor.Enabled = false;
            this.searchAuthor.Location = new System.Drawing.Point(124, 37);
            this.searchAuthor.Name = "searchAuthor";
            this.searchAuthor.Size = new System.Drawing.Size(361, 20);
            this.searchAuthor.TabIndex = 13;
            // 
            // searchISBN
            // 
            this.searchISBN.Enabled = false;
            this.searchISBN.Location = new System.Drawing.Point(124, 6);
            this.searchISBN.Name = "searchISBN";
            this.searchISBN.Size = new System.Drawing.Size(361, 20);
            this.searchISBN.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search on title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search on author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search on ISBN:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(410, 96);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // checkISBN
            // 
            this.checkISBN.AutoSize = true;
            this.checkISBN.Location = new System.Drawing.Point(103, 9);
            this.checkISBN.Name = "checkISBN";
            this.checkISBN.Size = new System.Drawing.Size(15, 14);
            this.checkISBN.TabIndex = 16;
            this.checkISBN.UseVisualStyleBackColor = true;
            this.checkISBN.CheckedChanged += new System.EventHandler(this.checkISBN_CheckedChanged);
            // 
            // checkAuthor
            // 
            this.checkAuthor.AutoSize = true;
            this.checkAuthor.Location = new System.Drawing.Point(103, 40);
            this.checkAuthor.Name = "checkAuthor";
            this.checkAuthor.Size = new System.Drawing.Size(15, 14);
            this.checkAuthor.TabIndex = 17;
            this.checkAuthor.UseVisualStyleBackColor = true;
            this.checkAuthor.CheckedChanged += new System.EventHandler(this.checkAuthor_CheckedChanged);
            // 
            // checkTitle
            // 
            this.checkTitle.AutoSize = true;
            this.checkTitle.Location = new System.Drawing.Point(103, 73);
            this.checkTitle.Name = "checkTitle";
            this.checkTitle.Size = new System.Drawing.Size(15, 14);
            this.checkTitle.TabIndex = 18;
            this.checkTitle.UseVisualStyleBackColor = true;
            this.checkTitle.CheckedChanged += new System.EventHandler(this.checkTitle_CheckedChanged);
            // 
            // SearchBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 133);
            this.Controls.Add(this.checkTitle);
            this.Controls.Add(this.checkAuthor);
            this.Controls.Add(this.checkISBN);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTitle);
            this.Controls.Add(this.searchAuthor);
            this.Controls.Add(this.searchISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SearchBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTitle;
        private System.Windows.Forms.TextBox searchAuthor;
        private System.Windows.Forms.TextBox searchISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox checkISBN;
        private System.Windows.Forms.CheckBox checkAuthor;
        private System.Windows.Forms.CheckBox checkTitle;
    }
}