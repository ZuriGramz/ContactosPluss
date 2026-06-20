using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosPlus.claseArchivos
{
    internal class Directorio
    {
        private List<Contacto> midirectorio=new List<Contacto>();

        public void add(int id, string nombre, string apellidos, int telefono, int extension, string puesto, string empresa,string correo, string observaciones)
        {
            midirectorio.Add(new Contacto(id, nombre, apellidos, telefono, extension, puesto, empresa, correo, observaciones) );
        }

        public void show()
        {
            foreach (Contacto dato in midirectorio)
            {
                Console.WriteLine(dato);
                //Console.WriteLine(dato.ToString());
            }
        }
    }
}
