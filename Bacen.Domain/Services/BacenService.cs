using Bacen.Domain.Entities;
using Bacen.Domain.Interfaces.Repositories;
using Bacen.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bacen.Domain.Services
{
    public class BacenService : IBacenService
    {
        public readonly IBacenRepository _bacenRepository;

        public BacenService(IBacenRepository bacenRepository)
        {
            _bacenRepository = bacenRepository;
        }

        public TaxaJuro GetTaxaJuro()
        {
            return _bacenRepository.GetTaxaJuro();
        }
    }
}
