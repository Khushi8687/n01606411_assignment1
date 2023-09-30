using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606411_assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public string Get(int id)
        {
            int add = id + 5 ;
            int sub = id - 7;
            int multiply = id * 3;
            int div = id / 6;
            return "add = " +add + " , sub = " + sub +", multiply = " + multiply +", div = " +div+ " "  ;
        }
    }
}
