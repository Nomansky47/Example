using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Example
{
    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }
        private static MyContext _context { get; set; }
        public static MyContext Get()
        {
            if (_context==null)
            {
                _context = new MyContext();
                return _context;
            } else return _context;
        }
        public virtual DbSet<Play> Play { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<CountPlace> CountPlace { get; set; }
        public virtual DbSet<Repertuar> Repertuar { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Play>()
                .Property(e => e.PlayName)
                .IsUnicode(false);

            modelBuilder.Entity<Play>()
                .HasMany(e => e.Repertuar)
                .WithRequired(e => e.Play)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Play>()
                .HasMany(e => e.Ticket)
                .WithRequired(e => e.Play)
                .WillCascadeOnDelete(false);
        }
    }
}
