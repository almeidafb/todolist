using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoList.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Task name")]
        public String Name { get; set; }

        [Required]
        public bool Done { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}