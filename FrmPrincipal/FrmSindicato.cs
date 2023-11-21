using Laburos;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using System.Text;

namespace FrmPrincipal
{
    /// <summary>
    /// Clase que representa el formulario principal de la aplicación.
    /// Permite gestionar una colección de trabajadores de diferentes clases y proporciona
    /// funcionalidades como agregar, modificar, eliminar y ordenar trabajadores.
    /// También ofrece la opción de cargar y guardar datos desde/hacia archivos XML.
    /// </summary>

    public partial class FrmSindicato : Form
    {
        DateTime fechaActual = DateTime.Now;
        private Usuario usuario;
        private Sindicato sindicato;
        private CancellationTokenSource actualizarTiempoTokenSource = new CancellationTokenSource();
        private CancellationTokenSource actualizarTrabajadoresTokenSource = new CancellationTokenSource();

        public Sindicato Sindicato
        {
            get { return sindicato; }
            set { sindicato = value; }
        }

        public FrmSindicato()
        {
            InitializeComponent();
            Sindicato = new Sindicato();
        }

        public FrmSindicato(Usuario usuario) : this()
        {
            this.usuario = usuario;
            MessageBox.Show($"Bienvenido/a {usuario.nombre}");

            if (usuario.perfil == "vendedor")
            {
                btnEliminar.Hide();
                btnAgregar.Hide();
                btnModificar.Hide();
            }
            else if (usuario.perfil == "supervisor")
            {
                btnEliminar.Hide();
            }
        }

        private void ActualizarVisor()
        {
            this.lstSindicato.Items.Clear();
            foreach (Trabajador trabajador in Sindicato.Trabajadores)
            {
                this.lstSindicato.Items.Add(trabajador.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstSindicato.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Por favor, selecciona un elemento para modificar.", "Elemento no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                object trabajador = Sindicato.Trabajadores[indice];

                DialogResult resultado;
                if (trabajador is Periodista)
                {
                    FrmPeriodista frmperiodista = new FrmPeriodista((Periodista)trabajador);

                    resultado = frmperiodista.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        Sindicato.Trabajadores[indice] = frmperiodista.Periodista;

                        AccesoDatos accesoDatos = new AccesoDatos();
                        accesoDatos.ModificarTrabajador(frmperiodista.Periodista);
                    }
                }
                else if (trabajador is Cirujano)
                {
                    FrmCirujano frmcirujano = new FrmCirujano((Cirujano)trabajador);

                    resultado = frmcirujano.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        Sindicato.Trabajadores[indice] = frmcirujano.Cirujano;

                        AccesoDatos accesoDatos = new AccesoDatos();
                        accesoDatos.ModificarTrabajador(frmcirujano.Cirujano);
                    }
                }
                else if (trabajador is Deportista)
                {
                    FrmDeportista frmdeportista = new FrmDeportista((Deportista)trabajador);

                    resultado = frmdeportista.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        Sindicato.Trabajadores[indice] = frmdeportista.Deportista;

                        // Modificar en la base de datos
                        AccesoDatos accesoDatos = new AccesoDatos();
                        accesoDatos.ModificarTrabajador(frmdeportista.Deportista);
                    }
                }
                this.ActualizarVisor();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            FrmProfesion frm1 = new FrmProfesion();
            DialogResult resultado = frm1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Trabajador nuevoTrabajador = frm1.Trabajador;
                if (Sindicato == nuevoTrabajador)
                {
                    MessageBox.Show("El trabajador ingresado ya existe.", "Ya existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Sindicato += nuevoTrabajador;
                    this.ActualizarVisor();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int indice = this.lstSindicato.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Por favor, selecciona un elemento para eliminar.", "Elemento no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Trabajador trabajador = Sindicato.Trabajadores[indice];

                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar al trabajador?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (trabajador is Periodista)
                    {

                        AccesoDatos accesoDatos = new AccesoDatos();
                        accesoDatos.EliminarRegistro((Periodista)trabajador);
                    }
                    else if (trabajador is Cirujano)
                    {
                        AccesoDatos accesoDatos = new AccesoDatos();
                        accesoDatos.EliminarRegistro((Cirujano)trabajador);
                    }
                    else if (trabajador is Deportista)
                    {
                        AccesoDatos accesoDatos = new AccesoDatos();
                        accesoDatos.EliminarRegistro((Deportista)trabajador);
                    }

                    Sindicato -= trabajador;
                    this.ActualizarVisor();
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            FrmOrdenamiento ordenamiento = new FrmOrdenamiento(sindicato);
            ordenamiento.OrdenamientoCompletado += OrdenamientoCompletadoHandler;
            ordenamiento.ShowDialog();
        }

        private void OrdenamientoCompletadoHandler(object? sender, EventArgs e)
        {
            ActualizarVisor();
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos XML|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await Task.Run(() =>
                    {
                        using (XmlTextReader lectorXml = new XmlTextReader(openFileDialog.FileName))
                        {
                            XmlSerializer serializador = new XmlSerializer(typeof(Sindicato));
                            this.sindicato = (Sindicato)serializador.Deserialize(lectorXml);
                        }
                    });

                    this.ActualizarVisor();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos XML|*.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (XmlTextWriter escritorXml = new XmlTextWriter(saveFileDialog.FileName, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Sindicato));
                    serializador.Serialize(escritorXml, this.sindicato);
                }
            }
        }

