using Financial.Domain.Entities;
using System.Threading.Tasks;

namespace Financial.Domain.Interface.Services
{
    public interface IFinancialService
    {
        Task<JuroComposto> CalculaJuros(double valorInicial, int tempo);
    }
}
