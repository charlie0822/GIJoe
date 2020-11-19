using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GIJoe.Models
{
    [Table("nameage")]
    public class nameages
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}
