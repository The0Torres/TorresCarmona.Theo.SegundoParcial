namespace FrmPrincipal
{
    partial class FrmTrabajador
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
            btnAgregar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtSalario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbTipo = new ComboBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ButtonFace;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(51, 295);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 39);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonFace;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(250, 295);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 39);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(51, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(51, 109);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(297, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(51, 169);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(297, 23);
            txtSalario.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 28);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 90);
            label2.Name = "label2";
            label2.Size = new Size(57, 16);
            label2.TabIndex = 7;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 150);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 8;
            label3.Text = "Salario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 214);
            label4.Name = "label4";
            label4.Size = new Size(35, 16);
            label4.TabIndex = 9;
            label4.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(49, 237);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(299, 23);
            cmbTipo.TabIndex = 10;
            // 
            // FrmTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(387, 358);
            Controls.Add(cmbTipo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSalario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Name = "FrmTrabajador";
            Text = "FrmTrabajador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public Button btnAgregar;
        public Button btnCancelar;
        public TextBox txtNombre;
        public TextBox txtApellido;
        public TextBox txtSalario;
        public ComboBox cmbTipo;
    }
}