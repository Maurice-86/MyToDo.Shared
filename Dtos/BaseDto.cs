using MyToDo.Shared.Models;

namespace MyToDo.Shared.Dtos
{
    public class BaseDto : ObservableObject, IBaseDto
    {
        public int Id { get; set; }
        public int Uid { get; set; }
    }
}
