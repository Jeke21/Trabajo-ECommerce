using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Envio
    {
        //Atributos de la Clase
        private string id;
        private string direccionFacturacion;
        private string finalizado;
        private DateTime fechaEnvio;
        private string compañia;

        //Propiedades
        public string Id
        {
            get { return this.id; } //Lectura de Atributos
            set { this.id = value; } //Escritura del Atributo
        }
        public string DireccionFacturacion
        {
            get { return this.direccionFacturacion; } //Lectura de Atributos
            set { this.direccionFacturacion = value; } //Escritura del Atributo
        }
        public string Finalizado
        {
            get { return this.finalizado; } //Lectura de Atributos
            set { this.finalizado = value; } //Escritura del Atributo
        }
        public DateTime FechaEnvio
        {
            get { return this.fechaEnvio; } //Lectura de Atributos
            set { this.fechaEnvio = value; } //Escritura del Atributo
        }
        public string Compañia
        {
            get { return this.compañia; } //Lectura de Atributos
            set { this.compañia = value; } //Escritura del Atributo
        }
        //Metodos u Operaciones
        public string Remitir()
        {
            return "No se ha implementado este metodo";
        }
    }
}
