using MyToDo.Shared.Models;

namespace MyToDo.Shared.Dtos
{
    public class UserInfoDto : ObservableObject
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
    }
}
