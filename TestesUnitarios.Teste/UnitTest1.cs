namespace TestesUnitarios.Teste
{
    public class UnitTest1
    {
        [Fact]
        public void TesteSomaPositivos()
        {

            //Arrange
            var calc = new Calculadora();

            //Act
            var resultado = calc.Soma(1, 1);

            //Assert
            Assert.Equal(2, resultado);

        }
        [Fact]
        public void TesteNumero()
        {
            var calc = new Calculadora();

            var result = calc.Numero(1);

            Assert.Equal("Um", result);
        }

        [Fact]
        public void TesteVerdadeiro()
        {
            var calc = new Calculadora();

            Assert.True(calc.Bool(true));
        }
    }
}