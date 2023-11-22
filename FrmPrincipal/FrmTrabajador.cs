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
        public event EventHandler<string> MessageBoxMostrado;

        protected string nombre;
        protected string apellido;
        protected double salario;
        protected ETipo tipo;
        protected double id;

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
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                    string.IsNullOrEmpty(txtSalario.Text) || cmbTipo.SelectedItem == null ||
                    string.IsNullOrEmpty(txtId.Text))
                {
                    OnMessageBoxMostrado("Por favor, complete todos los campos.");
                    return false;
                }

                if (!double.TryParse(this.txtSalario.Text, out double salario) || salario <= 0)
                {
                    OnMessageBoxMostrado("Ingrese un salario válido.");
                    return false;
                }

                if (!double.TryParse(this.txtId.Text, out double id) || id < 1)
                {
                    OnMessageBoxMostrado("Ingrese un Id válido.");
                    return false;
                }

                return true;
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        protected virtual void OnMessageBoxMostrado(string mensaje)
        {
            throw new DatosInvalidosException($"{mensaje}");
        }
    }
}
