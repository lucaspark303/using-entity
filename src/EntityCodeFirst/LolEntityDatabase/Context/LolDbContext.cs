using LolEntityDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolEntityDatabase.Context
{
    public class LolDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=lol_db;User Id=nuhabo;Password=fhfgkdl; Integrated Security=true;Trusted_Connection=True;");

        }
    }
}
