namespace FrmPrincipal
{
    partial class FrmCirujano
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
            txtCirugias = new TextBox();
            txtEspecialidad = new TextBox();
            cmbHospital = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(177, 295);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(451, 295);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCirugias
            // 
            txtCirugias.Location = new Point(379, 83);
            txtCirugias.Name = "txtCirugias";
            txtCirugias.Size = new Size(277, 23);
            txtCirugias.TabIndex = 11;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(379, 150);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(277, 23);
            txtEspecialidad.TabIndex = 12;
            // 
            // cmbHospital
            // 
            cmbHospital.FormattingEnabled = true;
            cmbHospital.Location = new Point(379, 214);
            cmbHospital.Name = "cmbHospital";
            cmbHospital.Size = new Size(277, 23);
            cmbHospital.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(379, 195);
            label5.Name = "label5";
            label5.Size = new Size(58, 16);
            label5.TabIndex = 14;
            label5.Text = "Hospital:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(379, 131);
            label6.Name = "label6";
            label6.Size = new Size(85, 16);
            label6.TabIndex = 15;
            label6.Text = "Especialidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(379, 64);
            label7.Name = "label7";
            label7.Size = new Size(104, 16);
            label7.TabIndex = 16;
            label7.Text = "Cirugias hechas:";
            // 
            // FrmCirujano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 353);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbHospital);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtCirugias);
            Name = "FrmCirujano";
            Text = "FrmCirujano";
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(txtSalario, 0);
            Controls.SetChildIndex(cmbTipo, 0);
            Controls.SetChildIndex(txtCirugias, 0);
            Controls.SetChildIndex(txtEspecialidad, 0);
            Controls.SetChildIndex(cmbHospital, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCirugias;
        private TextBox txtEspecialidad;
        private ComboBox cmbHospital;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}