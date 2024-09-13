using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateCasa.Factory
{
    public class CasaMadera : Casa
    {
        public CasaMadera(bool pint, bool secP, bool sot, string tipo, string ub) : base(pint, secP, sot, tipo)
        {
        }

        public override string Name => "Casa de Madera";

        protected override void ColocarAcabado()
        {
            Console.WriteLine("Colocando el acabado de la casa de madera");
        }

        protected override void ColocarTecho()
        {
            Console.WriteLine("Colocando el techo de la casa de madera");
        }

        protected override void ConstruirCimientos()
        {
            Console.WriteLine("Construyendo los cimientos de la casa de madera");
        }

        protected override void ConstruirPrimerPiso()
        {
            Console.WriteLine("Construyendo el primer piso de la casa de madera");
        }

        protected override void ConstruirSegundoPiso()
        {
            Console.WriteLine("Construyendo el segundo piso de la casa de madera");
        }

        protected override void ConstruirSotano()
        {
            Console.WriteLine("Construyendo el sotano de la casa de madera");
        }

        protected override void Pintar()
        {
            Console.WriteLine("Pintando la casa de madera");
        }

        protected override void RealizarPlanos()
        {
            Console.WriteLine("\nRelizando los planos de la casa");
        }
    }
}
