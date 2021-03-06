namespace shiny.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.SpeicherOrt)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Preis)
                .HasPrecision(19, 4);
        }

        public List<Item> GetItems()
        {
            List<Item> result = Items.ToList();
            return result;
        }
    }
}
