// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace HelloAvro.DTO
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ProjectDTO : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"ProjectDTO\",\"namespace\":\"HelloAvro.DTO\",\"fields\":[{\"name" +
				"\":\"ProjectId\",\"type\":\"int\"},{\"name\":\"ProjectName\",\"type\":\"string\"}]}");
		private int _ProjectId;
		private string _ProjectName;
		public virtual Schema Schema
		{
			get
			{
				return ProjectDTO._SCHEMA;
			}
		}
		public int ProjectId
		{
			get
			{
				return this._ProjectId;
			}
			set
			{
				this._ProjectId = value;
			}
		}
		public string ProjectName
		{
			get
			{
				return this._ProjectName;
			}
			set
			{
				this._ProjectName = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.ProjectId;
			case 1: return this.ProjectName;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.ProjectId = (System.Int32)fieldValue; break;
			case 1: this.ProjectName = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
