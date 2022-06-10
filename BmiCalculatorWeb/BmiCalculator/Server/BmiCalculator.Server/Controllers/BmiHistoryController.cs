using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BmiCalculator.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BmiHistoryController : ControllerBase
    {
        // GET: /BmiHistory
        [HttpGet(Name = "bmiHistory")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: /BmiHistory/5
        [HttpGet("{id:int}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: BmiHistory
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: BmiHistory/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: BmiHistory/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
