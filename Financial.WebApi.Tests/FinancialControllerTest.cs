using Financial.Application.Interface;
using Financial.WebApi.Controllers;
using NUnit.Framework;
using System.Net.Http;

namespace Tests
{
    
    public class Tests
    {
        private  IFinancialAppService _financialAppService;
        [SetUp]
        public void Setup(IFinancialAppService financialAppService)
        {
            _financialAppService = financialAppService;
        }

        [Test]
        public async void CalculaJuroValor100Meses5()
        {
            var controller = new FinancialController(_financialAppService);
            //controller.Request = new HttpRequestMessage();
            //controller.Configuration = new HttpConfiguration();
            var result =  controller.CalculoJuros(100, 5);

            Assert.Pass();
        }
    }
}