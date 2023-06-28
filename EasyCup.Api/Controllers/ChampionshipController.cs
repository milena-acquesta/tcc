using EasyCup.Api.Controllers.Base;
using EasyCup.Domain;
using EasyCup.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyCup.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChampionshipController : BaseController
    {
        #region Fields

        private readonly IChampionshipService _championshipService;

        #endregion

        #region Constructor

        public ChampionshipController(IChampionshipService championshipService)
        {
            _championshipService = championshipService;
        }

        #endregion

        #region EndPoints

        [HttpPost("Create")]
        [ProducesResponseType(typeof(Championship), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Create(
            [FromBody] Championship championship)
        {
            if (championship == null)
                return BadRequest();

            try
            {
                return Ok(await _championshipService.Add(championship));
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
          [FromBody] Championship championship)
        {
            if (championship == null)
                return BadRequest();

            try
            {
                await _championshipService.Update(championship);

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
          [FromBody] int championshipID)
        {
            if (championshipID == null)
                return BadRequest();

            try
            {
                await _championshipService.Delete(championshipID);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByID")]
        [ProducesResponseType(typeof(Championship), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByID(
         [FromBody] int championshipID)
        {
            if (championshipID == null)
                return BadRequest();

            try
            {
                Championship championship = await _championshipService.GetByID(championshipID);

                return Ok(championship);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<Championship>), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetAll(
        [FromBody] int championshipID)
        {
            if (championshipID == null)
                return BadRequest();

            try
            {
                List<Championship> championships = await _championshipService.GetAll();

                return Ok(championships);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
