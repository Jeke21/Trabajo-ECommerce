using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Producto
    {
        //Atributos
        private string id;
        private string denominacion;
        private string proveedor;

        //Propiedades 
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Denominacion
        {
            get { return denominacion; }
            set { denominacion = value; }
        }
        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        // Metodos u Operaciones 
        public string Pagar()
        {
            return "No se ha implementado este metodo";
        }
        public string Enviar()
        {
            return "No se ha implementado este metodo";
        }
        public string Recibir()
        {
            return "No se ha implementado este metodo";
        }
    }
}
