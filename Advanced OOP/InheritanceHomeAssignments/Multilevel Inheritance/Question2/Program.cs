using System;
namespace Question2;

public class Program
{
    public static void Main(string[] args)
    {
        // Book Info Object
        BookInfo bookInfo = new BookInfo("IT", "B.Tech", 74823, 7, "BID3027", "C# Fundamentals", "Baskaran", 310);

        bookInfo.Display();
    }
}
