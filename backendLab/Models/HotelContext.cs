﻿using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
    }

}