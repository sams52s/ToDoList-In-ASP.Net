namespace ToDo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Starting { get; set; }
        public Nullable<System.DateTime> Ending { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
