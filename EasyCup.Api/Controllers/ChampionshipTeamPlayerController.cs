using EasyCup.Api.Controllers.Base;
using EasyCup.Domain;
using EasyCup.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyCup.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChampionshipTeamPlayerController : BaseController
    {
        #region Fields

        private readonly IChampionshipTeamPlayerService _championshipTeamPlayerService;

        #endregion

        #region Constructor

        public ChampionshipTeamPlayerController(IChampionshipTeamPlayerService championshipTeamPlayerService)
        {
            _championshipTeamPlayerService = championshipTeamPlayerService;
        }

        #endregion

        #region EndPoints

        [HttpPost("Create")]
        [ProducesResponseType(typeof(ChampionshipTeamPlayer), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Create(
            [FromBody] ChampionshipTeamPlayer championshipTeamPlayer)
        {
            if (championshipTeamPlayer == null)
                return BadRequest();

            try
            {
                return Ok(await _championshipTeamPlayerService.Add(championshipTeamPlayer));
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
          [FromBody] ChampionshipTeamPlayer championshipTeamPlayer)
        {
            if (championshipTeamPlayer == null)
                return BadRequest();

            try
            {
                await _championshipTeamPlayerService.Update(championshipTeamPlayer);

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
          [FromBody] int championshipTeamPlayerID)
        {
            if (championshipTeamPlayerID == null)
                return BadRequest();

            try
            {
                await _championshipTeamPlayerService.Delete(championshipTeamPlayerID);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByID")]
        [ProducesResponseType(typeof(ChampionshipTeamPlayer), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByID(
         [FromBody] int championshipTeamPlayerID)
        {
            if (championshipTeamPlayerID == null)
                return BadRequest();

            try
            {
                ChampionshipTeamPlayer championshipTeamPlayer = await _championshipTeamPlayerService.GetByID(championshipTeamPlayerID);

                return Ok(championshipTeamPlayer);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<ChampionshipTeamPlayer>), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetAll(
        [FromBody] int championshipTeamPlayerID)
        {
            if (championshipTeamPlayerID == null)
                return BadRequest();

            try
            {
                List<ChampionshipTeamPlayer> championshipTeamPlayers = await _championshipTeamPlayerService.GetAll();

                return Ok(championshipTeamPlayers);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
