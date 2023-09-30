using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606411_assignment1.Controllers
{
    public class SquareController : ApiController
    {
        //GET api/Square/2 --> 4
        public int Get(int id)
        {
            int product = id * id;
            return product;
        }
    }
}
