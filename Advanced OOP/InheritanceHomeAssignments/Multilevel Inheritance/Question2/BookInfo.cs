using System;

namespace Question2
{
    public class BookInfo : DepartmentDetails
    {
        public string BookID { get; set; }
        
        public string BookName { get; set; }
        
        public string AuthorName { get; set; }
        
        public double Price { get; set; }
        
        public BookInfo(string departmentName, string degree, int rackNumber, int columnNumber, string bookID, string bookName, string authorName, double price) : base(departmentName, degree, rackNumber, columnNumber)
        {
            BookID = bookID;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine("\nBook Info");
            Console.WriteLine($"\n\tBookID: {BookID}\n\tBook Name: {BookName}\n\tDepartment Name: {DepartmentName}\n\tDegree: {Degree}\n\tAuthor Name: {AuthorName}\n\tPrice: {Price}\n\tRack Number: {RackNumber}\n\tColumn Number: {ColumnNumber}\n");
        }
    }
}
