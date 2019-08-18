using Financial.Application.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Financial.Application.Tests
{
    [TestClass]
    public class FinancialApplicationTests
    {
        
        private  IFinancialAppService _financialAppService;

        public FinancialApplicationTests(IFinancialAppService financialAppService)
        {
           
            _financialAppService = financialAppService;
        }

        [TestInitialize]
        public void Inicialize() {
            var moc = new Mock
        }


        [TestMethod]
        public async Task CalulaJurosValor100Meses5Igual105D10()
        {
            var result = await _financialAppService.CalculaJuro(100, 5);
            Assert.AreEqual(105.10, result.Valor);            
        }
    }
}
