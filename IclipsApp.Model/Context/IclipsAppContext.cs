using IclipsApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IclipsApp.Model.Context
{
    public class IclipsAppContext : DbContext
    {
        public IclipsAppContext() : base("Server=DESKTOP-V53GRSV;Database=IclipsAppDB; Trusted_Connection=True;")
        {
            
        }

        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pessoa>().HasKey(a => a.PessoaId);
        }
    }
}
