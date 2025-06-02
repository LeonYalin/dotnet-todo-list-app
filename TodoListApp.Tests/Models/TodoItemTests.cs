using TodoListApp.Models;

namespace TodoListApp.Tests.Models
{
  public class TodoListAppTests
  {
    [Fact]
    public void TodoItem_ShouldHoldRightData_WhenCreated()
    {
      var todoItem = new TodoItem("First Item");
      Assert.NotNull(todoItem.Id);
      Assert.Equal("First Item", todoItem.Description);
      Assert.False(todoItem.Completed);
    }
  }

}
