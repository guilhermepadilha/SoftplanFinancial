using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Financial.Application.Interface;
using Financial.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Financial.WebApi.Controllers
{
    
    [Route("api/financial")]
    [ApiController]
    public class FinancialController : Controller
    {
        private readonly IFinancialAppService _financialAppService;

        public FinancialController(IFinancialAppService financialAppService)
        {
            _financialAppService = financialAppService;
        }

        [HttpGet]
        [Route("calculajuros")]
        public async Task<JuroComposto>  CalculoJuros([FromQuery]double valorInicial, [FromQuery]int meses)
        {
            try
            {
                
                var valorCalculado = await _financialAppService.CalculaJuro(valorInicial, meses);
                return valorCalculado;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
