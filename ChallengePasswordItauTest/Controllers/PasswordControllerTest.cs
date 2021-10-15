using ChallengePasswordItau.Business;
using ChallengePasswordItau.Business.Interfaces;
using ChallengePasswordItau.Controllers;
using ChallengePasswordItau.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace ChallengePasswordItauTest.Controllers
{
    public class PasswordControllerTest
    {
        private  Mock<IPasswordBusiness> passwordBusiness;
        private  PasswordController _controller;

        public PasswordControllerTest()
        {
            passwordBusiness = new Mock<IPasswordBusiness>();
            _controller = new PasswordController(passwordBusiness.Object);
        }

        [Trait("Category", "PasswordControllerTest")]
        [Fact(DisplayName = "ValidatePassword_With_Returns_True_False")]
        public void ValidatePassword_With_Returns_True()
        {

           PasswordModel modelTeste = new PasswordModel()
            {
                Password = "AbTp9!fok"
            };

            var result = _controller.ValidatePassword(modelTeste);
            Assert.NotNull(result);      
        
        }
 

        [Trait("Category", "PasswordControllerTest")]
        [Fact(DisplayName = "ValidatePassword_With_Returns_Error")]
        public void ValidatePassword_With_Returns_Error()
        {
          PasswordModel modelTeste = new PasswordModel()
           {
                Password = "AbTp9!fo"
           };

            string errorMessage = "errorMessage";
            passwordBusiness.Setup(x=> x.ValidatePassword(It.IsAny<PasswordModel>(), out errorMessage));
            var result = _controller.ValidatePassword(modelTeste);
            Assert.Equal(0, ((ErrorModel)((JsonResult)result).Value).Status);      
        }
    }
}