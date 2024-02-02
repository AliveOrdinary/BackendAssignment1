using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendAssignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        public string GET (double id)
        {
            /// <summary>
            /// 
            /// This method calculates the cost of hosting a website for a given number of fortnights
            /// 
            /// </summary>
            /// 
            /// <param name="id">The number of fortnights to host the website for</param>
            /// 
            /// <returns>The cost of hosting the website for the given number of fortnights</returns>
            /// 

            //GET api/HostingCost/{id}


            //The cost of hosting a website for a fortnight is $5.50
            double charge = 5.50;

            //The HST is 13%
            double HST = 0.13;

            //Calculate the number of fortnights
            double days = Math.Floor((id / 14.0) + 1);

            //Calculate the cost of hosting the website
            double cost = (charge * days);

            //Calculate the HST
            double tax = Math.Round(cost * HST, 2);

            //Calculate the total cost
            double total = Math.Round(cost + tax, 2);


            string first = $"{days} fortnights at $5.50/FN = ${cost} CAD";
            string second = $"HST 13% = ${tax} CAD";
            string third = $"Total = ${total} CAD";


            //Return the result
            string result = string.Join("\n", first, second, third);

            return result;


        }
    }
}
