using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Laburos
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        public SqlCommand comando;
        private SqlDataReader lector;
        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = Properties.Resources.miConexion;
        }
        public AccesoDatos()
        {
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);

        }
        public bool PruebaConexion()
        {
            bool retorno = false;

            try
            {
                this.conexion.Open();
                retorno = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }

        public List<Dato> ObtenerListaDatos()
        {
            List<Dato> lista = new List<Dato>();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "select id,cadena,entero,flotante from dato";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();
                while (lector.Read())
                {
                    Dato dato = new Dato();
                    dato.id = (int)this.lector["id"];
                    dato.cadena = this.lector["cadena"].ToString();
                    dato.entero = (int)this.lector["entero"];
                    dato.flotante = (float)this.lector.GetDouble(3);
                    lista.Add(dato);
                }

                this.lector.Close();
            }
            catch
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }

        public bool InsertarDatos(Dato d)
        {
            bool retorno = false;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@cadena", d.cadena);
                this.comando.Parameters.AddWithValue("@entero", d.entero);
                this.comando.Parameters.AddWithValue("@flotante", d.flotante);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"insert into dato(cadena,entero,flotante) values (@cadena,@entero,@flotante)";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    retorno = true;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }

        public bool ModificarDatos(Dato d)
        {
            bool retorno = false;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@id", d.id);
                this.comando.Parameters.AddWithValue("@cadena", d.cadena);
                this.comando.Parameters.AddWithValue("@entero", d.entero);
                this.comando.Parameters.AddWithValue("@flotante", d.flotante);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"update dato set cadena = @cadena,entero = @entero,flotante=@flotante where id = @id";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    retorno = true;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }

    }
}