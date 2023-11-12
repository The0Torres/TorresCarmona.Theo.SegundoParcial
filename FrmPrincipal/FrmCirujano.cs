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
    /// Clase que representa el formulario para gestionar un trabajador de tipo Cirujano.
    /// Permite ingresar y modificar datos específicos de un Cirujano, como la especialidad médica,
    /// cantidad de cirugías realizadas y el hospital en el que trabaja.
    /// </summary>
    
    public partial class FrmCirujano : FrmTrabajador
    {

        protected EHospitales hospital;
        protected string especialidad;

        private Cirujano cirujano;

        public Cirujano Cirujano
        {
            get { return cirujano; }
        }

        public FrmCirujano(Cirujano cirujano): this()
        {
            txtNombre.Text = cirujano.Nombre;
            txtApellido.Text = cirujano.Apellido;
            txtSalario.Text = cirujano.Salario.ToString();
            cmbTipo.SelectedItem = cirujano.Tipo;
            txtEspecialidad.Text = cirujano.Especialidad;
            txtCirugias.Text = cirujano.Cirugias.ToString();
            cmbHospital.SelectedItem = cirujano.Hospital;
        }

        public FrmCirujano()
        {
            InitializeComponent();
            Array arrayHospital = Enum.GetValues(typeof(EHospitales));
            foreach (EHospitales hospitalElegido in arrayHospital)
            {
                this.cmbHospital.Items.Add(hospitalElegido);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            if (!double.TryParse(this.txtCirugias.Text, out double cirugias) || cirugias < 0 || this.txtCirugias.Text.Contains("."))
            {
                MessageBox.Show("Ingrese las cirugias hechas de forma correcta.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                MessageBox.Show("Ingrese una especialidad.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                return;
            }

            if (cmbHospital.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un hospital.",
                "Advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            }
            else
            {

                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                salario = double.Parse(txtSalario.Text);
                tipo = (ETipo)cmbTipo.SelectedItem;
                especialidad = txtEspecialidad.Text;
                hospital = (EHospitales)cmbHospital.SelectedItem;
                cirujano = new Cirujano(nombre, apellido, salario, tipo, especialidad, hospital, cirugias);

                DialogResult = DialogResult.OK;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
