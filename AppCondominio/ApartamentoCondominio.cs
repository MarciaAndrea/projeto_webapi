//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppCondominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApartamentoCondominio
    {
        public int ApartamentoId { get; set; }
        public int CondominioId { get; set; }
    
        public virtual Apartamento Apartamento { get; set; }
        public virtual Condominio Condominio { get; set; }
    }
}
