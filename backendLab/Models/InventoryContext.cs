﻿using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }

        public DbSet<Inventory> Inventories { get; set; }
    }

}
