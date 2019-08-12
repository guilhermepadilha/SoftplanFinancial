using Financial.Service.ValueObjects;
using System.Threading.Tasks;

namespace Financial.Service.Interface
{
    public interface IBacenFacade
    {
        Task<TaxaJuro> GetTaxaJuro();
    }
}
