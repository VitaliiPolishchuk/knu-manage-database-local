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
    
    public partial class Flight_Company
    {
        public int ID { get; set; }
        public int CompanyId { get; set; }
        public int FlightId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Flight Flight { get; set; }
    }
}
