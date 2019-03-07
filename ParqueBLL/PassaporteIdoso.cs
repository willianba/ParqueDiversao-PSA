namespace ParqueBLL
{
    public class PassaporteIdoso : PassaporteDecorator
    {
        public PassaporteIdoso(IPassaporte umPassaporte) : base(umPassaporte)
        {
        }

        public override decimal ValorDoDia(int nroDia)
        {
            // TODO new logic
            return base.ValorDoDia(nroDia);
        }
    }
}