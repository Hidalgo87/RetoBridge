using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoBridge
{
    internal class Circulo : Forma
    {
        int radio;
        public Circulo(IColor color, int radio): base(color)
        { 
            this.radio = radio;
        }
        override public void ImprimirPropiedades()
        {
            Console.WriteLine("El radio es "+this.radio);
            this.ImprimirColor();
        }
    }
}
