using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public string Title(string xtitle)
        {
            this.title = xtitle;
            return title;
        }
        public int Pages(int xPages)
        {
            this.pages = xPages;
            return pages;
        }
        public string Catgeory(string xCategory)
        {
            this.category = xCategory;
            return category;
        }
        public string Author(string xAuthor)
        {
            this.author = xAuthor;
            return author;
        }
        public int ReleaseDate(int xRealeaseDate)
        {
            this.releaseDate = xRealeaseDate;
            return releaseDate;
        }
        public void OlkoBolko()
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
            
        }

        
    }
}
