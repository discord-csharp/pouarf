using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pouarf.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset ModifiedAt { get; set; }
    }
}
