namespace TodoList;

public class TodoDbService
{
   TodoDbContext db;
   public TodoDbService(TodoDbContext _db){
    db = _db;
   }

   public void AddTodo(TodoItem todo){
        db.Add(todo);
        db.SaveChanges();
   }

   public List<TodoItem> GetTodoList(){
    return db.TodoItems.ToList();
   }
}
