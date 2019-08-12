using Bacen.Application.Interface;
using Bacen.Domain.Entities;
using Bacen.Domain.Interfaces.Services;

namespace Bacen.Application
{
    public class BacenAppService : IBacenAppService
    {
        private readonly IBacenService _bacenService;

        public BacenAppService(IBacenService bacenService)            
        {
            _bacenService = bacenService;
        }

        public TaxaJuro GetTaxaJuro()
        {
            return _bacenService.GetTaxaJuro();
        }
    }
}
