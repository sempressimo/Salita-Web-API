﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SalitaEntities : DbContext
    {
        public SalitaEntities()
            : base("name=SalitaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<CustomerNeed> CustomerNeeds { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerService> CustomerServices { get; set; }
        public virtual DbSet<Map> Maps { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<ListZip> ListZips { get; set; }
        public virtual DbSet<WatingForReason> WatingForReasons { get; set; }
        public virtual DbSet<v_CustomerNeeds> v_CustomerNeeds { get; set; }
        public virtual DbSet<v_RecentVisits> v_RecentVisits { get; set; }
    }
}
