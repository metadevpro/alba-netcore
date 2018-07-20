using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Metadev.Oas3.Attributes;

namespace alba.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [Operation("getValues")]
        [Description("Returns all values.")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [Operation("getValueById")]
        [Description("Returns values by Id.")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [Operation("createValue")]
        [Description("Create new values.")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [Operation("updateValue")]
        [Description("Update a value.")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [Operation("deleteValue")]
        [Description("Deteles a value by Id.")]
        public void Delete(int id)
        {
        }
    }
}
