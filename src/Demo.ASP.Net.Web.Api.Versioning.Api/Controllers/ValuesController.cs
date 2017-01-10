using Microsoft.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.ASP.Net.Web.Api.Versioning.Api.Controllers
{
    [ApiVersion("1")]
    [RoutePrefix("api/v{version:apiVersion}/values")]
    public class ValuesController : ApiController
    {
        [Route]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("{id:int}")]
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [Route]
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        [Route]
        // PUT api/values/5
        public void Put([FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
