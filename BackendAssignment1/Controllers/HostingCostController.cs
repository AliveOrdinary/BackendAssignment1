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
            double charge = 5.50;

            double HST = 0.13;



            if (id == 0)
            {
                int days = 1;

                double cost = charge * days;

                double tax = Math.Round(cost * HST, 2);

                double total = Math.Round(cost + tax,2);

                string result = $"{days} fortnights at $5.50/FN = ${cost} CAD\n HST 13% = ${tax} CAD\n Total = ${total} CAD";

                return result ;
            }
            else
            {
                double days = Math.Ceiling(id / 14.0);

                double cost = charge * days;

                double tax = Math.Round(cost * HST, 2);

                double total = Math.Round(cost + tax, 2);

                string result = $"{days} fortnights at $5.50/FN = ${cost} CAD\n HST 13% = ${tax} CAD\n Total = ${total} CAD";

                return result;
            }

            

        }
    }
}
