using EasyCup.Api.Controllers.Base;
using EasyCup.Domain;
using EasyCup.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyCup.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FutsalCourtController : BaseController
    {
        #region Fields

        private readonly IFutsalCourtService _futsalCourtService;

        #endregion

        #region Constructor

        public FutsalCourtController(IFutsalCourtService futsalCourtService)
        {
            _futsalCourtService = futsalCourtService;
        }

        #endregion

        #region EndPoints

        [HttpPost("Create")]
        [ProducesResponseType(typeof(FutsalCourt), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Create(
            [FromBody] FutsalCourt futsalCourt)
        {
            if (futsalCourt == null)
                return BadRequest();

            try
            {
                return Ok(await _futsalCourtService.Add(futsalCourt));
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
          [FromBody] FutsalCourt futsalCourt)
        {
            if (futsalCourt == null)
                return BadRequest();

            try
            {
                await _futsalCourtService.Update(futsalCourt);

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
          [FromBody] int futsalCourtID)
        {
            if (futsalCourtID == null)
                return BadRequest();

            try
            {
                await _futsalCourtService.Delete(futsalCourtID);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByID")]
        [ProducesResponseType(typeof(FutsalCourt), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByID(
         [FromBody] int futsalCourtID)
        {
            if (futsalCourtID == null)
                return BadRequest();

            try
            {
                FutsalCourt futsalCourt = await _futsalCourtService.GetByID(futsalCourtID);

                return Ok(futsalCourt);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<FutsalCourt>), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetAll(
        [FromBody] int futsalCourtID)
        {
            if (futsalCourtID == null)
                return BadRequest();

            try
            {
                List<FutsalCourt> futsalCourts = await _futsalCourtService.GetAll();

                return Ok(futsalCourts);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
