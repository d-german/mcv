using BmiCalculator.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace BmiCalculator.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BmiHistoryController : ControllerBase
    {
        private readonly IBmiRepository _bmiRepository;

        public BmiHistoryController(IBmiRepository bmiRepository)
        {
            _bmiRepository = bmiRepository ?? throw new ArgumentNullException(nameof(bmiRepository));
        }

        // GET: /BmiHistory
        [HttpGet(Name = "bmiHistory")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IEnumerable<BmiHistory>?>> Get()
        {
            var result = await _bmiRepository.GetBmiHistoryAsync("1");
            return result == null ? StatusCode(StatusCodes.Status404NotFound) : StatusCode(StatusCodes.Status200OK, result);
        }

        // GET: /BmiHistory/5
        [HttpGet("{id:int}", Name = "Get")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IEnumerable<BmiHistory>?>> Get(int id)
        {
            var result = await _bmiRepository.GetBmiHistoryAsync(id.ToString());
            return result == null ? StatusCode(StatusCodes.Status404NotFound) : StatusCode(StatusCodes.Status200OK, result);
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