        private void btnSesiones_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.ShowDialog();
        }

        private void btn_cargarBd_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoDatos accesoDatos = new AccesoDatos();

                List<Periodista> listaPeriodistasCargados = accesoDatos.ObtenerListaPeriodistas();
                List<Cirujano> listaCirujanosCargados = accesoDatos.ObtenerListaCirujanos();
                List<Deportista> listaDeportistasCargados = accesoDatos.ObtenerListaDeportistas();

                foreach (Periodista periodista in listaPeriodistasCargados)
                {
                    Sindicato += periodista;
                }

                foreach (Cirujano cirujano in listaCirujanosCargados)
                {
                    Sindicato += cirujano;
                }

                foreach (Deportista deportista in listaDeportistasCargados)
                {
                    Sindicato += deportista;
                }

                ActualizarVisor();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void FrmSindicato_Load(object sender, EventArgs e)
        {
            string datos = usuario.ToString();
            string logFilePath = "usuarios.log";
            string entrada = $"{fechaActual.ToString("yyyy-MM-dd HH:mm:ss")} - {datos}\n";

            using (StreamWriter registro = new StreamWriter(logFilePath, true))
            {
                registro.Write(entrada);
            }

            await Task.WhenAll(ActualizarLabelHora(), ActualizarLabelTrabajadores());
        }

        private async Task ActualizarLabelHora()
        {
            while (!actualizarTiempoTokenSource.Token.IsCancellationRequested)
            {
                DateTime horaActual = DateTime.Now;
                
                string textousuario = $"Perfil: {usuario.perfil} - Nombre: {usuario.nombre} - Hora actual: {horaActual.ToString(@"hh:mm:ss")}";

                lblUsuario.Invoke((MethodInvoker)(() => lblUsuario.Text = textousuario));

                await Task.Delay(1000);
            }
        }

        private async Task ActualizarLabelTrabajadores()
        {
            while (!actualizarTrabajadoresTokenSource.Token.IsCancellationRequested)
            {
                int cantidadTrabajadores = sindicato.Trabajadores.Count;
                string textoTrabajadores = $"Gente en el sindicato: {cantidadTrabajadores}";

                lblTrabajadores.Invoke((MethodInvoker)(() => lblTrabajadores.Text = textoTrabajadores));

                await Task.Delay(1000);
            }
        }

        private void FrmSindicato_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de cerrar la aplicación?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
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