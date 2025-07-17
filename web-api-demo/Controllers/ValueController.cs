using Microsoft.AspNetCore.Mvc;

namespace web_api_demo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValueController : Controller
    {
        static List<string> strings = new List<string>()
        {
            "value0", "value1", "value2"
        };

        //GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return strings;
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return strings[id];
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            strings.Add(value);
        }

        //PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
            strings[id] = value;
        }

        //DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
