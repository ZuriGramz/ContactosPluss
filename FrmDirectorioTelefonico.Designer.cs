namespace ContactosPlus
{
    partial class FrmDirectorioTelefonico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            grpDatos = new GroupBox();
            lblId = new Label();
            txtId = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblExtension = new Label();
            txtExtension = new TextBox();
            lblCargo = new Label();
            txtCargo = new TextBox();
            lblEmpresa = new Label();
            txtEmpresa = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblObservaciones = new Label();
            txtObservaciones = new RichTextBox();
            chkActivo = new CheckBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            dgvDirectorio = new DataGridView();
            error = new ErrorProvider(components);
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirectorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(384, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Directorio Telefónico";
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblId);
            grpDatos.Controls.Add(txtId);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblApellidos);
            grpDatos.Controls.Add(txtApellidos);
            grpDatos.Controls.Add(lblTelefono);
            grpDatos.Controls.Add(txtTelefono);
            grpDatos.Controls.Add(lblExtension);
            grpDatos.Controls.Add(txtExtension);
            grpDatos.Controls.Add(lblCargo);
            grpDatos.Controls.Add(txtCargo);
            grpDatos.Controls.Add(lblEmpresa);
            grpDatos.Controls.Add(txtEmpresa);
            grpDatos.Controls.Add(lblCorreo);
            grpDatos.Controls.Add(txtCorreo);
            grpDatos.Controls.Add(lblObservaciones);
            grpDatos.Controls.Add(txtObservaciones);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Location = new Point(20, 60);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(1240, 260);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de Contacto";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 35);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(20, 55);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(150, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(430, 35);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 4;
            lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(430, 55);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(300, 23);
            txtApellidos.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(20, 100);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(20, 120);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 23);
            txtTelefono.TabIndex = 7;
            // 
            // lblExtension
            // 
            lblExtension.AutoSize = true;
            lblExtension.Location = new Point(220, 100);
            lblExtension.Name = "lblExtension";
            lblExtension.Size = new Size(57, 15);
            lblExtension.TabIndex = 8;
            lblExtension.Text = "Extensión";
            // 
            // txtExtension
            // 
            txtExtension.Location = new Point(220, 120);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(100, 23);
            txtExtension.TabIndex = 9;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(350, 100);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(88, 15);
            lblCargo.TabIndex = 10;
            lblCargo.Text = "Puesto o Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(350, 120);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(250, 23);
            txtCargo.TabIndex = 11;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(630, 100);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(124, 15);
            lblEmpresa.TabIndex = 12;
            lblEmpresa.Text = "Empresa u Organismo";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(630, 120);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(350, 23);
            txtEmpresa.TabIndex = 13;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(20, 165);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 14;
            lblCorreo.Text = "Correo Electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(20, 185);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(350, 23);
            txtCorreo.TabIndex = 15;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(400, 165);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(84, 15);
            lblObservaciones.TabIndex = 16;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(400, 185);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(450, 50);
            txtObservaciones.TabIndex = 17;
            txtObservaciones.Text = "";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(900, 190);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 18;
            chkActivo.Text = "Activo";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(20, 340);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 40);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(280, 340);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(410, 340);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(540, 340);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 40);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(670, 340);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 40);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvDirectorio
            // 
            dgvDirectorio.AllowUserToAddRows = false;
            dgvDirectorio.AllowUserToDeleteRows = false;
            dgvDirectorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDirectorio.Location = new Point(20, 400);
            dgvDirectorio.Name = "dgvDirectorio";
            dgvDirectorio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirectorio.Size = new Size(1240, 350);
            dgvDirectorio.TabIndex = 8;
            // 
            // error
            // 
            error.ContainerControl = this;
            // 
            // FrmDirectorioTelefonico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 800);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatos);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvDirectorio);
            Name = "FrmDirectorioTelefonico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Directorio Telefónico Empresarial";
            FormClosed += FrmDirectorioTelefonico_FormClosed;
            Load += FrmDirectorioTelefonico_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirectorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.GroupBox grpDatos;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;

        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;

        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;

        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.TextBox txtExtension;

        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtEmpresa;

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;

        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.RichTextBox txtObservaciones;

        private System.Windows.Forms.CheckBox chkActivo;

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.DataGridView dgvDirectorio;
        private ErrorProvider error;
    }
}