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
        /// <summary>
        /// 
        /// This method returns a string
        /// 
        /// </summary>
        /// 
        /// <returns>string "Hello World!!"</returns>
        /// 


        // GET api/Greeting
        // This method returns a string "Hello World!!".
        public string GET()
        {
            return "Hello World!!";
        }
        // GET api/Greeting/{id}

        /// <summary>
        /// 
        /// This method takes an integer as input and returns a string "Greeting to {id} people!".
        /// 
        /// </summary>
        /// 
        /// <param name="id">The number of people to greet</param>
        /// 
        /// <returns>A string greeting to the number of people</returns>
        /// 

        public string GET(int id)
        {
            string output = $"Greeting to {id} people!";

            return output ;
        }
    }
}
