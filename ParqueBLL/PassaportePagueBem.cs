namespace ParqueBLL
{
    public class PassaportePagueBem : PassaporteDecorator
    {
        public PassaportePagueBem(IPassaporte umPassaporte) : base(umPassaporte)
        {
        }

        public override decimal ValorTotal()
        {
            const decimal desconto = 0.98M;
            var valorBase = base.ValorTotal();
            return valorBase * desconto;
        }
    }
}