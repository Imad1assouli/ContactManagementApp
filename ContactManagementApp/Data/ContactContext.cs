using Microsoft.EntityFrameworkCore;
using ContactManagementApp.Models;

namespace ContactManagementApp.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}