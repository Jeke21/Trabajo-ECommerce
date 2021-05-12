using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente
    {
        //atributos
        private string nombres;
        private string direccion;
        private string email;
        private int telefono;

        //Propiedades
        public string Nombres { get => nombres; set => nombres = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        //metodos
        public string MirarProducto()
        {
            return "No se ha implementado Mirar Producto";
        }
        public string Pedir()
        {
            return "No se ha implementado Pedir";
        }
        public string Pagar()
        {
            return "No se ha implementado Pagar";
        }
    }
}
