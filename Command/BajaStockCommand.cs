using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class BajaStockCommand : OrdenCommand
    {
        public BajaStockCommand(ProductoReceiver producto,int cantidad):base(producto,cantidad)
        { }
        public override void Ejecutar()
        {
            _producto.RestarStock(_cantidad);
        }
    }
}
