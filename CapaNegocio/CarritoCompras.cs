using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CarritoCompras
    {
        //atributos
        private int productosComprados;
        private DateTime fechaCreacion;
        private int codigo;

        //Propiedades
        public int ProductosComprados { get => productosComprados; set => productosComprados = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int Codigo { get => codigo; set => codigo = value; }

        //metodos
        public string CancelarPedidos()
        {
            return "No se ha implementado Cancelar Pedidos";
        }

        public string CambiarPedidos()
        {
            return "No se ha implementado Cambiar Pedidos";
        }
    }
}
