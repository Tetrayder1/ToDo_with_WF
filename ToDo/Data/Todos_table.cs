using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Data
{
    public class Todos_table
    {
        [Key]
        public int Id { get; set; }
        public string? ToDo { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsComplete { get; set; }

    }
}
