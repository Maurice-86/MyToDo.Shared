using MyToDo.Shared.Models;

namespace MyToDo.Shared.Dtos
{
    public class UserDto : ObservableObject
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
