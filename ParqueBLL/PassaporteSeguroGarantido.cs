namespace ParqueBLL
{
    public class PassaporteSeguroGarantido : PassaporteDecorator
    {
        public PassaporteSeguroGarantido(IPassaporte umPassaporte) : base(umPassaporte)
        {
        }
        
        public new decimal ValorDoDia(int nroDia)
        {
            var valorBase = base.ValorDoDia(nroDia);
            const int quantidadeDeDiasParaDesconto = 7;
            if (NroDias != quantidadeDeDiasParaDesconto)
            {
                return valorBase;
            }
            const decimal desconto = 0.98m;
            return valorBase * desconto;
        }
    }
}