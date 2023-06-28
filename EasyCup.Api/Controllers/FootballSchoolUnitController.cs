using EasyCup.Api.Controllers.Base;
using EasyCup.Domain;
using EasyCup.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyCup.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballSchoolUnitController : BaseController
    {
        #region Fields

        private readonly IFootballSchoolUnitService _footballSchoolUnitService;

        #endregion

        #region Constructor

        public FootballSchoolUnitController(IFootballSchoolUnitService footballSchoolUnitService)
        {
            _footballSchoolUnitService = footballSchoolUnitService;
        }

        #endregion

        #region EndPoints

        [HttpPost("Create")]
        [ProducesResponseType(typeof(FootballSchoolUnit), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Create(
            [FromBody] FootballSchoolUnit footballSchoolUnit)
        {
            if (footballSchoolUnit == null)
                return BadRequest();

            try
            {
                return Ok(await _footballSchoolUnitService.Add(footballSchoolUnit));
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
          [FromBody] FootballSchoolUnit footballSchoolUnit)
        {
            if (footballSchoolUnit == null)
                return BadRequest();

            try
            {
                await _footballSchoolUnitService.Update(footballSchoolUnit);

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
          [FromBody] int footballSchoolUnitID)
        {
            if (footballSchoolUnitID == null)
                return BadRequest();

            try
            {
                await _footballSchoolUnitService.Delete(footballSchoolUnitID);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByID")]
        [ProducesResponseType(typeof(FootballSchoolUnit), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByID(
         [FromBody] int footballSchoolUnitID)
        {
            if (footballSchoolUnitID == null)
                return BadRequest();

            try
            {
                FootballSchoolUnit footballSchoolUnit = await _footballSchoolUnitService.GetByID(footballSchoolUnitID);

                return Ok(footballSchoolUnit);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<FootballSchoolUnit>), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetAll(
        [FromBody] int footballSchoolUnitID)
        {
            if (footballSchoolUnitID == null)
                return BadRequest();

            try
            {
                List<FootballSchoolUnit> footballSchoolUnits = await _footballSchoolUnitService.GetAll();

                return Ok(footballSchoolUnits);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
