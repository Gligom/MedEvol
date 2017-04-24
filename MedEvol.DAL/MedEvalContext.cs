using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MedEvol.DAL.Model;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace MedEvol.DAL
{
    public class MedEvalContext: DbContext
    {
        public MedEvalContext()
            :base("name=MedEvolConnection")
        {
        }

        public DbSet<County> Counties { get; set; }
        public DbSet<City> Cities { get; set; }

      
    }
}
