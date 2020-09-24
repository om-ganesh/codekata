using System;
using System.Collections.Generic;
using System.Text;

namespace JonahRuleEngine
{
    public class DataResult
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public DataResult(bool Status, string Message)
        {
            this.Status = Status;
            this.Message = Message;
        }
    }
}
