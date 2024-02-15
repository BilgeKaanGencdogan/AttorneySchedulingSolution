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

        public Db(DbContextOptions options) : base(options) // super in Java
        {

        }
    }
}
