namespace MyToDo.Shared.Dtos
{
    public class TodoDto : BaseDto
    {
        public string Title { get; set; } = string.Empty;
        public string? Content { get; set; }
        public int Status { get; set; }
    }
}
