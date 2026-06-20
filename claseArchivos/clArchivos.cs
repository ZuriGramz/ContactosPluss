using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContactosPlus.claseArchivos
{
    internal class clArchivos
    {
        private readonly string rutaArchivo;

        public clArchivos(string ruta = "directorio.txt")
        {
            rutaArchivo = ruta;

            //Si no es verdad que a es
            //mayor que cero
            //if (!(a > 0))
            //    Console.WriteLine("A es el mayor");

            if (!File.Exists(rutaArchivo))
                File.Create(rutaArchivo).Close();
        }

        // CREATE
        public bool add(Contacto contacto)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(rutaArchivo, true);
                escritor.WriteLine(contacto);

                return true;
            }
            catch
            {
                return false;
            }
        }

        // READ ALL
        public List<Contacto> show()
        {
            List<Contacto> lista = new List<Contacto>();

            StreamReader lector = new StreamReader(rutaArchivo);

            string? linea;

            while ((linea = lector.ReadLine()) != null)
            {
                string[] datos = linea.Split('|');

                Contacto contacto = new Contacto(
                    Convert.ToInt32(datos[0]),
                    datos[1],
                    datos[2],
                    Convert.ToInt32(datos[3]),
                    Convert.ToInt32(datos[4]),
                    datos[5],
                    datos[6],
                    datos[7],
                    datos[8]
                );

                contacto.observaciones = datos[8];
                contacto.estatus = Convert.ToBoolean(datos[9]);

                lista.Add(contacto);
            }

            return lista;
        }

        // READ ONE
        public Contacto? find(int id)
        {

            List<Contacto> directorio = show();

            foreach (Contacto contacto in directorio)
                if (contacto.id == id)
                    return contacto;

            return null;
        }

        // UPDATE
        public bool update(Contacto contacto)
        {
            try
            {
                List<Contacto> lista = show();

                Contacto? actual = lista.FirstOrDefault(c => c.id == contacto.id);

                if (actual == null)
                    return false;

                actual.nombre = contacto.nombre;
                actual.apellidos = contacto.apellidos;
                actual.telefono = contacto.telefono;
                actual.extension = contacto.extension;
                actual.puesto = contacto.puesto;
                actual.empresa = contacto.empresa;
                actual.correo = contacto.correo;
                actual.observaciones = contacto.observaciones;
                actual.estatus = contacto.estatus;

                GuardarLista(lista);

                return true;
            }
            catch
            {
                return false;
            }
        }

        // DELETE
        public bool delete(int id)
        {
            try
            {
                List<Contacto> lista = show();

                Contacto contactoEncontrado = null;

                foreach (Contacto contacto in lista)
                {
                    if (contacto.id == id)
                    {
                        contactoEncontrado = contacto;
                        break;
                    }
                }

                if (contactoEncontrado == null)
                    return false;

                lista.Remove(contactoEncontrado);

                GuardarLista(lista);

                return true;
            }
            catch
            {
                return false;
            }
        }

        // Método privado
        private void GuardarLista(List<Contacto> lista)
        {
            using StreamWriter escritor = new StreamWriter(rutaArchivo, false);

            foreach (Contacto contacto in lista)
            {
                escritor.WriteLine(contacto);
            }
        }
    }

}

