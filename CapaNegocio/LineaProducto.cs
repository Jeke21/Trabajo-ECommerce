using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class LineaProducto
    {
        //Atributos
        private int cantidad;
        private int precio;

        //Propiedades 
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        // Metodos u Operaciones 
        public string Pagar()
        {
            return "No se ha implementado este metodo";
        }
        public string Entregar()
        {
            return "No se ha implementado este metodo";
        }
        public string Almacenar()
        {
            return "No se ha implementado este metodo";
        }
    }
}
