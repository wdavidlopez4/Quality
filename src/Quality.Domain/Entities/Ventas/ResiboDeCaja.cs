using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Entities.Ventas
{
    public class ResiboDeCaja : EntityBase
    {
        public string ResividoDe { get; private set; }

        public string SumadoDe { get; private set; }

        public string ConceptoDe { get; private set; }

        public List<Compra> Compras { get; private set; }

        internal ResiboDeCaja(string resividoDe, string sumadoDe, string conceptoDe, List<Compra> compras) : base()
        {
            this.ConceptoDe = conceptoDe;
            this.SumadoDe = sumadoDe;
            this.ConceptoDe = conceptoDe;
            this.Compras = compras;
        }

        private ResiboDeCaja()
        {

        }
    }
}
