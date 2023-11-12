namespace FrmPrincipal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FrmSindicato());


            //CREO UNA INSTANCIA DEL FORMULARIO DE INICIO
            FrmLogin frm = new FrmLogin();

            //INDICO LA POSICION EN LA PANTALLA
            frm.StartPosition = FormStartPosition.CenterScreen;

            try
            {
                frm.ShowDialog();

                //INDICO LA POSICION EN LA PANTALLA
                if (frm.UsuarioDelForm != null)
                {
                    FrmSindicato frmAplicacion = new FrmSindicato(frm.UsuarioDelForm);
                    frmAplicacion.StartPosition = FormStartPosition.CenterScreen;


                    //INICIO LA APLICACION
                    Application.Run(frmAplicacion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}