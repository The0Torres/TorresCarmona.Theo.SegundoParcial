namespace FrmPrincipal
{
    partial class FrmPeriodista
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
            txtCredibilidad = new TextBox();
            cmbMedio = new ComboBox();
            txtEspecializacion = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(144, 288);
            btnAgregar.Size = new Size(102, 52);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(428, 288);
            btnCancelar.Size = new Size(104, 52);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCredibilidad
            // 
            txtCredibilidad.Location = new Point(403, 83);
            txtCredibilidad.Name = "txtCredibilidad";
            txtCredibilidad.Size = new Size(284, 23);
            txtCredibilidad.TabIndex = 11;
            // 
            // cmbMedio
            // 
            cmbMedio.FormattingEnabled = true;
            cmbMedio.Location = new Point(403, 143);
            cmbMedio.Name = "cmbMedio";
            cmbMedio.Size = new Size(284, 23);
            cmbMedio.TabIndex = 12;
            // 
            // txtEspecializacion
            // 
            txtEspecializacion.Location = new Point(403, 212);
            txtEspecializacion.Name = "txtEspecializacion";
            txtEspecializacion.Size = new Size(284, 23);
            txtEspecializacion.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(403, 64);
            label5.Name = "label5";
            label5.Size = new Size(78, 16);
            label5.TabIndex = 14;
            label5.Text = "Credibilidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(403, 116);
            label6.Name = "label6";
            label6.Size = new Size(46, 16);
            label6.TabIndex = 15;
            label6.Text = "Medio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 189);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 16;
            label7.Text = "Especializacion:";
            // 
            // FrmPeriodista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 354);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEspecializacion);
            Controls.Add(cmbMedio);
            Controls.Add(txtCredibilidad);
            Name = "FrmPeriodista";
            Text = "FrmPeriodista";
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(txtSalario, 0);
            Controls.SetChildIndex(cmbTipo, 0);
            Controls.SetChildIndex(txtCredibilidad, 0);
            Controls.SetChildIndex(cmbMedio, 0);
            Controls.SetChildIndex(txtEspecializacion, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCredibilidad;
        private ComboBox cmbMedio;
        private TextBox txtEspecializacion;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}