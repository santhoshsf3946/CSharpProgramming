using System;
namespace Question4;

public class Program
{
    public static void Main(string[] args)
    {
        BookInfo book = new BookInfo("C# Fundamentals", "Baskaran", 650, "Information Technology", "B.Tech");

        book.ShowInfo();
    }
}
