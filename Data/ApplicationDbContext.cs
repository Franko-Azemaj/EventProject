using EventProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
#pragma warning disable CS8618

namespace EventProject.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }


    public DbSet<User> Users { get; set; }

    // public DbSet<EventCreator> EventCreators { get; set; } 

    public DbSet<Event> Events { get; set; }
    public DbSet<Category> Categorys { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Favorite> Favorites { get; set; }


}


