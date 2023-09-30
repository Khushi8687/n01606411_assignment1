using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static System.Net.WebRequestMethods;

namespace n01606411_assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        //POST api/Greeting
        public string Post()
        {
            return ("hello world");
        } 
    }
}
