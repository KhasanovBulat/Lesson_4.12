using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._12
{
    class Book
    {
        public string name;
        public string author;
        public string publisher;

        public Book()
        {

        }

        public Book(string name, string author, string publisher)
        {
            this.author = author;
            this.name = name;
            this.publisher = publisher;
        }

        public override string ToString()
        {
            return $"Автор {author}, Название: {name}, Издатель: {publisher}";
        }
        
    }
}
