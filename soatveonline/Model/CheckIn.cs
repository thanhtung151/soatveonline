using System;
using System.ComponentModel.DataAnnotations;

namespace HueFestival_OnlineTicket.Model
{
    public class CheckIn
    {
        [Key]
        public Guid Id { get; set; }
        public Guid TicketId { get; set; }
       
        public Guid EmployeeId { get; set; }
       
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
