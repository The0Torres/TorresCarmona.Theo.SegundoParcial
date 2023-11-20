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
            Periodista periodista = new Periodista("Nombre", "Apellido", 25, ETipo.Tiempocompleto, 7, "Deportes", 90, EMedios.Television);

            // Act
            bool resultado = accesoDatos.InsertarPeriodista(periodista);

            // Assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void TestModificarDeportista()
        {
            // Arrange
            AccesoDatos accesoDatos = new AccesoDatos();
            Deportista deportista = new Deportista
            {
                Nombre = "NuevoNombre",
                Apellido = "NuevoApellido",
                Salario = 60000,
                Tipo = ETipo.Tiempocompleto,
                Id = 1, 
                Deporte = "NuevoDeporte",
                Trofeos = 10,
                RankingMundial = 5
            };

            // Act
            bool resultado = accesoDatos.ModificarDeportista(deportista);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestEliminarPeriodista()
        {
            // Arrange
            AccesoDatos accesoDatos = new AccesoDatos();
            Periodista periodista = new Periodista("Nombre", "Apellido", 25, ETipo.Tiempocompleto, 30, "Deportes", 90, EMedios.Television);
            accesoDatos.InsertarPeriodista(periodista);

            // Act
            bool resultado = accesoDatos.EliminarPeriodista(periodista);

            // Assert
            Assert.IsTrue(resultado);
        }

    }
}
