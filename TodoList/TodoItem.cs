namespace TodoList;



public class ToDoCategory
{
    
    public List<TodoItem> doItems;
    public int length { get => doItems.Count; }

}


public class TodoItem
{
    public string itemName;
    public string itemDescription;
}

/*public class Hond
{
    public readonly int Poten = 4;
    public string Naam;
    public int GewichtInKilo;

}*/

