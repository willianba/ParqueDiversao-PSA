using System;
using System.Collections.Generic;

namespace ParqueBLL
{
    public class PassaporteFactory
    {
        public IPassaporte CriarPassaporte(
            string umCliente,
            int umNroDias,
            decimal umValorBasico,
            int dia,
            int mes,
            int ano,
            IEnumerable<PromocoesAtivas> descontos
        ) {
            IPassaporte passaporte = new PassaporteBasico(umCliente, umNroDias, umValorBasico, dia, mes, ano);
            // TODO handle exception
            return DefinirPassaporte(passaporte, descontos);
        }

        private IPassaporte DefinirPassaporte(IPassaporte passaporte, IEnumerable<PromocoesAtivas> promocoes)
        {
            foreach (var promocao in promocoes)
            {
                switch (promocao)
                {
                    case PromocoesAtivas.UNIVERSITARIO:
                        return new PassaporteUniversitario(passaporte);
                    case PromocoesAtivas.IDOSO:
                        return new PassaporteIdoso(passaporte);
                    case PromocoesAtivas.PAGUEBEM:
                        return new PassaportePagueBem(passaporte);
                    case PromocoesAtivas.SEGUROGARANTIDO:
                        return new PassaporteSeguroGarantido(passaporte);
                    default:
                        throw new ArgumentOutOfRangeException(
                            nameof(promocao),
                            "Promoção Inválida!"
                        );
                }
            }
            return passaporte;
        }
    }
}