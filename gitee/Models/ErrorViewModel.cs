namespace gitee.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }


        public int year { get; set; }
        public int MyProperty { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}