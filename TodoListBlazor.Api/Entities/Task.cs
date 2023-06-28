using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TodoListBlazor.Api.Entities
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid Assignee { get; set; }
    }
}
