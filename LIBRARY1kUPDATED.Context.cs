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
    
    public partial class libraryEntities : DbContext
    {
        public libraryEntities()
            : base("name=libraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AUTHORS> AUTHORS { get; set; }
        public virtual DbSet<BOOK_SET_CONTENTS> BOOK_SET_CONTENTS { get; set; }
        public virtual DbSet<BOOK_SETS> BOOK_SETS { get; set; }
        public virtual DbSet<BOOKLEND> BOOKLEND { get; set; }
        public virtual DbSet<BOOKS> BOOKS { get; set; }
        public virtual DbSet<EMPLOYEES> EMPLOYEES { get; set; }
        public virtual DbSet<LOST_BOOKS> LOST_BOOKS { get; set; }
        public virtual DbSet<PUBLISHERS> PUBLISHERS { get; set; }
        public virtual DbSet<READERS> READERS { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
    }
}
