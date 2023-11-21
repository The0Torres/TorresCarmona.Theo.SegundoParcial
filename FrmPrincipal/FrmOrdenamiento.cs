using Laburos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmOrdenamiento : Form
    {
        public event EventHandler OrdenamientoCompletado;

        private Sindicato sindicato;

        public Sindicato Sindicato
        {
            get { return sindicato; }
            set { sindicato = value; }
        }

        public FrmOrdenamiento(Sindicato sindicato)
        {
            InitializeComponent();
            this.sindicato = sindicato;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbtnSalario.Checked)
            {
                if (rbtnAscendente.Checked)
                {
                    await Task.Run(() => Sindicato.OrdenarPorSalarioAscendente());
                }
                else if (rbtnDescendente.Checked)
                {
                    await Task.Run(() => Sindicato.OrdenarPorSalarioDescendente());
                }
            }
            else if (rbtnApellido.Checked)
            {
                if (rbtnAscendente.Checked)
                {
                    await Task.Run(() => Sindicato.OrdenarPorApellidoAscendente());
                }
                else if (rbtnDescendente.Checked)
                {
                    await Task.Run(() => Sindicato.OrdenarPorApellidoDescendente());
                }
            }
            else if (rbtnNombre.Checked)
            {
                if (rbtnAscendente.Checked)
                {
                    await Task.Run(() => Sindicato.OrdenarPorNombreAscendente());
                }
                else if (rbtnDescendente.Checked)
                {
                    await Task.Run(() => Sindicato.OrdenarPorNombreDescendente());
                }
            }

            if (!rbtnAscendente.Checked && !rbtnDescendente.Checked)
            {
                MessageBox.Show("Por favor seleccione el orden",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                OnOrdenamientoCompletado(EventArgs.Empty);
                this.DialogResult = DialogResult.OK;
            }
        }

        protected virtual void OnOrdenamientoCompletado(EventArgs e)
        {
            OrdenamientoCompletado?.Invoke(this, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
