using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateCasa.Template;

namespace TemplateCasa.Factory
{
    public abstract class Casa : PasosConstruccion
    {
        public Casa(bool pint, bool secP, bool sot, string tipo, string ub) : base(pint, secP, sot)
        {
            Tipo = tipo;
            Ubicacion = ub;
        }

        

        public abstract string Name { get; }
        public string Ubicacion { get; }
        public string Tipo {  get; set; }   

    }
}
