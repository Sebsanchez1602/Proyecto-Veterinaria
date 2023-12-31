//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Mascotas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mascotas()
        {
            this.Citas = new HashSet<Citas>();
            this.Cotizaciones = new HashSet<Cotizaciones>();
            this.HistorialMedico = new HashSet<HistorialMedico>();
            this.RecetasMedicas = new HashSet<RecetasMedicas>();
        }
    
        public int MascotaID { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Genero { get; set; }
        public Nullable<int> PropietarioID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Citas> Citas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizaciones> Cotizaciones { get; set; }
        public virtual Dueno Dueno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialMedico> HistorialMedico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecetasMedicas> RecetasMedicas { get; set; }
    }
}
