using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoBridge
{
    internal class Cuadrado : Forma
    {
        int lado;
        public Cuadrado(IColor color, int lado) : base(color)
        {
            this.lado = lado;
        }
        override public void ImprimirPropiedades()
        {
            Console.WriteLine("El lado mide " + this.lado);
            this.ImprimirColor();
        }
    }
}
