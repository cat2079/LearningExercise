using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LearningExercise.Controllers
{
    public class TimesFiftyController : ApiController
    {
        // POST: api/TimeFifty/5 ->250

        public int Post(int id)
        {

            return id * 50;
        }
    }
}
