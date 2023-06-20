using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBookingApplication.Models
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public String? TicketTitle { get; set; }
        public String? From { get; set; }
        public String? To { get; set; }
        public int Price { get; set; }
        //navigation property
        public ICollection<Booking>? Bookings { get; set; }
    }
}
