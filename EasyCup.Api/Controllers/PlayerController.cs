using EasyCup.Api.Controllers.Base;
using EasyCup.Domain;
using EasyCup.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyCup.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : BaseController
    {
        #region Fields

        private readonly IPlayerService _playerService;

        #endregion

        #region Constructor

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        #endregion

        #region EndPoints

        [HttpPost("Create")]
        [ProducesResponseType(typeof(Player), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Create(
            [FromBody] Player player)
        {
            if (player == null)
                return BadRequest();

            try
            {
                return Ok(await _playerService.Add(player));
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
          [FromBody] Player player)
        {
            if (player == null)
                return BadRequest();

            try
            {
                await _playerService.Update(player);

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
          [FromBody] int playerID)
        {
            if (playerID == null)
                return BadRequest();

            try
            {
                await _playerService.Delete(playerID);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByID")]
        [ProducesResponseType(typeof(Player), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByID(
         [FromBody] int playerID)
        {
            if (playerID == null)
                return BadRequest();

            try
            {
                Player player = await _playerService.GetByID(playerID);

                return Ok(player);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<Player>), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetAll(
        [FromBody] int playerID)
        {
            if (playerID == null)
                return BadRequest();

            try
            {
                List<Player> players = await _playerService.GetAll();

                return Ok(players);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
