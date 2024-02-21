using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Context
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options): base(options){

        }

        public DbSet<Stock> Stocks {get; set;}
        public DbSet<User> Users {get; set;}
    }
}