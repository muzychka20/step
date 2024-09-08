using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class PrintedBook : Book
    {
        int PageCount { get; set; }

        public PrintedBook(string title, string author, string isbn, int pageCount) :
            base(title, author, isbn)
        {
            PageCount = pageCount;
        }

        public override void DisplayInfo()
        {            
            base.DisplayInfo();
            Console.WriteLine($"Pages: {PageCount}");
        }
    }
}
