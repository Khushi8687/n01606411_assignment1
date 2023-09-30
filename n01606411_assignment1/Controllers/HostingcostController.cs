using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606411_assignment1.Controllers
{
    public class HostingcostController : ApiController
    {
       public string Get(int id)
        {
            double forenightcost = 5.50;
            double hst = 0.13;
            double numoffn = id;
            double total = numoffn * forenightcost;
            double hstamt = total * hst;
            double totalprice = total * hstamt;

            return id + " fortnight at $5.50/FN = " + total + " CAD " + " HST 13% = $" + hstamt + "CAD " + " Total + $" + totalprice + "CAD";

       }
    }
}
