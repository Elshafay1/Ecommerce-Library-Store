using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Library_Store.Models;

namespace Library_Store.Data
{
    public class Library_StoreContext : DbContext
    {
        public Library_StoreContext (DbContextOptions<Library_StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Library_Store.Models.book> book { get; set; } = default!;

        public DbSet<Library_Store.Models.usersaccounts>? usersaccounts { get; set; }

        public DbSet<Library_Store.Models.orders>? orders { get; set; }

        public DbSet<Library_Store.Models.report>? report { get; set; }

    }
}
