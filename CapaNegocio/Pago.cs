using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Pago
    {
        //Atriutos
        private string id;
        private DateTime fechaPago;
        private string pago;

        //Propiedades
        public string Id { get => id; set => id = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public string PagoProp { get => pago; set => pago = value; }
  
        //Metodos u Operaciones
        public string Pagar()
        {
            return "No se ha implementado este metodo";
        }
        public string Cancelar()
        {
            return "No se ha implementado este metodo";
        }
    }
}
