﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLiThietBiEntities3 : DbContext
    {
        public QuanLiThietBiEntities3()
            : base("name=QuanLiThietBiEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CHITIETPHIEUGIAO> CHITIETPHIEUGIAOs { get; set; }
        public DbSet<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
        public DbSet<DONVI> DONVIs { get; set; }
        public DbSet<LOAITHIETBI> LOAITHIETBIs { get; set; }
        public DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public DbSet<PHIEUGIAO> PHIEUGIAOs { get; set; }
        public DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public DbSet<PHONGQUANTRI> PHONGQUANTRIs { get; set; }
        public DbSet<THIETBI> THIETBIs { get; set; }
        public DbSet<TINHTRANG> TINHTRANGs { get; set; }
    }
}