using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Data
{
    public class Vision_table
    {
        [Key]
        public int Id { get; set; }
        public string? FontStyle { get; set; }
        public string? TextColor { get; set; }
        public string? BackColor { get; set; }
        public string? TodoListColor { get; set; }
        public string? FindInputBC { get; set; }
        public string? Vision_Name {  get; set; }
        public bool? IsSelected { get; set; }

    }
}
