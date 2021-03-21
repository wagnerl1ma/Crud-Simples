using CrudSimples.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudSimples.Data
{
    public class CrudSimplesContext : DbContext
    {
        public CrudSimplesContext(DbContextOptions<CrudSimplesContext> options)
            : base(options)
        {
        }


        public DbSet<Cliente> Clientes { get; set; }




        //Usando DataAnnotations para especificar que e ClienteId é a chave, sendo assim não é necessário criar OnModelCreating no contexto

        //protected override void OnModelCreating(ModelBuilder modelBuilder)  
        //{
        //    modelBuilder.Entity<Cliente>().HasKey(x => x.ClienteId);


        //    base.OnModelCreating(modelBuilder);
        //}


        //String de conexão está sendo configurada e chamada na Startup
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Wagner\\Documents\\DbCrudTest.mdf;Integrated Security=True;Connect Timeout=30");
        //}
    }
}
