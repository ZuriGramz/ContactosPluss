namespace ContactosPlus
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panelIzquierdo = new Panel();
            pictureBox2 = new PictureBox();
            lblVersion = new Label();
            lblSistema = new Label();
            lblApp = new Label();
            panelDerecho = new Panel();
            cardLogin = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkRecordar = new CheckBox();
            linkOlvido = new LinkLabel();
            btnLogin = new Button();
            panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelDerecho.SuspendLayout();
            cardLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(5, 24, 61);
            panelIzquierdo.Controls.Add(pictureBox2);
            panelIzquierdo.Controls.Add(lblVersion);
            panelIzquierdo.Controls.Add(lblSistema);
            panelIzquierdo.Controls.Add(lblApp);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(420, 700);
            panelIzquierdo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.aludec;
            pictureBox2.Location = new Point(55, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(286, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.ForeColor = Color.Gainsboro;
            lblVersion.Location = new Point(25, 650);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(99, 19);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Versión 1.1.0.0";
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI", 16F);
            lblSistema.ForeColor = Color.FromArgb(80, 170, 255);
            lblSistema.Location = new Point(55, 320);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(279, 30);
            lblSistema.TabIndex = 1;
            lblSistema.Text = "Aludec Automoción México";
            // 
            // lblApp
            // 
            lblApp.AutoSize = true;
            lblApp.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblApp.ForeColor = Color.White;
            lblApp.Location = new Point(25, 265);
            lblApp.Name = "lblApp";
            lblApp.Size = new Size(338, 45);
            lblApp.TabIndex = 2;
            lblApp.Text = "Gestión de Contactos";
            // 
            // panelDerecho
            // 
            panelDerecho.BackColor = Color.FromArgb(245, 246, 250);
            panelDerecho.Controls.Add(cardLogin);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(420, 0);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(780, 700);
            panelDerecho.TabIndex = 0;
            // 
            // cardLogin
            // 
            cardLogin.BackColor = Color.White;
            cardLogin.BorderStyle = BorderStyle.FixedSingle;
            cardLogin.Controls.Add(lblTitulo);
            cardLogin.Controls.Add(lblSubtitulo);
            cardLogin.Controls.Add(lblUsuario);
            cardLogin.Controls.Add(txtUsuario);
            cardLogin.Controls.Add(lblPassword);
            cardLogin.Controls.Add(txtPassword);
            cardLogin.Controls.Add(chkRecordar);
            cardLogin.Controls.Add(linkOlvido);
            cardLogin.Controls.Add(btnLogin);
            cardLogin.Location = new Point(120, 80);
            cardLogin.Name = "cardLogin";
            cardLogin.Size = new Size(550, 520);
            cardLogin.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.Location = new Point(150, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Iniciar Sesión";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(70, 110);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(330, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Ingrese sus credenciales para acceder al sistema.";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUsuario.Location = new Point(50, 170);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(50, 193);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(450, 29);
            txtUsuario.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPassword.Location = new Point(50, 270);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(88, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(50, 300);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(450, 29);
            txtPassword.TabIndex = 5;
            // 
            // chkRecordar
            // 
            chkRecordar.AutoSize = true;
            chkRecordar.Location = new Point(50, 360);
            chkRecordar.Name = "chkRecordar";
            chkRecordar.Size = new Size(150, 23);
            chkRecordar.TabIndex = 6;
            chkRecordar.Text = "Recordar mi usuario";
            // 
            // linkOlvido
            // 
            linkOlvido.AutoSize = true;
            linkOlvido.Location = new Point(320, 360);
            linkOlvido.Name = "linkOlvido";
            linkOlvido.Size = new Size(150, 19);
            linkOlvido.TabIndex = 7;
            linkOlvido.TabStop = true;
            linkOlvido.Text = "¿Olvidó su contraseña?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 102, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(50, 420);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(450, 50);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelDerecho.ResumeLayout(false);
            cardLogin.ResumeLayout(false);
            cardLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelDerecho;

        private System.Windows.Forms.Panel cardLogin;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.CheckBox chkRecordar;

        private System.Windows.Forms.LinkLabel linkOlvido;

        private System.Windows.Forms.Button btnLogin;

        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblVersion;
        private PictureBox pictureBox2;
    }
}
