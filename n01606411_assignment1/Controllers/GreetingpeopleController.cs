using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace n01606411_assignment1.Controllers
{
    public class GreetingpeopleController : ApiController
    {
        //GET api/Greetingpeople/5 --> "greeting to 5 people"
        public string Get(int id)
        {
            return "Greeting to "+id+" people";
        }

    }
}
