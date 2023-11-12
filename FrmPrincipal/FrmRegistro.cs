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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            if (File.Exists("usuarios.log"))
            {
                using (StreamReader registro = new StreamReader("usuarios.log"))
                {
                    string linea;
                    while ((linea = registro.ReadLine()) != null)
                    {
                        lstRegistro.Items.Add(linea);
                    }
                }
            }
            else
            {
                lstRegistro.Items.Add("El archivo de log no existe.");
            }
        }
    }
}
