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
using Microsoft.VisualBasic.Devices;

namespace FrmPrincipal
{
    /// <summary>
    /// Clase que representa el formulario para gestionar un trabajador de tipo Deportista.
    /// Permite ingresar y modificar datos específicos de un Deportista, como el deporte practicado,
    /// cantidad de trofeos y ranking mundial.
    /// </summary>
  
    public partial class FrmDeportista : FrmTrabajador
    {
        protected string deporte;

        private Deportista deportista;

        public Deportista Deportista
        {
            get { return deportista; }
        }


        public FrmDeportista(Deportista deportista) :this()
        {
            txtNombre.Text = deportista.Nombre;
            txtApellido.Text = deportista.Apellido;
            txtSalario.Text = deportista.Salario.ToString();
            cmbTipo.SelectedItem = deportista.Tipo;
            txtDeporte.Text = deportista.Deporte;
            txtTrofeos.Text = deportista.Trofeos.ToString();
            txtRanking.Text = deportista.RankingMundial.ToString();
        }


        public FrmDeportista()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            if (!double.TryParse(this.txtTrofeos.Text, out double trofeos) || trofeos < 0 || this.txtTrofeos.Text.Contains("."))
            {
                MessageBox.Show("Ingrese una cantidad de trofeos valida.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(this.txtRanking.Text, out int ranking) || ranking <= 0 || this.txtRanking.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un ranking mundial.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeporte.Text))
            {
                MessageBox.Show("Ingrese una especializacion.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return;
            }

            else
            {

                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                salario = double.Parse(txtSalario.Text);
                tipo = (ETipo)cmbTipo.SelectedItem;
                deporte = txtDeporte.Text;
                deportista = new Deportista(nombre, apellido, salario, tipo, deporte, trofeos, ranking);

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
