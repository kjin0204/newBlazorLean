using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string todo { get; set; }
        public bool IsDone { get; set; }
    }
}
