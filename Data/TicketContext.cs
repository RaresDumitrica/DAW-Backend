using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DawAppWithAngular.Entities;

namespace DawAppWithAngular.Data
{
    public class TicketContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }

        public TicketContext(DbContextOptions<TicketContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // User Many to many for the many to many requirement -> I won't deny it is useless (ﾉ◕ヮ◕)ﾉ*:･ﾟ✧
            builder.Entity<UserRole>()
                .HasOne(x => x.User)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(z => z.UserId);

            builder.Entity<UserRole>()
                .HasOne(x => x.Role)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(z => z.RoleId);

            builder.Entity<UserRole>()
                .HasAlternateKey(x => new { x.UserId, x.RoleId });
        }
    }
}
