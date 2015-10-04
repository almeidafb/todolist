using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoList.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "User name")]
        public String Name { get; set; }

        [Required]
        public String Password { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}