using ChallengePasswordItau.Business.Interfaces;
using ChallengePasswordItau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChallengePasswordItau.Business
{
    public class PasswordBusiness : IPasswordBusiness
    {
        public bool? ValidatePassword(PasswordModel passwordModel, out string errorMessage)
        {            
            errorMessage = string.Empty;
            string pattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()-+])(?=\S+$)(?!.*(.).*\1).{9,}$";

            try
            {
                Regex rgx = new Regex(pattern);
                Match match = rgx.Match(passwordModel.Password);
                if (match.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                errorMessage = "An error has occurred in the operation";                
                return null;

            }
            
        }
    }
}
