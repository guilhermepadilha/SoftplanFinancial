using Financial.Domain.Entities;
using System.Threading.Tasks;

namespace Financial.Application.Interface
{
    public interface IFinancialAppService
    {
        Task<JuroComposto> CalculaJuro(double valorInicial, int tempo);
    }
}
