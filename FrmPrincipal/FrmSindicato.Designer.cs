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
            SuspendLayout();
            // 
            // lstSindicato
            // 
            lstSindicato.FormattingEnabled = true;
            lstSindicato.ItemHeight = 15;
            lstSindicato.Location = new Point(38, 28);
            lstSindicato.Name = "lstSindicato";
            lstSindicato.Size = new Size(705, 334);
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
            btnAgregar.Location = new Point(39, 391);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 46);
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
            btnModificar.Location = new Point(258, 391);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 46);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ButtonFace;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(479, 391);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 46);
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
            btnOrdenar.Location = new Point(479, 452);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(115, 41);
            btnOrdenar.TabIndex = 5;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(436, 5);
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
            btnCargar.Location = new Point(38, 452);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(124, 41);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar\r\nArchivo\r\n";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(258, 453);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 41);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar\r\nArchivo\r\n";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSesiones
            // 
            btnSesiones.BackColor = SystemColors.ButtonFace;
            btnSesiones.FlatStyle = FlatStyle.Popup;
            btnSesiones.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSesiones.Location = new Point(661, 401);
            btnSesiones.Name = "btnSesiones";
            btnSesiones.Size = new Size(82, 75);
            btnSesiones.TabIndex = 9;
            btnSesiones.Text = "Registro\r\nInicio de sesion";
            btnSesiones.UseVisualStyleBackColor = false;
            btnSesiones.Click += btnSesiones_Click;
            // 
            // FrmSindicato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(812, 516);
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
    }
}