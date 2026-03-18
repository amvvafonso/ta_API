using API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{
    // definir 
    public DbSet<Photography> Photos { get; set; }
    public DbSet<MyUser> MyUsers { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<Category> Categories { get; set; }
}