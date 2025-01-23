using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers 
{    
    [ApiController]
    [Route("[controller]")]
    public class ActivitiesController: BaseApiController

    {
        private readonly DataContext context;
        public ActivitiesController(DataContext context)
        {
            
        }
    }
}