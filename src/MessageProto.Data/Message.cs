using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProto.Data
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public string Content { get; set; }
    }
}
