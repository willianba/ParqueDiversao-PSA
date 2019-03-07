using System;

namespace ParqueBLL
{
    public interface IPassaporte
    {
        string NomeCliente { get; }
        int NroDias { get; }
        decimal ValorBasico { get; }
        DateTime DataInicial { get; }
        decimal ValorDoDia(int nroDia);
        decimal ValorTotal();
    }
}