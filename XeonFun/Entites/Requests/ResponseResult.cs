namespace XeonFun.Entites.Requests
{
    public class ResponseResult
    {
        public int Status { get; set; }
        public string Message { get; set; }

        public ResponseResult(int status, string message)
        {
            Status = status;
            Message = message;
        }
    }
}
