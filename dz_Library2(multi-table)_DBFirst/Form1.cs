using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// использован метод DataBase First
// на основе существующей БД MyLibrary2 автоматически созданы все
// сущности и связи
// Самостоятельно добавлен только переопределенный ToString() 
// в классе Books, и в классе MyLibrary2Entities (класс-контекст)
// написаны методы для Добавления/удаления/редактирования элементов
// в таблице БД
namespace dz_Library2_multi_table__DBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            using (MyLibrary2Entities db =  new MyLibrary2Entities())
            {
                db.AddBook(textBoxBookName.Text, Convert.ToInt32(textBoxBookAuthor.Text),
                    Convert.ToInt32(textBoxBookCat.Text), Convert.ToInt32(textBoxBookPublish.Text));
                listBox1.DataSource = db.Books.ToList();

            }
        }

        // обработчик кнопки Показать все книги
        private void buttonShowBooks_Click(object sender, EventArgs e)
        {
            using (MyLibrary2Entities db = new MyLibrary2Entities())
            {
                listBox1.DataSource = db.Books.ToList();
            }    

        }

        // обработчик кнопки Редактировать книгу (выбранную в листбоксе)
        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            using (MyLibrary2Entities db = new MyLibrary2Entities())
            {
                Books obj = listBox1.SelectedItem as Books;
                db.EditBook(obj, textBoxBookName.Text, Convert.ToInt32(textBoxBookAuthor.Text),
                    Convert.ToInt32(textBoxBookCat.Text), Convert.ToInt32(textBoxBookPublish.Text));
                listBox1.DataSource = db.Books.ToList();
            }
        }

        // обработчик кнопки Удалить книгу (выбранную в листбоксе)
        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            using (MyLibrary2Entities db = new MyLibrary2Entities())
            {
                Books obj = listBox1.SelectedItem as Books;
                db.DeleteBook(obj);
                listBox1.DataSource = db.Books.ToList();
            }
        }

        // обработчик события Выбор в листбоксе - копирование полей текущей книги
        // в соответствующие текстбоксы
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Books obj = listBox1.SelectedItem as Books;
            textBoxBookName.Text = obj.Name;
            textBoxBookAuthor.Text = obj.Authors.Id.ToString();
            textBoxBookCat.Text = obj.Categories.Id.ToString();
            textBoxBookPublish.Text = obj.Publishings.Id.ToString();
        }
    }
    
}
