namespace ParqueBLL
{
    public class PassaporteUniversitario : PassaporteDecorator
    {
        public PassaporteUniversitario(IPassaporte umPassaporte) : base(umPassaporte)
        {
        }
        
        public override decimal ValorDoDia(int nroDia)
        {
            // TODO new logic
            return base.ValorDoDia(nroDia);
        }
    }
}