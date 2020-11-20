using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using JsonWebAPI.Models;
using Microsoft.Extensions.Logging;

namespace JsonWebAPI.Controllers
{
    public class PeopleController : JsonApiController<Person>
    {
        public PeopleController(
        
            IJsonApiContext jsonApiContext,
            IResourceService< Person > resourceService,
            ILoggerFactory loggerFactory) 
                : base(jsonApiContext, resourceService, loggerFactory)
            { }
        
    }
}
