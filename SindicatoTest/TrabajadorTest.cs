using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laburos;

namespace SindicatoTest
{
    [TestClass]
    public class TrabajadorTest
    {
        [TestMethod]
        public void TestInsertarPeriodistaEnBaseDeDatos()
        {
            // Arrange
            AccesoDatos accesoDatos = new AccesoDatos();
            Periodista periodista = new Periodista("Nombre", "Apellido", 25, ETipo.Tiempocompleto, 1, "Deportes", 90, EMedios.Television);

            // Act
            bool resultado = accesoDatos.InsertarTrabajador(periodista,"Periodista");

            // Assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void TestModificarPeriodista()
        {
            // Arrange
            AccesoDatos accesoDatos = new AccesoDatos();
            Periodista periodista = new Periodista
            {
                Nombre = "NuevoNombre",
                Apellido = "NuevoApellido",
                Salario = 60000,
                Tipo = ETipo.Tiempocompleto,
                Id = 1, 
                Especializacion = "NuevoDeporte",
                Credibilidad = 20,
                Medio = EMedios.Television,
            };

            // Act
            bool resultado = accesoDatos.ModificarTrabajador(periodista);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestEliminarPeriodista()
        {
            // Arrange
            AccesoDatos accesoDatos = new AccesoDatos();
            Periodista periodista = new Periodista("Nombre", "Apellido", 25, ETipo.Tiempocompleto, 1, "Deportes", 90, EMedios.Television);

            // Act
            bool resultado = accesoDatos.EliminarRegistro(periodista);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestCargarListaDeportistas()
        {
            // Arrange
            AccesoDatos accesoDatos = new AccesoDatos();
            List<Deportista> listaDeportistas = new List<Deportista>();

            // Act
            accesoDatos.CargarLista(listaDeportistas, "SELECT nombre, apellido, salario, tipo, id, deporte, trofeos, rankingMundial FROM Deportista");

            // Assert
            Assert.IsNotNull(listaDeportistas);
            Assert.IsTrue(listaDeportistas.Count > 0);
        }

    }
}
