using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Encendido : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new Apagado());
        }

        public override string Describir()
        {
            return "Switch Encendido";
        }
    }
}
