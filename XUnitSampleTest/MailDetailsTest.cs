using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnitSample;

namespace XUnitSampleTest
{
    public class MailDetailsTest
    {
        [Fact]
        public void NotValidEmail()
        {
            //Arrange
            var mailDetails = new MailDetails();
            const string mailAddress = "john.smith.company.com";

            //Act
            bool isValid = mailDetails.IsValidAddress(mailAddress);

            //Assert
            Assert.False(isValid, $"The email {mailAddress} is valid, but it shouldn’t");
        }

        [Theory]
        [InlineData("john.smith@company.com", true)]
        [InlineData("johnsmith@company.com", true)]
        [InlineData("john.smith@company.comma", true)]
        [InlineData("john.smith@company.it", true)]
        [InlineData("john.smith.company.com", false)]
        [InlineData("john@smith@company.com", false)]
        [InlineData("john", false)]
        [InlineData("", false)]
        public void CheckEmail(string mailAddress, bool expectedTestResult)
        {
            var mailDetails = new MailDetails();

            Assert.Equal(expectedTestResult, mailDetails.IsValidAddress(mailAddress));
        }
    }

}
