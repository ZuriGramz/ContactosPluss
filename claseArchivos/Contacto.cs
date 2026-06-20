using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosPlus.claseArchivos
{
    internal class Contacto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int telefono { get; set; }
        public int extension { get; set; }
        public string puesto { get; set; }  
        public string empresa { get; set; }
        public string correo { get; set; }
        public string observaciones { get; set; }
        public bool estatus { get; set; }

        public Contacto(int id, string nombre, string apellidos, int telefono, int extension, string puesto, string empresa, string correo, string observaciones)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos= apellidos;
            this.telefono=  telefono;
            this.extension= extension;  
            this.puesto= puesto;
            this.empresa= empresa;  
            this.observaciones = observaciones;
            this.estatus = true;
        }

        public override string ToString() //Pertenece a todas las clases, solo lo estamos sobrescriturando
        {
            return $"ID: {this.id} |NOMBRE:  {this.nombre} | APELLIDOS: {this.apellidos} |TELEFONO:  {this.telefono} | EXT: {this.extension} | PUESTO: {this.puesto} |EMPRESA:  {this.empresa} | OBSERVACIONES: {this.observaciones} |ESTATUS:  {this.estatus} ";
        }
    }
}
