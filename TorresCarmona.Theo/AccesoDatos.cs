using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace Laburos
{
    public class AccesoDatos: IAccesoDatos
    {
        private SqlConnection conexion;
        private static string cadenaConexion;
        private SqlDataReader lector;
        public SqlCommand comando;

        static AccesoDatos()
        {
            cadenaConexion = TorresCarmona.Theo.Properties.Resources.miConexion;
        }

        public AccesoDatos()
        {
            this.conexion = new SqlConnection(cadenaConexion);
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

        public bool EliminarRegistro<T>(T entidad) where T : class
        {
            bool retorno = false;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.Clear();
                this.comando.Parameters.AddWithValue("@id", entidad.GetType().GetProperty("Id").GetValue(entidad));

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"DELETE FROM {typeof(T).Name} WHERE id = @id";
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


        public bool ModificarPeriodista(Periodista periodista)
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
                this.comando.CommandText = "UPDATE Periodista SET nombre = @nombre, apellido = @apellido, salario = @salario, tipo = @tipo, especializacion = @especializacion, credibilidad = @credibilidad, medio = @medio WHERE id = @id";
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

        public bool ModificarCirujano(Cirujano cirujano)
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
                this.comando.CommandText = "UPDATE Cirujano SET nombre = @nombre, apellido = @apellido, salario = @salario, tipo = @tipo, especialidad = @especialidad, hospital = @hospital, cirugias = @cirugias WHERE id = @id";
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

        public bool ModificarDeportista(Deportista deportista)
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
                this.comando.CommandText = "UPDATE Deportista SET nombre = @nombre, apellido = @apellido, salario = @salario, tipo = @tipo, deporte = @deporte, trofeos = @trofeos, rankingMundial = @rankingMundial WHERE id = @id";
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

        public List<Periodista> ObtenerListaPeriodistas()
        {
            List<Periodista> lista = new List<Periodista>();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT nombre, apellido, salario, tipo, id, especializacion, credibilidad, medio FROM Periodista";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();
                while (lector.Read())
                {
                    Periodista periodista = new Periodista();
                    periodista.Nombre = this.lector["nombre"].ToString();
                    periodista.Apellido = this.lector["apellido"].ToString();
                    periodista.Salario = (double)this.lector["salario"];
                    periodista.Tipo = (ETipo)Enum.Parse(typeof(ETipo), this.lector["tipo"].ToString());
                    periodista.Id = (double)this.lector["id"];
                    periodista.Especializacion = this.lector["especializacion"].ToString();
                    periodista.Credibilidad = (double)this.lector["credibilidad"];
                    periodista.Medio = (EMedios)Enum.Parse(typeof(EMedios), this.lector["medio"].ToString());
                    lista.Add(periodista);
                }

                this.lector.Close();
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
            return lista;
        }

        public List<Cirujano> ObtenerListaCirujanos()
        {
            List<Cirujano> lista = new List<Cirujano>();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT nombre, apellido, salario, tipo, id, especialidad, cirugias, hospital FROM Cirujano";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();
                while (lector.Read())
                {
                    Cirujano cirujano = new Cirujano();
                    cirujano.Nombre = this.lector["nombre"].ToString();
                    cirujano.Apellido = this.lector["apellido"].ToString();
                    cirujano.Salario = (double)this.lector["salario"];
                    cirujano.Tipo = (ETipo)Enum.Parse(typeof(ETipo), this.lector["tipo"].ToString());
                    cirujano.Id = (double)this.lector["id"];
                    cirujano.Especialidad = this.lector["especialidad"].ToString();
                    cirujano.Cirugias = (double)this.lector["cirugias"];
                    cirujano.Hospital = (EHospitales)Enum.Parse(typeof(EHospitales), this.lector["hospital"].ToString());
                    lista.Add(cirujano);
                }

                this.lector.Close();
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
            return lista;
        }

        public List<Deportista> ObtenerListaDeportistas()
        {
            List<Deportista> lista = new List<Deportista>();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT nombre, apellido, salario, tipo, id, deporte, trofeos, rankingMundial FROM Deportista";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();
                while (lector.Read())
                {
                    Deportista deportista = new Deportista();
                    deportista.Nombre = this.lector["nombre"].ToString();
                    deportista.Apellido = this.lector["apellido"].ToString();
                    deportista.Salario = (double)this.lector["salario"];
                    deportista.Tipo = (ETipo)Enum.Parse(typeof(ETipo), this.lector["tipo"].ToString());
                    deportista.Id = (double)this.lector["id"];
                    deportista.Deporte = this.lector["deporte"].ToString();
                    deportista.Trofeos = (double)this.lector["trofeos"];
                    deportista.RankingMundial = (double)this.lector["rankingMundial"];
                    lista.Add(deportista);
                }

                this.lector.Close();
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
            return lista;
        }
    }
}
