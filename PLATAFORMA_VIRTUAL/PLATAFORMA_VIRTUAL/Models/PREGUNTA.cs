//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PLATAFORMA_VIRTUAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PREGUNTA
    {
        public int id { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Curso { get; set; }
        public string Pregunta1 { get; set; }
        public string Descripcion { get; set; }
    
        public virtual CURSO CURSO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
