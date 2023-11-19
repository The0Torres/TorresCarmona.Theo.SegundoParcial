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

        public FrmCirujano(Cirujano cirujano) : this()
        {
            txtNombre.Text = cirujano.Nombre;
            txtApellido.Text = cirujano.Apellido;
            txtSalario.Text = cirujano.Salario.ToString();
            cmbTipo.SelectedItem = cirujano.Tipo;
            txtId.Text = cirujano.Id.ToString();
            txtId.Enabled = false;
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
            try
            {
                if (!ValidarDatos())
                {
                    return;
                }
                else if (!double.TryParse(this.txtCirugias.Text, out double cirugias) || cirugias < 0 || this.txtCirugias.Text.Contains("."))
                {
                    throw new DatosInvalidosException("Ingrese las cirugías hechas de forma correcta.");
                }
                else if (string.IsNullOrWhiteSpace(txtEspecialidad.Text))
                {
                    throw new DatosInvalidosException("Ingrese una especialidad.");
                }
                else if (cmbHospital.SelectedItem == null)
                {
                    throw new DatosInvalidosException("Seleccione un hospital.");
                }
                else
                {
                    nombre = txtNombre.Text;
                    apellido = txtApellido.Text;
                    salario = double.Parse(txtSalario.Text);
                    tipo = (ETipo)cmbTipo.SelectedItem;
                    id = double.Parse(txtId.Text);
                    especialidad = txtEspecialidad.Text;
                    hospital = (EHospitales)cmbHospital.SelectedItem;
                    cirujano = new Cirujano(nombre, apellido, salario, tipo, id, especialidad, hospital, cirugias);

                    DialogResult = DialogResult.OK;
                }
                
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
