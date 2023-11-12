namespace FrmPrincipal
{
    partial class FrmProfesion
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
            rbtnPeriodista = new RadioButton();
            rbtnCirujano = new RadioButton();
            rbtnDeportista = new RadioButton();
            groupBox1 = new GroupBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(124, 17);
            label1.TabIndex = 0;
            label1.Text = "Elegir la profesion";
            // 
            // rbtnPeriodista
            // 
            rbtnPeriodista.AutoSize = true;
            rbtnPeriodista.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnPeriodista.Location = new Point(6, 59);
            rbtnPeriodista.Name = "rbtnPeriodista";
            rbtnPeriodista.Size = new Size(83, 20);
            rbtnPeriodista.TabIndex = 1;
            rbtnPeriodista.TabStop = true;
            rbtnPeriodista.Text = "Periodista";
            rbtnPeriodista.UseVisualStyleBackColor = true;
            // 
            // rbtnCirujano
            // 
            rbtnCirujano.AutoSize = true;
            rbtnCirujano.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnCirujano.Location = new Point(6, 106);
            rbtnCirujano.Name = "rbtnCirujano";
            rbtnCirujano.Size = new Size(72, 20);
            rbtnCirujano.TabIndex = 2;
            rbtnCirujano.TabStop = true;
            rbtnCirujano.Text = "Cirujano";
            rbtnCirujano.UseVisualStyleBackColor = true;
            // 
            // rbtnDeportista
            // 
            rbtnDeportista.AutoSize = true;
            rbtnDeportista.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnDeportista.Location = new Point(5, 153);
            rbtnDeportista.Name = "rbtnDeportista";
            rbtnDeportista.Size = new Size(84, 20);
            rbtnDeportista.TabIndex = 3;
            rbtnDeportista.TabStop = true;
            rbtnDeportista.Text = "Deportista";
            rbtnDeportista.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnPeriodista);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rbtnDeportista);
            groupBox1.Controls.Add(rbtnCirujano);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 195);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ButtonFace;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Location = new Point(12, 232);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 36);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonFace;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(151, 232);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 36);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmProfesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(251, 287);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox1);
            Name = "FrmProfesion";
            Text = "FrmProfesion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private RadioButton rbtnPeriodista;
        private RadioButton rbtnCirujano;
        private RadioButton rbtnDeportista;
        private GroupBox groupBox1;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}