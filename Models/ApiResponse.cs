namespace MyToDo.Shared.Models
{
    /// <summary>
    /// 非泛型版本 - 用于简单的成功/失败响应
    /// </summary>
    public class ApiResponse
    {
        public string? Message { get; set; }
        public bool Status { get; set; }

        public ApiResponse() { }

        public ApiResponse(string message, bool status = false)
        {
            Message = message;
            Status = status;
        }
    }

    /// <summary>
    /// 泛型版本 - 用于需要强类型返回值的场景
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResponse<T> : ApiResponse
    {
        public T? Result { get; set; }

        public ApiResponse() { }

        public ApiResponse(string message, bool status = false)
            : base(message, status) { }

        public ApiResponse(string message, T result)
            : base(message, true)
        {
            Result = result;
        }
    }
}
