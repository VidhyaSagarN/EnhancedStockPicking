using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IEXTrading.Models;
using IEXTrading.Models.ViewModel;

namespace IEXTrading.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Equity> Equities { get; set; }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<GraphData> GraphData { get; set; }
        public DbSet<GraphData> enhancedCompanyInfos2 { get; set; }
    }
}
