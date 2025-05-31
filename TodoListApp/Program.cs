using System;
using TodoListApp.Models;

namespace TodoListApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      TodoItem item = new TodoItem("first item");
      Console.WriteLine(item);
    }
  }
}