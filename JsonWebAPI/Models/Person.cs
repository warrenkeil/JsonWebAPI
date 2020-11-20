using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;

namespace JsonWebAPI.Models
{
    public class Person : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }
    }
}
