using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data {
    public class SalesWebMVCContext : DbContext {
        public SalesWebMVCContext(DbContextOptions<SalesWebMVCContext> options)
            : base(options) {
        }

        //Dbset de departamentos.
        public DbSet<Departament> Departament { get; set; }

        //Dbset de vendedores.
        public DbSet<Seller> Seller { get; set; }

        //Dbset de recorde de vendas.
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
