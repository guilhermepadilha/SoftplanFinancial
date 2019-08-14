using Financial.Domain.Interface.Services;
using NUnit.Framework;

namespace Tests
{
    public class FinancialAppServiceTest
    {
        private IFinancialService _financialService;

        public FinancialAppServiceTest(IFinancialService financialService)
        {
            _financialService = financialService;
        }
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public async void CalculaJuroValor100Meses5()
        {
            var juroComposto = _financialService.CalculaJuros(100, 5);

            Assert.IsNotNull(juroComposto);
            Assert.AreEqual(juroComposto.Result.Valor, 105.1);
            
        }
    }
}