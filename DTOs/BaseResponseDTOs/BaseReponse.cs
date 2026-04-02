namespace API_DesignPartern.DTOs.BaseResponse
{
    public class BaseReponse
    {
        public int Code { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }
}
