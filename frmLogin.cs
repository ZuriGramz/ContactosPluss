using System.Diagnostics.Eventing.Reader;

namespace ContactosPlus
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (usuario.Length > 0)
            {
                if (password.Length > 0)
                {
                    if (usuario=="admin" && password=="1234")
                    {
                        //Abrir a la siguiente ventana >>FrmDirectorioTelefonico<<
                        // MisFunciones.mensajeAlerta(">>Bienvenido al sistema<<");
                        FrmDirectorioTelefonico obj = new FrmDirectorioTelefonico(); //se instancia la clase (ventana de directoriotelefonico)

                        this.Hide();//ocultar
                        obj.Show();//mostrar
                        obj.FormClosed += (s, args) => this.Show();
                    }
                    else
                    {
                        MisFunciones.mensajeAlerta("Verifica tus datos");
                        txtUsuario.Text = ""; //para borrar el texto incorrecto
                        txtPassword.Text = "";
                        txtUsuario.Focus();
                    }

                }
                else
                {
                    MisFunciones.mensajeAlerta("Escribe tu contraseña");
                    
                    txtUsuario.Focus();
                }
            }
            else
            {
                MisFunciones.mensajeAlerta("Escribe tu usuario");
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
        }
    }


}
