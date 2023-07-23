using System.ComponentModel.DataAnnotations;

namespace TodoList;

public class TodoItem
{
    [Key]
    public int Id { get; set;}
public string? Title { get; set; }//nullable
public bool IsDone { get; set; }
}
