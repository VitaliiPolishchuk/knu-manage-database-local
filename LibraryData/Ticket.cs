//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public Ticket()
        {
            this.Flight_Ticket = new HashSet<Flight_Ticket>();
        }
    
        public int TicketId { get; set; }
        public double Price { get; set; }
    
        public virtual ICollection<Flight_Ticket> Flight_Ticket { get; set; }
    }
}
