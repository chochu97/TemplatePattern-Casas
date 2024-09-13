using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateCasa.Factory
{
    public class CasaLadrillos : Casa
    {
        public CasaLadrillos(bool pint, bool secP, bool sot, string tipo, string ub) : base(pint, secP, sot, tipo)
        {
        }

        public override string Name => "Casa de Ladrillos";

        protected override void ColocarAcabado()
        {
            Console.WriteLine("Colocando el acabado de la casa de ladrillos");
        }

        protected override void ColocarTecho()
        {
            Console.WriteLine("Colocando el techo de la casa de ladrillos");
        }

        protected override void ConstruirCimientos()
        {
            Console.WriteLine("Construyendo los cimientos de la casa de ladrillo");
        }

        protected override void ConstruirPrimerPiso()
        {
            Console.WriteLine("Construyendo el primer piso de la casa de ladrillo");
        }

        protected override void ConstruirSegundoPiso()
        {
            Console.WriteLine("Construyendo el segundo piso de la casa de ladrillos");
        }

        protected override void ConstruirSotano()
        {
            Console.WriteLine("Construyendo el sotano de la casa de ladrillos");
        }

        protected override void Pintar()
        {
            Console.WriteLine("Pintando la casa de ladrillos");
        }

        protected override void RealizarPlanos()
        {
            Console.WriteLine("\nRelizando los planos de la casa");
        }
    }
}
