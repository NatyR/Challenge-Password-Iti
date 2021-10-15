using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChallengePasswordItau.Models;
using ChallengePasswordItau.Business.Interfaces;
using ChallengePasswordItau.Helpers;

namespace ChallengePasswordItau.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        #region Constructor
        private readonly IPasswordBusiness passwordBusiness;

        public PasswordController(IPasswordBusiness _passwordBusiness)
        {
            passwordBusiness = _passwordBusiness;
        }

        #endregion

        #region Metodos    

        /// <summary>
        /// Método Responsavel por Validar a Senha informada pelo Usuario
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ValidatePassword([FromBody] PasswordModel password)
        {
            bool? result = passwordBusiness.ValidatePassword(password, out string errorMessage);
                        
            return ReturnHelper.Try(result, errorMessage);           

        }     
        #endregion

    }
}
