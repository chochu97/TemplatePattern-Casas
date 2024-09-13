using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateCasa.Template
{
  
    
    public abstract class PasosConstruccion
    {
        protected bool PintarRequerido {  get; set; }
        protected bool SegundoPisoRequerido { get; set; }
        protected bool SotanoRequerido { get; set; }

        public PasosConstruccion(bool pint, bool secP, bool sot)
        {
            PintarRequerido = pint;
            SegundoPisoRequerido = secP;
            SotanoRequerido = sot;
        }

        public void Construir()
        {
            RealizarPlanos();
            ConstruirCimientos();
            if(SotanoRequerido == true)
            {
                ConstruirSotano();
            }
            ConstruirPrimerPiso();
            if(SegundoPisoRequerido == true)
            {
                ConstruirSegundoPiso();
            }
            ColocarTecho();
            ColocarAcabado();
            if(PintarRequerido == true)
            {
                Pintar();
            }
        }

        protected abstract void RealizarPlanos();
        protected abstract void ConstruirCimientos();
        protected abstract void ConstruirSotano();
        protected abstract void ConstruirPrimerPiso();
        protected abstract void ConstruirSegundoPiso();
        protected abstract void ColocarTecho();
        protected abstract void ColocarAcabado();
        protected abstract void Pintar();

    }
}
