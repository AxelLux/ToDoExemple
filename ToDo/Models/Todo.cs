using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class Todo
    {

        public int Id { get; set; }
        public string Statement { get; set; }
        public Boolean IsDone { get; set; }

    }
}
