using System;

namespace OnlineGroceryStoreApplication
{
    public enum BookingStatus { Default, Initiated, Booked, Cancelled }

    public class BookingDetails
    {
        private static int s_bookingID = 3000;

        public string BookingID { get; }

        public string CustomerID { get; set; }

        public double TotalPrice { get; set; }

        public DateTime DateOfBooking { get; set; }

        public BookingStatus BookingStatus { get; set; }
        
        public BookingDetails(string customerID, double totalPrice, DateTime dateOfBooking, BookingStatus bookingStatus) 
        {
            BookingID = $"BID{++s_bookingID}";
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }

        public BookingDetails(string data) 
        {
            string[] values = data.Split(',');
            s_bookingID = int.Parse(values[0].Remove(0, 3));
            BookingID = values[0];
            CustomerID = values[1];
            TotalPrice = double.Parse(values[2]);
            DateOfBooking = DateTime.ParseExact(values[3], "dd/MM/yyyy", null);
            BookingStatus = Enum.Parse<BookingStatus>(values[4], true);
        }

        public void ShowBookingDetails()
        {
            Console.WriteLine($"\t{BookingID}\t\t{CustomerID}\t\t{TotalPrice}\t\t{DateOfBooking.ToString("dd/MM/yyyy")}\t\t{BookingStatus}");
        }
    }
}