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
    
    public partial class RecetasMedicas
    {
        public int RecetaID { get; set; }
        public Nullable<int> MascotaID { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Medicamento { get; set; }
        public string Dosis { get; set; }
        public string Duracion { get; set; }
        public string Instrucciones { get; set; }
    
        public virtual Mascotas Mascotas { get; set; }
    }
}
