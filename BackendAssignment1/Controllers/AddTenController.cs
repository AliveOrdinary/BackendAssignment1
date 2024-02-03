﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendAssignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// 
        /// This method takes an integer as input and returns the integer after adding 10 to it.
        /// 
        /// </summary>
        /// 
        /// <param name="id">The integer to add 10 to</param>
        /// 
        /// <returns>The result after adding 10 to the input integer</returns>
        /// 

        /// <example>
        /// 
        /// GET api/AddTen/21 -> 31
        /// 
        /// </example>
  
        // GET api/AddTen/{id}
        public int GET(int id)
        {
            // Add 10 to the input integer
            int result = id + 10;
            // Return the result
            return result ;
        }
    }
}
