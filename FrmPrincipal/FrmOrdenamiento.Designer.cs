namespace FrmPrincipal
{
    partial class FrmOrdenamiento
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            rbtnNombre = new RadioButton();
            rbtnApellido = new RadioButton();
            rbtnSalario = new RadioButton();
            groupBox2 = new GroupBox();
            rbtnDescendente = new RadioButton();
            rbtnAscendente = new RadioButton();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rbtnNombre);
            groupBox1.Controls.Add(rbtnApellido);
            groupBox1.Controls.Add(rbtnSalario);
            groupBox1.Location = new Point(6, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(135, 194);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(117, 18);
            label1.TabIndex = 3;
            label1.Text = "Dato a ordenar:";
            // 
            // rbtnNombre
            // 
            rbtnNombre.AutoSize = true;
            rbtnNombre.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnNombre.Location = new Point(6, 63);
            rbtnNombre.Name = "rbtnNombre";
            rbtnNombre.Size = new Size(70, 20);
            rbtnNombre.TabIndex = 2;
            rbtnNombre.TabStop = true;
            rbtnNombre.Text = "Nombre";
            rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnApellido
            // 
            rbtnApellido.AutoSize = true;
            rbtnApellido.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnApellido.Location = new Point(6, 104);
            rbtnApellido.Name = "rbtnApellido";
            rbtnApellido.Size = new Size(71, 20);
            rbtnApellido.TabIndex = 1;
            rbtnApellido.TabStop = true;
            rbtnApellido.Text = "Apellido";
            rbtnApellido.UseVisualStyleBackColor = true;
            // 
            // rbtnSalario
            // 
            rbtnSalario.AutoSize = true;
            rbtnSalario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnSalario.Location = new Point(6, 145);
            rbtnSalario.Name = "rbtnSalario";
            rbtnSalario.Size = new Size(65, 20);
            rbtnSalario.TabIndex = 0;
            rbtnSalario.TabStop = true;
            rbtnSalario.Text = "Salario";
            rbtnSalario.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtnDescendente);
            groupBox2.Controls.Add(rbtnAscendente);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(147, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(137, 194);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // rbtnDescendente
            // 
            rbtnDescendente.AutoSize = true;
            rbtnDescendente.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnDescendente.Location = new Point(6, 129);
            rbtnDescendente.Name = "rbtnDescendente";
            rbtnDescendente.Size = new Size(101, 20);
            rbtnDescendente.TabIndex = 2;
            rbtnDescendente.TabStop = true;
            rbtnDescendente.Text = "Descendente";
            rbtnDescendente.UseVisualStyleBackColor = true;
            // 
            // rbtnAscendente
            // 
            rbtnAscendente.AutoSize = true;
            rbtnAscendente.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnAscendente.Location = new Point(6, 75);
            rbtnAscendente.Name = "rbtnAscendente";
            rbtnAscendente.Size = new Size(94, 20);
            rbtnAscendente.TabIndex = 1;
            rbtnAscendente.TabStop = true;
            rbtnAscendente.Text = "Ascendente";
            rbtnAscendente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 0;
            label2.Text = "Orden:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Location = new Point(12, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(290, 223);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ButtonFace;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(18, 241);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(122, 40);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonFace;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(165, 241);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 40);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmOrdenamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(324, 295);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox3);
            Name = "FrmOrdenamiento";
            Text = "FrmOrdenamiento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private RadioButton rbtnNombre;
        private RadioButton rbtnApellido;
        private RadioButton rbtnSalario;
        private Label label2;
        private RadioButton rbtnDescendente;
        private RadioButton rbtnAscendente;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}