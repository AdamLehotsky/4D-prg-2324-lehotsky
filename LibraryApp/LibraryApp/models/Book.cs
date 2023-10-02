using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp;

namespace LibraryApp.models
{
    internal class Book : LibraryItem<book>
    {
        int NumberOfPages { get; }
        public string Author { get; }
        public Book(int NumberOfPages, string Autor, int id, string Title) : base(id, Title)
        {
            this.NumberOfPages = NumberOfPages;
            this.Author = Autor;
        }
        public override void DisplyInfo()
        {
            Console.WriteLine($"Autor (Author) a počet stran: (NumberOfPages)");  
        }

    }
}
