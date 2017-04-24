using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MedEvol.DAL;
using MedEvol.DAL.Model;
using System.Web.Http.Cors;

namespace MedEvol.API.Controllers
{
   
    public class AnalizeController : ApiController
    {
        private testLaboratorEntities2 ctx = new testLaboratorEntities2();

        // GET: api/Analize
        public IEnumerable<usp_GetAnalizePacient_2_Result> Get()
        {
            var result = ctx.usp_GetAnalizePacient_2("1111111111111",1);

            return result.Select(x => new usp_GetAnalizePacient_2_Result
            {
                setData = x.setData,
                rezVal = x.rezVal,
                valMinVal = x.valMinVal,
                valmaxVal = x.valmaxVal,
                valcalc = x.valcalc
            }).ToList();
        }

        // GET: api/Analize/5
    public string Get(int id)
        {
            return "value";
        }

        // POST: api/Analize
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Analize/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Analize/5
        public void Delete(int id)
        {
        }
    }
}
