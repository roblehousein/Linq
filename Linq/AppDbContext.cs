using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class AppDbContext : DbContext
    {
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<DossierScolaire> DossierScolaires { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connexionString = "server=localhost;database=onetoone;user=root;";
            options.UseMySql(connexionString, ServerVersion.AutoDetect(connexionString));
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Etudiant>()
        //    .HasOne(e => e.dossier)
        //    .WithOne(d => d.etudiant)
        //    .HasForeignKey<DossierScolaire>(d => d.EtudiantId);
        //}
    }

}
