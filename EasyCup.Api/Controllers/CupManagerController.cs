using EasyCup.Api.Controllers.Base;
using EasyCup.Domain;
using EasyCup.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyCup.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CupManagerController : BaseController
    {
        #region Fields

        private readonly ICupManagerService _cupManagerService;

        #endregion

        #region Constructor

        public CupManagerController(ICupManagerService cupManagerService)
        {
            _cupManagerService = cupManagerService;
        }

        #endregion

        #region EndPoints

        [HttpPost("Create")]
        [ProducesResponseType(typeof(CupManager), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> Create(
            [FromBody] CupManager cupManager)
        {
            if (cupManager == null)
                return BadRequest();

            try
            {
                return Ok(await _cupManagerService.Add(cupManager));
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
          [FromBody] CupManager cupManager)
        {
            if (cupManager == null)
                return BadRequest();

            try
            {
                await _cupManagerService.Update(cupManager);

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
          [FromBody] int cupManagerID)
        {
            if (cupManagerID == null)
                return BadRequest();

            try
            {
                await _cupManagerService.Delete(cupManagerID);

                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByID")]
        [ProducesResponseType(typeof(CupManager), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetByID(
         [FromBody] int cupManagerID)
        {
            if (cupManagerID == null)
                return BadRequest();

            try
            {
                CupManager cupManager = await _cupManagerService.GetByID(cupManagerID);

                return Ok(cupManager);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(List<CupManager>), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public async Task<IActionResult> GetAll(
        [FromBody] int cupManagerID)
        {
            if (cupManagerID == null)
                return BadRequest();

            try
            {
                List<CupManager> cupManagers = await _cupManagerService.GetAll();

                return Ok(cupManagers);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
