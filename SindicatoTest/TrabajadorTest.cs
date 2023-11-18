using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laburos;

namespace SindicatoTest
{
    [TestClass]
    public class TrabajadorTest
    {
        [TestMethod]
        public void TestAgregarPeriodista()
        {
            // Arrange
            Sindicato sindicato = new Sindicato();
            Periodista periodista = new Periodista("Nombre", "Apellido", 25, ETipo.Tiempocompleto, "Deportes", 90, EMedios.Television);

            // Act
            sindicato += periodista;

            // Assert
            Assert.IsTrue(sindicato.Trabajadores.Contains(periodista));
        }

        [TestMethod]
        public void TestEliminarPeriodista()
        {
            // Arrange
            Sindicato sindicato = new Sindicato();
            Periodista periodista = new Periodista("Nombre", "Apellido", 25, ETipo.Tiempocompleto, "Deportes", 90, EMedios.Television);
            sindicato += periodista;

            // Act
            sindicato -= periodista;

            // Assert
            Assert.IsFalse(sindicato.Trabajadores.Contains(periodista));
        }

        [TestMethod]
        public void TestOrdenarPorNombreAscendente()
        {
            // Arrange
            Sindicato sindicato = new Sindicato();
            Periodista periodista1 = new Periodista("Zeta", "Apellido", 25, ETipo.Tiempocompleto, "Deportes", 90, EMedios.Television);
            Periodista periodista2 = new Periodista("Alfa", "Apellido", 30, ETipo.Tiempocompleto, "Política", 85, EMedios.Radio);
            sindicato += periodista1;
            sindicato += periodista2;

            // Act
            sindicato.OrdenarPorNombreAscendente();

            // Assert
            Assert.AreEqual("Alfa", sindicato.Trabajadores[0].Nombre);
            Assert.AreEqual("Zeta", sindicato.Trabajadores[1].Nombre);
        }

    }
}
