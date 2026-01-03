using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CGM.Service.Dtos;
using CGM.Service.Services;
using CGM.Service.Interfaces;

namespace CGM.Api.Controllers
{
    [Route("api/v1/[controller]/")]
    [ApiController]
    public class TrusteesController : ControllerBase
    {
        private readonly ITrusteeService trusteeService;

        public TrusteesController(ITrusteeService _trusteeService)
        {
            trusteeService = _trusteeService;
        }

        [HttpPost]
        [Route("add-new-trustee")]
        public async Task<IActionResult> AddTrustee(AddTrusteeDto addTrusteeDto)
        {
            return Ok("Trustee added successfully.");
        }

        [HttpGet]
        [Route("get-all-trustees")]
        public async Task<IActionResult> GetAllTrustees()
        {
            return Ok(await trusteeService.GetAllTrustee());
        }
    }
}
