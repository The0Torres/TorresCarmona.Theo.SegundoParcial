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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(rbtnSalario.Checked) 
            {
               if (rbtnAscendente.Checked) 
               {
                    Sindicato.OrdenarPorSalarioAscendente();
               }
               else if(rbtnDescendente.Checked)
               {
                    Sindicato.OrdenarPorSalarioDescendente();              
               }
            }
            else if(rbtnApellido.Checked)
            {
                 if(rbtnAscendente.Checked)
                {
                    Sindicato.OrdenarPorApellidoAscendente();
                }
                else if(rbtnDescendente.Checked)
                {
                    Sindicato.OrdenarPorApellidoDescendente();
                }
            }
            else if(rbtnNombre.Checked)
            {
                if(rbtnAscendente.Checked)
                {
                    Sindicato.OrdenarPorNombreAscendente();
                }
                else if (rbtnDescendente.Checked)
                {
                    Sindicato.OrdenarPorNombreDescendente();
                }
            }
            if (!rbtnAscendente.Checked && !rbtnDescendente.Checked)
            {
                MessageBox.Show("Por favor seleccione el orden",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning
                                        );
            }
            else
            {
                this.DialogResult = DialogResult.OK; 
            }
        }
    }
}
