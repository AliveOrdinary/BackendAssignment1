using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendAssignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        // GET api/NumberMachine/{id}
        // This method takes an integer as input and returns the result of the following operations:
        
        public int GET (int id)
        {
            // If the input integer is 0, return 0
            if (id == 0)
            {
                return 0;
            }
            else
            {
                // 1. Cube the input integer
                int cube = (int)Math.Pow(id, 3);

                // 2. Divide the result by the input integer
                int division = cube / id;

                // 3. Add the input integer to the result
                int addition = id + division;

                // 4. Multiply the result by the input integer
                int multiplication = addition * id;

                return multiplication;
            }


        }
    }
}
