using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEvol.DAL.Model
{
    public class County
    {
        public int CountyId { get; set; }
        public string CountyName { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
