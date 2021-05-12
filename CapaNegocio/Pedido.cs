using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Pedido
    {
        //Atributos de la Clase
        private string id;
        private DateTime fechaPedido;
        private string estado;
        private string total;

        //Propiedades
        public string Id
        {
            get { return this.id; } //Lectura de Atributos
            set { this.id = value; } //Escritura del Atributo
        }
        public DateTime FechaPedido
        {
            get { return this.fechaPedido; } //Lectura de Atributos
            set { this.fechaPedido = value; } //Escritura del Atributo
        }
        public string Estado
        {
            get { return this.estado; } //Lectura de Atributos
            set { this.estado = value; } //Escritura del Atributo
        }
        public string Total
        {
            get { return this.total; } //Lectura de Atributos
            set { this.total = value; } //Escritura del Atributo
        }
        //Metodos u Operaciones
        public string Requerir()
        {
            return "No se ha implementado este metodo";
        }
    }
}
