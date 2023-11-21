using System;
using System.Collections.Generic;
using System.Data;
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

        public bool InsertarTrabajador<T>(T trabajador, string nombreTabla) where T : Trabajador
        {
            bool retorno = false;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.Clear();
                this.comando.Parameters.AddWithValue("@nombre", trabajador.Nombre);
                this.comando.Parameters.AddWithValue("@apellido", trabajador.Apellido);
                this.comando.Parameters.AddWithValue("@salario", (double)trabajador.Salario);
                this.comando.Parameters.AddWithValue("@tipo", (int)trabajador.Tipo);
                this.comando.Parameters.AddWithValue("@id", (int)trabajador.Id);

                if (trabajador is Periodista periodista)
                {
                    comando.CommandText = $"INSERT INTO {nombreTabla} " +
                        "(nombre, apellido, salario, tipo, id, especializacion, credibilidad, medio) " +
                        "VALUES (@nombre, @apellido, @salario, @tipo, @id, @especializacion, @credibilidad, @medio)";

                    comando.Parameters.AddWithValue("@especializacion", periodista.Especializacion);
                    comando.Parameters.AddWithValue("@credibilidad", (double)periodista.Credibilidad);
                    comando.Parameters.AddWithValue("@medio", (int)periodista.Medio);
                }
                else if (trabajador is Cirujano cirujano)
                {
                    comando.CommandText = $"INSERT INTO {nombreTabla} " +
                        "(nombre, apellido, salario, tipo, id, especialidad, hospital, cirugias) " +
                        "VALUES (@nombre, @apellido, @salario, @tipo, @id, @especialidad, @hospital, @cirugias)";

                    comando.Parameters.AddWithValue("@especialidad", cirujano.Especialidad);
                    comando.Parameters.AddWithValue("@hospital", (int)cirujano.Hospital);
                    comando.Parameters.AddWithValue("@cirugias", cirujano.Cirugias);
                }
                else if (trabajador is Deportista deportista)
                {
                    comando.CommandText = $"INSERT INTO {nombreTabla} " +
                        "(nombre, apellido, salario, tipo, id, deporte, trofeos, rankingMundial) " +
                        "VALUES (@nombre, @apellido, @salario, @tipo, @id, @deporte, @trofeos, @rankingMundial)";

                    comando.Parameters.AddWithValue("@deporte", deportista.Deporte);
                    comando.Parameters.AddWithValue("@trofeos", deportista.Trofeos);
                    comando.Parameters.AddWithValue("@rankingMundial", deportista.RankingMundial);
                }


                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    retorno = true;
                }
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
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
            catch(Exception ex) 
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
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }

        public void CargarLista<T>(List<T> lista, string query) where T : class, new()
        {
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = query;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();
                while (lector.Read())
                {
                    T entidad = new T();

                    foreach (var propiedad in typeof(T).GetProperties())
                    {
                        if (propiedad.PropertyType.IsEnum)
                        {
                            propiedad.SetValue(entidad, Enum.Parse(propiedad.PropertyType, this.lector[propiedad.Name].ToString()));
                        }
                        else
                        {
                            propiedad.SetValue(entidad, Convert.ChangeType(this.lector[propiedad.Name], propiedad.PropertyType));
                        }
                    }

                    lista.Add(entidad);
                }

                this.lector.Close();
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
        }

        public List<Periodista> ObtenerListaPeriodistas()
        {
            List<Periodista> lista = new List<Periodista>();
            CargarLista(lista, "SELECT nombre, apellido, salario, tipo, id, especializacion, credibilidad, medio FROM Periodista");
            return lista;
        }

        public List<Cirujano> ObtenerListaCirujanos()
        {
            List<Cirujano> lista = new List<Cirujano>();
            CargarLista(lista, "SELECT nombre, apellido, salario, tipo, id, especialidad, cirugias, hospital FROM Cirujano");
            return lista;
        }

        public List<Deportista> ObtenerListaDeportistas()
        {
            List<Deportista> lista = new List<Deportista>();
            CargarLista(lista, "SELECT nombre, apellido, salario, tipo, id, deporte, trofeos, rankingMundial FROM Deportista");
            return lista;
        }
    }
}
