using ChallengePasswordItau.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengePasswordItau.Helpers
{
    public static class ReturnHelper
    {
        public static JsonResult Try(bool? success, string message)
        {
            AnswersModel result = new AnswersModel();
            ErrorModel error = new ErrorModel();            

            if (success == null)
            {
                error = new ErrorModel()
                {
                    Message = message,
                    Status = 0
                };
                
                return new JsonResult(error);                               
            }
            else
            {
                result.Result = success;

                return new JsonResult(result);
            }
            
        }

    }    
}
