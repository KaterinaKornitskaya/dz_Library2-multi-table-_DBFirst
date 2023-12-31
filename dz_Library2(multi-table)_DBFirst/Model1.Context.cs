﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dz_Library2_multi_table__DBFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Windows.Forms;

    public partial class MyLibrary2Entities : DbContext
    {
        public MyLibrary2Entities()
            : base("name=MyLibrary2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Publishings> Publishings { get; set; }

        public void AddBook(string name, int idAuth, int idCat, int idPub)
        {
            try
            {
                Authors auth = Authors.Find(idAuth);
                Categories cat = Categories.Find(idCat);
                Publishings pub = Publishings.Find(idPub);
                if (auth == null || cat == null || pub == null)
                {
                    throw new Exception("Книга не добавлена!");
                }
                Books obj = new Books
                { Name = name, Authors = auth, Categories = cat, Publishings = pub };
                Books.Add(obj);
                MessageBox.Show($"Книга {obj.Name} добавлена");
                SaveChanges();
                //books.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // метод для удаления книги (выбранной в листбоксе)
        public void DeleteBook(Books obj)
        {
            Books.Remove(Books.Find(obj.Id));
            MessageBox.Show($"Книга {obj.Name} удалена.");
            SaveChanges();
        }

        // метод для редактирования книги (выбранной в листбоксе)
        public void EditBook(Books obj, string name, int idAuth, int idCat, int idPub)
        {
            Authors auth = Authors.Find(idAuth);
            Categories cat = Categories.Find(idCat);
            Publishings pub = Publishings.Find(idPub);
            obj = Books.Find(obj.Id);
            obj.Name = name;
            obj.Authors = auth;
            obj.Categories = cat;
            obj.Publishings = pub;
            MessageBox.Show($"Книга изменена.");
            SaveChanges();
        }
    }
}
