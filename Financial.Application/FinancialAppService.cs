using Financial.Application.Interface;
using Financial.Domain.Entities;
using Financial.Domain.Interface.Services;
using System.Threading.Tasks;

namespace Financial.Application
{
    public class FinancialAppService : IFinancialAppService
    {
        private readonly IFinancialService _financialService;

        public FinancialAppService(IFinancialService financialService)
        {
            _financialService = financialService;
        }

        public Task<JuroComposto> CalculaJuro(double valorInicial, int tempo)
        {
            try
            {
                var valor = _financialService.CalculaJuros(valorInicial, tempo);
                return valor;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
