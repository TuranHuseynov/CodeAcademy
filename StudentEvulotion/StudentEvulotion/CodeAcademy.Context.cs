﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentEvulotion
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Code_Academy_DbEntities : DbContext
    {
        public Code_Academy_DbEntities()
            : base("name=Code_Academy_DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Group_schedule> Group_schedule { get; set; }
        public virtual DbSet<Group_types> Group_types { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Mentor> Mentors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Task_types> Task_types { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}
