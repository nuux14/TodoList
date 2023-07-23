using Microsoft.EntityFrameworkCore;
using TodoList.Pages;

namespace TodoList;

public class TodoDbContext: DbContext
{
   public static string publicConnstring;
   public TodoDbContext(DbContextOptions<TodoDbContext> options):base(options){}
   
   public DbSet<TodoItem> TodoItems {get; set;}

}
