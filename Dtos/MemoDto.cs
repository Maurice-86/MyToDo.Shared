namespace MyToDo.Shared.Dtos
{
    public class MemoDto : BaseDto
    {
        public string Title { get; set; } = string.Empty;
        public string? Content { get; set; }
    }
}
