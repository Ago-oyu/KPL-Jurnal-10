using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace modul10_1302220101.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiwaList = new List<Mahasiswa>()
        {
            new Mahasiswa("Yoga Fikri", "1302220101", new List<string>(){"KPL", "PBO", "Basdat"}, 2022),
            new Mahasiswa("Kyntar Barra", "1302220113", new List<string>(){"KPL", "PBO", "Basdat"}, 2022),
            new Mahasiswa("Haidar Abdul", "1302220152", new List<string>(){"KPL", "PBO", "Basdat"}, 2022),
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiwaList;
        }

        
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiwaList[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiwaList.Add(value);
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiwaList.RemoveAt(id);
        }


    }
}
