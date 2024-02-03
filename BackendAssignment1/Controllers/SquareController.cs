using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendAssignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// 
        /// A webAPI method that takes an integer as input and returns the square of the integer.
        /// 
        /// </summary>
        /// 
        /// <param name="id">the integer to get the square of.</param>
        /// 
        /// <returns>The square of the provided integer.</returns>
        /// 
        // GET api/Square/{id}
        
        /// <example>
        /// 
        /// GET api/Square/5 -> 25
        /// 
        /// </example>
        public int GET(int id)
        {
            // Square the input integer
            int square = (int)Math.Pow(id, 2);
            // Return the result
            return square;
        }
    }
}
