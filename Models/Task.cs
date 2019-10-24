using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string Text { get; set; }

        public bool Completed { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
