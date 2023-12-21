using VisualStudioNetCore;
using Xunit;

namespace VisualStudioNetCoreTests
{
    public class ClaseEjemploTests
    {
        [Fact]
        public void SiempreDevuelvoTrue_RetornaTrue()
        {
            //Arrange
            var claseEjemplo = new ClaseEjemplo();

            //Act
            var resultado = claseEjemplo.SiempreDevuelvoTrue();

            //Assert
            Assert.True(resultado);
        }
    }
}
