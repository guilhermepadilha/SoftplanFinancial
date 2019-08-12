using Bacen.Application.Interface;
using Bacen.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bacen.Controllers
{
    [Route("api/bacen")]
    public class BacenController : Controller
    {
        private readonly IBacenAppService _bacenAppService;

        public BacenController(IBacenAppService bacenAppService)
        {
            _bacenAppService = bacenAppService;
        }

        [HttpGet]
        [Route("taxaJuro")]
        public ActionResult<TaxaJuro> GetTaxaJuro()
        {
            try
            {
                return _bacenAppService.GetTaxaJuro();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
