using EasyCup.Api.Controllers.Base;
using EasyCup.Domain;
using EasyCup.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyCup.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchController : BaseController
    {
        #region Fields

        private readonly IMatchService _matchService;

        #endregion

        #region Constructor

        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        #endregion

        #region EndPoints

        [HttpPost("Create")]
        [ProducesResponseType(typeof(Match), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Create(
            [FromBody] Match match)
        {
            if (match == null)
                return BadRequest();

            try
            {
                return Ok(await _matchService.Add(match));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        [ProducesResponseType(typeof(void), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Update(
          [FromBody] Match match)
        {
            if (match == null)
                return BadRequest();

            try
            {
                await _matchService.Update(match);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete")]
        [ProducesResponseType(typeof(void), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Delete(
          [FromBody] int matchID)
        {
            if (matchID == null)
                return BadRequest();

            try
            {
                await _matchService.Delete(matchID);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByID")]
        [ProducesResponseType(typeof(Match), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByID(
         [FromBody] int matchID)
        {
            if (matchID == null)
                return BadRequest();

            try
            {
                Match match = await _matchService.GetByID(matchID);

                return Ok(match);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<Match>), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetAll(
        [FromBody] int matchID)
        {
            if (matchID == null)
                return BadRequest();

            try
            {
                List<Match> matches = await _matchService.GetAll();

                return Ok(matches);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
