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
        // GET api/Square/{id}
        // This method takes an integer as input and returns the square of the integer.
        public int GET(int id)
        {
            // Square the input integer
            int square = (int)Math.Pow(id, 2);
            // Return the result
            return square;
        }
    }
}
