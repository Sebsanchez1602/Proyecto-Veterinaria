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
    
    public partial class Citas
    {
        public int CitaID { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.TimeSpan> Hora { get; set; }
        public Nullable<int> MedicoID { get; set; }
        public Nullable<int> MascotaID { get; set; }
        public string Observaciones { get; set; }
    
        public virtual Mascotas Mascotas { get; set; }
        public virtual Medicos Medicos { get; set; }
    }
}
