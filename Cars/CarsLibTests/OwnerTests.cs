using System;
using Xunit;
using CarsLib;

namespace CarsLibTests
{
    public class OwnerTestsTests
    {
        [Theory]
        [InlineData(1234567891, 1234567891)]
        [InlineData(123456789123, 0)]
        [InlineData(123456789, 0)]
        public void SetLicenceNoTest(long newLicenceNo, long expected)
        {
            // Arange
            Owner o1 = new Owner("TESTOWNER", 1234567891);
            
            // Act
            o1.SetLicenceNo(newLicenceNo);
           

            // Assert
            Assert.Equal(o1.LicenceNo, expected);
            
        }


    }
}
