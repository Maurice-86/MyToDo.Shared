using MyToDo.Shared.Models;

namespace MyToDo.Shared.Dtos
{
    public class AuthDto : ObservableObject
    {
        public string AccessToken { get; set; } = string.Empty;
        public string? RefreshToken { get; set; }
        public UserInfoDto? UserInfo { get; set; }
    }
}
