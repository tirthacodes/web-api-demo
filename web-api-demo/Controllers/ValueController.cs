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
        public IEnumerable<string> GetValues()
        {
            return strings;
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public string GetValues(int id)
        {
            return strings[id];
        }

        //POST api/values
        [HttpPost]
        public void PostValues([FromBody] string value)
        {
            strings.Add(value);
        }

        //PUT api/values/5
        [HttpPut]
        public void PutValues(int id, [FromBody] string value)
        {
            strings[id] = value;
        }

        //DELETE api/values/5
        [HttpDelete]
        public void DeleteValues(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
