using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606411_assignment1.Controllers
{
    public class Assignment_1Controller : ApiController
    {
        //GET api/AddTen/10 --> 20
        public int Get(int id) 
        {
            int product = id + 10;
           return product;
        }
    }
}
