using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF
{
    public class KOCDbContextFactory : IDesignTimeDbContextFactory<KOCDbContext>
    {
        private readonly string _connectionString = @"Data Source=DESKTOP-3730FF9\SQLEXPRESS;Initial Catalog=KOC_BMW;Integrated Security=True";
        public KOCDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<KOCDbContext>();
            optionsBuilder.UseSqlServer(_connectionString);
            return new KOCDbContext(optionsBuilder.Options);
        }
    }
}
