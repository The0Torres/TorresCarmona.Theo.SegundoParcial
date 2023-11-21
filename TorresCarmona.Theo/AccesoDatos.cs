using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Laburos
{
    /// <summary>
    /// La clase AccesoDatos hereda la interfaz IAccesoDatos y aplica los metodos de la interfaz.
    /// Permite agregar, eliminar y modificar los trabajadores en la base de datos de cada uno.
    /// A su vez tiene el metodo CargarLista que trae todos los datos de la base de datos.
    /// </summary>
 
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
                    comando.Parameters.AddWithValue("@especializacion", periodista.Especializacion);
                    comando.Parameters.AddWithValue("@credibilidad", (double)periodista.Credibilidad);
                    comando.Parameters.AddWithValue("@medio", (int)periodista.Medio);

                    comando.CommandText = $"INSERT INTO {nombreTabla} " +
                        "(nombre, apellido, salario, tipo, id, especializacion, credibilidad, medio) " +
                        "VALUES (@nombre, @apellido, @salario, @tipo, @id, @especializacion, @credibilidad, @medio)";
                }
                else if (trabajador is Cirujano cirujano)
                {
                    comando.Parameters.AddWithValue("@especialidad", cirujano.Especialidad);
                    comando.Parameters.AddWithValue("@hospital", (int)cirujano.Hospital);
                    comando.Parameters.AddWithValue("@cirugias", cirujano.Cirugias);

                    comando.CommandText = $"INSERT INTO {nombreTabla} " +
                        "(nombre, apellido, salario, tipo, id, especialidad, hospital, cirugias) " +
                        "VALUES (@nombre, @apellido, @salario, @tipo, @id, @especialidad, @hospital, @cirugias)";                  
                }
                else if (trabajador is Deportista deportista)
                {
                    comando.Parameters.AddWithValue("@deporte", deportista.Deporte);
                    comando.Parameters.AddWithValue("@trofeos", deportista.Trofeos);
                    comando.Parameters.AddWithValue("@rankingMundial", deportista.RankingMundial);

                    comando.CommandText = $"INSERT INTO {nombreTabla} " +
                        "(nombre, apellido, salario, tipo, id, deporte, trofeos, rankingMundial) " +
                        "VALUES (@nombre, @apellido, @salario, @tipo, @id, @deporte, @trofeos, @rankingMundial)";     
                }


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

        public bool ModificarTrabajador<T>(T trabajador) where T : Trabajador
        {
            bool retorno = false;

            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = this.conexion;
                    comando.CommandType = CommandType.Text;

                    comando.Parameters.AddWithValue("@nombre", trabajador.Nombre);
                    comando.Parameters.AddWithValue("@apellido", trabajador.Apellido);
                    comando.Parameters.AddWithValue("@salario", (double)trabajador.Salario);
                    comando.Parameters.AddWithValue("@tipo", (int)trabajador.Tipo);
                    comando.Parameters.AddWithValue("@id", (int)trabajador.Id);

                    if (trabajador is Periodista periodista)
                    {
                        comando.Parameters.AddWithValue("@especializacion", periodista.Especializacion);
                        comando.Parameters.AddWithValue("@credibilidad", (double)periodista.Credibilidad);
                        comando.Parameters.AddWithValue("@medio", (int)periodista.Medio);

                        comando.CommandText = "UPDATE Periodista SET nombre = @nombre, apellido = @apellido, salario = @salario, tipo = @tipo, especializacion = @especializacion, credibilidad = @credibilidad, medio = @medio WHERE id = @id";                        
                    }
                    else if (trabajador is Cirujano cirujano)
                    {
                        comando.Parameters.AddWithValue("@especialidad", cirujano.Especialidad);
                        comando.Parameters.AddWithValue("@hospital", (int)cirujano.Hospital);
                        comando.Parameters.AddWithValue("@cirugias", cirujano.Cirugias);

                        comando.CommandText = "UPDATE Cirujano SET nombre = @nombre, apellido = @apellido, salario = @salario, tipo = @tipo, especialidad = @especialidad, hospital = @hospital, cirugias = @cirugias WHERE id = @id";                      
                    }
                    else if (trabajador is Deportista deportista)
                    {
                        comando.Parameters.AddWithValue("@deporte", deportista.Deporte);
                        comando.Parameters.AddWithValue("@trofeos", deportista.Trofeos);
                        comando.Parameters.AddWithValue("@rankingMundial", deportista.RankingMundial);

                        comando.CommandText = "UPDATE Deportista SET nombre = @nombre, apellido = @apellido, salario = @salario, tipo = @tipo, deporte = @deporte, trofeos = @trofeos, rankingMundial = @rankingMundial WHERE id = @id";                        
                    }

                    if (this.conexion.State == ConnectionState.Closed)
                    {
                        this.conexion.Open();
                    }

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas == 1)
                    {
                        retorno = true;
                    }
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
