using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace Laburos
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private static string cadenaConexion;

        public SqlCommand comando;

        static AccesoDatos()
        {

            cadenaConexion = TorresCarmona.Theo.Properties.Resources.miConexion;
        }

        public AccesoDatos()
        {

            this.conexion = new SqlConnection(cadenaConexion);
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

        public bool InsertarPeriodista(Periodista periodista)
        {
            bool retorno = false;

            try
            {
                
                this.comando = new SqlCommand();
                this.comando.Parameters.Clear();
                this.comando.Parameters.AddWithValue("@nombre", periodista.Nombre);
                this.comando.Parameters.AddWithValue("@apellido", periodista.Apellido);
                this.comando.Parameters.AddWithValue("@salario", (double)periodista.Salario);
                this.comando.Parameters.AddWithValue("@tipo", (int)periodista.Tipo);
                this.comando.Parameters.AddWithValue("@id", (int)periodista.Id);
                this.comando.Parameters.AddWithValue("@especializacion", periodista.Especializacion);
                this.comando.Parameters.AddWithValue("@credibilidad", (double)periodista.Credibilidad);
                this.comando.Parameters.AddWithValue("@medio", (int)periodista.Medio);

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "INSERT INTO Periodista (nombre, apellido, salario, tipo, id, especializacion, credibilidad, medio)" +
                    "VALUES (@nombre, @apellido, @salario, @tipo, @id, @especializacion, @credibilidad, @medio)";
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

        public bool InsertarCirujano(Cirujano cirujano)
        {
            bool retorno = false;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.Clear();
                this.comando.Parameters.AddWithValue("@nombre", cirujano.Nombre);
                this.comando.Parameters.AddWithValue("@apellido", cirujano.Apellido);
                this.comando.Parameters.AddWithValue("@salario", (double)cirujano.Salario);
                this.comando.Parameters.AddWithValue("@tipo", (int)cirujano.Tipo);
                this.comando.Parameters.AddWithValue("@id", (int)cirujano.Id);
                this.comando.Parameters.AddWithValue("@especialidad", cirujano.Especialidad);
                this.comando.Parameters.AddWithValue("@hospital", (int)cirujano.Hospital);
                this.comando.Parameters.AddWithValue("@cirugias", cirujano.Cirugias);

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "INSERT INTO Cirujano (nombre, apellido, salario, tipo, id, especialidad, hospital, cirugias)" +
                    "VALUES (@nombre, @apellido, @salario, @tipo, @id, @especialidad, @hospital, @cirugias)";
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

        public bool InsertarDeportista(Deportista deportista)
        {
            bool retorno = false;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.Clear();
                this.comando.Parameters.AddWithValue("@nombre", deportista.Nombre);
                this.comando.Parameters.AddWithValue("@apellido", deportista.Apellido);
                this.comando.Parameters.AddWithValue("@salario", (double)deportista.Salario);
                this.comando.Parameters.AddWithValue("@tipo", (int)deportista.Tipo);
                this.comando.Parameters.AddWithValue("@id", (int)deportista.Id);
                this.comando.Parameters.AddWithValue("@deporte", deportista.Deporte);
                this.comando.Parameters.AddWithValue("@trofeos", deportista.Trofeos);
                this.comando.Parameters.AddWithValue("@rankingMundial", deportista.RankingMundial);

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "INSERT INTO Deportista (nombre, apellido, salario, tipo, id, deporte, trofeos, rankingMundial)" +
                    "VALUES (@nombre, @apellido, @salario, @tipo, @id, @deporte, @trofeos, @rankingMundial)";
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
