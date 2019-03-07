using System;
using System.Transactions;

namespace ParqueBLL
{
    public class PassaporteDecorator : IPassaporte
    {
        private IPassaporte PassaporteDecorado { get; }
        public string NomeCliente => PassaporteDecorado.NomeCliente;
        public int NroDias => PassaporteDecorado.NroDias;
        public decimal ValorBasico => PassaporteDecorado.ValorBasico;
        public DateTime DataInicial => PassaporteDecorado.DataInicial;

        protected PassaporteDecorator(IPassaporte umPassaporte)
        {
            PassaporteDecorado = umPassaporte;
        }
        
        public virtual decimal ValorDoDia(int nroDia)
        {
            return PassaporteDecorado.ValorDoDia(nroDia);
        }

        public virtual decimal ValorTotal()
        {
            return PassaporteDecorado.ValorTotal();
        }
        
        public override string ToString()
        {
            return PassaporteDecorado.ToString();
        }
    }
}