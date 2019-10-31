using System;


namespace MES_MVC.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class item
    {
        public string productname { get; set; }
        public string producttime { get; set; }
    }
}
