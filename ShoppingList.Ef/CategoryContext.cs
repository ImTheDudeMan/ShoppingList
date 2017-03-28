using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ShoppingList.Ef
{
    public class CategoryContext: DbContext
    {
        public CategoryContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
