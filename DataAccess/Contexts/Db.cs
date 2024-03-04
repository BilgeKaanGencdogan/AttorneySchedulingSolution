using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    public class Db : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<LawyerType> LawyerTypes { get; set; }

        public Db(DbContextOptions options) : base(options) // super in Java
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().Property(appointment => appointment.Description).IsRequired();
            modelBuilder.Entity<Client>().Property(client => client.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Contact>().Property(contact => contact.TelephoneNumber).IsRequired();
            modelBuilder.Entity<Contact>().Property(contact => contact.Address).IsRequired();
            modelBuilder.Entity<Document>().Property(document => document.Name).IsRequired();
            modelBuilder.Entity<Lawyer>().Property(lawyer => lawyer.Name).IsRequired().HasMaxLength(100);

        }
    }
}
