using System;

namespace ParqueBLL
{
    class PassaporteBasico : IPassaporte
    {
        public string NomeCliente { get; }
        public int NroDias { get; }
        public decimal ValorBasico { get; }
        public DateTime DataInicial { get; }
        
        public PassaporteBasico(
            string umCliente,
            int umNroDias,
            decimal umValorBasico,
            int dia,
            int mes,
            int ano
        ) {
            NomeCliente = umCliente;
            NroDias = umNroDias;
            ValorBasico = umValorBasico;
            DataInicial = new DateTime(ano, mes, dia);
        }

        public decimal ValorDoDia(int nroDia)
        {
            var valorDia = ValorBasico;
            for (var i = 1; i < nroDia; i++)
            {
                valorDia -= valorDia * 0.2M;
            }
            return valorDia;
        }

        public decimal ValorTotal()
        {
            decimal valorTotal = 0;
            for (var d = 1; d <= NroDias; d++)
            {
                valorTotal += ValorDoDia(d);
            }
            return valorTotal;
        }

        public override string ToString()
        {
            return $"Cliente: {NomeCliente}\t Valor básico: {ValorBasico}  Número de dias: {NroDias}";
        }
    }
}