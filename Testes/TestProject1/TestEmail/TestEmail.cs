using Console_test.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.TestEmail
{
    public class TestEmail
    {
        [Theory]
        [InlineData("test@example.com", true)]
        [InlineData("invalidemail.com", false)]
        [InlineData("invalidemail@", false)]
        [InlineData("@example.com", false)]
        [InlineData("", false)]
        [InlineData(null, false)]

        //metoo para validar o email (passa as variaveis)
        public void ValidateEmail (string email, bool expected)
        {
            // Arrange (arruma)
            var emailValidator = new Email();

            // Act (age)
            var result = emailValidator.ValidarEmail(email);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
