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
    
    public partial class v_CustomerNeeds
    {
        public int CustomerNeed_ID { get; set; }
        public Nullable<int> Customer_ID { get; set; }
        public Nullable<int> RequestedService_ID { get; set; }
        public Nullable<System.DateTime> RequestDateTime { get; set; }
        public string Note { get; set; }
        public Nullable<bool> WasFullfilled { get; set; }
        public string Address_Line { get; set; }
        public string Town { get; set; }
        public string ZipCode { get; set; }
        public Nullable<bool> FromDealer { get; set; }
        public string ServiceType { get; set; }
        public string ServiceDescription { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_Town { get; set; }
        public string Customer_ZipCode { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> Canceled { get; set; }
    }
}
