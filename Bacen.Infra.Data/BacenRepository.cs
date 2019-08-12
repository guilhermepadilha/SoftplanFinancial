using Bacen.Domain.Entities;
using Bacen.Domain.Interfaces.Repositories;

namespace Bacen.Infra.Data
{
    public class BacenRepository : IBacenRepository
    {
        public TaxaJuro GetTaxaJuro()
        {
            return new TaxaJuro { Valor = 0.01 };
        }
    }
}
