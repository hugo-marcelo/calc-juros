using api2.Validations;
using Xunit;

namespace api2.unit.tests
{
    public class ValidateParametersTest
    {

        [Fact]
        public void ValidateParameters_ShoulReturnErroWhenInitialValueIsLessThanZero()
        {
            ValidateParameters validateParameters = new ValidateParameters();
            decimal initialValue = -1;
            int months = 0;

            var result = validateParameters.Validate(initialValue, months);

            Assert.Equal("[ERRO] O Valor inicial informado deve ser um número decimal maior que zero (0).", result);
        }

        [Fact]
        public void ValidateParameters_ShoulReturnErroWhenInitialValueIsZero()
        {
            ValidateParameters validateParameters = new ValidateParameters();
            decimal initialValue = 0;
            int months = 0;

            var result = validateParameters.Validate(initialValue, months);

            Assert.Equal("[ERRO] O Valor inicial informado deve ser um número decimal maior que zero (0).", result);
        }

        [Fact]
        public void ValidateParameters_ShoulReturnErroWhenMonthsIsLessThanZero()
        {
            ValidateParameters validateParameters = new ValidateParameters();
            decimal initialValue = 1;
            int months = -1;

            var result = validateParameters.Validate(initialValue, months);

            Assert.Equal("[ERRO] O Valor informado no parâmetro 'meses' deve ser um número inteiro maior que zero (0).", result);
        }

        [Fact]
        public void ValidateParameters_ShoulReturnErroWhenMonthsIsZero()
        {
            ValidateParameters validateParameters = new ValidateParameters();
            decimal initialValue = 1;
            int months = 0;

            var result = validateParameters.Validate(initialValue, months);

            Assert.Equal("[ERRO] O Valor informado no parâmetro 'meses' deve ser um número inteiro maior que zero (0).", result);
        }

        [Fact]
        public void ValidateParameters_ShoulNotReturnErroWhenInitialValueAndMonthsAreGreaterThanZero()
        {
            ValidateParameters validateParameters = new ValidateParameters();
            decimal initialValue = 1;
            int months = 1;

            var result = validateParameters.Validate(initialValue, months);

            Assert.Equal(string.Empty, result);
        }

        [Theory]
        [InlineData("0,1")]
        [InlineData("1,0")]
        [InlineData("1,1")]
        public void ValidateStringParameters_ShoulReturnErroWhenInitialValueHasAComma(string initialValue)
        {
            ValidateStringParameter validateStringParameters = new ValidateStringParameter();
            int months = 1;

            var result = validateStringParameters.Validate(initialValue, months);

            Assert.Equal("[ERRO] O Valor inicial informado está em formato inválido.", result);
        }

        [Theory]
        [InlineData("1.250.120")]
        [InlineData("2.135.030")]
        [InlineData("25.045.915")]
        [InlineData("1.130.800.00")]
        [InlineData("20.354.320.050")]
        public void ValidateStringParameters_ShoulReturnErroWhenInitialValueHasMoreThanOneDot(string initialValue)
        {
            ValidateStringParameter validateStringParameters = new ValidateStringParameter();
            int months = 1;

            var result = validateStringParameters.Validate(initialValue, months);

            Assert.Equal("[ERRO] O Valor inicial informado está em formato inválido.", result);
        }

        [Theory]
        [InlineData("A")]
        [InlineData("%")]
        [InlineData("/")]
        public void ValidateStringParameters_ShoulReturnErroWhenInitialValueIsNotNumber(string initialValue)
        {
            ValidateStringParameter validateStringParameters = new ValidateStringParameter();

            var result = validateStringParameters.ValidateDecimal(initialValue);

            Assert.Equal("[ERRO] O Valor inicial informado está em formato inválido.", result);
        }

        [Theory]
        [InlineData("0.1")]
        [InlineData("1.0")]
        [InlineData("1.1")]
        public void ValidateStringParameters_ShoulReturnErroWhenMonthsIsLessThanZero(string initialValue)
        {
            ValidateStringParameter validateStringParameters = new ValidateStringParameter();
            int months = -1;

            var result = validateStringParameters.Validate(initialValue, months);

            Assert.Equal("[ERRO] O Valor informado no parâmetro 'meses' deve ser um número inteiro maior que zero (0).", result);
        }

        [Theory]
        [InlineData("0.1")]
        [InlineData("1.0")]
        [InlineData("1.1")]
        public void ValidateStringParameters_ShoulReturnErroWhenMonthsIsZero(string initialValue)
        {
            ValidateStringParameter validateStringParameters = new ValidateStringParameter();
            int months = 0;

            var result = validateStringParameters.Validate(initialValue, months);

            Assert.Equal("[ERRO] O Valor informado no parâmetro 'meses' deve ser um número inteiro maior que zero (0).", result);
        }

        [Fact]
        public void ValidateStringParameters_ShoulReturnErroWhenInitialValueIsZero()
        {
            ValidateStringParameter validateStringParameters = new ValidateStringParameter();
            string initialValue = "0.00";

            var result = validateStringParameters.ValidateDecimal(initialValue);

            Assert.Equal("[ERRO] O Valor inicial informado deve ser um número decimal maior que zero (0).", result);
        }

        [Fact]
        public void ValidateStringParameters_ShoulNotReturnErroWhenInitialValueIsValidDecimal()
        {
            ValidateStringParameter validateStringParameters = new ValidateStringParameter();
            string initialValue = "0.01";

            var result = validateStringParameters.ValidateDecimal(initialValue);

            Assert.Equal(string.Empty, result);
        }

        [Theory]
        [InlineData("0.1")]
        [InlineData("1.0")]
        [InlineData("1.1")]
        public void ValidateStringParameters_ShoulReturnErroWhenInitialValueAndMonthsAreValid(string initialValue)
        {
            ValidateStringParameter validateStringParameters = new ValidateStringParameter();
            int months = 1;

            var result = validateStringParameters.Validate(initialValue, months);

            Assert.Equal(string.Empty, result);
        }
    }
}
