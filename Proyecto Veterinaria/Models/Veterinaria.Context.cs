﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Veterinaria.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VeterinariaEntities1 : DbContext
    {
        public VeterinariaEntities1()
            : base("name=VeterinariaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Citas> Citas { get; set; }
        public virtual DbSet<Cotizaciones> Cotizaciones { get; set; }
        public virtual DbSet<Dueno> Dueno { get; set; }
        public virtual DbSet<HistorialMedico> HistorialMedico { get; set; }
        public virtual DbSet<InventarioMedicamentos> InventarioMedicamentos { get; set; }
        public virtual DbSet<Mascotas> Mascotas { get; set; }
        public virtual DbSet<Medicamentos> Medicamentos { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<RecetasMedicas> RecetasMedicas { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }
    }
}
