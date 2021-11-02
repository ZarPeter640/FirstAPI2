using FirstAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KundenController : ControllerBase
    {
        private List<Kunde> kunden = new List<Kunde>()
        {
            new Kunde(){iD = 0, name = "Max Mustermann", age = 20},
            new Kunde(){iD = 1, name = "Tim Löffel", age = 32},
        };

        [HttpGet]
        public IEnumerable<Kunde> Get()
        {
            return kunden;
        }

        [HttpPost]
        public void Post([FromBody]Kunde kunde)
        {
            kunden.Add(kunde);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Kunde kunde)
        {
            kunden[id] = kunde;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            kunden.RemoveAt(id);
        }
    }
}
