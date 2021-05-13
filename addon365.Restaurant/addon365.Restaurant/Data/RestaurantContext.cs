using addon365.Restaurant.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addon365.Restaurant.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {

        }
        public DbSet<RestaurantCatalog> RestaurantCatalogs { get; set; }

        public DbSet<RestaurantCategory> RestaurantCategories { get; set; }
    }
}
