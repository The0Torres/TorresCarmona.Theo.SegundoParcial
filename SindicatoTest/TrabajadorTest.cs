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

    }
}
