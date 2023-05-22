using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoBridge
{
    internal abstract class Forma
    {
        IColor color;
        public Forma(IColor color)
        {
            this.color = color;
        }

        public abstract void ImprimirPropiedades();

        protected void ImprimirColor()
        {
            this.color.ImprimirColor();
        }
    }
}
