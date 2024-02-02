using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendAssignment1.Controllers
{
    public class GreetingController : ApiController
    {
        // GET api/Greeting
        // This method returns a string "Hello World!!".
        public string GET()
        {
            return "Hello World!!";
        }
        // GET api/Greeting/{id}
        // This method takes an integer as input and returns a string "Greeting to {id} people!".
        public string GET(int id)
        {
            string output = $"Greeting to {id} people!";

            return output ;
        }
    }
}
