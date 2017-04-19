using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MedEvol.DAL.Model;

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
