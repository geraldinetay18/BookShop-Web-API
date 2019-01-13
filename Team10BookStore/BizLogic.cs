using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team10BookStore
{
    
    public class BizLogic
    {
        Model2 model = new Model2();

        // 1. List of Categories
        public List<Category> ListCategory()
        {
            return model.Categories.ToList<Category>();
        }

        // 2. List of Books in that category
        public List<Book> ListBookByCategory(int categoryId)
        {
            List<Book> list = model.Books.Where(b => b.CategoryID == categoryId).ToList<Book>();
            return list;
        }


        // 3. Display one book's details
        public Book GetBook(int bookId)
        {
            List<Book> list = model.Books.Where
                                  (b => b.BookID == bookId).ToList<Book>();
            if (list.Count > 0)
                return list[0];
            else
                return null;
        }

        // 4. Update one book's details
        public int UpdateBook(Book b)
        {
            Book book = GetBook(b.BookID);

            if (book != null)
            {
                book.Title = b.Title;
                book.Author = b.Author;
                book.CategoryID = b.CategoryID;
                book.Stock = b.Stock;
                book.Price = b.Price;
                model.SaveChanges();
                return 1;
            }
            return 0;
        }
    }
}