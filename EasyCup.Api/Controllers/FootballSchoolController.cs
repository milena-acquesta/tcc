using EasyCup.Api.Controllers.Base;
using EasyCup.Domain;
using EasyCup.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyCup.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballSchoolController : BaseController
    {
        #region Fields

        private readonly IFootballSchoolService _footballSchoolService;

        #endregion

        #region Constructor

        public FootballSchoolController(IFootballSchoolService footballSchoolService)
        {
            _footballSchoolService = footballSchoolService;
        }

        #endregion

        #region EndPoints

        [HttpPost("Create")]
        [ProducesResponseType(typeof(FootballSchool), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Create(
            [FromBody] FootballSchool footballSchool)
        {
            if (footballSchool == null)
                return BadRequest();

            try
            {
                return Ok(await _footballSchoolService.Add(footballSchool));
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
          [FromBody] FootballSchool footballSchool)
        {
            if (footballSchool == null)
                return BadRequest();

            try
            {
                await _footballSchoolService.Update(footballSchool);

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
          [FromBody] int footballSchoolID)
        {
            if (footballSchoolID == null)
                return BadRequest();

            try
            {
                await _footballSchoolService.Delete(footballSchoolID);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByID")]
        [ProducesResponseType(typeof(FootballSchool), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByID(
         [FromBody] int footballSchoolID)
        {
            if (footballSchoolID == null)
                return BadRequest();

            try
            {
                FootballSchool footballSchool = await _footballSchoolService.GetByID(footballSchoolID);

                return Ok(footballSchool);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<FootballSchool>), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetAll(
        [FromBody] int footballSchoolID)
        {
            if (footballSchoolID == null)
                return BadRequest();

            try
            {
                List<FootballSchool> footballSchools = await _footballSchoolService.GetAll();

                return Ok(footballSchools);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
