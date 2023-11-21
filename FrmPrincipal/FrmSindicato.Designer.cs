namespace FrmPrincipal
{
    partial class FrmSindicato
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
            lstSindicato = new ListBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            lblUsuario = new Label();
            btnCargar = new Button();
            btnGuardar = new Button();
            btnSesiones = new Button();
            btn_cargarBd = new Button();
            lblTrabajadores = new Label();
            SuspendLayout();
            // 
            // lstSindicato
            // 
            lstSindicato.FormattingEnabled = true;
            lstSindicato.ItemHeight = 15;
            lstSindicato.Location = new Point(38, 28);
            lstSindicato.Name = "lstSindicato";
            lstSindicato.Size = new Size(874, 319);
            lstSindicato.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 5);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "Trabajadores:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ButtonFace;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(270, 383);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(124, 32);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ButtonFace;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(537, 383);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 32);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(797, 383);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 32);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = SystemColors.Desktop;
            btnOrdenar.FlatStyle = FlatStyle.Popup;
            btnOrdenar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrdenar.ForeColor = SystemColors.ControlLightLight;
            btnOrdenar.Location = new Point(929, 245);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(124, 34);
            btnOrdenar.TabIndex = 5;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(526, 5);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(91, 16);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario/Fecha";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = SystemColors.ActiveCaptionText;
            btnCargar.FlatStyle = FlatStyle.Popup;
            btnCargar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargar.ForeColor = SystemColors.ButtonFace;
            btnCargar.Location = new Point(929, 28);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(124, 41);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar\r\n archivo";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(929, 99);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 41);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar\r\n archivo";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSesiones
            // 
            btnSesiones.BackColor = SystemColors.Desktop;
            btnSesiones.FlatStyle = FlatStyle.Popup;
            btnSesiones.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSesiones.ForeColor = SystemColors.ButtonFace;
            btnSesiones.Location = new Point(929, 307);
            btnSesiones.Name = "btnSesiones";
            btnSesiones.Size = new Size(124, 40);
            btnSesiones.TabIndex = 9;
            btnSesiones.Text = "Registro\r\nInicio de sesion";
            btnSesiones.UseVisualStyleBackColor = false;
            btnSesiones.Click += btnSesiones_Click;
            // 
            // btn_cargarBd
            // 
            btn_cargarBd.BackColor = SystemColors.Desktop;
            btn_cargarBd.FlatStyle = FlatStyle.Popup;
            btn_cargarBd.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cargarBd.ForeColor = SystemColors.ButtonFace;
            btn_cargarBd.Location = new Point(929, 170);
            btn_cargarBd.Name = "btn_cargarBd";
            btn_cargarBd.Size = new Size(124, 43);
            btn_cargarBd.TabIndex = 10;
            btn_cargarBd.Text = "Cargar Base de Datos";
            btn_cargarBd.UseVisualStyleBackColor = false;
            btn_cargarBd.Click += btn_cargarBd_Click;
            // 
            // lblTrabajadores
            // 
            lblTrabajadores.AutoSize = true;
            lblTrabajadores.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrabajadores.Location = new Point(38, 350);
            lblTrabajadores.Name = "lblTrabajadores";
            lblTrabajadores.Size = new Size(148, 17);
            lblTrabajadores.TabIndex = 11;
            lblTrabajadores.Text = "Gente en el sindicato:";
            // 
            // FrmSindicato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1068, 427);
            Controls.Add(lblTrabajadores);
            Controls.Add(btn_cargarBd);
            Controls.Add(btnSesiones);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargar);
            Controls.Add(lblUsuario);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(lstSindicato);
            Name = "FrmSindicato";
            Text = "Sindicato";
            FormClosing += FrmSindicato_FormClosing;
            Load += FrmSindicato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSindicato;
        private Label label1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnOrdenar;
        private Label lblUsuario;
        private Button btnCargar;
        private Button btnGuardar;
        private Button btnSesiones;
        private Button btn_cargarBd;
        private Label lblTrabajadores;
    }
}