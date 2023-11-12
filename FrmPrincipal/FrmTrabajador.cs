using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laburos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmPrincipal
{
    /// <summary>
    /// Clase base para los formularios que gestionan trabajadores.
    /// Contiene métodos para validar datos comunes.
    /// </summary>

    public partial class FrmTrabajador : Form
    {
        protected string nombre;
        protected string apellido;
        protected double salario;
        protected ETipo tipo;

        public FrmTrabajador()
        {
            InitializeComponent();
            Array arrayTipo = Enum.GetValues(typeof(ETipo));
            foreach (ETipo tipoElegido in arrayTipo)
            {
                this.cmbTipo.Items.Add(tipoElegido);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        protected bool ValidarDatos()
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || 
                string.IsNullOrEmpty(txtSalario.Text) || cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(this.txtSalario.Text, out double salario) || salario <= 0)
            {
                MessageBox.Show("Ingrese un salario valido.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

    }
}
