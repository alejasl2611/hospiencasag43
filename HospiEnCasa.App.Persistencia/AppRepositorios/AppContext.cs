using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;
namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas{get; set;}
        public DbSet<Persona> Pacientes{get; set;}
        public DbSet<Persona> Medicos{get; set;}
        public DbSet<Persona> Enfermeras{get; set;}
        public DbSet<Persona> FamiliaresDesignados{get; set;}
        public DbSet<Persona> SignosVitales{get; set;}
        public DbSet<Persona> Historias{get; set;}
        public DbSet<Persona> SugerenciasCuidado{get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=HospiEnCasaDataG43");
            }
        }

    }
}