﻿using System;
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


        public FrmDeportista(Deportista deportista) : this()
        {
            txtNombre.Text = deportista.Nombre;
            txtApellido.Text = deportista.Apellido;
            txtSalario.Text = deportista.Salario.ToString();
            cmbTipo.SelectedItem = deportista.Tipo;
            txtId.Text = deportista.Id.ToString();
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
            try
            {
                if (!ValidarDatos())
                {
                    return;
                }

                if (!double.TryParse(this.txtTrofeos.Text, out double trofeos) || trofeos < 0 || this.txtTrofeos.Text.Contains("."))
                {
                    throw new DatosInvalidosException("Ingrese una cantidad de trofeos válida.");
                }

                if (!int.TryParse(this.txtRanking.Text, out int ranking) || ranking <= 0 || this.txtRanking.Text.Contains("."))
                {
                    throw new DatosInvalidosException("Ingrese un ranking mundial válido.");
                }

                if (string.IsNullOrWhiteSpace(txtDeporte.Text))
                {
                    throw new DatosInvalidosException("Ingrese una especialidad.");
                }

                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                salario = double.Parse(txtSalario.Text);
                tipo = (ETipo)cmbTipo.SelectedItem;
                id = double.Parse(txtId.Text);
                deporte = txtDeporte.Text;
                deportista = new Deportista(nombre, apellido, salario, tipo, id, deporte, trofeos, ranking);

                DialogResult = DialogResult.OK;
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
