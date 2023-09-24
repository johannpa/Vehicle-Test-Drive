using CustomersApi.Interfaces;
using CustomersApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomer _customerService;

        public CustomersController(ICustomer customerService)
        {
            _customerService = customerService;
        }

        #region Get Methods
        // GET: api/<CustomersController>
        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        } */
        #endregion

        // POST api/<CustomersController>
        [HttpPost]
        public async Task Post([FromBody] Customer customer)
        {
            await _customerService.AddCustomer(customer);
        }

        #region Put and Delete Methods
        /*
        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
        #endregion
    }
}
