﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APCS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class APCSEntities : DbContext
    {
        public APCSEntities()
            : base("name=APCSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<station> stations { get; set; }
        public virtual DbSet<tow> tows { get; set; }
        public virtual DbSet<user_role> user_role { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<vehicle> vehicles { get; set; }
        public virtual DbSet<vehicle_own> vehicle_own { get; set; }
        public virtual DbSet<picture> pictures { get; set; }
    }
}
