//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
namespace Apps.Models.DEF
{
	public class Virtual_DEF_TestJobsModel
	{
			public virtual string VerCode { get; set; }
			public virtual string Name { get; set; }
			public virtual Nullable<bool> Result { get; set; }
			public virtual string Description { get; set; }
			public virtual string Creator { get; set; }
			public virtual Nullable<System.DateTime> CrtDt { get; set; }
			public virtual Nullable<bool> CloseState { get; set; }
			public virtual string Closer { get; set; }
			public virtual Nullable<System.DateTime> CloseDt { get; set; }
			public virtual Nullable<bool> Def { get; set; }
			public virtual Nullable<bool> CheckFlag { get; set; }
		}
}
