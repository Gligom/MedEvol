﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedEvol.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class testLaboratorEntities2 : DbContext
    {
        public testLaboratorEntities2()
            : base("name=testLaboratorEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<usp_GetAnalizePacient_2_Result> usp_GetAnalizePacient_2(string cnp, Nullable<int> analiza)
        {
            var cnpParameter = cnp != null ?
                new ObjectParameter("cnp", cnp) :
                new ObjectParameter("cnp", typeof(string));
    
            var analizaParameter = analiza.HasValue ?
                new ObjectParameter("analiza", analiza) :
                new ObjectParameter("analiza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAnalizePacient_2_Result>("usp_GetAnalizePacient_2", cnpParameter, analizaParameter);
        }
    }
}
