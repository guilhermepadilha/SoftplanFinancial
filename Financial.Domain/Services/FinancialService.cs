using Financial.Domain.Entities;
using Financial.Domain.Interface.Services;
using Financial.Service.Interface;
using Financial.Service.ValueObjects;
using System;
using System.Threading.Tasks;

namespace Financial.Domain.Services
{
    public class FinancialService : IFinancialService
    {
        public readonly IBacenFacade _bacenFacade;

        public FinancialService(IBacenFacade bacenFacade)
        {
            _bacenFacade = bacenFacade;
        }


        public async Task<JuroComposto> CalculaJuros(double valorInicial, int tempo)
        {
            try
            {
                TaxaJuro juro = await _bacenFacade.GetTaxaJuro();

                var juroComposto = (double)valorInicial * Math.Pow(1 + juro.Valor, tempo);
                 
                return new JuroComposto
                {
                    Valor = Truncate(juroComposto, 2)
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private double Truncate(double valor, int precisao)
        {
            return Math.Truncate(valor * Math.Pow(10, precisao)) / Math.Pow(10, precisao);
        }
    }
}
