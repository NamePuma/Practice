﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PractikaOleshki
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConnectionWithBase : DbContext
    {
        public ConnectionWithBase()
            : base("name=ConnectionWithBase")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<fk_order_category> fk_order_category { get; set; }
        public virtual DbSet<fk_order_manufacrure> fk_order_manufacrure { get; set; }
        public virtual DbSet<fk_order_maxDiscount> fk_order_maxDiscount { get; set; }
        public virtual DbSet<fk_order_name> fk_order_name { get; set; }
        public virtual DbSet<fk_order_provaides> fk_order_provaides { get; set; }
        public virtual DbSet<fk_status> fk_status { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<PickupPoint> PickupPoints { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SI> SIs { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
