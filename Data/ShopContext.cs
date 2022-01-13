﻿using Microsoft.EntityFrameworkCore;
using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedFastreact.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options): base(options)
            {
}
public DbSet<Shops> Shops { get; set; }

    }
}
