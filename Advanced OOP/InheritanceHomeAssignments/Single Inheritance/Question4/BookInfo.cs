using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class BookInfo : DepartmentDetails
    {
        private static int s_bookID = 1000;
        
        public string BookID { get; set; }

        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public double Price { get; set; }

        public BookInfo(string bookName, string authorName, double price, string departmentName, string degree) : base(departmentName, degree) 
        {
            BookID = $"BID{++s_bookID}";
            BookName = bookName;
            AuthorName = authorName;
            Price = price;  
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n  Book ID: {BookID}\n  Book Name: {BookName}\n  Author Name: {AuthorName}\n  Price: {Price}\n  Degree: {Degree}\n  Department: {DepartmentName}\n");
        }
    }
}
