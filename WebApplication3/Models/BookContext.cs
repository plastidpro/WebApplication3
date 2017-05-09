﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }
}