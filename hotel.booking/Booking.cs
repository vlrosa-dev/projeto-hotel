using System;
using projeto_hotel.hotel.room;

namespace projeto_hotel.hotel.booking
{
    public class Booking
    {
        public Booking(DateTime entryDate, DateTime exitDate)
        {
            this.NumberBooking = new Random().Next(1, 50).ToString();
            EntryDate = entryDate;
            ExitDate = exitDate;
        }

        public string NumberBooking { get; set; }

        public DateTime EntryDate { get; set; }

        public DateTime ExitDate { get; set; }
        
    }
}