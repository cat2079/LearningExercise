using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LearningExercise.Controllers
{
    public class ChallengeController : ApiController
    {   
        /// <summary>
        /// Calculates the volume of a prism given length, width and height
        /// </summary>
        /// <param name="x">The width of the prism in cm</param>
        /// <param name="y">The legnth of the prism in cm</param>
        /// <param name="z">The length of the prism in cm</param>
        /// <returns>
        /// The total volume of the prism is: {result}cm^3
        /// </returns>
        // get: api/Challenge/Calculate/x/y/z -> "The volume of the prism is: x * y * Z cm^3"
        [HttpGet]
        [Route("api/Challenge/Calculate/{x}/{y}/{z}")]
        public string Calculate(int x, int y, int z)
        {
            int volume = x * y * z;
            string message = "The volume of the prism is: " +  (x * y * z) + "cm^3";
            return message;
        }
    }
}
