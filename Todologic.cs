using System.Collections.Generic;
namespace TODO 
{
    public class TodoLogic{

    
    private Dictinary<int, TodoModel> cache =new Dictinary<int, TodoModel>();




     public void add(TodoModel newtodo)
{
        cache.add(newtodo.key,newtodo);
    }

    
public void update(TodoModel updateTodo)



public list<TodoModel> Read()

    var allTodos = new List<Todo