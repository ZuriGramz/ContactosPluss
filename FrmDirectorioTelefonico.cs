using ContactosPlus.claseArchivos;

namespace ContactosPlus
{
    public partial class FrmDirectorioTelefonico : Form
    {

        private clArchivos archivo; 

        public FrmDirectorioTelefonico()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        List<TextBox> componentes = new List<TextBox>(); //como atributo, fuera de los metodos para que funcione de forma global
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*validarTextbox(txtNombre, "Verifica tu nombre");
            validarTextbox(txtApellidos, "Verifica tus apellidos");
            validarTextbox(txtTelefono, "Verifica tu numero de telefono");
            validarTextbox(txtExtension, "Verifica tu numero de ext");
            validarTextbox(txtCargo, "Verifica tu numero de Cargo");
            validarTextbox(txtEmpresa, "Verifica tu Empresa");
            validarTextbox(txtCorreo, "Verifica tu Correo");*/

            


            foreach (TextBox componente in componentes)

                validarTextbox(componente, "Campo obligatorio");


            /*Directorio obj = new Directorio();
            int id = Convert.ToInt32(txtId.Text);

            obj.add(id, nombre, apellidos);
            obj.show();
            MessageBox.Show("Texto");*/

        }

        private void validarTextbox(TextBox txtComp, string msgError)
        {
            string cuadritos = txtComp.Text.Trim();
            if (cuadritos.Length > 0)
                error.SetError(txtComp, "");
            else
                error.SetError(txtComp, msgError);

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Registro actualizado.",
                "Directorio Telefónico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea eliminar el registro?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Registro eliminado.",
                    "Directorio Telefónico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Implementar búsqueda.",
                "Directorio Telefónico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtExtension.Clear();
            txtCargo.Clear();
            txtEmpresa.Clear();
            txtCorreo.Clear();
            txtObservaciones.Clear();

            chkActivo.Checked = true;

            txtNombre.Focus();
        }

        private void FrmDirectorioTelefonico_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola! ya estoy funcionando");

            componentes.Add(txtNombre);
            componentes.Add(txtApellidos);
            componentes.Add(txtTelefono);
            componentes.Add(txtExtension);
            componentes.Add(txtCargo);
            componentes.Add(txtEmpresa);
            componentes.Add(txtCorreo);



          this.archivo  = new clArchivos("Directorio.txt");


        }

        private void FrmDirectorioTelefonico_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Noooooooooo!! Me Mori :(");
        }
    }
}
