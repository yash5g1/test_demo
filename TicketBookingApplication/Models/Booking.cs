namespace TicketBookingApplication.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int TicketID { get; set; }
        public String? PassengerName { get; set; }
        public int NoOfPassengers { get; set; }
        
        //navigation properties
        public Ticket? Ticket { get; set; }
        public double BookingCost()
        {
            double cost = 0;
            if (Ticket != null)
            {
                cost = Ticket.Price * NoOfPassengers;
            }
            return cost;

        }
    }
}
