using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laburos;

namespace FrmPrincipal
{
    public partial class FrmLogin : Form
    {
        private Usuario usuario;
        private bool cerrarAplicacion = true;

        public Usuario UsuarioDelForm
        {
            get { return this.usuario; }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        public FrmLogin(Usuario usuario) : this()
        {
            this.usuario = usuario;
            this.txtCorreo.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuarioVerificado = this.Verificar();

            if (usuarioVerificado == null)
            {
                MessageBox.Show("Datos inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.usuario = this.Verificar();
                this.DialogResult = DialogResult.OK;
                cerrarAplicacion = false;
            }
            
        }

        private Usuario Verificar()
        {
            Usuario? rta = null;

            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"..\..\..\MOCK_DATA.json"))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;

                string json_str = sr.ReadToEnd();

                List<Usuario> users = JsonSerializer.Deserialize<List<Usuario>>(json_str, opciones);


                foreach (Usuario item in users)
                {
                    if (item.correo == this.txtCorreo.Text && item.clave == this.txtContraseña.Text)
                    {
                        rta = item;
                        break;
                    }
                }
            }

            return rta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrarAplicacion && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de cerrar la aplicación?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
