using EasyCup.Api.Controllers.Base;
using EasyCup.Domain;
using EasyCup.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyCup.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : BaseController
    {
        #region Fields

        private readonly ITeamService _teamService;

        #endregion

        #region Constructor

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        #endregion

        #region EndPoints

        [HttpPost("Create")]
        [ProducesResponseType(typeof(Team), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Create(
            [FromBody] Team team)
        {
            if (team == null)
                return BadRequest();

            try
            {
                return Ok(await _teamService.Add(team));
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
          [FromBody] Team team)
        {
            if (team == null)
                return BadRequest();

            try
            {
                await _teamService.Update(team);

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
          [FromBody] int teamID)
        {
            if (teamID == null)
                return BadRequest();

            try
            {
                await _teamService.Delete(teamID);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByID")]
        [ProducesResponseType(typeof(Team), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByID(
         [FromBody] int teamID)
        {
            if (teamID == null)
                return BadRequest();

            try
            {
                Team team = await _teamService.GetByID(teamID);

                return Ok(team);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<Team>), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetAll(
        [FromBody] int teamID)
        {
            if (teamID == null)
                return BadRequest();

            try
            {
                List<Team> teams = await _teamService.GetAll();

                return Ok(teams);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
