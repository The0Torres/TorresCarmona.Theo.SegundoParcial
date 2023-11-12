namespace FrmPrincipal
{
    partial class FrmDeportista
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
            txtDeporte = new TextBox();
            label5 = new Label();
            txtTrofeos = new TextBox();
            txtRanking = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(152, 288);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(490, 288);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDeporte
            // 
            txtDeporte.Location = new Point(404, 83);
            txtDeporte.Name = "txtDeporte";
            txtDeporte.Size = new Size(259, 23);
            txtDeporte.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(404, 65);
            label5.Name = "label5";
            label5.Size = new Size(56, 16);
            label5.TabIndex = 12;
            label5.Text = "Deporte:";
            // 
            // txtTrofeos
            // 
            txtTrofeos.Location = new Point(404, 143);
            txtTrofeos.Name = "txtTrofeos";
            txtTrofeos.Size = new Size(259, 23);
            txtTrofeos.TabIndex = 13;
            // 
            // txtRanking
            // 
            txtRanking.Location = new Point(404, 212);
            txtRanking.Name = "txtRanking";
            txtRanking.Size = new Size(246, 23);
            txtRanking.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(404, 189);
            label6.Name = "label6";
            label6.Size = new Size(107, 16);
            label6.TabIndex = 15;
            label6.Text = "Ranking mundial:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(404, 125);
            label7.Name = "label7";
            label7.Size = new Size(53, 16);
            label7.TabIndex = 16;
            label7.Text = "Trofeos:";
            // 
            // FrmDeportista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 350);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtRanking);
            Controls.Add(txtTrofeos);
            Controls.Add(label5);
            Controls.Add(txtDeporte);
            Name = "FrmDeportista";
            Text = "FrmDeportista";
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(txtSalario, 0);
            Controls.SetChildIndex(cmbTipo, 0);
            Controls.SetChildIndex(txtDeporte, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtTrofeos, 0);
            Controls.SetChildIndex(txtRanking, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDeporte;
        private Label label5;
        private TextBox txtTrofeos;
        private TextBox txtRanking;
        private Label label6;
        private Label label7;
    }
}