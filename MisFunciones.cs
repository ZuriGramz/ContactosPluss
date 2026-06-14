using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosPlus
{
    internal class MisFunciones
    {
        //El modificador de accesi static se utiliza para invocar un metodo
        //sin necesidad de instanciar la clase 
        public static void mensajeAlerta(String mensaje)
        {
            //Se personaliza el show con iconos, nombre del caption, etc en una nueva clase para usar el mismo mensaje de alerta.
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
