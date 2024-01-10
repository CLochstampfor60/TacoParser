using System;
using Xunit;
using static System.Formats.Asn1.AsnWriter;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.21147,-87.620375, Taco Bell Haleyvill...", 34.21147)]
        [InlineData("33.887468, -84.248611, Taco Bell Doravill...", 33.887468)]
        [InlineData("33.796264, -84.224516, Taco Bell Stone Mountain...", 33.796264)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tp = new TacoParser();
            //Act
            var actual = tp.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.21147,-87.620375, Taco Bell Haleyvill...", -87.620375)]
        [InlineData("33.887468, -84.248611, Taco Bell Doravill...", -84.248611)]
        [InlineData("33.796264, -84.224516, Taco Bell Stone Mountain...", -84.224516)]

        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tp = new TacoParser();
            //Act
            var actual = tp.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }

    }
}
