using FashionWebStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FashionWebStoreApp.Entities
{
    public class FashionStoreContext : DbContext
    {
        public FashionStoreContext(DbContextOptions<FashionStoreContext> options) : base(options)
        {
        }

        public DbSet<Warehouse> Warehouses { get; set; }
    }
}