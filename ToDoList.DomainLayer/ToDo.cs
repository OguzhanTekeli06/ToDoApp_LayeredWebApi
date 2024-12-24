using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DomainLayer;

public class ToDo
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; } = false;
    public DateTime? DueDate { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
