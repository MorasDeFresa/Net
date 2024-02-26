using Microsoft.EntityFrameworkCore;
using tatiana.Models;

namespace tatiana.Context
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options): base(options){

        }
        public DbSet<Sapa> Sapas {get; set;}
    }
}