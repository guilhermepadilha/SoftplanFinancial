using AutoMoq;
using Financial.Application.Interface;
using Financial.Domain.Entities;
using Financial.Domain.Interface.Services;
using Financial.Domain.Services;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Financial.Application.Test
{
    public class FinancialApplicationTests
    {
        public FinancialAppService _financialAppService { get; set; }
        public FinancialService _financialService { get; set; }
        private Mock<IFinancialAppService> _financialAppServiceMock { get; set; }
        private Mock<IFinancialService> _financialServiceMock { get; set; }

        public FinancialApplicationTests()
        {
            var mocker = new AutoMoqer();

            mocker.Create<FinancialAppService>();
            mocker.Create<FinancialService>();

            

            _financialService = mocker.Resolve<FinancialService>();
            mocker.SetInstance<FinancialService>(_financialService);

            _financialAppService = mocker.Resolve<FinancialAppService>();
                                  
            _financialAppServiceMock = mocker.GetMock<IFinancialAppService>();   
            _financialServiceMock = mocker.GetMock<IFinancialService>();

             _financialServiceMock.Setup(c => c.CalculaJuros((double)100, (int)5));
            
            //.ReturnsAsync(new JuroComposto { Valor = 0});

        }


        
        [Fact]
        public async Task CalculaJuros()
        {   
            var result = await _financialAppService.CalculaJuro(100, 5);
            Assert.Equal(105.10, result.Valor);
        }
    }
}
