using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class BookManage
    {
        public List<Book> Books { get; private set; }

        public void SetBooks(IEnumerable<Book> data)
        {
            Books = data.ToList();
        }

        public void Add(Book entity)
        {
            if (!Books.Contains(entity))
            {
                Books.Add(entity);
            }
        }

        public IList<Book> FindAll()
        {
            return Books;
        }

        public IList<Book> FindByIsbn(string Isbn)
        {
            var book = Books.Where(t => t.Isbn == Isbn).ToList();
            return book;
        }

        public void Modify(Book entity)
        {
            if (Books.Contains(entity))
            {
                var book = Books.Find(t => t.Id == entity.Id);
                Books.Remove(book);
                Books.Add(entity);
            }
        }

        public List<Book> Remove(int id)
        {
            if (Books.Exists(t => t.Id == id))
            {
                Books.Remove(new Book { Id = id });
            }
            return Books;
        }
    }
}