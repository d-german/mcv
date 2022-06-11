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

        // GET: /BmiHistory/5
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IEnumerable<BmiHistory>?>> Get(int id)
        {
            var result = await _bmiRepository.GetBmiHistoryAsync(id.ToString());
            return result == null ? StatusCode(StatusCodes.Status404NotFound) : StatusCode(StatusCodes.Status200OK, result);
        }

        // POST: BmiHistory
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IEnumerable<BmiHistory>?>> Post([FromBody] BmiHistory value)
        {
            var result = await _bmiRepository.SaveBmiHistoryAsync(value);
            return result == null ? StatusCode(StatusCodes.Status404NotFound) : StatusCode(StatusCodes.Status200OK, result);
        }

    }
}
