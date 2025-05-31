using System;

namespace TodoListApp.Models
{
  public class TodoItem(string description)
  {
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Description { get; set; } = description;
    public bool Completed { get; set; }

    public override string ToString() { return $"\"TodoItem: {{Id:{Id},Description:{Description},Completed:{Completed}}}\""; }
  }

}
