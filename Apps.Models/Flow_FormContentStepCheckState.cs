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
    
    public partial class Flow_FormContentStepCheckState
    {
        public string Id { get; set; }
        public string StepCheckId { get; set; }
        public string UserId { get; set; }
        public int CheckFlag { get; set; }
        public string Reamrk { get; set; }
        public string TheSeal { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        public virtual Flow_FormContentStepCheck Flow_FormContentStepCheck { get; set; }
        public virtual SysUser SysUser { get; set; }
    }
}
