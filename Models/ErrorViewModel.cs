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

    public class Dispatch_Item
    {
        public string order { get; set; }
        public string process { get; set; }
        public string processname { get; set; }
        public string productid { get; set; }
        public string product { get; set; }
        public string requestquantity { get; set; }
        public string quantity { get; set; }
        public string staff { get; set; }
        public string time { get; set; }
        public string[] staff_name { get; set; }
    }

    public class Work_Data_Item
    {
        public string order { get; set; }
        public string process { get; set; }
        public string processname { get; set; }
        public string productid { get; set; }
        public string product { get; set; }
        public string machine { get; set; }
        public string quantity { get; set; }
        public string staff { get; set; }
        public string time { get; set; }        
    }
}
