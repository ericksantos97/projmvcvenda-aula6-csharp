﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjMVC_Aula5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VendaDBEntities : DbContext
    {
        public VendaDBEntities()
            : base("name=VendaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_CLIENTE> TB_CLIENTE { get; set; }
        public virtual DbSet<TB_FABRICANTE> TB_FABRICANTE { get; set; }
        public virtual DbSet<TB_PRODUTO> TB_PRODUTO { get; set; }
    }
}
