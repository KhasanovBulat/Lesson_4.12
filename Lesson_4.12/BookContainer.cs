using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._12
{
    class BookContainer
    {
        public List<Book> Books;

        public void AddBook()
        {
            Books.Add(new Book());
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Books.Count; i++)
            {
                result = $"Author: {Books[i].author} Name: {Books[i].name} Publisher: {Books[i].publisher}";
            }
            return result;
        }
        public List<Book> SortByName()
        {
            return Books.OrderBy(book => book.name).ToList();
        }
        public List<Book> SortByAuthor()
        {
            return Books.OrderBy(book => book.author).ToList();
        }
        public List<Book> SortByPublish()
        {
            return Books.OrderBy(book => book.publisher).ToList();
        }
    }
}
