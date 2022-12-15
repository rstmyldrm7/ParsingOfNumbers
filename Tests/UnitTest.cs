using Tests.Helper;
using AutoBogus;
using Autofac;
using Autofac.Extras.Moq;
using Bogus;
using ParsingOfNumbers.Service;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class UnitTest
    {
        
        [Fact]
        async Task ParseSingleDigitNumber()
        {
            var randomNumber = TestHelper.GetRandomNumberWithDigits(1);
            var requestText = TestHelper.NumberToWords(randomNumber);
            using (var mock = AutoMock.GetLoose(cfg =>
            {
            }))
            {
                //Arrange
                var sut = mock.Create<ParseService>();

                //Act
                var ret = await sut.ParseTheText(requestText);

                //Assert
                Assert.Contains(randomNumber.ToString(), ret);
            }
        }

        [Fact]
        async Task ParseDoubleDigitNumber()
        {
            var randomNumber = TestHelper.GetRandomNumberWithDigits(2);
            var requestText = TestHelper.NumberToWords(randomNumber);
            using (var mock = AutoMock.GetLoose(cfg =>
            {
            }))
            {
                //Arrange
                var sut = mock.Create<ParseService>();

                //Act
                var ret = await sut.ParseTheText(requestText);

                //Assert
                Assert.Contains(randomNumber.ToString(), ret);
            }
        }

        [Fact]
        async Task ParseThreeDigitNumber()
        {
            var randomNumber = TestHelper.GetRandomNumberWithDigits(3);
            var requestText = TestHelper.NumberToWords(randomNumber);
            using (var mock = AutoMock.GetLoose(cfg =>
            {
            }))
            {
                //Arrange
                var sut = mock.Create<ParseService>();

                //Act
                var ret = await sut.ParseTheText(requestText);

                //Assert
                Assert.Contains(randomNumber.ToString(), ret);
            }
        }

        [Fact]
        async Task ParseFourDigitNumber()
        {
            var randomNumber = TestHelper.GetRandomNumberWithDigits(4);
            var requestText = TestHelper.NumberToWords(randomNumber);
            using (var mock = AutoMock.GetLoose(cfg =>
            {
            }))
            {
                //Arrange
                var sut = mock.Create<ParseService>();

                //Act
                var ret = await sut.ParseTheText(requestText);

                //Assert
                Assert.Contains(randomNumber.ToString(), ret);
            }
        }
        [Fact]
        async Task ParseFiveDigitNumber()
        {
            var randomNumber = TestHelper.GetRandomNumberWithDigits(5);
            var requestText = TestHelper.NumberToWords(randomNumber);
            using (var mock = AutoMock.GetLoose(cfg =>
            {
            }))
            {
                //Arrange
                var sut = mock.Create<ParseService>();

                //Act
                var ret = await sut.ParseTheText(requestText);

                //Assert
                Assert.Contains(randomNumber.ToString(), ret);
            }
        }
        [Fact]
        async Task ParseSixDigitNumber()
        {
            var randomNumber = TestHelper.GetRandomNumberWithDigits(6);
            var requestText = TestHelper.NumberToWords(randomNumber);
            using (var mock = AutoMock.GetLoose(cfg =>
            {
            }))
            {
                //Arrange
                var sut = mock.Create<ParseService>();

                //Act
                var ret = await sut.ParseTheText(requestText);

                //Assert
                Assert.Contains(randomNumber.ToString(), ret);
            }
        }
        [Fact]
        async Task ParseSevenDigitNumber()
        {
            var randomNumber = TestHelper.GetRandomNumberWithDigits(7);
            var requestText = TestHelper.NumberToWords(randomNumber);
            using (var mock = AutoMock.GetLoose(cfg =>
            {
            }))
            {
                //Arrange
                var sut = mock.Create<ParseService>();

                //Act
                var ret = await sut.ParseTheText(requestText);

                //Assert
                Assert.Contains(randomNumber.ToString(), ret);
            }
        }
        [Fact]
        async Task ParseEightDigitNumber()
        {
            var randomNumber = TestHelper.GetRandomNumberWithDigits(8);
            var requestText = TestHelper.NumberToWords(randomNumber);
            using (var mock = AutoMock.GetLoose(cfg =>
            {
            }))
            {
                //Arrange
                var sut = mock.Create<ParseService>();

                //Act
                var ret = await sut.ParseTheText(requestText);

                //Assert
                Assert.Contains(randomNumber.ToString(), ret);
            }
        }
        [Fact]
        async Task ParseNoNumber()
        {
            var requestText = "No Number in this sentence bla bla great job";
            using (var mock = AutoMock.GetLoose(cfg =>
            {
            }))
            {
                //Arrange
                var sut = mock.Create<ParseService>();

                //Act
                var ret = await sut.ParseTheText(requestText);

                //Assert
                Assert.Contains(requestText, ret);
            }
        }

        [Fact]
        async Task ParseSpecificTest()
        {
            var requestText = "He paid twenty millions for three such cars";
            using (var mock = AutoMock.GetLoose(cfg =>
            {
            }))
            {
                //Arrange
                var sut = mock.Create<ParseService>();

                //Act
                var ret = await sut.ParseTheText(requestText);

                //Assert
                var expectedResponse = "He paid 20000000 for 3 such cars";
                Assert.Contains(expectedResponse, ret);
            }
        }
    }
}
