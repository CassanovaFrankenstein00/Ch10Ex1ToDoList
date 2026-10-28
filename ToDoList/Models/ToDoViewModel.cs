using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ToDoList.Models
{
    public class ToDoViewModel
    {
        [ValidateNever]
        public Filters Filters { get; set; } = new Filters("all-all-all");
        [ValidateNever]
        public List<Status> Statuses { get; set; } = new List<Status>();
        [ValidateNever]
        public List<Category> Categories { get; set; } = new List<Category>();
        [ValidateNever]
        public Dictionary<string, String> DueFilters { get; set; } = new Dictionary<string, string>();
        [ValidateNever]
        public List<ToDo> Tasks { get; set; } = new List<ToDo>();
        [ValidateNever]
        public ToDo CurrentTask { get; set; } = new ToDo();
    }
}
