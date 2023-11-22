namespace FrmPrincipal
{
    partial class FrmRegistro
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
            lstRegistro = new ListBox();
            lblRegistros = new Label();
            SuspendLayout();
            // 
            // lstRegistro
            // 
            lstRegistro.FormattingEnabled = true;
            lstRegistro.ItemHeight = 15;
            lstRegistro.Location = new Point(21, 23);
            lstRegistro.Name = "lstRegistro";
            lstRegistro.Size = new Size(713, 379);
            lstRegistro.TabIndex = 0;
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistros.Location = new Point(21, 415);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(57, 16);
            lblRegistros.TabIndex = 1;
            lblRegistros.Text = "registros";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(756, 451);
            Controls.Add(lblRegistros);
            Controls.Add(lstRegistro);
            Name = "FrmRegistro";
            Text = "FrmRegistro";
            Load += FrmRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstRegistro;
        private Label lblRegistros;
    }
}