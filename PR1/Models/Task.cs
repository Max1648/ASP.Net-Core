using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PR1.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
