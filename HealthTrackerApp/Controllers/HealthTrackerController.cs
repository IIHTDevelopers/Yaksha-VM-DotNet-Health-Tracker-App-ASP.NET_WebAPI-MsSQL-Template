using HealthTrackerApp.DAL.Interrfaces;
using HealthTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HealthTrackerApp.Controllers
{
    public class HealthController : ApiController
    {
        private readonly IHealthTrackerService _service;
        public HealthController(IHealthTrackerService service)
        {
            _service = service;
        }
        public HealthController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Health/CreateHealth")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateHealth([FromBody] Health model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Health/UpdateHealth")]
        public async Task<IHttpActionResult> UpdateHealth([FromBody] Health model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Health/DeleteHealth")]
        public async Task<IHttpActionResult> DeleteHealth(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Health/GetHealthById")]
        public async Task<IHttpActionResult> GetHealthById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Health/GetAllHealths")]
        public async Task<IEnumerable<Health>> GetAllHealths()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
