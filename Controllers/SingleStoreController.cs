using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SingleStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SingleStoreController : ControllerBase
    {
        private readonly SingleStoreDataContext _dbContext;

        public SingleStoreController(SingleStoreDataContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var messages = _dbContext.Messages.ToList();

            return Ok(messages);
        }
    }
}
