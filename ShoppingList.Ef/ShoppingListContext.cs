using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ShoppingList.Ef
{
    public class ShoppingListContext : DbContext
    {
        public ShoppingListContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
