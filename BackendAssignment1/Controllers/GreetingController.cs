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

        ///<example>
        ///
        /// GET api/Greeting -> "Hello World!!"
        /// 
        ///</example>

        // GET api/Greeting
        public string GET()
        {
            return "Hello World!!";
        }


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

        ///<example>
        ///              
        /// GET api/Greeting/5 -> "Greeting to 5 people!"
        /// 
        ///</example>

        // GET api/Greeting/{id}
        public string GET(int id)
        {
            string output = $"Greeting to {id} people!";

            return output ;
        }
    }
}
