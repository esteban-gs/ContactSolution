using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContactDB
{
    public partial class ContactsContext : DbContext
    {
        public ContactsContext()
        {
        }

        public ContactsContext(DbContextOptions<ContactsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=127.0.0.1,1433;Initial Catalog=Contacts;persist security info=True; User id=SA; Password=!Passw0rd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.ContactCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContactEmail).HasMaxLength(50);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContactNotes).HasMaxLength(1000);

                entity.Property(e => e.ContactPhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ContactPhoneType).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
