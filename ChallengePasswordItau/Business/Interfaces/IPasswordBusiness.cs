using ChallengePasswordItau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengePasswordItau.Business.Interfaces
{
    public interface IPasswordBusiness
    {
        bool? ValidatePassword(PasswordModel password, out string errorMessage);
    }
}
