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
        bool modificar = false;

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
            txtId.Enabled = false;
            modificar = true;
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
                else if (!double.TryParse(this.txtTrofeos.Text, out double trofeos) || trofeos < 0 || this.txtTrofeos.Text.Contains("."))
                {
                    OnMessageBoxMostrado("Ingrese una cantidad de trofeos válida.");
                }
                else if (!int.TryParse(this.txtRanking.Text, out int ranking) || ranking <= 0 || this.txtRanking.Text.Contains("."))
                {
                    OnMessageBoxMostrado("Ingrese un ranking mundial válido.");
                }
                else if (string.IsNullOrWhiteSpace(txtDeporte.Text))
                {
                    OnMessageBoxMostrado("Ingrese un deporte.");
                }
                else
                {
                    nombre = txtNombre.Text;
                    apellido = txtApellido.Text;
                    salario = double.Parse(txtSalario.Text);
                    tipo = (ETipo)cmbTipo.SelectedItem;
                    id = double.Parse(txtId.Text);
                    deporte = txtDeporte.Text;

                    AccesoDatos accesoDatos = new AccesoDatos();
                    List<Deportista> deportistasEnBaseDeDatos = accesoDatos.ObtenerListaDeportistas();
                    if (deportistasEnBaseDeDatos.Any(d => d.Id == id) && modificar == false)
                    {
                        OnMessageBoxMostrado("El ID ya existe en la base de datos. Ingrese un ID único.");
                    }

                    deportista = new Deportista(nombre, apellido, salario, tipo, id, deporte, trofeos, ranking);

                    accesoDatos.InsertarTrabajador(deportista, "Deportista");

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
