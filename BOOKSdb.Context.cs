﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIBRARY_lite
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LIBRARYCPEntities : DbContext
    {
        public LIBRARYCPEntities()
            : base("name=LIBRARYCPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BOOK_LEND> BOOK_LEND { get; set; }
        public virtual DbSet<BOOKS> BOOKS { get; set; }
        public virtual DbSet<EMPLOYEES> EMPLOYEES { get; set; }
        public virtual DbSet<INSTANCE_SET_CONTENTS> INSTANCE_SET_CONTENTS { get; set; }
        public virtual DbSet<INSTANCE_SETS> INSTANCE_SETS { get; set; }
        public virtual DbSet<INSTANCES> INSTANCES { get; set; }
        public virtual DbSet<READERS> READERS { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
    }
}
