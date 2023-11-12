namespace FrmPrincipal
{
    partial class FrmLogin
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
            label1 = new Label();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            label2 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(50, 80);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(316, 23);
            txtCorreo.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(50, 173);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(316, 23);
            txtContraseña.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 137);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ButtonFace;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Location = new Point(50, 250);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(92, 36);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonFace;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(276, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 36);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(426, 303);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "Inicio";
            FormClosing += FrmLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtCorreo;
        public Label label1;
        public TextBox txtContraseña;
        public Label label2;
        public Button btnAceptar;
        public Button btnCancelar;
    }
}