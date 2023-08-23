namespace dz_Library2_multi_table__DBFirst
{
    partial class Form1
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
            this.buttonShowBooks = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBookPublish = new System.Windows.Forms.TextBox();
            this.textBoxBookCat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonShowBooks
            // 
            this.buttonShowBooks.Location = new System.Drawing.Point(137, 12);
            this.buttonShowBooks.Name = "buttonShowBooks";
            this.buttonShowBooks.Size = new System.Drawing.Size(125, 23);
            this.buttonShowBooks.TabIndex = 57;
            this.buttonShowBooks.Text = "Показать все книги";
            this.buttonShowBooks.UseVisualStyleBackColor = true;
            this.buttonShowBooks.Click += new System.EventHandler(this.buttonShowBooks_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(10, 191);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(121, 23);
            this.buttonAddBook.TabIndex = 56;
            this.buttonAddBook.Text = "Добавить книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(399, 12);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(125, 23);
            this.buttonDeleteBook.TabIndex = 55;
            this.buttonDeleteBook.Text = "Удалить";
            this.buttonDeleteBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Location = new System.Drawing.Point(268, 12);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(125, 23);
            this.buttonEditBook.TabIndex = 54;
            this.buttonEditBook.Text = "Редактировать";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(137, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(385, 173);
            this.listBox1.TabIndex = 53;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxBookAuthor
            // 
            this.textBoxBookAuthor.Location = new System.Drawing.Point(11, 84);
            this.textBoxBookAuthor.Name = "textBoxBookAuthor";
            this.textBoxBookAuthor.Size = new System.Drawing.Size(120, 20);
            this.textBoxBookAuthor.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Автор";
            // 
            // textBoxBookPublish
            // 
            this.textBoxBookPublish.Location = new System.Drawing.Point(11, 162);
            this.textBoxBookPublish.Name = "textBoxBookPublish";
            this.textBoxBookPublish.Size = new System.Drawing.Size(120, 20);
            this.textBoxBookPublish.TabIndex = 50;
            // 
            // textBoxBookCat
            // 
            this.textBoxBookCat.Location = new System.Drawing.Point(11, 123);
            this.textBoxBookCat.Name = "textBoxBookCat";
            this.textBoxBookCat.Size = new System.Drawing.Size(120, 20);
            this.textBoxBookCat.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Издательство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Категория";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(12, 41);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(119, 20);
            this.textBoxBookName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Название книги";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 227);
            this.Controls.Add(this.buttonShowBooks);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxBookAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBookPublish);
            this.Controls.Add(this.textBoxBookCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowBooks;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxBookAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBookPublish;
        private System.Windows.Forms.TextBox textBoxBookCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label label1;
    }
}

