//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoungeWebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class v_RecentVisits
    {
        public int Customer_ID { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string ZipCode { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public int Visit_ID { get; set; }
        public Nullable<System.DateTime> VisitDate { get; set; }
        public Nullable<int> Seat_X { get; set; }
        public Nullable<int> Seat_Y { get; set; }
        public Nullable<bool> InLounge { get; set; }
        public string WaitingFor { get; set; }
        public string LoginPIN { get; set; }
        public string Mood { get; set; }
    }
}
