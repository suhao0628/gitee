namespace gitee.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }


        public int year { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}