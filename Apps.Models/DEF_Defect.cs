//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEF_Defect
    {
        public string ItemID { get; set; }
        public string VerCode { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> CrtDt { get; set; }
        public string Receiver { get; set; }
        public Nullable<System.DateTime> SendDt { get; set; }
        public Nullable<bool> CloseState { get; set; }
        public string Closer { get; set; }
        public Nullable<System.DateTime> CloseDt { get; set; }
        public string TestContent { get; set; }
        public string ResultContent { get; set; }
        public string Remark { get; set; }
        public string MessageId { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<bool> ProcessState { get; set; }
        public string Processor { get; set; }
        public Nullable<System.DateTime> ProcessDt { get; set; }
        public Nullable<int> ErrorLevel { get; set; }
        public string CaseName { get; set; }
        public Nullable<int> Complex { get; set; }
        public Nullable<System.DateTime> PStartDt { get; set; }
        public Nullable<System.DateTime> PEndDt { get; set; }
        public string Executor { get; set; }
    
        public virtual DEF_TestJobs DEF_TestJobs { get; set; }
    }
}
